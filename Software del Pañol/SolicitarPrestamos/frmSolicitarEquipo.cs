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
using Software_del_Pañol.SolicitarPrestamos;

namespace Software_del_Pañol
{
    public partial class frmSolicitarEquipo : Form
    {

        public List<eEquipo> _equipos = new List<eEquipo>();

        public frmSolicitarEquipo()
        {
            InitializeComponent();
        }

        private void frmGestionDeEquipo_Load(object sender, EventArgs e)
        {

        }

        #region ComboBox

        #endregion

        #region DataGridView

        public void actualizarDgv()
        {
            dgvEquipos.DataSource = _equipos;
        }

        #endregion

        #region Botones

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            frmSeleccionarEquipos frmEq = new frmSeleccionarEquipos();
            AddOwnedForm(frmEq);
            frmEq.Show();
        }

        #endregion

    }
}
