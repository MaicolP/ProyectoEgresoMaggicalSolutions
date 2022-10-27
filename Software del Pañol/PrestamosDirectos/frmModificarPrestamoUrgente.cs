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
    public partial class frmModificarPrestamoUrgente : Form
    {
        ePrestamoUrgente prestamo = new ePrestamoUrgente();
        //List<ePrestamoEquipo> _prestamosEq = new List<ePrestamoEquipo>();
        dPrestamoUrgente unPUR = new dPrestamoUrgente();

        public frmModificarPrestamoUrgente(int IDPrestamo)
        {
            InitializeComponent();

            prestamo.id = IDPrestamo;
            prestamo = unPUR.buscarPrestamoUrgente(prestamo);
        }

        public void frmModificarPrestamoUrgente_Load(object sender, EventArgs e)
        { 
            dgvPrestamoEq.Rows.Add(prestamo.id, prestamo.fecha_retiro, prestamo.fecha_devolucion, prestamo.fecha_solicitado, prestamo.duracion, prestamo.responsable.id, prestamo.estadoP);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ePrestamoUrgente unPUR = new ePrestamoUrgente();
            unPUR.id = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["ID"].Value);
            unPUR.fecha_retiro = (DateTime)dgvPrestamoEq.CurrentCell.OwningRow.Cells["FechaRetiro"].Value;
            unPUR.fecha_devolucion = (DateTime)dgvPrestamoEq.CurrentCell.OwningRow.Cells["FechaDevolucion"].Value;
            unPUR.fecha_solicitado = (DateTime)dgvPrestamoEq.CurrentCell.OwningRow.Cells["FechaSolicitada"].Value;
            unPUR.duracion = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["Duracion"].Value);
            unPUR.estadoP = dgvPrestamoEq.CurrentCell.OwningRow.Cells["Estado"].Value.ToString();
            unPUR.responsable.id = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["Responsable"].Value);

            dPrestamoUrgente prestamo = new dPrestamoUrgente();
            prestamo.modificarPrestamoUrgente(unPUR);

            this.Close();
        }
    }
}  