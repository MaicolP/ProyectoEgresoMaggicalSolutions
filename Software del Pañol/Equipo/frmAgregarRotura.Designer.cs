namespace Software_del_Pañol.Equipo
{
    partial class frmAgregarRotura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarRotura));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDesperfecto = new System.Windows.Forms.TextBox();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.mskPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(98, 310);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 46);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDesperfecto
            // 
            this.txtDesperfecto.BackColor = System.Drawing.Color.LightGray;
            this.txtDesperfecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesperfecto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesperfecto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDesperfecto.Location = new System.Drawing.Point(142, 127);
            this.txtDesperfecto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesperfecto.Multiline = true;
            this.txtDesperfecto.Name = "txtDesperfecto";
            this.txtDesperfecto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesperfecto.Size = new System.Drawing.Size(217, 62);
            this.txtDesperfecto.TabIndex = 30;
            // 
            // txtSolucion
            // 
            this.txtSolucion.BackColor = System.Drawing.Color.LightGray;
            this.txtSolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolucion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSolucion.Location = new System.Drawing.Point(142, 207);
            this.txtSolucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolucion.Size = new System.Drawing.Size(217, 64);
            this.txtSolucion.TabIndex = 32;
            // 
            // mskPrestamo
            // 
            this.mskPrestamo.AllowPromptAsInput = false;
            this.mskPrestamo.BackColor = System.Drawing.Color.LightGray;
            this.mskPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskPrestamo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrestamo.HidePromptOnLeave = true;
            this.mskPrestamo.Location = new System.Drawing.Point(142, 82);
            this.mskPrestamo.Mask = "9999";
            this.mskPrestamo.Name = "mskPrestamo";
            this.mskPrestamo.Size = new System.Drawing.Size(72, 26);
            this.mskPrestamo.TabIndex = 78;
            this.mskPrestamo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "Préstamo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 76;
            this.label4.Text = "Solución:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.Black;
            this.lblObservaciones.Location = new System.Drawing.Point(16, 127);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(119, 26);
            this.lblObservaciones.TabIndex = 75;
            this.lblObservaciones.Text = "Desperfecto:";
            this.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(380, 60);
            this.pnlTitulo.TabIndex = 80;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 60);
            this.lblTitulo.TabIndex = 81;
            this.lblTitulo.Text = "Rotura del equipo ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(50, 275);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(270, 32);
            this.lblMensaje.TabIndex = 81;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAgregarRotura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 368);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.mskPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.txtDesperfecto);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarRotura";
            this.Text = "Agregar Rotura";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAgregarRotura_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDesperfecto;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.MaskedTextBox mskPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
    }
}