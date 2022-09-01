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
using System.Runtime.InteropServices;

namespace Software_del_Pañol
{
    public partial class frmPrincipal : Form
    {

        private Form frmHijoSeleccionado = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmPrincipal()
        {
            InitializeComponent();
            cambiarFormHijo(new frmInicio());
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

        #region Inicio

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmInicio());
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

        #region Gestion Usuario

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmGestionUsuarios());
        }

        #endregion

        #region Gestion Equipo

        private void agregarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmAltaEquipo());
        }

        private void listaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFormHijo(new frmListaEquipo());
        }

        #endregion
    }
}
