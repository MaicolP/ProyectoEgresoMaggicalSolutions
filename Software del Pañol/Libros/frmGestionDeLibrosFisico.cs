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
    public partial class frmGestionDeLibrosFisico : Form
    {
        public frmGestionDeLibrosFisico()
        {
            InitializeComponent();
        }
        private void frmGestionDeLibrosFisico_Load(object sender, EventArgs e)
        {
            modoEdicion(false);
            actualizarDgv();
        }

        private void frmGestionDeLibrosFisico_MouseClick(object sender, MouseEventArgs e)
        {
            dgvLibros.ClearSelection();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            dgvLibros.ClearSelection();
        }

        private void frmGestionDeLibrosFisico_Click(object sender, EventArgs e)
        {
            dgvLibros.ClearSelection();
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

                txtTitulo.Clear();
                txtAutor.Clear();
                rbDisponible.Checked = false;
                rbNoDisponible.Checked = false;
            }
        }


        #region botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtAutor.Text == "")
            {
                lblMensaje.Text = "Rellene todos los campos, por favor";
            }
            else if (rbDisponible.Checked == false && rbNoDisponible.Checked == false)
            {
                lblMensaje.Text = "Por favor seleccione estado del Libro";
            }
            else
            {
                eLibro libro = new eLibro();
                libro.titulo = txtTitulo.Text;
                libro.autor = txtAutor.Text;

                if (rbDisponible.Checked == true)
                {
                    libro.disponible = true;
                }
                else if (rbNoDisponible.Checked == false)
                {
                    libro.disponible = false;
                }

                dLibro unL = new dLibro();
                unL.altaLibro(libro);

                actualizarDgv();

                txtTitulo.Clear();
                txtAutor.Clear();
                rbDisponible.Checked = false;
                rbNoDisponible.Checked = false;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eLibro libro = new eLibro();
            libro.id = Convert.ToInt32(dgvLibros.CurrentCell.OwningRow.Cells["id_libro"].Value);
            libro.titulo = dgvLibros.CurrentCell.OwningRow.Cells["titulo"].Value.ToString();
            libro.autor = dgvLibros.CurrentCell.OwningRow.Cells["autor"].Value.ToString();
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar el libro : " + dgvLibros.CurrentCell.OwningRow.Cells["titulo"].Value.ToString() +
                           " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dLibro unL = new dLibro();
                unL.bajaLibro(libro);
                actualizarDgv();
                lblMensaje.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtAutor.Text == "")
            {
                lblMensaje.Text = "Rellene todos los campos, por favor";
            }
            else if (rbDisponible.Checked == false && rbNoDisponible.Checked == false)
            {
                lblMensaje.Text = "Por favor seleccione estado del espacio";
            }
            else
            {
                eLibro libro = new eLibro();
                libro.id = Convert.ToInt32(dgvLibros.CurrentCell.OwningRow.Cells["id_libro"].Value);
                libro.titulo = txtTitulo.Text;
                libro.autor = txtAutor.Text;
                if (rbDisponible.Checked == true)
                {
                    libro.disponible = true;
                }
                else if (rbNoDisponible.Checked == false)
                {
                    libro.disponible = false;
                }

                dLibro unL = new dLibro();
                unL.modificarLibro(libro);

                actualizarDgv();

                txtTitulo.Clear();
                txtAutor.Clear();
                rbDisponible.Checked = false;
                rbNoDisponible.Checked = false;
            }
        }

        #endregion

        #region DataGridView

        private void actualizarDgv()
        {
            dLibro unL = new dLibro();
            List<eLibro> _libros = new List<eLibro>();

            _libros = unL.listarLibro();
            dgvLibros.DataSource = _libros;
            lblMensaje.Text = "";
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedCells.Count != 0)
            {
                modoEdicion(true);
                eLibro libro = new eLibro();
                libro.id = Convert.ToInt32(dgvLibros.CurrentCell.OwningRow.Cells["id_libro"].Value);
                dLibro unL = new dLibro();
                libro = unL.buscarLibro(libro);

                txtTitulo.Text = libro.titulo;
                txtAutor.Text = libro.autor;
                if (libro.disponible == true)
                {
                    rbDisponible.Checked = true;
                }
                else if (libro.disponible == false)
                {
                    rbNoDisponible.Checked = true;
                }

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