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
using Dominio;

namespace Software_del_Pañol.PrestamosDirectos
{
    public partial class frmEquiposPUrgente : Form
    {
        ePrestamoUrgente prestamoUr = new ePrestamoUrgente();
        List<eEquipo> _equipos = new List<eEquipo>();
        dPrestamoUrgente unPE = new dPrestamoUrgente();

        public frmEquiposPUrgente(int idPrestamo)
        {
            InitializeComponent();

            prestamoUr.id = idPrestamo;
            prestamoUr = unPE.buscarPrestamoUrgente(prestamoUr);
            _equipos = prestamoUr._equipos;

            lblTitulo.Text = "Equipos asociados al préstamo N°:" + idPrestamo;

        }
        private void frmEquiposPrestamoUrgente_Load(object sender, EventArgs e)
        {
            foreach (eEquipo unEq in _equipos)
            {
                dgvEquipos.Rows.Add(unEq.id, unEq.nombre, unEq.nroSerie, unEq.fechaIngreso, unEq.precio, unEq.estado, unEq.observaciones, unEq.asegurado);
            }

        }
    }
}