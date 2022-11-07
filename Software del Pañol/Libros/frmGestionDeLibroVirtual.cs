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

namespace Software_del_Pañol.Libros
{
    public partial class frmGestionDeLibroVirtual : Form
    {
        public frmGestionDeLibroVirtual()
        {
            InitializeComponent();
        }

        private void frmGestionDeLibroVirtual_Load_1(object sender, EventArgs e)
        {
            modoEdicion(false);
            actualizarDgv();
        }


        private void frmGestionDeLibroVirtual_MouseClick(object sender, MouseEventArgs e)
        {
            dgvLibrosVirtual.ClearSelection();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            dgvLibrosVirtual.ClearSelection();
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
                txtUrl.Clear();
            }
        }

#region botones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUrl.Text == "")
            {
                lblMensaje.Text = "Rellene todos los campos, por favor";
            }
            else
            {
                eLibroVirtual libroVirtual = new eLibroVirtual();
                libroVirtual.nombre = txtNombre.Text;
                libroVirtual.url = txtUrl.Text;
                dLibroVirtual unLV = new dLibroVirtual();
                unLV.altaLibroVirtual(libroVirtual);
                actualizarDgv();
                modoEdicion(false);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eLibroVirtual libroVirtual = new eLibroVirtual();
            libroVirtual.id = Convert.ToInt32(dgvLibrosVirtual.CurrentCell.OwningRow.Cells["id"].Value);
            libroVirtual.nombre = dgvLibrosVirtual.CurrentCell.OwningRow.Cells["Nombre"].Value.ToString();
            libroVirtual.url = dgvLibrosVirtual.CurrentCell.OwningRow.Cells["url"].Value.ToString();
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar ellibro virtual : " + dgvLibrosVirtual.CurrentCell.OwningRow.Cells["nombre"].Value.ToString() + " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dLibroVirtual unLV = new dLibroVirtual();
                unLV.bajaLibroVirtual(libroVirtual);
                actualizarDgv();
                lblMensaje.Text = "";
            }
        }   
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUrl.Text == "")
            {
                lblMensaje.Text = "Rellene todos los campos, por favor";
            }
            else
            {
                eLibroVirtual libroVirtual = new eLibroVirtual();
                libroVirtual.id =
                Convert.ToInt32(dgvLibrosVirtual.CurrentCell.OwningRow.Cells["id"].Value);
                libroVirtual.nombre = txtNombre.Text;
                libroVirtual.url = txtUrl.Text;
                dLibroVirtual unLV = new dLibroVirtual();
                unLV.modificarLibroVirtual(libroVirtual);
                actualizarDgv();
                txtNombre.Clear();
                txtUrl.Clear();
            }
        }
        
#endregion

#region DataGridView

        private void actualizarDgv()
        {
            dLibroVirtual unLV = new dLibroVirtual();
            List<eLibroVirtual> _librosVirtual = new List<eLibroVirtual>();
            _librosVirtual = unLV.listarLibroVirtual();
            dgvLibrosVirtual.DataSource = _librosVirtual;
            lblMensaje.Text = "";
        }

        private void dgvLibrosVirtual_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibrosVirtual.SelectedCells.Count != 0)
            {
                modoEdicion(true);
                eLibroVirtual libroVirtual = new eLibroVirtual();
                libroVirtual.id =
                Convert.ToInt32(dgvLibrosVirtual.CurrentCell.OwningRow.Cells["id"].Value);
                dLibroVirtual unLV = new dLibroVirtual();
                libroVirtual = unLV.buscarLibroVirtual(libroVirtual);
                txtNombre.Text = libroVirtual.nombre;
                txtUrl.Text = libroVirtual.url;
                lblMensaje.Text = "";
            }
            else
            {
                modoEdicion(false);
            }
        }
        #endregion
    }
}
