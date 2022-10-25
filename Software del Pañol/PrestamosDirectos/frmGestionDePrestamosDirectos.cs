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
    public partial class frmGestionDePrestamosDirectos : Form
    {
        List<ePrestamoUrgente> _prestamosUR= new List<ePrestamoUrgente>();

        List<ePrestamoLibro> _prestamosLB = new List<ePrestamoLibro>();

        public frmGestionDePrestamosDirectos()
        {
            InitializeComponent();
        }

        private void frmGestionDePrestamosDirectos_Load(object sender, EventArgs e)
        {

            cbxTipoPrestamo.SelectedItem = "Préstamos de libros";
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
            dPrestamoUrgente unPUR = new dPrestamoUrgente();
            dPrestamoLibro unPLB = new dPrestamoLibro();
            _prestamosLB.Clear();
            _prestamosUR.Clear();
            dgvPrestamoLibros.Rows.Clear();
            dgvPrestamoUrgente.Rows.Clear();

            if (cbxEstado.Text == "Todos")
            {
                if (cbxTipoPrestamo.Text == "Préstamos de libros")
                {
                    if (dgvPrestamoLibros.IsAccessible == false) dgvPrestamoLibros.Show();
                    dgvPrestamoUrgente.Hide();
                    _prestamosLB = unPLB.listarPrestamoLibro();
                    //dgvPrestamos.DataSource = _prestamosEQ;
                    foreach (ePrestamoLibro prestamoLB in _prestamosLB)
                    {
                        dgvPrestamoLibros.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoLB.id, prestamoLB.fecha_retiro, prestamoLB.fecha_devolucion, prestamoLB.fecha_solicitado, prestamoLB.duracion, prestamoLB.responsable.id, prestamoLB.estadoP, "Ver lista de libros");
                    }
                }
                else
                {
                    if (dgvPrestamoUrgente.IsAccessible == false) dgvPrestamoUrgente.Show();
                    dgvPrestamoLibros.Hide();
                    _prestamosUR = unPUR.listarPrestamoUrgente();
                    // dgvPrestamos.DataSource = _prestamosES;
                    foreach (ePrestamoUrgente prestamoUR in _prestamosUR)
                    {
                        dgvPrestamoUrgente.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoUR.id, prestamoUR.fecha_retiro, prestamoUR.fecha_devolucion, prestamoUR.fecha_solicitado, prestamoUR.duracion, prestamoUR.responsable.id, prestamoUR.estadoP, "Ver lista de equipos");
                    }
                }
            }
            else if (cbxEstado.Text == "En Curso")
            {
                if (cbxTipoPrestamo.Text == "Préstamos de libros")
                {
                    _prestamosLB = unPLB.listarPrestamoLibro(estadoP.EnCurso);

                    foreach (ePrestamoLibro prestamoLB in _prestamosLB)
                    {
                        dgvPrestamoLibros.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoLB.id, prestamoLB.fecha_retiro, prestamoLB.fecha_devolucion, prestamoLB.fecha_solicitado, prestamoLB.duracion, prestamoLB.responsable.id, prestamoLB.estadoP, "Ver lista de libros");
                    }
                }            
                else
                {
                    _prestamosUR = unPUR.listarPrestamoUrgente(estadoP.EnCurso);
                    //dgvPrestamoEspacios.DataSource = _prestamosES;
                    foreach (ePrestamoUrgente prestamoUR in _prestamosUR)
                    {
                        dgvPrestamoUrgente.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoUR.id, prestamoUR.fecha_retiro, prestamoUR.fecha_devolucion, prestamoUR.fecha_solicitado, prestamoUR.duracion, prestamoUR.responsable.id, prestamoUR.estadoP, "Ver lista de equipos");
                    }
                }
            }
            else if (cbxEstado.Text == "Finalizado")
            {
                if (cbxTipoPrestamo.Text == "Préstamos de libros")
                {
                    _prestamosLB = unPLB.listarPrestamoLibro(estadoP.Finalizado);
                    //dgvPrestamoEquipos.DataSource = _prestamosEQ;
                    foreach (ePrestamoLibro prestamoLB in _prestamosLB)
                    {
                        dgvPrestamoLibros.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoLB.id, prestamoLB.fecha_retiro, prestamoLB.fecha_devolucion, prestamoLB.fecha_solicitado, prestamoLB.duracion, prestamoLB.responsable.id, prestamoLB.estadoP, "Ver lista de libros");
                    }
                }
                else
                {
                    _prestamosUR = unPUR.listarPrestamoUrgente(estadoP.Finalizado);
                    // dgvPrestamoEquipos.DataSource = _prestamosES;
                    foreach (ePrestamoUrgente prestamoUR in _prestamosUR)
                    {
                        dgvPrestamoUrgente.Rows.Add(Properties.Resources.eliminarr, Properties.Resources.modificar, prestamoUR.id, prestamoUR.fecha_retiro, prestamoUR.fecha_devolucion, prestamoUR.fecha_solicitado, prestamoUR.duracion, prestamoUR.responsable.id, prestamoUR.estadoP, "Ver lista de equipos");
                    }
                }
            }
        }


        private void dgvPrestamoLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrestamoLibros.Columns[e.ColumnIndex].Name == "EliminarLi")
            {
                ePrestamoLibro pLibro = new ePrestamoLibro();
                pLibro.id = Convert.ToInt32(dgvPrestamoLibros.CurrentCell.OwningRow.Cells["IDPLB"].Value);
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar el préstamo " + pLibro.id +
                               " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    dPrestamoLibro unPLB = new dPrestamoLibro();
                    unPLB.bajaPrestamoLibro(pLibro);
                    actualizarDgv();
                }
            }
        }
           /* if (dgvPrestamoEquipos.Columns[e.ColumnIndex].Name == "Modificar")
            {
                frmModificarPrestamoEquipos m1 = new frmModificarPrestamoEquipos(Convert.ToInt32(dgvPrestamoEquipos.CurrentRow.Cells["ID"].Value));
                m1.Show();
            }
            if (dgvPrestamoEquipos.Columns[e.ColumnIndex].Name == "EquiposAsociados")
            {
                frmEquiposPrestamo m1 = new frmEquiposPrestamo(Convert.ToInt32(dgvPrestamoEquipos.CurrentRow.Cells["ID"].Value));
                this.AddOwnedForm(m1);
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
        }*/
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            actualizarDgv();
        }
    }
}
