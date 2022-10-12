namespace Software_del_Pañol.PrestamoEspacios
{
    partial class frmSolicitarEspacio
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
            this.lblFechaR = new System.Windows.Forms.Label();
            this.lblFechaD = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dtpRetiro = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.cbxEspacio = new System.Windows.Forms.ComboBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.ForeColor = System.Drawing.Color.Black;
            this.lblFechaR.Location = new System.Drawing.Point(225, 103);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(146, 26);
            this.lblFechaR.TabIndex = 84;
            this.lblFechaR.Text = "Fecha de retiro:";
            this.lblFechaR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaD
            // 
            this.lblFechaD.AutoSize = true;
            this.lblFechaD.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaD.ForeColor = System.Drawing.Color.Black;
            this.lblFechaD.Location = new System.Drawing.Point(225, 144);
            this.lblFechaD.Name = "lblFechaD";
            this.lblFechaD.Size = new System.Drawing.Size(192, 26);
            this.lblFechaD.TabIndex = 85;
            this.lblFechaD.Text = "Fecha de devolución:";
            this.lblFechaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(225, 185);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(66, 26);
            this.lblCurso.TabIndex = 94;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpRetiro
            // 
            this.dtpRetiro.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpRetiro.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpRetiro.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpRetiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetiro.Location = new System.Drawing.Point(491, 100);
            this.dtpRetiro.Name = "dtpRetiro";
            this.dtpRetiro.Size = new System.Drawing.Size(179, 29);
            this.dtpRetiro.TabIndex = 95;
            this.dtpRetiro.Value = new System.DateTime(2022, 9, 17, 0, 0, 0, 0);
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDevolucion.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpDevolucion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDevolucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucion.Location = new System.Drawing.Point(491, 141);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(179, 29);
            this.dtpDevolucion.TabIndex = 96;
            this.dtpDevolucion.Value = new System.DateTime(2022, 9, 17, 0, 0, 0, 0);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(901, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario de solicitud de espacios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.LightGray;
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurso.Location = new System.Drawing.Point(491, 185);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(179, 26);
            this.txtCurso.TabIndex = 98;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio.ForeColor = System.Drawing.Color.Black;
            this.lblEjercicio.Location = new System.Drawing.Point(225, 229);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(89, 26);
            this.lblEjercicio.TabIndex = 103;
            this.lblEjercicio.Text = "Ejercicio:";
            this.lblEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.BackColor = System.Drawing.Color.LightGray;
            this.txtEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEjercicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEjercicio.Location = new System.Drawing.Point(491, 229);
            this.txtEjercicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(179, 26);
            this.txtEjercicio.TabIndex = 104;
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacio.ForeColor = System.Drawing.Color.Black;
            this.lblEspacio.Location = new System.Drawing.Point(225, 271);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(82, 26);
            this.lblEspacio.TabIndex = 105;
            this.lblEspacio.Text = "Espacio:";
            this.lblEspacio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxEspacio
            // 
            this.cbxEspacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspacio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspacio.FormattingEnabled = true;
            this.cbxEspacio.Location = new System.Drawing.Point(491, 272);
            this.cbxEspacio.Name = "cbxEspacio";
            this.cbxEspacio.Size = new System.Drawing.Size(179, 25);
            this.cbxEspacio.TabIndex = 106;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.btnSolicitar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSolicitar.Location = new System.Drawing.Point(316, 489);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(252, 56);
            this.btnSolicitar.TabIndex = 107;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(313, 439);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(255, 36);
            this.lblMensaje.TabIndex = 108;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSolicitarEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 557);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.cbxEspacio);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.dtpRetiro);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblFechaD);
            this.Controls.Add(this.lblFechaR);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmSolicitarEspacio";
            this.Text = "frmPrestamoEspacios";
            this.Load += new System.EventHandler(this.frmSolicitarEspacio_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmSolicitarEspacio_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.Label lblFechaD;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.ComboBox cbxEspacio;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label lblMensaje;
    }
}