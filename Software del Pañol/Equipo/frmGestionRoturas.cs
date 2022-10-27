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

namespace Software_del_Pañol
{
    public partial class frmGestionRoturas : Form
    {

        List<eRotura> _roturas = new List<eRotura>();

        public frmGestionRoturas()
        {
            InitializeComponent();
        }
        private void frmGestionDeLibrosFisico_Load(object sender, EventArgs e)
        {
            dEquipo unDE = new dEquipo();
            cbxEquipos.DataSource = unDE.listarEquipo();
            cbxEquipos.ValueMember = "id";
            cbxEquipos.DisplayMember = "nombre";

            actualizarDgv();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            dgvRoturas.ClearSelection();
        }

        #region Botones

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar la rotura : " + dgvRoturas.CurrentCell.OwningRow.Cells["idRotura"].Value.ToString() +
                           " ?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dRotura unDR = new dRotura();
                eRotura r = new eRotura();
                r.idRotura = (int)dgvRoturas.CurrentCell.OwningRow.Cells["idRotura"].Value;
                unDR.bajaRotura(r);
                actualizarDgv();
                lblMensaje.Text = "Rotura eliminada correctamente";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDesperfecto.Text == "" || txtSolucion.Text == "" || mskPrestamo.Text == "" || cbxEquipos.SelectedValue == null)
            {
                lblMensaje.Text = "Complete los campos";
            }
            else
            {
                dRotura unDR = new dRotura();
                eRotura r = new eRotura();
                r.idRotura = (int)dgvRoturas.CurrentCell.OwningRow.Cells["idRotura"].Value;
                r.detalleDesperfecto = txtDesperfecto.Text;
                r.detalleSolucion = txtSolucion.Text;
                r.equipo = (eEquipo)cbxEquipos.SelectedItem;
                r.idPrestamoOrigenRotura = Convert.ToInt32(mskPrestamo.Text);
                unDR.modificarRotura(r);
                actualizarDgv();
                lblMensaje.Text = "Modificado correctamente";
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Informe de roturas";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "PañolAudiovisual";//Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvRoturas);
        }

        #endregion

        #region DataGridView

        private void actualizarDgv()
        {
            _roturas.Clear();
            dgvRoturas.Rows.Clear();

            dRotura unDR = new dRotura();
            if (!chkEquipo.Checked)
            {
                _roturas = unDR.listarRotura();
            }
            else
            {                
                _roturas = unDR.listarRoturaPorEq();
            }

            foreach(var r in _roturas)
            {
                dgvRoturas.Rows.Add(r.idRotura,r.equipo.nombre,r.equipo.nroSerie,r.equipo.id, r.idPrestamoOrigenRotura, r.detalleDesperfecto,r.detalleSolucion);
            }
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoturas.SelectedCells.Count != 0)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

                dRotura unDR = new dRotura();
                eRotura rotura = new eRotura();
                rotura = unDR.buscarRotura((int)dgvRoturas.CurrentCell.OwningRow.Cells["idRotura"].Value);

                cbxEquipos.SelectedValue = rotura.equipo.id;
                txtDesperfecto.Text = rotura.detalleDesperfecto;
                txtSolucion.Text = rotura.detalleSolucion;
                mskPrestamo.Text = rotura.idPrestamoOrigenRotura.ToString();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtDesperfecto.Clear();
                txtSolucion.Clear();
                mskPrestamo.Clear();
            }
        }

        #endregion

        private void chkEquipo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarDgv();
        }

        private void frmGestionRoturas_Click(object sender, EventArgs e)
        {
            dgvRoturas.ClearSelection();
        }

        private void linkRoturas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal aux = (frmPrincipal)ActiveForm;
            aux.abrirGestionEquipos();
            Close();
        }
    }
}