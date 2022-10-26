namespace Software_del_Pañol.Calendario
{
    partial class contenedorDia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDia = new System.Windows.Forms.Label();
            this.fpnlContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fpnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(0, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(120, 16);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "1";
            // 
            // fpnlContenedor
            // 
            this.fpnlContenedor.Controls.Add(this.label1);
            this.fpnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlContenedor.Location = new System.Drawing.Point(0, 16);
            this.fpnlContenedor.Name = "fpnlContenedor";
            this.fpnlContenedor.Size = new System.Drawing.Size(120, 73);
            this.fpnlContenedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            this.label1.Visible = false;
            // 
            // contenedorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.fpnlContenedor);
            this.Controls.Add(this.lblDia);
            this.Name = "contenedorDia";
            this.Size = new System.Drawing.Size(120, 89);
            this.Load += new System.EventHandler(this.contenedorDia_Load);
            this.fpnlContenedor.ResumeLayout(false);
            this.fpnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.FlowLayoutPanel fpnlContenedor;
        private System.Windows.Forms.Label label1;
    }
}
