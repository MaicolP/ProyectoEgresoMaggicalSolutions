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
    public partial class frmModificarPrestamoEquipos : Form
    {
        ePrestamoEquipo prestamo = new ePrestamoEquipo();
        List<ePrestamoEquipo> _prestamosEq = new List<ePrestamoEquipo>();
        dPrestamoEquipo prestamoEq = new dPrestamoEquipo();

        public frmModificarPrestamoEquipos(int IDPrestamo)
        {
            InitializeComponent();

            prestamo.id = IDPrestamo;
            _prestamosEq = prestamoEq.listarPrestamoEquipoxId(IDPrestamo);
            foreach (ePrestamoEquipo prestamoEQ in _prestamosEq)
            {
                dgvPrestamoEq.Rows.Add(prestamoEQ.id, prestamoEQ.fecha_retiro, prestamoEQ.fecha_devolucion, prestamoEQ.fecha_solicitado, prestamoEQ.duracion, prestamoEQ.responsable.id, prestamoEQ.estadoP, prestamoEQ.ejercicio, prestamoEQ.curso, prestamoEQ.prioridad, prestamoEQ.nomDocente, prestamoEQ.apeDocente, prestamoEQ.transporte, prestamoEQ.locaciones, prestamoEQ.equipoRodaje);
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ePrestamoEquipo unPEQ = new ePrestamoEquipo();
            unPEQ.id = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["ID"].Value);
            unPEQ.fecha_retiro = (DateTime)dgvPrestamoEq.CurrentCell.OwningRow.Cells["FechaRetiro"].Value;
            unPEQ.fecha_devolucion = (DateTime)dgvPrestamoEq.CurrentCell.OwningRow.Cells["FechaDevolucion"].Value;
            unPEQ.fecha_solicitado = (DateTime)dgvPrestamoEq.CurrentCell.OwningRow.Cells["FechaSolicitada"].Value;
            unPEQ.duracion = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["Duracion"].Value);
            unPEQ.estadoP = dgvPrestamoEq.CurrentCell.OwningRow.Cells["Estado"].Value.ToString();
            unPEQ.responsable.id = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["Responsable"].Value);
            unPEQ.prioridad = Convert.ToInt32(dgvPrestamoEq.CurrentCell.OwningRow.Cells["Prioridad"].Value);
            unPEQ.curso = dgvPrestamoEq.CurrentCell.OwningRow.Cells["Curso"].Value.ToString();
            unPEQ.ejercicio = dgvPrestamoEq.CurrentCell.OwningRow.Cells["Ejercicio"].Value.ToString();
            unPEQ.nomDocente = dgvPrestamoEq.CurrentCell.OwningRow.Cells["NombreDocente"].Value.ToString();
            unPEQ.apeDocente = dgvPrestamoEq.CurrentCell.OwningRow.Cells["ApellidoDocente"].Value.ToString();
            unPEQ.transporte = dgvPrestamoEq.CurrentCell.OwningRow.Cells["Transporte"].Value.ToString();
            unPEQ.locaciones = dgvPrestamoEq.CurrentCell.OwningRow.Cells["Locaciones"].Value.ToString();
            unPEQ.equipoRodaje = dgvPrestamoEq.CurrentCell.OwningRow.Cells["EquipoRodaje"].Value.ToString();

            dPrestamoEquipo prestamo = new dPrestamoEquipo();
            prestamo.modificarPrestamoEquipo(unPEQ);           

            this.Close();
        }
    }
}
