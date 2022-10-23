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

namespace Software_del_Pañol.GestionDePrestamos
{
    public partial class frmEquiposPrestamo : Form
    {
        List<ePrestamoEquipo> _prestamosEq = new List<ePrestamoEquipo>();
        List<eEquipo> _equipos = new List<eEquipo>();
        dPrestamoEquipo unPE= new dPrestamoEquipo();

        public frmEquiposPrestamo(int idPrestamo)
        {
            InitializeComponent();

            _prestamosEq = unPE.listarPrestamoEquipoxId(idPrestamo);
            _equipos = _prestamosEq[0]._equipos;

            lblTitulo.Text = "Equipos asociados al préstamo N°:" + idPrestamo;

            /* for (int i=0; i<= _prestamosEq.Count; i++)
             {

             }*/

        }
        private void frmEquiposPrestamo_Load(object sender, EventArgs e)
        {


            foreach(eEquipo unEq in _equipos)
            {
                dgvEquipos.Rows.Add(unEq.id,unEq.nombre,unEq.nroSerie,unEq.fechaIngreso,unEq.precio,unEq.estado,unEq.observaciones,unEq.asegurado);
            }

        }
    }
}
