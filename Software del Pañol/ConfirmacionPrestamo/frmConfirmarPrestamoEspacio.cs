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


namespace Software_del_Pañol.ConfirmacionPrestamo
{
    public partial class frmConfirmarPrestamoEspacio : Form
    {
        List<ePrestamoEspacio> _prestamo = new List<ePrestamoEspacio>();
        eAsisTec asisTec = new eAsisTec();
        ePrestamoEspacio prestamoActual = new ePrestamoEspacio();
        private int auxNroP;

        public frmConfirmarPrestamoEspacio(eAsisTec asisTec)
        {
            InitializeComponent();
            this.asisTec = asisTec;
            auxNroP = 0;
        }

        private void frmConfirmarPrestamoEspacio_Load(object sender, EventArgs e)
        {
            btnAnterior.Enabled = false;
            dPrestamoEspacio unPE = new dPrestamoEspacio();
            _prestamo = unPE.listarPrestamoEspacio();

            if (_prestamo.Any())
            {
                prestamoActual = _prestamo[0];

                if (_prestamo.Count == 1)
                {
                    btnSiguiente.Enabled = false;
                }

                dEspacio unE = new dEspacio();
                cbxEspacio.ValueMember = "id_espacio";
                cbxEspacio.DisplayMember = "nom";
                cbxEspacio.DataSource = unE.listarEspacios();

                mostrarPrestamoActual();
            }
            else
            {
                desactivarBotones();
            }

        }

        public void mostrarPrestamoActual()
        {
            lblPrestamoActual.Text = "Prestamo N°" + prestamoActual.id;
            txtNombreResponsable.Text = prestamoActual.responsable.nombre;
            txtApellidoResponsable.Text = prestamoActual.responsable.apellido;
            dtpSolicitado.Value = prestamoActual.fecha_solicitado;
            dtpRetiro.Value = prestamoActual.fecha_retiro;
            dtpDevolucion.Value = prestamoActual.fecha_devolucion;
            txtCurso.Text = prestamoActual.curso;
            txtEjercicio.Text = prestamoActual.ejercicio;
            cbxEspacio.Text = prestamoActual.espacio.nom;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            prestamoActual.estadoP = estadoP.EnCurso.ToString();
            dPrestamoEspacio unPE = new dPrestamoEspacio();
            unPE.modificarPrestamoEspacio(prestamoActual);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar esta solicitud ? ", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dPrestamoEspacio prestamo = new dPrestamoEspacio();
                prestamo.bajaPrestamoEspacio(prestamoActual);
                lblMensaje.Text = "Solicitud eliminada correctamente";
                _prestamo.RemoveAt(auxNroP);
                if (_prestamo.Any() == false)
                {
                    desactivarBotones();
                    vaciarCampos();
                }
                else if(auxNroP == _prestamo.Count)
                {
                    auxNroP--;

                    if (auxNroP == 0)
                    {
                        btnAnterior.Enabled = false;
                    }

                    prestamoActual = _prestamo[auxNroP-1];
                    mostrarPrestamoActual();
                }
                else 
                {
                    auxNroP++;

                    if (auxNroP == _prestamo.Count - 1)
                    {
                        btnSiguiente.Enabled = false;
                    }

                    prestamoActual = _prestamo[(auxNroP)];
                    mostrarPrestamoActual();
                }
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            auxNroP++;
            btnAnterior.Enabled = true;

            if (auxNroP == _prestamo.Count - 1)
            {
                btnSiguiente.Enabled = false;

            }

            prestamoActual = _prestamo[auxNroP];
            mostrarPrestamoActual();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            auxNroP--;
            btnSiguiente.Enabled = true;

            if (auxNroP == 0)
            {
                btnAnterior.Enabled = false;
            }

            prestamoActual = _prestamo[auxNroP];
            mostrarPrestamoActual();
        }
        private void activarCampos()
        {
            txtNombreResponsable.Enabled = true;
            txtApellidoResponsable.Enabled = true;
            dtpRetiro.Enabled = true;
            dtpDevolucion.Enabled = true;
            dtpSolicitado.Enabled = true;
            txtCurso.Enabled = true;
            txtEjercicio.Enabled = true;
            cbxEspacio.Enabled = true;
        }
        private void vaciarCampos()
        {
            txtNombreResponsable.Text = "";
            txtApellidoResponsable.Text = "";
            dtpRetiro.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now;
            dtpSolicitado.Value = DateTime.Now;
            txtCurso.Text = "";
            txtEjercicio.Text = "";
            cbxEspacio.SelectedItem = "";
        }
        private void desactivarBotones()
        {
            lblPrestamoActual.Text = "No hay prestamos para confirmar";
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnConfirmar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
