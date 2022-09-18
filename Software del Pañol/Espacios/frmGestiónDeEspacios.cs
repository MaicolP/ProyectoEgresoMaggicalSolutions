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
            modoEdicion(false);
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
            }
        }
    }
}
