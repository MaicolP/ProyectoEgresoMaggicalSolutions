using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dominio;

namespace Software_del_Pañol
{
    public partial class frmSolicitarLibro : Form
    {
        public List<eLibro> _libros = new List<eLibro>();
        public List<eLibro> _librosSel = new List<eLibro>();
        public eUsuario usuarioActual { get; set; }

        public frmSolicitarLibro(eUsuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            dgvLibros.AutoGenerateColumns = false;
            dgvLibrosSel.AutoGenerateColumns = false;
        }

        private void frmGestionDeEquipo_Load(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        #region DataGridView

        private void actualizarDgv()
        {
            dLibro unL = new dLibro();
            _libros = unL.listarLibroDisp(true);

            foreach (eLibro lib in this._librosSel)
            {
                for (int i = 0; i < _libros.Count; i++)
                {
                    if (lib.id == _libros[i].id)
                    {
                        _libros.RemoveAt(i);
                    }
                }
            }

            dgvLibros.DataSource = _libros;
        }

        #endregion

        #region Botones

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (_librosSel.Any() == false)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor seleccione algún libro";
            }
            else if (validarfecha() == false)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Asegurese que la fecha sea 1 día mayor que la fecha actual";
            }
            else
            {
                ePrestamoLibro prestamo = new ePrestamoLibro();
                prestamo.fecha_devolucion = dtpDevolucion.Value;
                prestamo.fecha_retiro = dtpRetiro.Value;
                prestamo.fecha_solicitado = DateTime.Now;
                prestamo._libros = _librosSel;
                prestamo.responsable = usuarioActual;
                prestamo.estadoP = estadoP.EnCurso.ToString();

                dPrestamoLibro unP = new dPrestamoLibro();
                unP.altaPrestamoLibro(prestamo);

                actualizarDgv();
                dgvLibrosSel.DataSource = null;
                _librosSel.Clear();


                lblMensaje.ForeColor = Color.CornflowerBlue;
                lblMensaje.Text = "Se envió la solicitud";

            }
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.Rows.Count > 0)
            {
                eLibro lib = new eLibro();
                lib.id = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["id_libro"].Value.ToString());

                dLibro unL = new dLibro();
                lib = unL.buscarLibro(lib);

                if (lib != null)
                {
                    this._librosSel.Add(lib);
                    dgvLibrosSel.DataSource = null;
                    dgvLibrosSel.DataSource = _librosSel;
                    actualizarDgv();
                }
            }
        }

        private void btnQuitarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibrosSel.Rows.Count > 0)
            {
                eLibro lib = new eLibro();
                lib.id = Convert.ToInt32(dgvLibrosSel.SelectedRows[0].Cells["id_libroSel"].Value.ToString());

                dLibro unL = new dLibro();
                lib = unL.buscarLibro(lib);

                for (int i = 0; i < _librosSel.Count; i++)
                {
                    if (lib.id == _librosSel[i].id)
                    {
                        _librosSel.RemoveAt(i);
                    }
                }

                dgvLibrosSel.DataSource = null;
                dgvLibrosSel.DataSource = this._librosSel;
                actualizarDgv();
            }
        }

        #endregion

        private bool validarfecha()
        {
            bool aux = false;
            TimeSpan difDia = dtpRetiro.Value - DateTime.Now;
            TimeSpan difReserva = dtpDevolucion.Value - dtpRetiro.Value;
            if (difDia.Days >= 1 && difReserva.TotalHours > 0)
            {
                aux = true;
            }
            return aux;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEquipo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
