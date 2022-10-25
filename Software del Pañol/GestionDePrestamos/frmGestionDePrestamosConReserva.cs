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
    public partial class frmGestionDePrestamosConReserva : Form
    {

        List<ePrestamoEquipo> _prestamosEQ = new List<ePrestamoEquipo>();

        List<ePrestamoEspacio> _prestamosES = new List<ePrestamoEspacio>();

        public frmGestionDePrestamosConReserva()
        {
            InitializeComponent();
        }

        private void frmGestionDePrestamosConReserva_Load(object sender, EventArgs e)
        {
            /*dgvPrestamoEquipos.Columns["asisTec"].Visible = false;
            dgvPrestamoEspacios.Columns["asisTec"].Visible = false;*/
            cbxTipoPrestamo.SelectedItem = "Préstamo de equipos";
            cbxEstado.SelectedItem = "Todos";
            actualizarDgv();
        }

        private void cbxTipoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        public void actualizarDgv()
        {
            dPrestamoEquipo unPEQ = new dPrestamoEquipo();
            dPrestamoEspacio unPES = new dPrestamoEspacio();
            _prestamosEQ.Clear();
            _prestamosES.Clear();
            dgvPrestamoEquipos.Rows.Clear();
            dgvPrestamoEspacios.Rows.Clear();

            if (cbxEstado.Text == "Todos")
            {
                if (cbxTipoPrestamo.Text == "Préstamo de equipos")
                {
                    if(dgvPrestamoEquipos.IsAccessible == false) dgvPrestamoEquipos.Show();
                    dgvPrestamoEspacios.Hide();
                    _prestamosEQ = unPEQ.listarPrestamoEquipoNoPendiente();
                    //dgvPrestamos.DataSource = _prestamosEQ;
                    foreach (ePrestamoEquipo prestamoEQ in _prestamosEQ)
                    {
                        dgvPrestamoEquipos.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoEQ.id, prestamoEQ.fecha_retiro, prestamoEQ.fecha_devolucion, prestamoEQ.fecha_solicitado, prestamoEQ.duracion, prestamoEQ.responsable.id,prestamoEQ.estadoP, prestamoEQ.ejercicio, prestamoEQ.curso, prestamoEQ.prioridad, prestamoEQ.nomDocente, prestamoEQ.apeDocente, prestamoEQ.transporte, prestamoEQ.locaciones, prestamoEQ.equipoRodaje, "Ver lista de equipos");
                    }
                }
                else
                {
                    if(dgvPrestamoEspacios.IsAccessible == false) dgvPrestamoEspacios.Show();
                    dgvPrestamoEquipos.Hide();
                    _prestamosES = unPES.listarPrestamoEspacioNoPendiente();
                    // dgvPrestamos.DataSource = _prestamosES;
                    foreach (ePrestamoEspacio prestamoES in _prestamosES)
                    {
                        dgvPrestamoEspacios.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoES.id, prestamoES.fecha_retiro, prestamoES.fecha_devolucion, prestamoES.fecha_solicitado, prestamoES.duracion, prestamoES.responsable.id, prestamoES.estadoP, prestamoES.ejercicio, prestamoES.curso, prestamoES.prioridad, prestamoES.espacio.id);
                    }
                }
            }
            else if (cbxEstado.Text == "En Curso")
            {
                if (cbxTipoPrestamo.Text == "Préstamo de equipos")
                {
                    _prestamosEQ = unPEQ.listarPrestamoEquipo(estadoP.EnCurso);

                    foreach (ePrestamoEquipo prestamoEQ in _prestamosEQ)
                    {
                        dgvPrestamoEquipos.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoEQ.id, prestamoEQ.fecha_retiro, prestamoEQ.fecha_devolucion, prestamoEQ.fecha_solicitado, prestamoEQ.duracion, prestamoEQ.responsable.id, prestamoEQ.estadoP, prestamoEQ.ejercicio, prestamoEQ.curso, prestamoEQ.prioridad, prestamoEQ.nomDocente, prestamoEQ.apeDocente, prestamoEQ.transporte, prestamoEQ.locaciones, prestamoEQ.equipoRodaje, "Ver lista de equipos");
                    }

                }
                else
                {
                    _prestamosES = unPES.listarPrestamoEspacio(estadoP.EnCurso);
                    //dgvPrestamoEspacios.DataSource = _prestamosES;
                    foreach (ePrestamoEspacio prestamoES in _prestamosES)
                    {
                        dgvPrestamoEspacios.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoES.id, prestamoES.fecha_retiro, prestamoES.fecha_devolucion, prestamoES.fecha_solicitado, prestamoES.duracion, prestamoES.responsable.id,prestamoES.estadoP, prestamoES.ejercicio, prestamoES.curso, prestamoES.prioridad, prestamoES.espacio.id);
                    }
                }
            }
            else if (cbxEstado.Text == "Finalizado")
            {
                if (cbxTipoPrestamo.Text == "Préstamo de equipos")
                {
                    _prestamosEQ = unPEQ.listarPrestamoEquipo(estadoP.Finalizado);
                    //dgvPrestamoEquipos.DataSource = _prestamosEQ;
                    foreach (ePrestamoEquipo prestamoEQ in _prestamosEQ)
                    {
                        dgvPrestamoEquipos.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoEQ.id, prestamoEQ.fecha_retiro, prestamoEQ.fecha_devolucion, prestamoEQ.fecha_solicitado, prestamoEQ.duracion, prestamoEQ.responsable.id, prestamoEQ.estadoP, prestamoEQ.ejercicio, prestamoEQ.curso, prestamoEQ.prioridad, prestamoEQ.nomDocente, prestamoEQ.apeDocente, prestamoEQ.transporte, prestamoEQ.locaciones, prestamoEQ.equipoRodaje, "Ver lista de equipos");
                    }

                }
                else
                {
                    _prestamosES = unPES.listarPrestamoEspacio(estadoP.Finalizado);
                    // dgvPrestamoEquipos.DataSource = _prestamosES;
                    foreach (ePrestamoEspacio prestamoES in _prestamosES)
                    {
                        dgvPrestamoEspacios.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoES.id, prestamoES.fecha_retiro, prestamoES.fecha_devolucion, prestamoES.fecha_solicitado, prestamoES.duracion, prestamoES.responsable.id, prestamoES.estadoP, prestamoES.ejercicio, prestamoES.curso, prestamoES.prioridad, prestamoES.espacio.id);
                    }
                }
            }
        }


        private void dgvPrestamoEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrestamoEquipos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                eReserva reserva = new eReserva();
                ePrestamoEquipo pEquipo = new ePrestamoEquipo();
                pEquipo.id = Convert.ToInt32(dgvPrestamoEquipos.CurrentCell.OwningRow.Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar el préstamo " + pEquipo.id +
                               " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    dReserva unR = new dReserva();
                    dPrestamoEquipo unPEQ = new dPrestamoEquipo();
                    unPEQ.bajaPrestamoEquipo(pEquipo);
                    unR.bajaReserva(pEquipo.id);
                    actualizarDgv();
                }
            }
            if (dgvPrestamoEquipos.Columns[e.ColumnIndex].Name == "Modificar")
            {
                    frmModificarPrestamoEquipos m1 = new frmModificarPrestamoEquipos(Convert.ToInt32(dgvPrestamoEquipos.CurrentRow.Cells["ID"].Value));
                    m1.Show();       
            }
            if (dgvPrestamoEquipos.Columns[e.ColumnIndex].Name == "EquiposAsociados")
            {
                frmEquiposPrestamo m1 = new frmEquiposPrestamo(Convert.ToInt32(dgvPrestamoEquipos.CurrentRow.Cells["ID"].Value));
                m1.Show();
            }
        }

        private void dgvPrestamoEspacios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrestamoEspacios.Columns[e.ColumnIndex].Name == "EliminarEs")
            {
                eReserva reserva = new eReserva();
                ePrestamoEspacio pEspacio = new ePrestamoEspacio();
                pEspacio.id = Convert.ToInt32(dgvPrestamoEspacios.CurrentRow.Cells["IDPES"].Value);
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar el préstamo " + pEspacio.id +
                               " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    dReserva unR = new dReserva();
                    dPrestamoEspacio unPES = new dPrestamoEspacio();
                    unPES.bajaPrestamoEspacio(pEspacio);
                    unR.bajaReserva(pEspacio.id);
                    actualizarDgv();
                }
            }
            if (dgvPrestamoEspacios.Columns[e.ColumnIndex].Name == "ModificarEs")
            {
                    frmModificarPrestamoEspacios m1 = new frmModificarPrestamoEspacios(Convert.ToInt32(dgvPrestamoEspacios.CurrentRow.Cells["IDPES"].Value));
                    m1.Show();
            }
        }
    }
}

