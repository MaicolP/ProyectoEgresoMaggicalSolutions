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

            //AGREGAR NOTIFICACION
            //notificacion a = new notificacion("El plazo de devolución del prestamo ... realizado por ... ha finalizado!", tipoNoti.);
            //this.fpnlContenido.Controls.Add(a);

            int auxCant = 0;

            dPrestamoEquipo unPEQ = new dPrestamoEquipo();
            notiPEquipo(unPEQ.listarPESinDevolver());

            dPrestamoEspacio unPE = new dPrestamoEspacio();
            notiPEspacio(unPE.listarPESinDevolver());

            dPrestamoLibro unPL = new dPrestamoLibro();
            notiPLibro(unPL.listarPLSinDevolver());

            dPrestamoUrgente unPU = new dPrestamoUrgente();
            notiPUrgente(unPU.listarPUSinDevolver());

            auxCant = unPEQ.listarPrestamoEquipo(estadoP.Pendiente).Count;
            if (auxCant != 0)
            {
                notificacion noti = new notificacion("Tiene " + auxCant + " prestamos de equipo sin confirmar",tipoNoti.MENSAJE);
                fpnlContenido.Controls.Add(noti);
            }

            auxCant = unPE.listarPrestamoEspacio(estadoP.Pendiente).Count;
            if (auxCant != 0)
            {
                notificacion noti = new notificacion("Tiene " + auxCant + " prestamos de espacio sin confirmar", tipoNoti.MENSAJE);
                fpnlContenido.Controls.Add(noti);
            }
        }

        private void notiPEquipo(List<ePrestamoEquipo> _prestamos)
        {
            foreach(var p in _prestamos)
            {
                notificacion noti = new notificacion("El plazo de devolución del prestamo de equipo " + p.id + " realizado por " + p.responsable.nombre  + " " + p.responsable.apellido + " ha finalizado!", tipoNoti.ATRASADOS);
                this.fpnlContenido.Controls.Add(noti);
                noti.prestamo = p;
            }
        }

        private void notiPEspacio(List<ePrestamoEspacio> _prestamos)
        {
            foreach (var p in _prestamos)
            {
                notificacion noti = new notificacion("El plazo de devolución del prestamo de espacio " + p.id + " realizado por " + p.responsable.nombre + " " + p.responsable.apellido + " ha finalizado!", tipoNoti.ATRASADOS);
                this.fpnlContenido.Controls.Add(noti);
                noti.prestamo = p;
            }
        }

        private void notiPLibro(List<ePrestamoLibro> _prestamos)
        {
            foreach (var p in _prestamos)
            {
                notificacion noti = new notificacion("El plazo de devolución del prestamo de libro " + p.id + " realizado por " + p.responsable.nombre + " " + p.responsable.apellido + " ha finalizado!", tipoNoti.ATRASADOS);
                this.fpnlContenido.Controls.Add(noti);
                noti.prestamo = p;
            }
        }

        private void notiPUrgente(List<ePrestamoUrgente> _prestamos)
        {
            foreach (var p in _prestamos)
            {
                notificacion noti = new notificacion("El plazo de devolución del prestamo urgente " + p.id + " realizado por " + p.responsable.nombre + " " + p.responsable.apellido + " ha finalizado!", tipoNoti.ATRASADOS);
                this.fpnlContenido.Controls.Add(noti);
                noti.prestamo = p;
            }
        }
    }

    class notificacion : Panel // PANEL DE NOTIFICACIÓNES
    {

        PictureBox pbxFlecha = new PictureBox();
        Label lblMensaje = new Label();
        PictureBox pbxLinea = new PictureBox();
        Button btnFinalizar = new Button();
        public ePrestamo prestamo = new ePrestamo();

        public notificacion(string texto, tipoNoti tipo)
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
            lblMensaje.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMensaje.ForeColor = System.Drawing.Color.Black;
            lblMensaje.Location = new System.Drawing.Point(133, 3);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new System.Drawing.Size(670, 60);
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
            Dock = System.Windows.Forms.DockStyle.Top;
            Location = new System.Drawing.Point(3, 62);
            Name = "pnlNoti";
            Size = new System.Drawing.Size(867, 70);
            TabIndex = 0;
            
            if(tipo == tipoNoti.ATRASADOS)
            {
                // 
                // btnFinalizar
                // 
                btnFinalizar.BackColor = System.Drawing.Color.Red;
                btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnFinalizar.ForeColor = System.Drawing.Color.White;
                btnFinalizar.Location = new System.Drawing.Point(795, 20);
                btnFinalizar.Name = "btnFinalizar";
                btnFinalizar.Size = new System.Drawing.Size(70, 27);
                btnFinalizar.TabIndex = 56;
                btnFinalizar.Text = "Finalizar";
                btnFinalizar.UseVisualStyleBackColor = false;
                btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
                Controls.Add(btnFinalizar);
            }

            Controls.Add(pbxLinea);
            Controls.Add(lblMensaje);
            Controls.Add(pbxFlecha);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.prestamo.estadoP = estadoP.Finalizado.ToString();
            dPrestamo dP = new dPrestamo();
            dP.finalizarPrestamo(this.prestamo);
            this.Dispose();
        }
    }

    enum tipoNoti {ATRASADOS,MENSAJE}
}
