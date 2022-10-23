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
using Microsoft.VisualBasic;


namespace Software_del_Pañol.ConfirmacionPrestamo
{
    public partial class frmConfirmarPrestamoEspacio : Form
    {
        List<ePrestamoEspacio> _prestamo = new List<ePrestamoEspacio>();
        eAsisTec asisTec = new eAsisTec();
        ePrestamoEspacio prestamoActual = new ePrestamoEspacio();
        private int auxP;

        public frmConfirmarPrestamoEspacio(eAsisTec asisTec)
        {
            InitializeComponent();
            this.asisTec = asisTec;
            auxP = 0;
        }

        private void frmConfirmarPrestamoEspacio_Load(object sender, EventArgs e)
        {
            btnAnterior.Enabled = false;
            dPrestamoEspacio unPE = new dPrestamoEspacio();
            _prestamo = unPE.listarPrestamoEspacio(estadoP.Pendiente);

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

        #region Botones

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            prestamoActual.fecha_devolucion = dtpDevolucion.Value;
            prestamoActual.fecha_retiro = dtpRetiro.Value;
            prestamoActual.fecha_solicitado = DateTime.Now;
            prestamoActual.curso = txtCurso.Text;
            prestamoActual.ejercicio = txtEjercicio.Text;
            prestamoActual.espacio = (eEspacio)cbxEspacio.SelectedValue;
            prestamoActual.espacio.disponible = false;

            dEspacio unDE = new dEspacio();

            if (unDE.buscarEspacio(prestamoActual.espacio).disponible == false)
            {
                lblMensaje.Text = "El espacio no está disponible";
            }
            else
            {

                prestamoActual.estadoP = estadoP.EnCurso.ToString();

                dPrestamoEspacio unPE = new dPrestamoEspacio();
                unPE.modificarPrestamoEspacio(prestamoActual);

                unDE.modificarEspacio(prestamoActual.espacio);

                _prestamo = unPE.listarPrestamoEspacio(estadoP.Pendiente);

                lblMensaje.Text = "Solicitud confirmada correctamente";

                if (_prestamo.Count == 0)
                {
                    desactivarBotones();
                    vaciarCampos();
                    activarCampos(false);
                }
                else
                {
                    auxP--;
                    siguientePrestamo();
                    activarCampos(false);
                }

                eReserva reserva = new eReserva();
                dReserva unR = new dReserva();
                reserva.prestamoCR = prestamoActual;
                try
                {
                    reserva.numMesa = Convert.ToInt32(Interaction.InputBox("Ingrese N° de mesa"));
                    unR.altaReserva(reserva);
                }
                catch
                {
                    MessageBox.Show("Valor incorrecto", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarCampos(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar esta solicitud ? ", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dPrestamoEspacio prestamo = new dPrestamoEspacio();
                prestamo.bajaPrestamoEspacio(prestamoActual);
                _prestamo = prestamo.listarPrestamoEspacio(estadoP.Pendiente);

                lblMensaje.Text = "Solicitud eliminada correctamente";

                if(_prestamo.Count == 0)
                {
                    desactivarBotones();
                    vaciarCampos();
                    activarCampos(false);
                }
                else
                {
                    auxP--;
                    siguientePrestamo();
                    activarCampos(false);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguientePrestamo();
            activarCampos(false);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anteriorPrestamo();
            activarCampos(false);
        }

        #endregion

        private void siguientePrestamo()
        {
            if (auxP < _prestamo.Count-1)
            {
                auxP++;

                if (auxP == _prestamo.Count-1)
                {
                    btnSiguiente.Enabled = false;
                }

                if (auxP == 0)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }

                prestamoActual = _prestamo[auxP];
                mostrarPrestamoActual();
            }
            else if (auxP == _prestamo.Count-1)
            {
                btnSiguiente.Enabled = false;

                if (_prestamo.Count == 1)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }

                prestamoActual = _prestamo[auxP];
                mostrarPrestamoActual();
            }
        }

        private void anteriorPrestamo()
        {
            if (auxP == 0 || auxP-1 == 0)
            {
                btnAnterior.Enabled = false;
            }

            if ((auxP-1) >= 0)
            {
                auxP--;
                btnSiguiente.Enabled = true;

                prestamoActual = _prestamo[auxP];
                mostrarPrestamoActual();
            }
        }

        private void activarCampos(bool estado)
        {
            txtNombreResponsable.Enabled = estado;
            txtApellidoResponsable.Enabled = estado;
            dtpRetiro.Enabled = estado;
            dtpDevolucion.Enabled = estado;
            dtpSolicitado.Enabled = estado;
            txtCurso.Enabled = estado;
            txtEjercicio.Enabled = estado;
            cbxEspacio.Enabled = estado;
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
