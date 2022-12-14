namespace Software_del_Pañol.GestionDePrestamos
{
    partial class frmModificarPrestamoEspacios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarPrestamoEspacios));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvPrestamoEs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEspacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoEs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(390, 169);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(192, 45);
            this.btnConfirmar.TabIndex = 154;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvPrestamoEs
            // 
            this.dgvPrestamoEs.AllowUserToAddRows = false;
            this.dgvPrestamoEs.AllowUserToDeleteRows = false;
            this.dgvPrestamoEs.AllowUserToResizeColumns = false;
            this.dgvPrestamoEs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPrestamoEs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamoEs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamoEs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrestamoEs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrestamoEs.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamoEs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamoEs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestamoEs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamoEs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamoEs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamoEs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FechaRetiro,
            this.FechaDevolucion,
            this.FechaSolicitada,
            this.Duracion,
            this.IDUsuario,
            this.Estado,
            this.Ejercicio,
            this.Curso,
            this.Prioridad,
            this.IDEspacio});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamoEs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamoEs.EnableHeadersVisualStyles = false;
            this.dgvPrestamoEs.GridColor = System.Drawing.Color.Gray;
            this.dgvPrestamoEs.Location = new System.Drawing.Point(31, 47);
            this.dgvPrestamoEs.MultiSelect = false;
            this.dgvPrestamoEs.Name = "dgvPrestamoEs";
            this.dgvPrestamoEs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrestamoEs.RowHeadersVisible = false;
            this.dgvPrestamoEs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPrestamoEs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamoEs.Size = new System.Drawing.Size(551, 87);
            this.dgvPrestamoEs.TabIndex = 153;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 47;
            // 
            // FechaRetiro
            // 
            this.FechaRetiro.DataPropertyName = "fecha_retiro";
            this.FechaRetiro.HeaderText = "Fecha Retiro";
            this.FechaRetiro.Name = "FechaRetiro";
            this.FechaRetiro.Width = 117;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.DataPropertyName = "fecha_devolucion";
            this.FechaDevolucion.HeaderText = "Fecha Devolución";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Width = 154;
            // 
            // FechaSolicitada
            // 
            this.FechaSolicitada.DataPropertyName = "fecha_solicitado";
            this.FechaSolicitada.HeaderText = "Fecha Solicitada";
            this.FechaSolicitada.Name = "FechaSolicitada";
            this.FechaSolicitada.ReadOnly = true;
            this.FechaSolicitada.Width = 142;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "duracion";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 95;
            // 
            // IDUsuario
            // 
            this.IDUsuario.DataPropertyName = "eUsuario.ci";
            this.IDUsuario.HeaderText = "Responsable";
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.ReadOnly = true;
            this.IDUsuario.Width = 117;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estadoP";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 77;
            // 
            // Ejercicio
            // 
            this.Ejercicio.DataPropertyName = "ejercicio";
            this.Ejercicio.HeaderText = "Ejercicio";
            this.Ejercicio.Name = "Ejercicio";
            this.Ejercicio.ReadOnly = true;
            this.Ejercicio.Width = 89;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 71;
            // 
            // Prioridad
            // 
            this.Prioridad.DataPropertyName = "prioridad";
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 96;
            // 
            // IDEspacio
            // 
            this.IDEspacio.DataPropertyName = "prestamoEspacio.espacio.id";
            this.IDEspacio.HeaderText = "Espacio";
            this.IDEspacio.Name = "IDEspacio";
            this.IDEspacio.ReadOnly = true;
            this.IDEspacio.Width = 83;
            // 
            // frmModificarPrestamoEspacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 233);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvPrestamoEs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarPrestamoEspacios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModificarPrestamoEspacios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoEs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvPrestamoEs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspacio;
    }
}