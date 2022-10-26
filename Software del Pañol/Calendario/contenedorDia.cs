using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Software_del_Pañol.Calendario
{
    public partial class contenedorDia : UserControl
    {
        public int num { get; set; }
        List<ePrestamoEquipo> _pEq = new List<ePrestamoEquipo>();
        List<ePrestamoEspacio> _pEs = new List<ePrestamoEspacio>();

        public contenedorDia()
        {
            InitializeComponent();
        }

        private void contenedorDia_Load(object sender, EventArgs e)
        {

        }

        public void dias(int numDia)
        {
            lblDia.Text = numDia.ToString();
        }

        public void alertaPrestamoEquipo(ePrestamoEquipo p)
        {
            if (this.num == p.fecha_retiro.Day)
            {
                nuevoLbl("P. equipo " + p.id, tipo.RETIRO);
            }
            else if (this.num == p.fecha_devolucion.Day)
            {
                nuevoLbl("P. equipo " + p.id, tipo.DEVOLUCION);
            }
            _pEq.Add(p);
        }

        public void alertaPrestamoEspacio(ePrestamoEspacio p)
        {
            if (this.num == p.fecha_retiro.Day)
            {
                nuevoLbl("P. espacio " + p.id, tipo.RETIRO);
            }
            else if (this.num == p.fecha_devolucion.Day)
            {
                nuevoLbl("P. espacio " + p.id, tipo.DEVOLUCION);
            }
            _pEs.Add(p);
        }

        private void nuevoLbl(string txt, tipo tipo)
        {
            Label lblNoti = new Label();
            //lblNoti.AutoSize = true;
            lblNoti.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoti.Location = new System.Drawing.Point(3, 0);
            lblNoti.Name = "lblNoti";
            lblNoti.MaximumSize = new System.Drawing.Size(120, 0);
            lblNoti.Size = new System.Drawing.Size(120, 16);
            lblNoti.TabIndex = 2;
            lblNoti.Dock = DockStyle.Top;

            lblNoti.Text = txt;

            if(tipo == tipo.DEVOLUCION) lblNoti.BackColor = Color.LightGreen;
            if(tipo == tipo.RETIRO) lblNoti.BackColor = Color.OrangeRed;

            fpnlContenedor.Controls.Add(lblNoti);
        }

        enum tipo {DEVOLUCION,RETIRO}
    }
}
