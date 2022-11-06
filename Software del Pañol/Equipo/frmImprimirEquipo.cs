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

namespace Software_del_Pañol.Equipo
{
    public partial class frmImprimirEquipo : Form
    {
        public List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();
        public List<eEquipo> _equipos = new List<eEquipo>();
        public List<eEquipo> _equiposSel = new List<eEquipo>();

        public frmImprimirEquipo()
        {
            InitializeComponent();
        }

        private void frmImprimirEquipo_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquiposSel.AutoGenerateColumns = false;
            actualizarCbx();
        }

        #region ComboBox

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text != "Todos")
            {
                cbxSubtipo.Items.Clear();
                cbxSubtipo.Enabled = true;
                foreach (eTipoDeEquipo tipo in _tipos)
                {
                    if (tipo.nombre == cbxTipo.Text)
                    {
                        cbxSubtipo.Items.Add(tipo.subtipo);
                    }
                }
                cbxSubtipo.Items.Add("Todos");
                cbxSubtipo.SelectedItem = "Todos";
            }
            else
            {
                cbxSubtipo.Items.Clear();
                cbxSubtipo.Enabled = false;
                actualizarDgv();
            }
        }

        private void cbxSubtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSubtipo.Text != null)
            {
                actualizarDgv();
            }
        }

        private void actualizarCbx()
        {
            dTipoDeEquipo unT = new dTipoDeEquipo();
            _tipos = unT.listarTipoDeEquipo();

            foreach (eTipoDeEquipo tipo in _tipos)
            {
                if (cbxTipo.Items.Contains(tipo.nombre) == false)
                {
                    cbxTipo.Items.Add(tipo.nombre);
                }
            }
            cbxTipo.Items.Add("Todos");
            cbxTipo.SelectedItem = "Todos";
        }

        #endregion

        #region DataGridView

        public void actualizarDgv()
        {

            dEquipo unE = new dEquipo();

            if (cbxTipo.Text == "Todos")
            {
                _equipos = unE.listarEquipo();
            }
            else
            {
                if (cbxSubtipo.Text == "Todos")
                {
                    _equipos = unE.listarEquipo(cbxTipo.Text);

                }
                else
                {
                    _equipos = unE.listarEquipo(cbxTipo.Text, cbxSubtipo.Text);
                }
            }

            dgvEquipos.DataSource = _equipos;

        }

        #endregion

        #region Botones

        private void btnAgregarEquipo_Click_1(object sender, EventArgs e)
        {
            if (dgvEquipos.Rows.Count > 0)
            {
                eEquipo eq = new eEquipo();
                eq.id = Convert.ToInt32(dgvEquipos.SelectedRows[0].Cells["id_equipo"].Value.ToString());

                dEquipo unDE = new dEquipo();
                eq = unDE.buscarEquipo(eq);

                if (eq != null)
                {
                    this._equiposSel.Add(eq);
                    dgvEquiposSel.DataSource = null;
                    dgvEquiposSel.DataSource = _equiposSel;
                    actualizarDgv();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquiposSel.Rows.Count > 0)
            {
                eEquipo eq = new eEquipo();
                eq.id = Convert.ToInt32(dgvEquiposSel.SelectedRows[0].Cells["id_equipoSel"].Value.ToString());

                dEquipo unDE = new dEquipo();
                eq = unDE.buscarEquipo(eq);
                for (int i = 0; i < _equiposSel.Count; i++)
                {
                    if (eq.id == _equiposSel[i].id)
                    {
                        _equiposSel.RemoveAt(i);
                    }
                }
                dgvEquiposSel.DataSource = null;
                dgvEquiposSel.DataSource = this._equiposSel;
                actualizarDgv();
            }
        }

        #endregion

        private void btnImprimirSel_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Lista de equipos seleccionados";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "PañolAudiovisual " + DateTime.Now.ToShortDateString();//Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvEquiposSel);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Lista de equipos ";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "PañolAudiovisual " + DateTime.Now.ToShortDateString();//Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvEquipos);
        }

        private void linkRoturas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal aux = (frmPrincipal)ActiveForm;
            aux.abrirGestionEquipos();
            Close();
        }
    }
}
