using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Software_del_Pañol.SolicitarPrestamos
{
    public partial class frmSeleccionarEquipos : Form
    {

        public List<eEquipo> _equipos = new List<eEquipo>();
        public List<eEquipo> _equiposSel = new List<eEquipo>();
        public List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();

        public frmSeleccionarEquipos()
        {
            InitializeComponent();
        }

        private void frmSeleccionarEquipos_Load(object sender, EventArgs e)
        {
            actualizarCbx();
        }

        #region Botones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSolicitarEquipo frmOwner = (frmSolicitarEquipo)this.Owner;

            foreach (DataGridViewRow fila in dgvEquipos.Rows)
            {
                if(Convert.ToBoolean(fila.Cells["eqSel"].Value) == true)
                {
                    _equiposSel.Add((eEquipo)fila.DataBoundItem);
                }
            }

            if (_equiposSel != null)
            {
                frmOwner._equipos = _equiposSel;
                frmOwner.actualizarDgv();
            }
            this.Dispose();
        }

        #endregion

        #region DataGridView

        private void actualizarDgv()
        {
            frmSolicitarEquipo frmOwner = (frmSolicitarEquipo)this.Owner;
            _equiposSel = frmOwner._equipos;

            dEquipo unE = new dEquipo();

            if (cbxTipoList.Text == "Todos")
            {
                _equipos = unE.listarEquipo();
            }
            else
            {
                if (cbxSubtipoList.Text == "Todos")
                {
                    _equipos = unE.listarEequipo(cbxTipoList.Text);
                }
                else
                {
                    _equipos = unE.listarEequipo(cbxTipoList.Text, cbxSubtipoList.Text);
                }
            }

            for (int i=0; i<_equipos.Count; i++)
            {
                if(_equipos[i].estado != "Disponible")
                {
                    _equipos.RemoveAt(i);
                }
            }

            dgvEquipos.DataSource = _equipos;

            foreach (DataGridViewRow fila in dgvEquipos.Rows)
            {
                eEquipo eqFila = (eEquipo)fila.DataBoundItem;

                if (frmOwner._equipos.Contains(eqFila))
                {
                    fila.Cells["eqSel"].Value = true;
                }
            }

            dgvEquipos.Columns["tipo"].Visible = false;
            dgvEquipos.Columns["estado"].Visible = false;

        }

        #endregion

        #region ComboBox

        private void actualizarCbx()
        {
            dTipoDeEquipo unT = new dTipoDeEquipo();
            _tipos = unT.listarTipoDeEquipo();

            foreach (eTipoDeEquipo tipo in _tipos)
            {
                if (cbxTipoList.Items.Contains(tipo.nombre) == false)
                {
                    cbxTipoList.Items.Add(tipo.nombre);
                }
            }
            cbxTipoList.Items.Add("Todos");
            cbxTipoList.SelectedItem = "Todos";
        }

        private void cbxTipoList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoList.Text != "Todos")
            {
                cbxSubtipoList.Items.Clear();
                cbxSubtipoList.Enabled = true;
                foreach (eTipoDeEquipo tipo in _tipos)
                {
                    if (tipo.nombre == cbxTipoList.Text)
                    {
                        cbxSubtipoList.Items.Add(tipo.subtipo);
                    }
                }
                cbxSubtipoList.Items.Add("Todos");
                cbxSubtipoList.SelectedItem = "Todos";
            }
            else
            {
                cbxSubtipoList.Items.Clear();
                cbxSubtipoList.Enabled = false;
                actualizarDgv();
            }
        }

        private void cbxSubtipoList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxSubtipoList.Text != null)
            {
                actualizarDgv();
            }
        }

        #endregion
    }
}
