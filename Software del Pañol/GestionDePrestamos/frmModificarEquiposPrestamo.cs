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
    public partial class frmModificarEquiposPrestamo : Form
    {
        List<ePrestamoEquipo> _prestamos = new List<ePrestamoEquipo>();
        List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();
        List<eEquipo> _equipos = new List<eEquipo>();
        List<eEquipo> _equiposSel = new List<eEquipo>();

        public frmModificarEquiposPrestamo(int idPrestamo)
        {
            InitializeComponent();
        }

        private void frmModificarEquiposPrestamo_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquiposSel.AutoGenerateColumns = false;
            actualizarCbx();
            actualizarDgv();  
        }

        private void actualizarDgv()
        {

            dEquipo unE = new dEquipo();

            if (cbxTipoList.Text == "Todos")
            {
                _equipos = unE.listarEquipo();
            }
            else
            {
                if (cbxSubtipoList.Text == "Todos")
                {
                    _equipos = unE.listarEquipo(cbxTipoList.Text);

                }
                else
                {
                    _equipos = unE.listarEquipo(cbxTipoList.Text, cbxSubtipoList.Text);
                }
            }

            for (int i = 0; i < _equipos.Count; i++)
            {
                if (_equipos[i].estado != "Disponible")
                {
                    _equipos.RemoveAt(i);
                    i--;
                }
            }

            foreach (eEquipo eqSel in this._equiposSel)
            {
                for (int i = 0; i < _equipos.Count; i++)
                {
                    if (eqSel.id == _equipos[i].id)
                    {
                        _equipos.RemoveAt(i);
                    }
                }
            }

            dgvEquipos.DataSource = _equipos;
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
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

        private void btnQuitar_Click(object sender, EventArgs e)
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

        private void cbxTipoList_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbxSubtipoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSubtipoList.Text != null)
            {
                actualizarDgv();
            }
        }

    }
}
