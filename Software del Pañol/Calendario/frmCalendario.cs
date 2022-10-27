using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dominio;

namespace Software_del_Pañol.Calendario
{
    public partial class frmCalendario : Form
    {
        int mes, ano;
        List<ePrestamoEquipo> _pEquipo = new List<ePrestamoEquipo>();
        List<ePrestamoEspacio> _pEspacio = new List<ePrestamoEspacio>();
        List<contenedorDia> _contDia = new List<contenedorDia>();

        public frmCalendario()
        {
            InitializeComponent();
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            mes = hoy.Month;
            ano = hoy.Year;

            mostrarDias();
        }

        private void mostrarDias()
        {
            _contDia.Clear();

            string nomMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblFecha.Text = nomMes + " " + ano;

            DateTime principioDelMes = new DateTime(ano, mes, 1);

            int dias = DateTime.DaysInMonth(ano, mes);

            int diasDeLaSemana = Convert.ToInt32(principioDelMes.DayOfWeek.ToString("d"));

            for (int i = 0; i < diasDeLaSemana; i++)
            {
                contenedorBlanco contBlanco = new contenedorBlanco();
                fpnlCalendario.Controls.Add(contBlanco);
            }

            for (int i = 1; i <= dias; i++)
            {
                contenedorDia dia = new contenedorDia();
                dia.num = i;
                dia.mes = mes;
                _contDia.Add(dia);
                dia.dias(i);
                fpnlCalendario.Controls.Add(dia);
            }

            datosDias();
        }

        private void datosDias()
        {
            dPrestamoEquipo unPEq = new dPrestamoEquipo();
            _pEquipo = unPEq.listarPrestamoEquipoXMes(ano, mes);

            dPrestamoEspacio unPEs = new dPrestamoEspacio();
            _pEspacio = unPEs.listarPrestamoEquipoXMes(ano, mes);

            foreach (var dia in _contDia)
            {
                foreach(var p in _pEquipo)
                {
                    if (dia.num == p.fecha_retiro.Day || dia.num == p.fecha_devolucion.Day)
                    {
                        dia.alertaPrestamoEquipo(p);
                    }
                }

                foreach (var p in _pEspacio)
                {
                    if (dia.num == p.fecha_retiro.Day || dia.num == p.fecha_devolucion.Day)
                    {
                        dia.alertaPrestamoEspacio(p);
                    }
                }
            }
        }

        private void btnSiguiente_CLick(object sender, EventArgs e)
        {
            fpnlCalendario.Controls.Clear();

            mes++;

            if(mes == 13)
            {
                mes = 1;
                ano++;
            }

            mostrarDias();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            fpnlCalendario.Controls.Clear();

            mes--;

            if (mes == 0)
            {
                mes = 12;
                ano--;
            }

            mostrarDias();
        }
    }
}
