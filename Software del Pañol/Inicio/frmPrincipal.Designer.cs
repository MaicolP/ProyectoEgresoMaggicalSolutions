namespace Software_del_Pañol
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lklCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEspaciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosFísicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosVirtualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosConReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosConReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosDirectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espacioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urgenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.espacioCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMinimizar.Location = new System.Drawing.Point(1085, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Location = new System.Drawing.Point(1119, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 24);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblFecha);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.panel3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1150, 36);
            this.pnlTitulo.TabIndex = 12;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(256, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 19);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "10/08/2022";
            this.lblFecha.Paint += new System.Windows.Forms.PaintEventHandler(this.lblFecha_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.lklCerrarSesion);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 36);
            this.panel3.TabIndex = 15;
            // 
            // lklCerrarSesion
            // 
            this.lklCerrarSesion.AutoSize = true;
            this.lklCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lklCerrarSesion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklCerrarSesion.LinkColor = System.Drawing.Color.Red;
            this.lklCerrarSesion.Location = new System.Drawing.Point(10, 9);
            this.lklCerrarSesion.Name = "lklCerrarSesion";
            this.lklCerrarSesion.Size = new System.Drawing.Size(80, 15);
            this.lklCerrarSesion.TabIndex = 15;
            this.lklCerrarSesion.TabStop = true;
            this.lklCerrarSesion.Text = "Cerrar sesión";
            this.lklCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCerrarSesion_LinkClicked);
            // 
            // pnlCont
            // 
            this.pnlCont.AutoScroll = true;
            this.pnlCont.Location = new System.Drawing.Point(249, 36);
            this.pnlCont.MaximumSize = new System.Drawing.Size(901, 614);
            this.pnlCont.MinimumSize = new System.Drawing.Size(901, 614);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(901, 614);
            this.pnlCont.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 614);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 113);
            this.panel4.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_del_Pañol.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(50, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 2);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gestor de Préstamos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.panel5.Controls.Add(this.lblHumedad);
            this.panel5.Controls.Add(this.lblTemperatura);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 557);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 57);
            this.panel5.TabIndex = 17;
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.ForeColor = System.Drawing.Color.White;
            this.lblHumedad.Location = new System.Drawing.Point(12, 10);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(110, 19);
            this.lblHumedad.TabIndex = 17;
            this.lblHumedad.Text = "Humedad : 50%";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.Color.White;
            this.lblTemperatura.Location = new System.Drawing.Point(12, 29);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(133, 19);
            this.lblTemperatura.TabIndex = 16;
            this.lblTemperatura.Text = "Temperatura : 20°C";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.msMenu);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 450);
            this.panel2.TabIndex = 15;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(234)))));
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDeEquiposToolStripMenuItem,
            this.gestionDeEspaciosToolStripMenuItem,
            this.gestionDeLibrosToolStripMenuItem,
            this.prestamosConReservaToolStripMenuItem,
            this.calendarioDeReservasToolStripMenuItem,
            this.solicitarPrestamoToolStripMenuItem,
            this.confirmarPrestamoToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Margin = new System.Windows.Forms.Padding(5);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(224, 450);
            this.msMenu.TabIndex = 14;
            this.msMenu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeEquiposToolStripMenuItem
            // 
            this.gestionDeEquiposToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeEquiposToolStripMenuItem.Name = "gestionDeEquiposToolStripMenuItem";
            this.gestionDeEquiposToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.gestionDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.gestionDeEquiposToolStripMenuItem.Text = "Gestión de Equipos";
            this.gestionDeEquiposToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEquiposToolStripMenuItem_Click);
            // 
            // gestionDeEspaciosToolStripMenuItem
            // 
            this.gestionDeEspaciosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeEspaciosToolStripMenuItem.Name = "gestionDeEspaciosToolStripMenuItem";
            this.gestionDeEspaciosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.gestionDeEspaciosToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.gestionDeEspaciosToolStripMenuItem.Text = "Gestión de Espacios";
            this.gestionDeEspaciosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionDeEspaciosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEspaciosToolStripMenuItem_Click);
            // 
            // gestionDeLibrosToolStripMenuItem
            // 
            this.gestionDeLibrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosFísicosToolStripMenuItem,
            this.librosVirtualesToolStripMenuItem});
            this.gestionDeLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeLibrosToolStripMenuItem.Name = "gestionDeLibrosToolStripMenuItem";
            this.gestionDeLibrosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.gestionDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.gestionDeLibrosToolStripMenuItem.Text = "Gestión de Libros";
            this.gestionDeLibrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // librosFísicosToolStripMenuItem
            // 
            this.librosFísicosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librosFísicosToolStripMenuItem.Name = "librosFísicosToolStripMenuItem";
            this.librosFísicosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.librosFísicosToolStripMenuItem.Text = "Libros Físicos";
            this.librosFísicosToolStripMenuItem.Click += new System.EventHandler(this.librosFísicosToolStripMenuItem_Click);
            // 
            // librosVirtualesToolStripMenuItem
            // 
            this.librosVirtualesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librosVirtualesToolStripMenuItem.Name = "librosVirtualesToolStripMenuItem";
            this.librosVirtualesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.librosVirtualesToolStripMenuItem.Text = "Libros Virtuales";
            this.librosVirtualesToolStripMenuItem.Click += new System.EventHandler(this.librosVirtualesToolStripMenuItem_Click);
            // 
            // prestamosConReservaToolStripMenuItem
            // 
            this.prestamosConReservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préstamosConReservaToolStripMenuItem,
            this.préstamosDirectosToolStripMenuItem});
            this.prestamosConReservaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.prestamosConReservaToolStripMenuItem.Name = "prestamosConReservaToolStripMenuItem";
            this.prestamosConReservaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.prestamosConReservaToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.prestamosConReservaToolStripMenuItem.Text = "Gestión de préstamos ";
            this.prestamosConReservaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // préstamosConReservaToolStripMenuItem
            // 
            this.préstamosConReservaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.préstamosConReservaToolStripMenuItem.Name = "préstamosConReservaToolStripMenuItem";
            this.préstamosConReservaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.préstamosConReservaToolStripMenuItem.Text = "Préstamos con reserva";
            this.préstamosConReservaToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePréstamosConReservaToolStripMenuItem_Click);
            // 
            // préstamosDirectosToolStripMenuItem
            // 
            this.préstamosDirectosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.préstamosDirectosToolStripMenuItem.Name = "préstamosDirectosToolStripMenuItem";
            this.préstamosDirectosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.préstamosDirectosToolStripMenuItem.Text = "Préstamos directos";
            this.préstamosDirectosToolStripMenuItem.Click += new System.EventHandler(this.préstamosDirectosToolStripMenuItem_Click_1);
            // 
            // calendarioDeReservasToolStripMenuItem
            // 
            this.calendarioDeReservasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calendarioDeReservasToolStripMenuItem.Name = "calendarioDeReservasToolStripMenuItem";
            this.calendarioDeReservasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.calendarioDeReservasToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.calendarioDeReservasToolStripMenuItem.Text = "Calendario de reservas";
            this.calendarioDeReservasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarioDeReservasToolStripMenuItem.Click += new System.EventHandler(this.calendarioDeReservasToolStripMenuItem_Click);
            // 
            // solicitarPrestamoToolStripMenuItem
            // 
            this.solicitarPrestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.espacioToolStripMenuItem,
            this.libroToolStripMenuItem,
            this.urgenteToolStripMenuItem});
            this.solicitarPrestamoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitarPrestamoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.solicitarPrestamoToolStripMenuItem.Name = "solicitarPrestamoToolStripMenuItem";
            this.solicitarPrestamoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.solicitarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(211, 39);
            this.solicitarPrestamoToolStripMenuItem.Text = "Solicitar préstamo";
            this.solicitarPrestamoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // espacioToolStripMenuItem
            // 
            this.espacioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.espacioToolStripMenuItem.Name = "espacioToolStripMenuItem";
            this.espacioToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.espacioToolStripMenuItem.Text = "Espacios";
            this.espacioToolStripMenuItem.Click += new System.EventHandler(this.espacioToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.libroToolStripMenuItem.Text = "Libros";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // urgenteToolStripMenuItem
            // 
            this.urgenteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urgenteToolStripMenuItem.Name = "urgenteToolStripMenuItem";
            this.urgenteToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.urgenteToolStripMenuItem.Text = "Urgente";
            this.urgenteToolStripMenuItem.Click += new System.EventHandler(this.urgenteToolStripMenuItem_Click);
            // 
            // confirmarPrestamoToolStripMenuItem
            // 
            this.confirmarPrestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoCToolStripMenuItem1,
            this.espacioCToolStripMenuItem});
            this.confirmarPrestamoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.confirmarPrestamoToolStripMenuItem.Name = "confirmarPrestamoToolStripMenuItem";
            this.confirmarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(211, 29);
            this.confirmarPrestamoToolStripMenuItem.Text = "Confirmar prestamo";
            this.confirmarPrestamoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipoCToolStripMenuItem1
            // 
            this.equipoCToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipoCToolStripMenuItem1.Name = "equipoCToolStripMenuItem1";
            this.equipoCToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.equipoCToolStripMenuItem1.Text = "Equipo";
            this.equipoCToolStripMenuItem1.Click += new System.EventHandler(this.equipoCToolStripMenuItem1_Click);
            // 
            // espacioCToolStripMenuItem
            // 
            this.espacioCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espacioCToolStripMenuItem.Name = "espacioCToolStripMenuItem";
            this.espacioCToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.espacioCToolStripMenuItem.Text = "Espacio";
            this.espacioCToolStripMenuItem.Click += new System.EventHandler(this.espacioCToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlCont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosConReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeReservasToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lklCerrarSesion;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEspaciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosFísicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosVirtualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espacioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem espacioCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosConReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urgenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosDirectosToolStripMenuItem;
    }
}