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

namespace Software_del_Pañol.Espacios
{
    public partial class frmGestionDeEspacios : Form
    {
        public frmGestionDeEspacios()
        {
            InitializeComponent();
        }

        private void frmGestionDeEspacios_Load(object sender, EventArgs e)
        {
            actualizarDgv();
            modoEdicion(false);
        }

        private void frmGestionEspacios_MouseClick(object sender, MouseEventArgs e)
        {
            dgvEspacios.ClearSelection();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            dgvEspacios.ClearSelection();
        }

        private void frmGestionDeEspacios_Click(object sender, EventArgs e)
        {
            dgvEspacios.ClearSelection();
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
                rbDisponible.Checked = false;
                rbNoDisponible.Checked = false;

            }
        }

        #region Botones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblMensaje.Text = "Rellene todos los campos, por favor";
            }
            else if (rbDisponible.Checked == false && rbNoDisponible.Checked == false)
            {
                lblMensaje.Text = "Por favor seleccione estado del espacio";
            }
            else
            {
                eEspacio espacio = new eEspacio();
                espacio.nom = txtNombre.Text;
                if (rbDisponible.Checked)
                {
                    espacio.disponible = true;
                }
                else if (rbNoDisponible.Checked)
                {
                    espacio.disponible = false;
                }

                dEspacio unE = new dEspacio();
                unE.altaEspacio(espacio);

                actualizarDgv();

                txtNombre.Clear();
                rbDisponible.Checked = false;
                rbNoDisponible.Checked = false;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eEspacio espacio = new eEspacio();
            espacio.id = Convert.ToInt32(dgvEspacios.CurrentCell.OwningRow.Cells["id_espacio"].Value);
            espacio.nom = dgvEspacios.CurrentCell.OwningRow.Cells["nombre"].Value.ToString();
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar el espacio : " + dgvEspacios.CurrentCell.OwningRow.Cells["nombre"].Value.ToString() +
                           " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dEspacio unE = new dEspacio();
                unE.bajaEspacio(espacio);
                actualizarDgv();
                lblMensaje.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblMensaje.Text = "Rellene todos los campos, por favor";
            }
            else if (rbDisponible.Checked == false && rbNoDisponible.Checked == false)
            {
                lblMensaje.Text = "Por favor seleccione estado del espacio";
            }
            else
            {
                eEspacio espacio = new eEspacio();
                espacio.id = Convert.ToInt32(dgvEspacios.CurrentCell.OwningRow.Cells["id_espacio"].Value);
                espacio.nom = txtNombre.Text;
                if (rbDisponible.Checked == true)
                {
                    espacio.disponible = true;
                }
                else if (rbNoDisponible.Checked == false)
                {
                    espacio.disponible = false;
                }

                dEspacio unE = new dEspacio();
                unE.modificarEspacio(espacio);

                actualizarDgv();

                txtNombre.Clear();
                rbDisponible.Checked = false;
                rbNoDisponible.Checked = false;
            }
        }

        #endregion 

        #region DataGridView

        private void actualizarDgv()
        {
            dEspacio unE = new dEspacio();
            List<eEspacio> _espacios = new List<eEspacio>();

                _espacios = unE.listarEspacios();
                dgvEspacios.DataSource = _espacios;
                lblMensaje.Text = "";
        }

        private void dgvEspacios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEspacios.SelectedCells.Count != 0)
            {
                modoEdicion(true);
                eEspacio espacio = new eEspacio();
                espacio.id = Convert.ToInt32(dgvEspacios.CurrentCell.OwningRow.Cells["id_espacio"].Value);
                dEspacio unE = new dEspacio();
                espacio = unE.buscarEspacio(espacio);

                txtNombre.Text = espacio.nom;
                if(espacio.disponible == true)
                {
                    rbDisponible.Checked = true;
                }
                else if(espacio.disponible == false)
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
