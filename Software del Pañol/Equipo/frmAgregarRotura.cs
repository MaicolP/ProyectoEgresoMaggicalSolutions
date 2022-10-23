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

namespace Software_del_Pañol.Equipo
{
    public partial class frmAgregarRotura : Form
    {

        eEquipo equipo = new eEquipo();

        public frmAgregarRotura(eEquipo eq)
        {
            InitializeComponent();
            equipo = eq;
        }

        private void frmAgregarRotura_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Rotura del equipo " + equipo.nombre ;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesperfecto.Text == "" || txtSolucion.Text == "" || mskPrestamo.Text == "")
            {
                lblMensaje.Text = "Complete los campos";
            }
            else
            {
                dRotura unDR = new dRotura();
                eRotura rotura = new eRotura();
                rotura.detalleDesperfecto = txtDesperfecto.Text;
                rotura.detalleSolucion = txtSolucion.Text;
                rotura.idPrestamoOrigenRotura = Convert.ToInt32(mskPrestamo.Text);
                rotura.equipo = equipo;
                unDR.altaRotura(rotura);
                Close();
            }
        }
    }
}
