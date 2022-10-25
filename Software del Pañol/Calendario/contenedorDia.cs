using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_del_Pañol.Calendario
{
    public partial class contenedorDia : UserControl
    {
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
    }
}
