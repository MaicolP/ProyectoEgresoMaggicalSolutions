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
    public partial class frmTiposDeEquipo : Form
    {

        public frmTiposDeEquipo()
        {
            InitializeComponent();
        }
        private void frmGestionDeLibrosFisico_Load(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            dgvTipos.ClearSelection();
        }

        #region Botones

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar el tipo : " + dgvTipos.CurrentCell.OwningRow.Cells["idTipo"].Value.ToString() +
                           " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dTipoDeEquipo unDT = new dTipoDeEquipo();
                eTipoDeEquipo tipo = new eTipoDeEquipo();
                tipo.id = (int)dgvTipos.CurrentCell.OwningRow.Cells["idTipo"].Value;
                unDT.bajaTipoDeEquipo(tipo);
                actualizarDgv();
                lblMensaje.Text = "Tipo eliminado correctamente";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtSubtipo.Text == "")
            {
                lblMensaje.Text = "Complete los campos";
            }
            else
            {
                dTipoDeEquipo unDT = new dTipoDeEquipo();
                eTipoDeEquipo tipo = new eTipoDeEquipo();
                tipo.id = (int)dgvTipos.CurrentCell.OwningRow.Cells["idTipo"].Value;
                tipo.nombre = txtNombre.Text;
                tipo.subtipo = txtSubtipo.Text;

                unDT.modificarTipoDeEquipo(tipo);

                actualizarDgv();
                lblMensaje.Text = "Modificado correctamente";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtSubtipo.Text == "")
            {
                lblMensaje.Text = "Complete los campos";
            }
            else
            {
                dTipoDeEquipo unDT = new dTipoDeEquipo();
                eTipoDeEquipo tipo = new eTipoDeEquipo();
                tipo.nombre = txtNombre.Text;
                tipo.subtipo = txtSubtipo.Text;

                unDT.altaTipoDeEquipo(tipo);

                actualizarDgv();
                lblMensaje.Text = "Agregado correctamente";
            }
        }

        #endregion

        #region DataGridView

        private void actualizarDgv()
        {
            dTipoDeEquipo unDT = new dTipoDeEquipo();
            dgvTipos.DataSource = unDT.listarTipoDeEquipo();
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTipos.SelectedCells.Count != 0)
            {
                btnEliminar.Show();
                btnModificar.Show();
                btnAgregar.Hide();

                dTipoDeEquipo unDT = new dTipoDeEquipo();
                eTipoDeEquipo tipo = new eTipoDeEquipo();
                tipo = unDT.buscarTipo((int)dgvTipos.CurrentCell.OwningRow.Cells["idTipo"].Value);

                txtNombre.Text = tipo.nombre;
                txtSubtipo.Text = tipo.subtipo;
            }
            else
            {
                btnAgregar.Show();
                btnEliminar.Hide();
                btnModificar.Hide();
                txtNombre.Clear();
                txtSubtipo.Clear();
            }
        }

        #endregion

        private void chkEquipo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        private void frmGestionRoturas_Click(object sender, EventArgs e)
        {
            dgvTipos.ClearSelection();
        }
    }
}