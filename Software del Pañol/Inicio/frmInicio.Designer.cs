namespace Software_del_Pañol
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.fpnlContenido = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.pbxFlecha = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbxLinea = new System.Windows.Forms.PictureBox();
            this.pnlNoti = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            this.fpnlContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinea)).BeginInit();
            this.pnlNoti.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(885, 60);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(885, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido Administrador";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnlContenido
            // 
            this.fpnlContenido.BackColor = System.Drawing.Color.White;
            this.fpnlContenido.Controls.Add(this.panel1);
            this.fpnlContenido.Controls.Add(this.pnlNoti);
            this.fpnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlContenido.Location = new System.Drawing.Point(0, 60);
            this.fpnlContenido.Name = "fpnlContenido";
            this.fpnlContenido.Size = new System.Drawing.Size(885, 515);
            this.fpnlContenido.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 53);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_del_Pañol.Properties.Resources.campana;
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(55, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(133, 26);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Notificaciones";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbxFlecha
            // 
            this.pbxFlecha.Image = ((System.Drawing.Image)(resources.GetObject("pbxFlecha.Image")));
            this.pbxFlecha.Location = new System.Drawing.Point(13, 10);
            this.pbxFlecha.Name = "pbxFlecha";
            this.pbxFlecha.Size = new System.Drawing.Size(102, 37);
            this.pbxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFlecha.TabIndex = 1;
            this.pbxFlecha.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(133, 3);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(737, 43);
            this.lblMensaje.TabIndex = 12;
            this.lblMensaje.Text = "Tienes 3 prestamos por confirmar";
            // 
            // pbxLinea
            // 
            this.pbxLinea.BackColor = System.Drawing.Color.Silver;
            this.pbxLinea.Location = new System.Drawing.Point(164, 49);
            this.pbxLinea.Name = "pbxLinea";
            this.pbxLinea.Size = new System.Drawing.Size(560, 2);
            this.pbxLinea.TabIndex = 16;
            this.pbxLinea.TabStop = false;
            // 
            // pnlNoti
            // 
            this.pnlNoti.Controls.Add(this.pbxLinea);
            this.pnlNoti.Controls.Add(this.lblMensaje);
            this.pnlNoti.Controls.Add(this.pbxFlecha);
            this.pnlNoti.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNoti.Location = new System.Drawing.Point(3, 62);
            this.pnlNoti.Name = "pnlNoti";
            this.pnlNoti.Size = new System.Drawing.Size(882, 54);
            this.pnlNoti.TabIndex = 0;
            this.pnlNoti.Visible = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 575);
            this.Controls.Add(this.fpnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmInicio";
            this.Text = "frmAltaUsuario";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.fpnlContenido.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLinea)).EndInit();
            this.pnlNoti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel fpnlContenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Panel pnlNoti;
        private System.Windows.Forms.PictureBox pbxLinea;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbxFlecha;
    }
}