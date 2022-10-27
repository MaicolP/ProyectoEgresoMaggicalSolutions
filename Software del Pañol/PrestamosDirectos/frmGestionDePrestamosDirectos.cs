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
        
           if (dgvPrestamoLibros.Columns[e.ColumnIndex].Name == "ModificarLi")
            {
                frmModificarPrestamoLibros m1 = new frmModificarPrestamoLibros(Convert.ToInt32(dgvPrestamoLibros.CurrentRow.Cells["IDPLB"].Value));
                m1.Show();
            }
            if (dgvPrestamoLibros.Columns[e.ColumnIndex].Name == "LibrosAsociados")
            {
                frmLibrosPrestamo m1 = new frmLibrosPrestamo(Convert.ToInt32(dgvPrestamoLibros.CurrentRow.Cells["IDPLB"].Value));
                m1.Show();

            }

        }

        private void dgvPrestamoUrgentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrestamoUrgente.Columns[e.ColumnIndex].Name == "EliminarUr")
            {
                ePrestamoUrgente pUrgente = new ePrestamoUrgente();
                pUrgente.id = Convert.ToInt32(dgvPrestamoUrgente.CurrentRow.Cells["IDPUR"].Value);
                DialogResult result = MessageBox.Show("Está seguro que desea eliminar el préstamo " + pUrgente.id +
                               " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    dPrestamoUrgente unPUR = new dPrestamoUrgente();
                    unPUR.bajaPrestamoUrgente(pUrgente);
                    actualizarDgv();
                }
            }
            if (dgvPrestamoUrgente.Columns[e.ColumnIndex].Name == "ModificarUr")
            {
                frmModificarPrestamoUrgente m1 = new frmModificarPrestamoUrgente(Convert.ToInt32(dgvPrestamoUrgente.CurrentRow.Cells["IDPUR"].Value));
                m1.Show();
            }
            if (dgvPrestamoUrgente.Columns[e.ColumnIndex].Name == "EquiposAsociadosUr")
            {
                frmEquiposPUrgente m1 = new frmEquiposPUrgente(Convert.ToInt32(dgvPrestamoUrgente.CurrentRow.Cells["IDPUR"].Value));
                m1.Show();

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cbxTipoPrestamo.Text == "Préstamos de libros")
            {
                dgvPrestamoLibros.Columns["EliminarLi"].Visible = false;
                dgvPrestamoLibros.Columns["ModificarLi"].Visible = false;
                dgvPrestamoLibros.Columns["LibrosAsociados"].Visible = false;
                this.dgvPrestamoLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                DGVPrinter printer = new DGVPrinter();

                printer.Title = "Préstamos de libros";
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "PañolAudiovisual";//Footer
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvPrestamoLibros);

                this.dgvPrestamoLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPrestamoLibros.Columns["EliminarLi"].Visible = true;
                dgvPrestamoLibros.Columns["ModificarLi"].Visible = true;
                dgvPrestamoLibros.Columns["LibrosAsociados"].Visible = true;
            }
            else
            {
                dgvPrestamoUrgente.Columns["EliminarUr"].Visible = false;
                dgvPrestamoUrgente.Columns["ModificarUr"].Visible = false;
                dgvPrestamoUrgente.Columns["EquiposAsociadosUr"].Visible = false;
                this.dgvPrestamoUrgente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                DGVPrinter printer = new DGVPrinter();

                printer.Title = "Préstamos urgentes";
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "PañolAudiovisual";//Footer
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvPrestamoUrgente);

                this.dgvPrestamoUrgente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPrestamoUrgente.Columns["EliminarUr"].Visible = true;
                dgvPrestamoUrgente.Columns["ModificarUr"].Visible = true;
                dgvPrestamoUrgente.Columns["EquiposAsociadosUr"].Visible = true;
            }
        }
    }
}
