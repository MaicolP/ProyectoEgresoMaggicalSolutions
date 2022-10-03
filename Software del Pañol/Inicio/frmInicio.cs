using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Software_del_Pañol
{
    public partial class frmInicio : Form
    {
        public eUsuario usuarioActual { get; set; }

        public frmInicio(eUsuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Bienvenido " +usuarioActual.nombre;
        }
    }
}
