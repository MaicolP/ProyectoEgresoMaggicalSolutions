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
    public partial class frmSolicitarPrestamoUrgente : Form
    {
        public List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();
        public List<eEquipo> _equipos = new List<eEquipo>();
        public List<eEquipo> _equiposSel = new List<eEquipo>();
        public eUsuario usuarioActual { get; set; }

        public frmSolicitarPrestamoUrgente(eUsuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void frmGestionDeEquipo_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquiposSel.AutoGenerateColumns = false;
            actualizarCbx();
        }

        #region ComboBox

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

        #endregion

        #region DataGridView

        public void actualizarDgv()
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
                if (_equipos[i].estado != estadoEq.Disponible.ToString())
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

        #region Botones

        private void btnAgregarEquipo_Click_1(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (mskCi.Text == "" || txtNombreDocente.Text == "" || txtApellidoDocente.Text == "" || txtApellidoDocente.Text == "" || txtNombreDocente.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Complete todos los campos";
            }
            else if (validarfecha() == false)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Asegurese que la fecha sea 1 día mayor que la fecha actual";
            }
            else
            {
                ePrestamoUrgente prestamo = new ePrestamoUrgente();
                prestamo.fecha_devolucion = dtpDevolucion.Value;
                prestamo.fecha_retiro = dtpRetiro.Value;
                prestamo.fecha_solicitado = DateTime.Now;
                prestamo._equipos = _equiposSel;
                dUsuario unU = new dUsuario();
                prestamo.responsable.ci = mskCi.Text;
                prestamo.responsable = unU.buscarUsuario(prestamo.responsable);
                prestamo.estadoP = estadoP.EnCurso.ToString();

                dPrestamoUrgente unP = new dPrestamoUrgente();
                unP.altaPrestamoUrgente(prestamo);

                dgvEquiposSel.DataSource = null;
                _equiposSel.Clear();
                actualizarDgv();

                txtApellidoDocente.Clear();
                txtNombreDocente.Clear();
                mskCi.Clear();

                lblMensaje.ForeColor = Color.CornflowerBlue;
                lblMensaje.Text = "Se envió la solicitud";

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

        private void mskCi_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            if(mskCi.MaskFull)
            {
                eUsuario usuario = new eUsuario();
                usuario.ci = mskCi.Text;
                dUsuario unU = new dUsuario();
                usuario = unU.buscarUsuario(usuario);
                if(usuario != null)
                {
                    txtApellidoDocente.Text = usuario.apellido;
                    txtNombreDocente.Text = usuario.nombre;
                }
                else
                {
                    lblMensaje.Text = "El usuario con esa cedula no existe";
                }
            }
            else
            {
                txtApellidoDocente.Clear();
                txtNombreDocente.Clear();
            }
        }

        private void cbxTipoList_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cbxSubtipoList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxSubtipoList.Text != null)
            {
                actualizarDgv();
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
    }
}
