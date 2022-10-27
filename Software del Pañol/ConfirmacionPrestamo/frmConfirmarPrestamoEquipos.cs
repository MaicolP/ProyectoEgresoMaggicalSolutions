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
using System.Drawing.Printing;


namespace Software_del_Pañol.ConfirmacionPrestamo
{
    public partial class frmConfirmarPrestamoEquipos : Form
    {
        List<ePrestamoEquipo> _prestamos = new List<ePrestamoEquipo>();
        List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();
        List<eEquipo> _equipos = new List<eEquipo>();
        List<eEquipo> _equiposSel = new List<eEquipo>();
        eAsisTec asisTec = new eAsisTec();
        ePrestamoEquipo prestamoActual = new ePrestamoEquipo();
        private int auxP;

        public frmConfirmarPrestamoEquipos(eAsisTec asisTec)
        {
            InitializeComponent();
            this.asisTec = asisTec;
            auxP = 0;
        }

        private void frmConfirmarPrestamoEquipos_Load(object sender, EventArgs e)
        {
            // dgvEquipos y cbx
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquiposSel.AutoGenerateColumns = false;
            activarCampos(false);
            actualizarCbx();

            // Prestamos
            btnAnterior.Enabled = false;
            dPrestamoEquipo unPE = new dPrestamoEquipo();
            _prestamos = unPE.listarPrestamoEquipoPendiente();

            if (_prestamos.Any())
            {
                prestamoActual = _prestamos[0];

                if (_prestamos.Count == 1)
                {
                    btnSiguiente.Enabled = false;
                }

                actualizarDgv();

                mostrarPrestamoActual();
            }
            else
            {
                desactivarBotones();
            }
        }

        #region DataGridView

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

        #endregion

        #region Botones

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar esta solicitud ? ", "Alerta de seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                dPrestamoEquipo prestamo = new dPrestamoEquipo();
                prestamo.bajaPrestamoEquipo(prestamoActual);
                _prestamos = prestamo.listarPrestamoEquipo(estadoP.Pendiente);

                lblMensaje.Text = "Solicitud eliminada correctamente";

                if (_prestamos.Count == 0)
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            prntDoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            prntDoc.PrinterSettings = ps;
            prntDoc.PrintPage += Imprimir;
            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = prntDoc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;
            ppd.ShowDialog();

            dPrestamoEquipo prestamo = new dPrestamoEquipo();

            prestamoActual.fecha_solicitado = dtpSolicitado.Value;
            prestamoActual.fecha_retiro = dtpRetiro.Value;
            prestamoActual.fecha_devolucion = dtpDevolucion.Value;
            prestamoActual.curso = cbxCurso.Text;
            prestamoActual.ejercicio = cbxEjercicio.Text;
            if ((cbxCurso.Text == "Tercero Bachillerato" && cbxEjercicio.Text == "Rodaje") || (cbxCurso.Text == "Segundo Tecnicatura" && cbxEjercicio.Text == "Rodaje")) prestamoActual.prioridad = 3;
            else if ((cbxCurso.Text == "Primero Tecnicatura" && cbxEjercicio.Text == "Rodaje")) prestamoActual.prioridad = 2;
            else
            {
                prestamoActual.prioridad = 1;
            }
            prestamoActual.equipoRodaje = txtEquipoRodaje.Text;
            prestamoActual.locaciones = txtLocaciones.Text;
            prestamoActual.nomDocente = txtNombreDocente.Text;
            prestamoActual.apeDocente = txtApellidoDocente.Text;
            prestamoActual.transporte = txtTransporte.Text;
            prestamoActual.estadoP = estadoP.EnCurso.ToString();
            prestamoActual._equipos = _equiposSel;

            prestamo.modificarPrestamoEquipo(prestamoActual);
            _prestamos = prestamo.listarPrestamoEquipoPendiente();

            lblMensaje.Text = "Solicitud confirmada correctamente";

            if (_prestamos.Count == 0)
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
                    foreach (eEquipo unEq in _equiposSel)
                    {
                        dgvEquiposSel.Rows.Add(unEq.nombre, unEq.nroSerie, unEq.observaciones);
                    }
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
                foreach (eEquipo unEq in _equiposSel)
                {
                    dgvEquiposSel.Rows.Add(unEq.nombre, unEq.nroSerie, unEq.observaciones);
                }
                actualizarDgv();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anteriorPrestamo();
            activarCampos(false);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguientePrestamo();
            activarCampos(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarCampos(true);
        }

        #endregion

        private void siguientePrestamo()
        {
            if (auxP < _prestamos.Count - 1)
            {
                auxP++;

                if (auxP == _prestamos.Count - 1)
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

                prestamoActual = _prestamos[auxP];
                mostrarPrestamoActual();
            }
            else if (auxP == _prestamos.Count - 1)
            {
                btnSiguiente.Enabled = false;

                if (_prestamos.Count == 1)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }

                prestamoActual = _prestamos[auxP];
                mostrarPrestamoActual();
            }
        }

        private void anteriorPrestamo()
        {
            if (auxP == 0 || auxP - 1 == 0)
            {
                btnAnterior.Enabled = false;
            }

            if ((auxP - 1) >= 0)
            {
                auxP--;
                btnSiguiente.Enabled = true;

                prestamoActual = _prestamos[auxP];
                mostrarPrestamoActual();
            }
        }

        private void activarCampos(bool estado)
        {
            dtpRetiro.Enabled = estado;
            dtpDevolucion.Enabled = estado;
            dtpSolicitado.Enabled = estado;
            cbxCurso.Enabled = estado;
            cbxEjercicio.Enabled = estado;
            txtEquipoRodaje.Enabled = estado;
            txtLocaciones.Enabled = estado;
            txtTransporte.Enabled = estado;
            txtNombreDocente.Enabled = estado;
            txtApellidoDocente.Enabled = estado;
            txtNombreResponsable.Enabled = estado;
            txtApellidoResponsable.Enabled = estado;
            btnAgregarEquipo.Enabled = estado;
            btnQuitar.Enabled = estado;
        }

        private void vaciarCampos()
        {
            lblPrioridad.Text = "";
            txtNombreResponsable.Text = "";
            txtApellidoResponsable.Text = "";
            dtpRetiro.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now;
            dtpSolicitado.Value = DateTime.Now;
            cbxCurso.Text = "";
            cbxEjercicio.Text = "";
            txtEquipoRodaje.Text = "";
            txtTransporte.Text = "";
            txtLocaciones.Text = "";
            txtNombreDocente.Text = "";
            txtApellidoDocente.Text = "";
            _equiposSel.Clear();
            actualizarDgv();
        }

        public void mostrarPrestamoActual()
        {
            lblPrestamoActual.Text = "Prestamo N°" + prestamoActual.id;
            lblPrioridad.Text = "Prioridad : " + prestamoActual.prioridad;
            if (lblPrioridad.Text == "Prioridad : 1") lblPrioridad.ForeColor = Color.Green;
            else if (lblPrioridad.Text == "Prioridad : 2") lblPrioridad.ForeColor = Color.Gold;
            else if (lblPrioridad.Text == "Prioridad : 3") lblPrioridad.ForeColor = Color.Red;
            txtNombreResponsable.Text = prestamoActual.responsable.nombre;
            txtApellidoResponsable.Text = prestamoActual.responsable.apellido;
            dtpSolicitado.Value = prestamoActual.fecha_solicitado;
            dtpRetiro.Value = prestamoActual.fecha_retiro;
            dtpDevolucion.Value = prestamoActual.fecha_devolucion;
            cbxCurso.Text = prestamoActual.curso;
            cbxEjercicio.Text = prestamoActual.ejercicio;
            txtEquipoRodaje.Text = prestamoActual.equipoRodaje;
            txtLocaciones.Text = prestamoActual.locaciones;
            txtNombreDocente.Text = prestamoActual.nomDocente;
            txtApellidoDocente.Text = prestamoActual.apeDocente;
            txtTransporte.Text = prestamoActual.transporte;

            _equiposSel = prestamoActual._equipos;
            dgvEquiposSel.DataSource = null;
            dgvEquiposSel.DataSource = _equiposSel;
            actualizarDgv();
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

        public void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 16, FontStyle.Underline, GraphicsUnit.Point);

            e.Graphics.DrawString("PLANILLA DE PRÉSTAMOS PAÑOL AUDIOVISUAL", font, Brushes.Black, new RectangleF(20, 40, 600, 30));

            font = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);

            String fecha_retiro = prestamoActual.fecha_retiro.ToShortDateString();

            e.Graphics.DrawString("FECHA RETIRO : " + fecha_retiro, font, Brushes.Black, new RectangleF(20, 90, 600, 30));

            String hora_retiro = prestamoActual.fecha_retiro.ToShortTimeString();

            e.Graphics.DrawString("HORA RETIRO : " + hora_retiro, font, Brushes.Black, new RectangleF(20, 140, 600, 30));

            String fecha_devolucion = prestamoActual.fecha_devolucion.ToShortDateString();

            e.Graphics.DrawString("FECHA DEVOLUCIÓN : " + fecha_devolucion, font, Brushes.Black, new RectangleF(20, 190, 600, 30));

            String hora_devolucion = prestamoActual.fecha_devolucion.ToShortTimeString();

            e.Graphics.DrawString("HORA DEVOLUCIÓN : " + hora_devolucion, font, Brushes.Black, new RectangleF(20, 240, 600, 30));

            e.Graphics.DrawString("RESPONSABLE DEL EQUIPO : " + prestamoActual.responsable.nombre + " " + prestamoActual.responsable.apellido, font, Brushes.Black, new RectangleF(20, 290, 800, 30));

            e.Graphics.DrawString("DOCENTE RESPONSABLE : " + prestamoActual.nomDocente + " " + prestamoActual.apeDocente, font, Brushes.Black, new RectangleF(20, 340, 800, 30));

            e.Graphics.DrawString("LOCACIONES : " + prestamoActual.locaciones, font, Brushes.Black, new RectangleF(20, 390, 800, 30));

            e.Graphics.DrawString("TRANSPORTE : " + prestamoActual.transporte, font, Brushes.Black, new RectangleF(20, 440, 800, 30));

            e.Graphics.DrawString("EQUIPO DE RODAJE : " + prestamoActual.equipoRodaje, font, Brushes.Black, new RectangleF(20, 490, 800, 30));

            e.Graphics.DrawString("CURSO: " + prestamoActual.curso, font, Brushes.Black, new RectangleF(20, 540, 800, 30));

            e.Graphics.DrawString("EJERCICIO : " + prestamoActual.ejercicio, font, Brushes.Black, new RectangleF(20, 590, 800, 30));

            dgvEquiposSel.Columns["NombreS"].Width = 200;
            dgvEquiposSel.Columns["NroSerieS"].Width = 120;
            dgvEquiposSel.Columns["ObservacionesS"].Width = 300;

            const int DGV_ALTO = 35;
            int left = e.MarginBounds.Left - 50, top = e.MarginBounds.Top + 590;

            foreach (DataGridViewColumn col in dgvEquiposSel.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, left, top);
                left += col.Width;

                if (col.Index < dgvEquiposSel.ColumnCount - 1)
                    e.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvEquiposSel.RowCount) * DGV_ALTO);
            }
            left = e.MarginBounds.Left - 50;
            e.Graphics.FillRectangle(Brushes.Black, left, top + 40, e.MarginBounds.Right - left + 50, 3);
            top += 43;

            foreach (DataGridViewRow row in dgvEquiposSel.Rows)
            {
                if (row.Index == dgvEquiposSel.RowCount) break;
                left = e.MarginBounds.Left -50;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                    left += cell.OwningColumn.Width;
                }
                top += DGV_ALTO;
                e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left - 50, top, e.MarginBounds.Right + 50, top);
            }

            dgvEquiposSel.Columns["NombreS"].Width = 110;
            dgvEquiposSel.Columns["NroSerieS"].Width = 111;
            dgvEquiposSel.Columns["ObservacionesS"].Width = 111;

            e.Graphics.DrawString("__________________", font, Brushes.Black, new RectangleF(150, 1000, 800, 30));
            e.Graphics.DrawString("__________________", font, Brushes.Black, new RectangleF(450, 1000, 800, 30));

            font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);

            e.Graphics.DrawString("Firma asistente técnico", font, Brushes.Black, new RectangleF(180, 1030, 800, 30));
            e.Graphics.DrawString("Firma responsable", font, Brushes.Black, new RectangleF(495, 1030, 800, 30));
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}