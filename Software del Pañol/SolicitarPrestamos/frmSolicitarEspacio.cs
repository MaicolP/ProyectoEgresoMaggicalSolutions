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
            if (cbxCurso.Text == "" || cbxEjercicio.Text == "")
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Por favor complete todos los campos";
            }
            else if (validarfecha() == false)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Asegurese que la fecha sea 1 día mayor que la fecha actual";
            }
            else
            {
                ePrestamoEspacio prestamo = new ePrestamoEspacio();

                prestamo.responsable = usuarioActual;
                prestamo.fecha_devolucion = dtpDevolucion.Value;
                prestamo.fecha_retiro = dtpRetiro.Value;
                prestamo.fecha_solicitado = DateTime.Now;
                prestamo.curso = cbxCurso.Text;
                prestamo.ejercicio = cbxEjercicio.Text;
                if ((cbxCurso.Text == "Tercero Bachillerato" && cbxEjercicio.Text == "Rodaje") || (cbxCurso.Text == "Segundo Tecnicatura" && cbxEjercicio.Text == "Rodaje")) prestamo.prioridad = 3;
                else if ((cbxCurso.Text == "Primero Tecnicatura" && cbxEjercicio.Text == "Rodaje")) prestamo.prioridad = 2;
                else
                {
                    prestamo.prioridad = 1;
                }
                prestamo.espacio = (eEspacio)cbxEspacio.SelectedValue;
                prestamo.estadoP = estadoP.Pendiente.ToString();

                dPrestamoEspacio undp = new dPrestamoEspacio();
                undp.altaPrestamoEspacio(prestamo);

                lblMensaje.ForeColor = System.Drawing.Color.CornflowerBlue;
                lblMensaje.Text = "Se ha envíado la solicitud";

                cbxCurso.Items.Clear();
                cbxEjercicio.Items.Clear();
                cbxEspacio.Items.Clear();
            }

        }

        private void actualizarCbx()
        {
            dEspacio unE = new dEspacio();

            cbxEspacio.ValueMember = "id_espacio";
            cbxEspacio.DisplayMember = "nom";
            cbxEspacio.DataSource = unE.listarEspacios();
        }

        private bool validarfecha()
        {
            bool aux = false;
            TimeSpan difDia = dtpRetiro.Value - DateTime.Now;
            TimeSpan difReserva = dtpDevolucion.Value - dtpRetiro.Value;
            if (difDia.Days >= 1 && difReserva.TotalHours > 0)
            {
                aux = true;
            }
            return aux;
        }

    }
}
