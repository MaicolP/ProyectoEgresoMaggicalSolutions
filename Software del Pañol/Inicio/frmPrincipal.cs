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
using System.Runtime.InteropServices;
using Software_del_Pañol.Espacios;
using Software_del_Pañol.PrestamoEspacios;
using Software_del_Pañol.ConfirmacionPrestamo;

namespace Software_del_Pañol
{
    public partial class frmPrincipal : Form
    {

        public Form frmHijoSeleccionado = null;
        public eUsuario usuarioActual { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmPrincipal(eUsuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        #region Form

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmInicio(usuarioActual));

            eResponsable responsable = new eResponsable();
            responsable.ci = usuarioActual.ci;
            dResponsable unR = new dResponsable();

            if (unR.buscarResponsable(responsable) != null)
            {
                gestionDeEquiposToolStripMenuItem.Visible = false;
                gestionDeLibrosToolStripMenuItem.Visible = false;
                gestionDeEspaciosToolStripMenuItem.Visible = false;
                gestionDeUsuariosToolStripMenuItem.Visible = false;
            }

        }

        private void cambiarFormHijo(Form formHijo)
        {
            if (frmHijoSeleccionado != null) frmHijoSeleccionado.Close();

            frmHijoSeleccionado = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlCont.Controls.Add(formHijo);
            pnlCont.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        #endregion

        #region Titulo

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void lblFecha_Paint(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();

            FormCollection login = Application.OpenForms;

            login[0].Show();
        }

        #endregion

        #region Inicio

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmInicio(usuarioActual));
        }

        #endregion

        #region Gestion Usuario

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmGestionUsuarios());
        }

        #endregion

        #region Gestion Equipo

        private void gestionDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmGestionDeEquipo());
        }

        #endregion

        #region Gestion de espacios

        private void gestionDeEspaciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmGestionDeEspacios());
        }

        #endregion

        #region Solicitar prestamo

        private void espacioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmSolicitarEspacio(usuarioActual));
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmSolicitarEquipo(usuarioActual));
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmSolicitarLibro(usuarioActual));
        }




        #endregion

        #region Gestion Libros

        private void librosFísicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmGestionDeLibrosFisico());
        }

        #endregion

        private void equipoCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dAsisTec unAT = new dAsisTec();
            eAsisTec asisTec = new eAsisTec();

            asisTec.id = usuarioActual.id;
            asisTec = unAT.buscarAsisTec(asisTec);

            if (asisTec != null) cambiarFormHijo(new frmConfirmarPrestamoEquipos(asisTec));
        }

        private void espacioCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dAsisTec unAT = new dAsisTec();
            eAsisTec asisTec = new eAsisTec();

            asisTec.id = usuarioActual.id;
            asisTec = unAT.buscarAsisTec(asisTec);

            if (asisTec != null) cambiarFormHijo(new frmConfirmarPrestamoEspacio(asisTec));
            
    
            
            
        }

    }
}
