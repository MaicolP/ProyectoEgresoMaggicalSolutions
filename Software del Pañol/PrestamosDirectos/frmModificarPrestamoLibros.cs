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
    public partial class frmModificarPrestamoLibros : Form
    {
        ePrestamoLibro prestamo = new ePrestamoLibro();
        dPrestamoLibro prestamoLi = new dPrestamoLibro();

        public frmModificarPrestamoLibros(int IDPrestamo)
        {
            InitializeComponent();

            prestamo.id = IDPrestamo;
            prestamo = prestamoLi.buscarPrestamoLibro(prestamo);
        }

        private void frmModificarPrestamoLibros_Load(object sender, EventArgs e)
        {
                dgvPrestamoLibros.Rows.Add(prestamo.id, prestamo.fecha_retiro, prestamo.fecha_devolucion, prestamo.fecha_solicitado, prestamo.duracion, prestamo.responsable.id, prestamo.estadoP);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ePrestamoLibro unPLI = new ePrestamoLibro();
            unPLI.id = Convert.ToInt32(dgvPrestamoLibros.CurrentCell.OwningRow.Cells["ID"].Value);
            unPLI.fecha_retiro = (DateTime)dgvPrestamoLibros.CurrentCell.OwningRow.Cells["FechaRetiro"].Value;
            unPLI.fecha_devolucion = (DateTime)dgvPrestamoLibros.CurrentCell.OwningRow.Cells["FechaDevolucion"].Value;
            unPLI.fecha_solicitado = (DateTime)dgvPrestamoLibros.CurrentCell.OwningRow.Cells["FechaSolicitada"].Value;
            unPLI.duracion = Convert.ToInt32(dgvPrestamoLibros.CurrentCell.OwningRow.Cells["Duracion"].Value);
            unPLI.responsable.id = Convert.ToInt32(dgvPrestamoLibros.CurrentCell.OwningRow.Cells["Responsable"].Value);
            unPLI.estadoP = dgvPrestamoLibros.CurrentCell.OwningRow.Cells["Estado"].Value.ToString();

            dPrestamoLibro prestamo = new dPrestamoLibro();
            prestamo.modificarPrestamoLibro(unPLI);

            this.Close();

        }
    }
}
