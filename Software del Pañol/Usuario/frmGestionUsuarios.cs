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
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            cbxTipoUsuario.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mskCi.MaskFull != true || txtNombre.Text == "" || txtApellido.Text == "" || txtClave.Text == "")
            {
                lblMensaje.Text = "Relle todos los campos porfavor";
            } else if (mskCi.Text == txtNombre.Text || mskCi.Text == txtApellido.Text || txtNombre == txtApellido)
            {
                lblMensaje.Text = "No pueden existir campos con el mismo nombre, excepto CI y Clave";
            } else if (rbDocente.Checked == false && rbAsisTec.Checked == false && rbAlumno.Checked == false)
            {
                lblMensaje.Text = "Porfavor seleccione un tipo de usuario";
            } else
            {
                eUsuario usuario = new eUsuario();
                usuario.ci = mskCi.Text;
                dUsuario unDu = new dUsuario();
                if (unDu.buscarUsuario(usuario) == null)
                {
                    if (rbAsisTec.Checked) {

                        eAsisTec asisTec = new eAsisTec();
                        asisTec.ci = mskCi.Text;
                        asisTec.nombre = txtNombre.Text;
                        asisTec.apellido = txtApellido.Text;
                        asisTec.clave = txtClave.Text;

                        usuario = asisTec;
                        unDu.altaUsuario(usuario);

                        dAsisTec unAsis = new dAsisTec();
                        unAsis.altaAsisTec(asisTec);
                    }
                    if (rbDocente.Checked || rbAlumno.Checked)
                    {
                        eResponsable responsable = new eResponsable();
                        responsable.ci = mskCi.Text;
                        responsable.nombre = txtNombre.Text;
                        responsable.apellido = txtApellido.Text;
                        responsable.clave = txtClave.Text;

                        usuario = responsable;
                        unDu.altaUsuario(usuario);

                        if (rbDocente.Checked) responsable.docente = true;
                        if (rbAlumno.Checked) responsable.docente = false;

                        dResponsable unC = new dResponsable();
                        unC.altaResponsable(responsable);
                    }

                    cbxTipoUsuario_SelectedIndexChanged(cbxTipoUsuario, EventArgs.Empty); //Invoca el evento del cbx para realizar el refresh del dgv

                    mskCi.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtClave.Clear();
                    rbAlumno.Checked = false;
                    rbDocente.Checked = false;
                    rbAsisTec.Checked = false;
                    lblMensaje.Text = "";
                } else
                {
                    lblMensaje.Text = "La CI ya está ingresada en el sistema";
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dUsuario unU = new dUsuario();
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar los siguientes " + dgvUsuarios.SelectedRows.Count.ToString() +
                            " usuarios?", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                
            }
        }

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTipoUsuario.SelectedIndex)
            {
                case 0:     //Todos
                    dUsuario unU = new dUsuario();
                    dgvUsuarios.DataSource = unU.listarUsuario();
                    break;
                case 1:     //Alumnos
                    dResponsable unRA = new dResponsable();
                    dgvUsuarios.DataSource = unRA.listarResponsableSegunTipo(false);
                    break;
                case 2:     //Docentes
                    dResponsable unRD = new dResponsable();
                    dgvUsuarios.DataSource = unRD.listarResponsableSegunTipo(true);
                    break;
                case 3:     //Asistentes Tecnicos
                    dAsisTec unAT = new dAsisTec();
                    dgvUsuarios.DataSource = unAT.listarAsisTec();
                    break;
            }
        }

    }
}
