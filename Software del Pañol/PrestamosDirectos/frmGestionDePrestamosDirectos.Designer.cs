namespace Software_del_Pañol.PrestamosDirectos
{
    partial class frmGestionDePrestamosDirectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPrestamoLibros = new System.Windows.Forms.DataGridView();
            this.dgvPrestamoUrgente = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolución = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquiposAsociados = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.EliminarLi = new System.Windows.Forms.DataGridViewImageColumn();
            this.ModificarEs = new System.Windows.Forms.DataGridViewImageColumn();
            this.IDPLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibrosAsociados = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoUrgente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_del_Pañol.Properties.Resources.refresh1;
            this.pictureBox1.InitialImage = global::Software_del_Pañol.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(838, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvPrestamoLibros
            // 
            this.dgvPrestamoLibros.AllowUserToAddRows = false;
            this.dgvPrestamoLibros.AllowUserToDeleteRows = false;
            this.dgvPrestamoLibros.AllowUserToResizeColumns = false;
            this.dgvPrestamoLibros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPrestamoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamoLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamoLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrestamoLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrestamoLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamoLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamoLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestamoLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarLi,
            this.ModificarEs,
            this.IDPLB,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Responsable,
            this.dataGridViewTextBoxColumn7,
            this.LibrosAsociados});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamoLibros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamoLibros.EnableHeadersVisualStyles = false;
            this.dgvPrestamoLibros.GridColor = System.Drawing.Color.Gray;
            this.dgvPrestamoLibros.Location = new System.Drawing.Point(3, 115);
            this.dgvPrestamoLibros.MultiSelect = false;
            this.dgvPrestamoLibros.Name = "dgvPrestamoLibros";
            this.dgvPrestamoLibros.ReadOnly = true;
            this.dgvPrestamoLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrestamoLibros.RowHeadersVisible = false;
            this.dgvPrestamoLibros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPrestamoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamoLibros.Size = new System.Drawing.Size(867, 449);
            this.dgvPrestamoLibros.TabIndex = 67;
            this.dgvPrestamoLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamoLibros_CellClick);
            // 
            // dgvPrestamoUrgente
            // 
            this.dgvPrestamoUrgente.AllowUserToAddRows = false;
            this.dgvPrestamoUrgente.AllowUserToDeleteRows = false;
            this.dgvPrestamoUrgente.AllowUserToResizeColumns = false;
            this.dgvPrestamoUrgente.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvPrestamoUrgente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamoUrgente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamoUrgente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrestamoUrgente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrestamoUrgente.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamoUrgente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamoUrgente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestamoUrgente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamoUrgente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrestamoUrgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamoUrgente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Modificar,
            this.ID,
            this.FechaRetiro,
            this.FechaDevolución,
            this.FechaSolicitada,
            this.Duracion,
            this.IDUsuario,
            this.Estado,
            this.EquiposAsociados});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamoUrgente.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrestamoUrgente.EnableHeadersVisualStyles = false;
            this.dgvPrestamoUrgente.GridColor = System.Drawing.Color.Gray;
            this.dgvPrestamoUrgente.Location = new System.Drawing.Point(3, 115);
            this.dgvPrestamoUrgente.MultiSelect = false;
            this.dgvPrestamoUrgente.Name = "dgvPrestamoUrgente";
            this.dgvPrestamoUrgente.ReadOnly = true;
            this.dgvPrestamoUrgente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrestamoUrgente.RowHeadersVisible = false;
            this.dgvPrestamoUrgente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPrestamoUrgente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamoUrgente.Size = new System.Drawing.Size(867, 449);
            this.dgvPrestamoUrgente.TabIndex = 66;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::Software_del_Pañol.Properties.Resources.eliminarr;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Width = 5;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Image = global::Software_del_Pañol.Properties.Resources.modificar;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.Width = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 47;
            // 
            // FechaRetiro
            // 
            this.FechaRetiro.HeaderText = "Fecha Retiro";
            this.FechaRetiro.Name = "FechaRetiro";
            this.FechaRetiro.ReadOnly = true;
            this.FechaRetiro.Width = 117;
            // 
            // FechaDevolución
            // 
            this.FechaDevolución.HeaderText = "Fecha Devolución";
            this.FechaDevolución.Name = "FechaDevolución";
            this.FechaDevolución.ReadOnly = true;
            this.FechaDevolución.Width = 154;
            // 
            // FechaSolicitada
            // 
            this.FechaSolicitada.HeaderText = "Fecha Solicitada";
            this.FechaSolicitada.Name = "FechaSolicitada";
            this.FechaSolicitada.ReadOnly = true;
            this.FechaSolicitada.Width = 142;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 95;
            // 
            // IDUsuario
            // 
            this.IDUsuario.HeaderText = "Responsable";
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.ReadOnly = true;
            this.IDUsuario.Width = 117;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 77;
            // 
            // EquiposAsociados
            // 
            this.EquiposAsociados.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.EquiposAsociados.HeaderText = "Equipos asociados";
            this.EquiposAsociados.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.EquiposAsociados.Name = "EquiposAsociados";
            this.EquiposAsociados.ReadOnly = true;
            this.EquiposAsociados.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EquiposAsociados.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EquiposAsociados.Text = "Ver lista de equipos";
            this.EquiposAsociados.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.EquiposAsociados.Width = 156;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(603, 73);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 26);
            this.lblEstado.TabIndex = 65;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Todos",
            "En Curso",
            "Finalizado"});
            this.cbxEstado.Location = new System.Drawing.Point(695, 73);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(133, 25);
            this.cbxEstado.TabIndex = 64;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // cbxTipoPrestamo
            // 
            this.cbxTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPrestamo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoPrestamo.FormattingEnabled = true;
            this.cbxTipoPrestamo.Items.AddRange(new object[] {
            "Préstamos de libros",
            "Préstamos urgentes"});
            this.cbxTipoPrestamo.Location = new System.Drawing.Point(3, 74);
            this.cbxTipoPrestamo.Name = "cbxTipoPrestamo";
            this.cbxTipoPrestamo.Size = new System.Drawing.Size(194, 25);
            this.cbxTipoPrestamo.TabIndex = 63;
            this.cbxTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoList_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-3, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(901, 60);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Gestión de Préstamos directos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EliminarLi
            // 
            this.EliminarLi.HeaderText = "";
            this.EliminarLi.Image = global::Software_del_Pañol.Properties.Resources.eliminarr;
            this.EliminarLi.Name = "EliminarLi";
            this.EliminarLi.ReadOnly = true;
            this.EliminarLi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarLi.Width = 5;
            // 
            // ModificarEs
            // 
            this.ModificarEs.HeaderText = "";
            this.ModificarEs.Image = global::Software_del_Pañol.Properties.Resources.modificar;
            this.ModificarEs.Name = "ModificarEs";
            this.ModificarEs.ReadOnly = true;
            this.ModificarEs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ModificarEs.Width = 5;
            // 
            // IDPLB
            // 
            this.IDPLB.HeaderText = "ID";
            this.IDPLB.Name = "IDPLB";
            this.IDPLB.ReadOnly = true;
            this.IDPLB.Width = 47;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Retiro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 117;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Devolución";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 154;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Solicitada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 142;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            this.Responsable.Width = 117;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 77;
            // 
            // LibrosAsociados
            // 
            this.LibrosAsociados.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.LibrosAsociados.HeaderText = "Libros Asociados";
            this.LibrosAsociados.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.LibrosAsociados.Name = "LibrosAsociados";
            this.LibrosAsociados.ReadOnly = true;
            this.LibrosAsociados.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.LibrosAsociados.Width = 126;
            // 
            // frmGestionDePrestamosDirectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPrestamoLibros);
            this.Controls.Add(this.dgvPrestamoUrgente);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxTipoPrestamo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmGestionDePrestamosDirectos";
            this.Text = "frmGestionDePrestamosDirectos";
            this.Load += new System.EventHandler(this.frmGestionDePrestamosDirectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoUrgente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPrestamoLibros;
        private System.Windows.Forms.DataGridView dgvPrestamoUrgente;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolución;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewLinkColumn EquiposAsociados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxTipoPrestamo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewImageColumn EliminarLi;
        private System.Windows.Forms.DataGridViewImageColumn ModificarEs;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewLinkColumn LibrosAsociados;
    }
}