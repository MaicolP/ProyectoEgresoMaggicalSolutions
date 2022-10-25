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
    public partial class frmModificarPrestamoEspacios : Form
    {
        List<ePrestamoEspacio> _prestamosEs = new List<ePrestamoEspacio>();
        dPrestamoEspacio prestamoEs = new dPrestamoEspacio();

        public frmModificarPrestamoEspacios(int IDPrestamo)
        {
            InitializeComponent();

            // dgvPrestamoEq.Columns["asisTec"].Dispose();

            _prestamosEs = prestamoEs.listarPrestamoEspacioxId(IDPrestamo);
        }

        private void frmModificarPrestamoEspacios_Load(object sender, EventArgs e)
        {
            foreach (ePrestamoEspacio prestamoES in _prestamosEs)
            {
                dgvPrestamoEs.Rows.Add(prestamoES.id, prestamoES.fecha_retiro, prestamoES.fecha_devolucion, prestamoES.fecha_solicitado, prestamoES.duracion, prestamoES.responsable.id, prestamoES.estadoP, prestamoES.ejercicio, prestamoES.curso, prestamoES.prioridad, prestamoES.espacio.id);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ePrestamoEspacio unPES = new ePrestamoEspacio();
            unPES.id = Convert.ToInt32(dgvPrestamoEs.CurrentCell.OwningRow.Cells["ID"].Value);
            unPES.fecha_retiro = (DateTime)dgvPrestamoEs.CurrentCell.OwningRow.Cells["FechaRetiro"].Value;
            unPES.fecha_devolucion = (DateTime)dgvPrestamoEs.CurrentCell.OwningRow.Cells["FechaDevolucion"].Value;
            unPES.fecha_solicitado = (DateTime)dgvPrestamoEs.CurrentCell.OwningRow.Cells["FechaSolicitada"].Value;
            unPES.duracion = Convert.ToInt32(dgvPrestamoEs.CurrentCell.OwningRow.Cells["Duracion"].Value);
            unPES.responsable.id = Convert.ToInt32(dgvPrestamoEs.CurrentCell.OwningRow.Cells["IDUsuario"].Value);
            unPES.estadoP = dgvPrestamoEs.CurrentCell.OwningRow.Cells["Estado"].Value.ToString();
            unPES.curso = dgvPrestamoEs.CurrentCell.OwningRow.Cells["Curso"].Value.ToString();
            unPES.ejercicio = dgvPrestamoEs.CurrentCell.OwningRow.Cells["Ejercicio"].Value.ToString();
            unPES.prioridad = Convert.ToInt32(dgvPrestamoEs.CurrentCell.OwningRow.Cells["Prioridad"].Value);
            unPES.espacio.id = Convert.ToInt32(dgvPrestamoEs.CurrentCell.OwningRow.Cells["IDEspacio"].Value);

            dPrestamoEspacio prestamo = new dPrestamoEspacio();
            prestamo.modificarPrestamoEspacio(unPES);

            this.Close();

        }
       
    }
}
