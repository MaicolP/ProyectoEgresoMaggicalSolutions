namespace Software_del_Pañol.ConfirmacionPrestamo
{
    partial class frmConfirmarPrestamoEspacio
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEspacio = new System.Windows.Forms.ComboBox();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpRetiro = new System.Windows.Forms.DateTimePicker();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblFechaD = new System.Windows.Forms.Label();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoResponsable = new System.Windows.Forms.TextBox();
            this.dtpSolicitado = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrestamoActual = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmar préstamos de espacios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxEspacio
            // 
            this.cbxEspacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspacio.Enabled = false;
            this.cbxEspacio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspacio.FormattingEnabled = true;
            this.cbxEspacio.Location = new System.Drawing.Point(480, 424);
            this.cbxEspacio.Name = "cbxEspacio";
            this.cbxEspacio.Size = new System.Drawing.Size(179, 25);
            this.cbxEspacio.TabIndex = 116;
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacio.ForeColor = System.Drawing.Color.Black;
            this.lblEspacio.Location = new System.Drawing.Point(214, 423);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(82, 26);
            this.lblEspacio.TabIndex = 115;
            this.lblEspacio.Text = "Espacio:";
            this.lblEspacio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.BackColor = System.Drawing.Color.LightGray;
            this.txtEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEjercicio.Enabled = false;
            this.txtEjercicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEjercicio.Location = new System.Drawing.Point(480, 381);
            this.txtEjercicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(179, 26);
            this.txtEjercicio.TabIndex = 114;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio.ForeColor = System.Drawing.Color.Black;
            this.lblEjercicio.Location = new System.Drawing.Point(214, 381);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(89, 26);
            this.lblEjercicio.TabIndex = 113;
            this.lblEjercicio.Text = "Ejercicio:";
            this.lblEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.LightGray;
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurso.Enabled = false;
            this.txtCurso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurso.Location = new System.Drawing.Point(480, 337);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(179, 26);
            this.txtCurso.TabIndex = 112;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDevolucion.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpDevolucion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDevolucion.Enabled = false;
            this.dtpDevolucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucion.Location = new System.Drawing.Point(480, 293);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(179, 29);
            this.dtpDevolucion.TabIndex = 111;
            this.dtpDevolucion.Value = new System.DateTime(2022, 9, 17, 0, 0, 0, 0);
            // 
            // dtpRetiro
            // 
            this.dtpRetiro.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpRetiro.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpRetiro.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpRetiro.Enabled = false;
            this.dtpRetiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetiro.Location = new System.Drawing.Point(480, 252);
            this.dtpRetiro.Name = "dtpRetiro";
            this.dtpRetiro.Size = new System.Drawing.Size(179, 29);
            this.dtpRetiro.TabIndex = 110;
            this.dtpRetiro.Value = new System.DateTime(2022, 9, 17, 0, 0, 0, 0);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(214, 337);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(66, 26);
            this.lblCurso.TabIndex = 109;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaD
            // 
            this.lblFechaD.AutoSize = true;
            this.lblFechaD.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaD.ForeColor = System.Drawing.Color.Black;
            this.lblFechaD.Location = new System.Drawing.Point(214, 296);
            this.lblFechaD.Name = "lblFechaD";
            this.lblFechaD.Size = new System.Drawing.Size(192, 26);
            this.lblFechaD.TabIndex = 108;
            this.lblFechaD.Text = "Fecha de devolución:";
            this.lblFechaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.ForeColor = System.Drawing.Color.Black;
            this.lblFechaR.Location = new System.Drawing.Point(211, 255);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(146, 26);
            this.lblFechaR.TabIndex = 107;
            this.lblFechaR.Text = "Fecha de retiro:";
            this.lblFechaR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(211, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 26);
            this.label2.TabIndex = 117;
            this.label2.Text = "Nombre responsable:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.BackColor = System.Drawing.Color.LightGray;
            this.txtNombreResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreResponsable.Enabled = false;
            this.txtNombreResponsable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreResponsable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreResponsable.Location = new System.Drawing.Point(480, 140);
            this.txtNombreResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(179, 26);
            this.txtNombreResponsable.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(211, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 119;
            this.label3.Text = "Apellido responsable:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellidoResponsable
            // 
            this.txtApellidoResponsable.BackColor = System.Drawing.Color.LightGray;
            this.txtApellidoResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoResponsable.Enabled = false;
            this.txtApellidoResponsable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoResponsable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellidoResponsable.Location = new System.Drawing.Point(480, 179);
            this.txtApellidoResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoResponsable.Name = "txtApellidoResponsable";
            this.txtApellidoResponsable.Size = new System.Drawing.Size(179, 26);
            this.txtApellidoResponsable.TabIndex = 120;
            // 
            // dtpSolicitado
            // 
            this.dtpSolicitado.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpSolicitado.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpSolicitado.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpSolicitado.Enabled = false;
            this.dtpSolicitado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSolicitado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSolicitado.Location = new System.Drawing.Point(480, 214);
            this.dtpSolicitado.Name = "dtpSolicitado";
            this.dtpSolicitado.Size = new System.Drawing.Size(179, 29);
            this.dtpSolicitado.TabIndex = 122;
            this.dtpSolicitado.Value = new System.DateTime(2022, 9, 17, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(211, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 121;
            this.label4.Text = "Fecha solicitada:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrestamoActual
            // 
            this.lblPrestamoActual.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamoActual.ForeColor = System.Drawing.Color.Black;
            this.lblPrestamoActual.Location = new System.Drawing.Point(1, 82);
            this.lblPrestamoActual.Name = "lblPrestamoActual";
            this.lblPrestamoActual.Size = new System.Drawing.Size(883, 26);
            this.lblPrestamoActual.TabIndex = 123;
            this.lblPrestamoActual.Text = "Préstamo N° 1";
            this.lblPrestamoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(326, 467);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(255, 36);
            this.lblMensaje.TabIndex = 127;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(181, 522);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 56);
            this.btnModificar.TabIndex = 126;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(606, 522);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 56);
            this.btnEliminar.TabIndex = 125;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(329, 522);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(252, 56);
            this.btnConfirmar.TabIndex = 124;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.Image = global::Software_del_Pañol.Properties.Resources.Fondo11;
            this.btnSiguiente.Location = new System.Drawing.Point(750, 242);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSiguiente.Size = new System.Drawing.Size(50, 51);
            this.btnSiguiente.TabIndex = 129;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.White;
            this.btnAnterior.Image = global::Software_del_Pañol.Properties.Resources.Fondo1;
            this.btnAnterior.Location = new System.Drawing.Point(85, 242);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 56);
            this.btnAnterior.TabIndex = 128;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmConfirmarPrestamoEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 601);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblPrestamoActual);
            this.Controls.Add(this.dtpSolicitado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoResponsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreResponsable);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.label1);
            this.Name = "frmConfirmarPrestamoEspacio";
            this.Text = "frmConfirmarPrestamocs";
            this.Load += new System.EventHandler(this.frmConfirmarPrestamoEspacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEspacio;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblFechaD;
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoResponsable;
        private System.Windows.Forms.DateTimePicker dtpSolicitado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrestamoActual;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}