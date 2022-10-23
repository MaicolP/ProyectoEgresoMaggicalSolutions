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
using System.Drawing.Printing;

namespace Software_del_Pañol
{
    public partial class frmGestionDeEquipo : Form
    {

        private List<eTipoDeEquipo> _tipos { get; set; }

        public frmGestionDeEquipo()
        {
            InitializeComponent();
        }

        private void frmGestionDeEquipo_Load(object sender, EventArgs e)
        {
            modoEdicion(false);
            actualizarCbx();
        }

        private void frmGestionDeEquipo_Click(object sender, EventArgs e)
        {
            dgvEquipos.ClearSelection();
        }

        private void modoEdicion(bool aux)
        {
            if (aux == true)
            {
                btnAgregar.Hide();
                btnEliminar.Show();
                btnModificar.Show();
            }
            else
            {
                btnAgregar.Show();
                btnEliminar.Hide();
                btnModificar.Hide();

                txtPrecio.Clear();
                txtNombre.Clear();
                txtNroSerie.Clear();
                txtObservaciones.Clear();
                ckbAsegurado.Checked = false;
            }
        }

        #region DataGridView

        private void actualizarDgv()
        {
            dEquipo unE = new dEquipo();
            List<eEquipo> _equipos = new List<eEquipo>();

            if (cbxTipoList.Text == "Todos")
            {
                _equipos = unE.listarEquipo();
                dgvEquipos.DataSource = _equipos;

            }
            else
            {
                if (cbxSubtipoList.Text == "Todos")
                {
                    _equipos = unE.listarEquipo(cbxTipoList.Text);
                    dgvEquipos.DataSource = _equipos;
                } else
                {
                    _equipos = unE.listarEquipo(cbxTipoList.Text, cbxSubtipoList.Text);
                    dgvEquipos.DataSource = _equipos;
                }
            }
           
            dgvEquipos.Columns["tipo"].Visible = false;
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedCells.Count != 0)
            {
                modoEdicion(true);
                eEquipo equipo = new eEquipo();
                equipo.id = Convert.ToInt32(dgvEquipos.CurrentCell.OwningRow.Cells["id_equipo"].Value);
                dEquipo unE = new dEquipo();
                equipo = unE.buscarEquipo(equipo);

                txtNombre.Text = equipo.nombre;
                txtNroSerie.Text = equipo.nroSerie;
                txtObservaciones.Text = equipo.observaciones;
                txtPrecio.Text = equipo.precio;
                dtpFechaIngreso.Value = equipo.fechaIngreso.Date;
                ckbAsegurado.Checked = equipo.asegurado;
                cbxEstado.Text = equipo.estado;
                cbxTipo.Text = equipo.tipo.nombre;
                cbxSubtipo.Text = equipo.tipo.subtipo;
            }
            else
            {
                modoEdicion(false);
            }
        }

        #endregion

        #region ComboBox

        private void actualizarCbx()
        {
            cbxEstado.DataSource = Enum.GetValues(typeof(estadoEq));

            dTipoDeEquipo unT = new dTipoDeEquipo();
            _tipos = unT.listarTipoDeEquipo();

            foreach (eTipoDeEquipo tipo in _tipos)
            {
                if (cbxTipo.Items.Contains(tipo.nombre) == false)
                {
                    cbxTipo.Items.Add(tipo.nombre);
                    cbxTipoList.Items.Add(tipo.nombre);
                }
            }
            cbxTipoList.Items.Add("Todos");
            cbxTipoList.SelectedItem = "Todos";
        }

        private void cbxTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text != null)
            {
                cbxSubtipo.Items.Clear();
                cbxSubtipo.Enabled = true;
                foreach (eTipoDeEquipo tipo in _tipos)
                {
                    if (tipo.nombre == cbxTipo.Text)
                    {
                        cbxSubtipo.Items.Add(tipo.subtipo);
                    }
                }
            }
        }

        private void cbxTipoList_SelectedValueChanged(object sender, EventArgs e)
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

        private void cbxSubtipoList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxSubtipoList.Text != null)
            {
                actualizarDgv();
            }
        }

        #endregion

        #region Botones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNroSerie.Text == "" || dtpFechaIngreso.Value == null)
            {
                lblMensaje.Text = "Rellene todos los campos por favor, los únicos opcionales son Observaciones y Precio";
            }
            else if (cbxTipo.Text == "" || cbxSubtipo.Text == "")
            {
                lblMensaje.Text = "Por favor seleccione Tipo y Subtipo del equipo";
            }
            else
            {
                eEquipo equipo = new eEquipo();
                equipo.nombre = txtNombre.Text;
                equipo.nroSerie = txtNroSerie.Text;
                equipo.precio = txtPrecio.Text;
                equipo.observaciones = txtObservaciones.Text;
                equipo.estado = cbxEstado.Text;
                equipo.fechaIngreso = dtpFechaIngreso.Value;
                equipo.asegurado = ckbAsegurado.Checked;
                foreach (eTipoDeEquipo tipo in _tipos)       //Asignar el tipo elegido
                {
                    if (cbxTipo.Text == tipo.nombre && cbxSubtipo.Text == tipo.subtipo)
                    {
                        equipo.tipo = tipo;
                        break;
                    }
                }
                dEquipo unE = new dEquipo();
                unE.altaEquipo(equipo);

                txtNombre.Clear();
                txtNroSerie.Clear();
                txtObservaciones.Clear();
                ckbAsegurado.Checked = false;
                actualizarDgv();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eEquipo equipo = new eEquipo();
            equipo.id = Convert.ToInt32(dgvEquipos.CurrentCell.OwningRow.Cells["id_equipo"].Value);
            equipo.nombre = dgvEquipos.CurrentCell.OwningRow.Cells["nombre"].Value.ToString();
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar el equipo " + equipo.nombre +
                           " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dEquipo unE = new dEquipo();
                unE.bajaEquipo(equipo);
                actualizarDgv();
                lblMensaje.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNroSerie.Text == "" || dtpFechaIngreso.Value == null)
            {
                lblMensaje.Text = "Rellene todos los campos por favor, los únicos opcionales son Observaciones y Precio";
            }
            else if (cbxTipo.Text == "" || cbxSubtipo.Text == "")
            {
                lblMensaje.Text = "Por favor seleccione Tipo y Subtipo del equipo";
            }
            else
            {
                eEquipo equipo = new eEquipo();
                equipo.id = Convert.ToInt32(dgvEquipos.CurrentRow.Cells["id_equipo"].Value);
                equipo.nombre = txtNombre.Text;
                equipo.nroSerie = txtNroSerie.Text;
                equipo.precio = txtPrecio.Text;
                equipo.observaciones = txtObservaciones.Text;
                equipo.estado = cbxEstado.Text;
                equipo.fechaIngreso = dtpFechaIngreso.Value;
                equipo.asegurado = ckbAsegurado.Checked;

                foreach (eTipoDeEquipo tipo in _tipos)       //Asignar el tipo elegido
                {
                    if (cbxTipo.Text == tipo.nombre && cbxSubtipo.Text == tipo.subtipo)
                    {
                        equipo.tipo = tipo;
                        break;
                    }
                }

                dEquipo unE = new dEquipo();
                unE.modificarEquipo(equipo);
                actualizarDgv();
            }
        }



        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          

            DGVPrinter printer = new DGVPrinter();

                printer.Title = "Lista de equipos";
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "PañolAudiovisual";//Footer
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvEquipos);
     
        }

        private void linkRoturas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal aux = (frmPrincipal)ActiveForm;
            aux.abrirGestionRoturas();
            Close();
        }

        private void btnAgregarRotura_Click(object sender, EventArgs e)
        {

        }
    }
}
