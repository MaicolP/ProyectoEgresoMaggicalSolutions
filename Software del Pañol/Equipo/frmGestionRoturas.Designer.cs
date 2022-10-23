namespace Software_del_Pañol
{
    partial class frmGestionRoturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvRoturas = new System.Windows.Forms.DataGridView();
            this.idRotura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesperfecto = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblNroSerie = new System.Windows.Forms.Label();
            this.cbxEquipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.chkEquipo = new System.Windows.Forms.CheckBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoturas)).BeginInit();
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
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(885, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Roturas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(36, 493);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 56);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(187, 493);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 56);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(36, 438);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(270, 52);
            this.lblMensaje.TabIndex = 41;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRoturas
            // 
            this.dgvRoturas.AllowUserToAddRows = false;
            this.dgvRoturas.AllowUserToDeleteRows = false;
            this.dgvRoturas.AllowUserToResizeColumns = false;
            this.dgvRoturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvRoturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRoturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRotura,
            this.Titulo,
            this.Autor,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoturas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoturas.EnableHeadersVisualStyles = false;
            this.dgvRoturas.GridColor = System.Drawing.Color.Gray;
            this.dgvRoturas.Location = new System.Drawing.Point(373, 115);
            this.dgvRoturas.MultiSelect = false;
            this.dgvRoturas.Name = "dgvRoturas";
            this.dgvRoturas.ReadOnly = true;
            this.dgvRoturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRoturas.RowHeadersVisible = false;
            this.dgvRoturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvRoturas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRoturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoturas.Size = new System.Drawing.Size(502, 414);
            this.dgvRoturas.TabIndex = 62;
            this.dgvRoturas.SelectionChanged += new System.EventHandler(this.dgvLibros_SelectionChanged);
            // 
            // idRotura
            // 
            this.idRotura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idRotura.DataPropertyName = "id";
            this.idRotura.HeaderText = "Id Rotura";
            this.idRotura.Name = "idRotura";
            this.idRotura.ReadOnly = true;
            this.idRotura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idRotura.Width = 120;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Titulo.DataPropertyName = "titulo";
            this.Titulo.HeaderText = "Equipo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 150;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Autor.DataPropertyName = "autor";
            this.Autor.HeaderText = "Nro Serie";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Equipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 97;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Préstamo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 113;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Desperfecto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 114;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Solucion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 91;
            // 
            // txtDesperfecto
            // 
            this.txtDesperfecto.BackColor = System.Drawing.Color.LightGray;
            this.txtDesperfecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesperfecto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesperfecto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDesperfecto.Location = new System.Drawing.Point(127, 148);
            this.txtDesperfecto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesperfecto.Multiline = true;
            this.txtDesperfecto.Name = "txtDesperfecto";
            this.txtDesperfecto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesperfecto.Size = new System.Drawing.Size(220, 73);
            this.txtDesperfecto.TabIndex = 69;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.Black;
            this.lblObservaciones.Location = new System.Drawing.Point(1, 145);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(119, 26);
            this.lblObservaciones.TabIndex = 68;
            this.lblObservaciones.Text = "Desperfecto:";
            this.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNroSerie
            // 
            this.lblNroSerie.AutoSize = true;
            this.lblNroSerie.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSerie.ForeColor = System.Drawing.Color.Black;
            this.lblNroSerie.Location = new System.Drawing.Point(1, 115);
            this.lblNroSerie.Name = "lblNroSerie";
            this.lblNroSerie.Size = new System.Drawing.Size(77, 26);
            this.lblNroSerie.TabIndex = 67;
            this.lblNroSerie.Text = "Equipo:";
            this.lblNroSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxEquipos
            // 
            this.cbxEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEquipos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEquipos.FormattingEnabled = true;
            this.cbxEquipos.Location = new System.Drawing.Point(127, 116);
            this.cbxEquipos.Name = "cbxEquipos";
            this.cbxEquipos.Size = new System.Drawing.Size(220, 25);
            this.cbxEquipos.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 71;
            this.label1.Text = "Solución:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSolucion
            // 
            this.txtSolucion.BackColor = System.Drawing.Color.LightGray;
            this.txtSolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSolucion.Location = new System.Drawing.Point(127, 229);
            this.txtSolucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolucion.Size = new System.Drawing.Size(220, 73);
            this.txtSolucion.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 73;
            this.label2.Text = "Préstamo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskPrestamo
            // 
            this.mskPrestamo.AllowPromptAsInput = false;
            this.mskPrestamo.BackColor = System.Drawing.Color.LightGray;
            this.mskPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskPrestamo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrestamo.HidePromptOnLeave = true;
            this.mskPrestamo.Location = new System.Drawing.Point(127, 309);
            this.mskPrestamo.Mask = "9999";
            this.mskPrestamo.Name = "mskPrestamo";
            this.mskPrestamo.Size = new System.Drawing.Size(62, 26);
            this.mskPrestamo.TabIndex = 74;
            this.mskPrestamo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // chkEquipo
            // 
            this.chkEquipo.AutoSize = true;
            this.chkEquipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEquipo.Location = new System.Drawing.Point(373, 75);
            this.chkEquipo.Name = "chkEquipo";
            this.chkEquipo.Size = new System.Drawing.Size(154, 23);
            this.chkEquipo.TabIndex = 75;
            this.chkEquipo.Text = "Ordenar por equipo";
            this.chkEquipo.UseVisualStyleBackColor = true;
            this.chkEquipo.CheckedChanged += new System.EventHandler(this.chkEquipo_CheckedChanged);
            // 
            // frmGestionRoturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 575);
            this.Controls.Add(this.chkEquipo);
            this.Controls.Add(this.mskPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEquipos);
            this.Controls.Add(this.txtDesperfecto);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblNroSerie);
            this.Controls.Add(this.dgvRoturas);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmGestionRoturas";
            this.Text = "frmGestionDeLibrosFisico";
            this.Load += new System.EventHandler(this.frmGestionDeLibrosFisico_Load);
            this.Click += new System.EventHandler(this.frmGestionRoturas_Click);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dgvRoturas;
        private System.Windows.Forms.TextBox txtDesperfecto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblNroSerie;
        private System.Windows.Forms.ComboBox cbxEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPrestamo;
        private System.Windows.Forms.CheckBox chkEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRotura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}