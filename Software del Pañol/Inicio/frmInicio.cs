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
using Software_del_Pañol.Properties;
using Dominio;

namespace Software_del_Pañol
{
    public partial class frmInicio : Form
    {
        public eUsuario usuarioActual { get; set; }

        public frmInicio(eUsuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Bienvenido " + usuarioActual.nombre;
            //notificacion a = new notificacion("El plazo de devolución del prestamo ... realizado por ... ha finalizado!");
            //this.fpnlContenido.Controls.Add(a);

            dPrestamoEquipo unPEQ = new dPrestamoEquipo();
            notiPEquipo(unPEQ.listarPESinDevolver());

            dPrestamoEspacio unPE = new dPrestamoEspacio();
            notiPEspacio(unPE.listarPESinDevolver());
        }

        private void notiPEquipo(List<ePrestamoEquipo> _prestamos)
        {
            foreach(var p in _prestamos)
            {
                notificacion a = new notificacion("El plazo de devolución del prestamo de equipo " + p.id + " realizado por " + p.responsable.nombre  + " " + p.responsable.apellido + " ha finalizado!");
                this.fpnlContenido.Controls.Add(a);
            }
        }

        private void notiPEspacio(List<ePrestamoEspacio> _prestamos)
        {
            foreach (var p in _prestamos)
            {
                notificacion a = new notificacion("El plazo de devolución del prestamo de espacio " + p.id + " realizado por " + p.responsable.nombre + " " + p.responsable.apellido + " ha finalizado!");
                this.fpnlContenido.Controls.Add(a);
            }
        }

    }

    class notificacion : Panel
    {
        PictureBox pbxFlecha = new PictureBox();
        Label lblMensaje = new Label();
        PictureBox pbxLinea = new PictureBox();

        public notificacion(string texto)
        {
            // 
            // pbxFlecha
            // 
            pbxFlecha.Image = ((System.Drawing.Image)(Resources.flechaNotis));
            pbxFlecha.Location = new System.Drawing.Point(13, 10);
            pbxFlecha.Name = "pbxFlecha";
            pbxFlecha.Size = new System.Drawing.Size(102, 37);
            pbxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbxFlecha.TabIndex = 1;
            pbxFlecha.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMensaje.ForeColor = System.Drawing.Color.Black;
            lblMensaje.Location = new System.Drawing.Point(133, 3);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new System.Drawing.Size(737, 60);
            lblMensaje.TabIndex = 12;
            lblMensaje.Text = texto;
            // 
            // pbxLinea
            // 
            pbxLinea.BackColor = System.Drawing.Color.Silver;
            pbxLinea.Location = new System.Drawing.Point(164, 57);
            pbxLinea.Name = "pbxLinea";
            pbxLinea.Size = new System.Drawing.Size(560, 2);
            pbxLinea.TabIndex = 16;
            pbxLinea.TabStop = false;
            // 
            // pnlNoti
            // 
            Controls.Add(pbxLinea);
            Controls.Add(lblMensaje);
            Controls.Add(pbxFlecha);
            Dock = System.Windows.Forms.DockStyle.Top;
            Location = new System.Drawing.Point(3, 62);
            Name = "pnlNoti";
            Size = new System.Drawing.Size(882, 70);
            TabIndex = 0;
        }

    }
}
