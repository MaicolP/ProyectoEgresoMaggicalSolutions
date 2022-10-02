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

namespace Software_del_Pañol.PrestamoEspacios
{
    public partial class frmSolicitarEspacio : Form
    {
        eUsuario usuarioActual = new eUsuario();

        public frmSolicitarEspacio(eUsuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void frmSolicitarEspacio_Load(object sender, EventArgs e)
        {
            actualizarCbx();
        }
        private void frmSolicitarEspacio_MouseClick(object sender, MouseEventArgs e)
        {
            lblMensaje.Text = "";
        }
        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text == "" || txtEjercicio.Text == "")
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Por favor complete todos los campos";
            }
            else
            {
                ePrestamoEspacio prestamo = new ePrestamoEspacio();

                prestamo.responsable = usuarioActual;
                prestamo.fecha_devolucion = dtpDevolucion.Value;
                prestamo.fecha_retiro = dtpRetiro.Value;
                prestamo.fecha_solicitado = DateTime.Now;
                prestamo.curso = txtCurso.Text;
                prestamo.ejercicio = txtEjercicio.Text;
                prestamo.espacio = (eEspacio)cbxEspacio.SelectedValue;
                prestamo.estadoP = estadoP.Pendiente.ToString();

                dPrestamo unPr = new dPrestamo();
                unPr.altaPrestamoEspacio(prestamo);

                lblMensaje.ForeColor = System.Drawing.Color.CornflowerBlue;
                lblMensaje.Text = "Se ha envíado la solicitud";

                txtCurso.Text = "";
                txtEjercicio.Text = "";
                cbxEspacio.ResetText();
            }

        }

        private void actualizarCbx()
        {
            dEspacio unE = new dEspacio();

            cbxEspacio.ValueMember = "id_espacio";
            cbxEspacio.DisplayMember = "nom";
            cbxEspacio.DataSource = unE.listarEspacios();
        }

  
    }
}
