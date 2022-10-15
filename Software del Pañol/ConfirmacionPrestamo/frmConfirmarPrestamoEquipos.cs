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

namespace Software_del_Pañol.ConfirmacionPrestamo
{
    public partial class frmConfirmarPrestamoEquipos : Form
    {
        List<ePrestamoEquipo> _prestamos = new List<ePrestamoEquipo>();
        List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();
        List<eEquipo> _equipos = new List<eEquipo>();
        List<eEquipo> _equiposSel = new List<eEquipo>();
        eAsisTec asisTec = new eAsisTec();
        ePrestamoEquipo prestamoActual = new ePrestamoEquipo();
        private int auxP;

        public frmConfirmarPrestamoEquipos(eAsisTec asisTec)
        {
            InitializeComponent();
            this.asisTec = asisTec;
            auxP = 0;
        }

        private void frmConfirmarPrestamoEquipos_Load(object sender, EventArgs e)
        {
            // dgvEquipos y cbx
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquiposSel.AutoGenerateColumns = false;
            actualizarCbx();

            // Prestamos
            btnAnterior.Enabled = false;
            dPrestamoEquipo unPE = new dPrestamoEquipo();
            _prestamos = unPE.listarPrestamoEquipo(estadoP.Pendiente);

            if (_prestamos.Any())
            {
                prestamoActual = _prestamos[0];

                if (_prestamos.Count == 1)
                {
                    btnSiguiente.Enabled = false;
                }

                actualizarDgv();

                mostrarPrestamoActual();
            }
            else
            {
                desactivarBotones();
            }
        }

        #region DataGridView

        private void actualizarDgv()
        {

            dEquipo unE = new dEquipo();

            if (cbxTipoList.Text == "Todos")
            {
                _equipos = unE.listarEquipo();
            }
            else
            {
                if (cbxSubtipoList.Text == "Todos")
                {
                    _equipos = unE.listarEquipo(cbxTipoList.Text);

                }
                else
                {
                    _equipos = unE.listarEquipo(cbxTipoList.Text, cbxSubtipoList.Text);
                }
            }

            for (int i = 0; i < _equipos.Count; i++)
            {
                if (_equipos[i].estado != "Disponible")
                {
                    _equipos.RemoveAt(i);
                    i--;
                }
            }

            foreach (eEquipo eqSel in this._equiposSel)
            {
                for (int i = 0; i < _equipos.Count; i++)
                {
                    if (eqSel.id == _equipos[i].id)
                    {
                        _equipos.RemoveAt(i);
                    }
                }
            }

            dgvEquipos.DataSource = _equipos;

        }

        #endregion

        #region ComboBox

        private void actualizarCbx()
        {
            dTipoDeEquipo unT = new dTipoDeEquipo();
            _tipos = unT.listarTipoDeEquipo();

            foreach (eTipoDeEquipo tipo in _tipos)
            {
                if (cbxTipoList.Items.Contains(tipo.nombre) == false)
                {
                    cbxTipoList.Items.Add(tipo.nombre);
                }
            }
            cbxTipoList.Items.Add("Todos");
            cbxTipoList.SelectedItem = "Todos";
        }

        private void cbxTipoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoList.Text != "Todos")
            {
                cbxSubtipoList.Items.Clear();
                cbxSubtipoList.Enabled = true;
                foreach (eTipoDeEquipo tipo in _tipos)
                {
                    if (tipo.nombre == cbxTipoList.Text)
                    {
                        cbxSubtipoList.Items.Add(tipo.subtipo);
                    }
                }
                cbxSubtipoList.Items.Add("Todos");
                cbxSubtipoList.SelectedItem = "Todos";
            }
            else
            {
                cbxSubtipoList.Items.Clear();
                cbxSubtipoList.Enabled = false;
                actualizarDgv();
            }
        }

        private void cbxSubtipoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSubtipoList.Text != null)
            {
                actualizarDgv();
            }
        }

        #endregion

        #region Botones

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar esta solicitud ? ", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dPrestamoEquipo prestamo = new dPrestamoEquipo();
                prestamo.bajaPrestamoEquipo(prestamoActual);
                _prestamos = prestamo.listarPrestamoEquipo(estadoP.Pendiente);

                lblMensaje.Text = "Solicitud eliminada correctamente";

                if (_prestamos.Count == 0)
                {
                    desactivarBotones();
                    vaciarCampos();
                    activarCampos(false);
                }
                else
                {
                    auxP--;
                    siguientePrestamo();
                    activarCampos(false);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            dPrestamoEquipo prestamo = new dPrestamoEquipo();

            prestamoActual.fecha_solicitado = dtpSolicitado.Value;
            prestamoActual.fecha_retiro = dtpRetiro.Value;
            prestamoActual.fecha_devolucion = dtpDevolucion.Value;
            prestamoActual.curso = txtCurso.Text;
            prestamoActual.ejercicio = txtEjercicio.Text;
            prestamoActual.equipoRodaje = txtEquipoRodaje.Text;
            prestamoActual.locaciones = txtLocaciones.Text;
            prestamoActual.nomDocente = txtNombreDocente.Text;
            prestamoActual.apeDocente = txtApellidoDocente.Text;
            prestamoActual.transporte = txtTransporte.Text;
            prestamoActual.estadoP = estadoP.EnCurso.ToString();
            prestamoActual._equipos = _equiposSel;

            prestamo.modificarPrestamoEquipo(prestamoActual);
            _prestamos = prestamo.listarPrestamoEquipo(estadoP.Pendiente);

            lblMensaje.Text = "Solicitud confirmada correctamente";

            if (_prestamos.Count == 0)
            {
                desactivarBotones();
                vaciarCampos();
                activarCampos(false);
            }
            else
            {
                auxP--;
                siguientePrestamo();
                activarCampos(false);
            }
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.Rows.Count > 0)
            {
                eEquipo eq = new eEquipo();
                eq.id = Convert.ToInt32(dgvEquipos.SelectedRows[0].Cells["id_equipo"].Value.ToString());

                dEquipo unDE = new dEquipo();
                eq = unDE.buscarEquipo(eq);

                if (eq != null)
                {
                    this._equiposSel.Add(eq);
                    dgvEquiposSel.DataSource = null;
                    dgvEquiposSel.DataSource = _equiposSel;
                    actualizarDgv();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvEquiposSel.Rows.Count > 0)
            {
                eEquipo eq = new eEquipo();
                eq.id = Convert.ToInt32(dgvEquiposSel.SelectedRows[0].Cells["id_equipoSel"].Value.ToString());

                dEquipo unDE = new dEquipo();
                eq = unDE.buscarEquipo(eq);
                for (int i = 0; i < _equiposSel.Count; i++)
                {
                    if (eq.id == _equiposSel[i].id)
                    {
                        _equiposSel.RemoveAt(i);
                    }
                }
                dgvEquiposSel.DataSource = null;
                dgvEquiposSel.DataSource = this._equiposSel;
                actualizarDgv();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anteriorPrestamo();
            activarCampos(false);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguientePrestamo();
            activarCampos(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarCampos(true);
        }

        #endregion

        private void siguientePrestamo()
        {
            if (auxP < _prestamos.Count - 1)
            {
                auxP++;

                if (auxP == _prestamos.Count - 1)
                {
                    btnSiguiente.Enabled = false;
                }

                if (auxP == 0)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }

                prestamoActual = _prestamos[auxP];
                mostrarPrestamoActual();
            }
            else if (auxP == _prestamos.Count - 1)
            {
                btnSiguiente.Enabled = false;

                if (_prestamos.Count == 1)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }

                prestamoActual = _prestamos[auxP];
                mostrarPrestamoActual();
            }
        }

        private void anteriorPrestamo()
        {
            if (auxP == 0 || auxP - 1 == 0)
            {
                btnAnterior.Enabled = false;
            }

            if ((auxP - 1) >= 0)
            {
                auxP--;
                btnSiguiente.Enabled = true;

                prestamoActual = _prestamos[auxP];
                mostrarPrestamoActual();
            }
        }

        private void activarCampos(bool estado)
        {
            dtpRetiro.Enabled = estado;
            dtpDevolucion.Enabled = estado;
            dtpSolicitado.Enabled = estado;
            txtCurso.Enabled = estado;
            txtEjercicio.Enabled = estado;
            txtEquipoRodaje.Enabled = estado;
            txtLocaciones.Enabled = estado;
            txtTransporte.Enabled = estado;
            txtNombreDocente.Enabled = estado;
            txtApellidoDocente.Enabled = estado;
            txtNombreResponsable.Enabled = estado;
            txtApellidoResponsable.Enabled = estado;
            btnAgregarEquipo.Enabled = estado;
            btnQuitar.Enabled = estado;
        }

        private void vaciarCampos()
        {
            txtNombreResponsable.Text = "";
            txtApellidoResponsable.Text = "";
            dtpRetiro.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now;
            dtpSolicitado.Value = DateTime.Now;
            txtCurso.Text = "";
            txtEjercicio.Text = "";
            txtEquipoRodaje.Text = "";
            txtLocaciones.Text = "";
            txtNombreDocente.Text = "";
            txtApellidoDocente.Text = "";
            _equiposSel.Clear();
            actualizarDgv();
        }

        public void mostrarPrestamoActual()
        {
            lblPrestamoActual.Text = "Prestamo N°" + prestamoActual.id;
            txtNombreResponsable.Text = prestamoActual.responsable.nombre;
            txtApellidoResponsable.Text = prestamoActual.responsable.apellido;
            dtpSolicitado.Value = prestamoActual.fecha_solicitado;
            dtpRetiro.Value = prestamoActual.fecha_retiro;
            dtpDevolucion.Value = prestamoActual.fecha_devolucion;
            txtCurso.Text = prestamoActual.curso;
            txtEjercicio.Text = prestamoActual.ejercicio;
            txtEquipoRodaje.Text = prestamoActual.equipoRodaje;
            txtLocaciones.Text = prestamoActual.locaciones;
            txtNombreDocente.Text = prestamoActual.nomDocente;
            txtApellidoDocente.Text = prestamoActual.apeDocente;
            txtTransporte.Text = prestamoActual.transporte;

            _equiposSel = prestamoActual._equipos;
            dgvEquiposSel.DataSource = null;
            dgvEquiposSel.DataSource = _equiposSel;
            actualizarDgv();
        }

        private void desactivarBotones()
        {
            lblPrestamoActual.Text = "No hay prestamos para confirmar";
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnConfirmar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}