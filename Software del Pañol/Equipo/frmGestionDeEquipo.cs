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
            actualizarDgv();
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

                txtNombre.Clear();
                txtNroSerie.Clear();
                txtObservaciones.Clear();
                ckbAsegurado.Checked = false;
            }
        }

        private void actualizarDgv()
        {
            dEquipo unE = new dEquipo();
            List<eEquipo> _equipos = unE.listarEquipo();
            dgvEquipos.DataSource = _equipos;
        }

        private void actualizarCbx()
        {
            dTipoDeEquipo unT = new dTipoDeEquipo();
            _tipos = unT.listarTipoDeEquipo();

            foreach (eTipoDeEquipo tipo in _tipos)
            {
                if (cbxTipo.Items.Contains(tipo.nombre) == false) cbxTipo.Items.Add(tipo.nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNroSerie.Text == "" || dtpFechaIngreso.Value == null)
            {
                lblMensaje.Text = "Rellene todos los campos por favor, los únicos opcionales son Observaciones y Precio";
            } else if (cbxTipo.Text == "" || cbxSubtipo.Text == "")
            {
                lblMensaje.Text = "Por favor seleccione Tipo y Subtipo del equipo";
            } else
            {
                eEquipo equipo = new eEquipo();
                equipo.nombre = txtNombre.Text;
                equipo.nroSerie = txtNroSerie.Text;
                equipo.precio = txtPrecio.Text;
                equipo.observaciones = txtObservaciones.Text;
                equipo.estado = estado.Disponible;
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

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedCells.Count != 0)
            {
                modoEdicion(true);
                eEquipo equipo = new eEquipo();
                equipo.id = Convert.ToInt32(dgvEquipos.CurrentCell.OwningRow.Cells[1].Value);
                dEquipo unE = new dEquipo();
                equipo = unE.buscarEquipo(equipo);

                txtNombre.Text = equipo.nombre;
                txtNroSerie.Text = equipo.nroSerie;
                txtObservaciones.Text = equipo.observaciones;
                txtPrecio.Text = equipo.precio;
                dtpFechaIngreso.Value = equipo.fechaIngreso.Date;
                ckbAsegurado.Checked = equipo.asegurado;

                cbxTipo.Text = equipo.tipo.nombre;
                cbxSubtipo.Text = equipo.tipo.subtipo;
                // !! Falta realizar Tipos !!

            } else
            {
                modoEdicion(false);
            }
        }

        private void cbxTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedText != null)
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
    }
}
