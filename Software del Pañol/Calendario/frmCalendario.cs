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

namespace Software_del_Pañol.Calendario
{
    public partial class frmCalendario : Form
    {
        int mes, ano;

        public frmCalendario()
        {
            InitializeComponent();
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            mostrarDias();
        }

        private void mostrarDias()
        {
            DateTime hoy = DateTime.Now;
            mes = hoy.Month;
            ano = hoy.Year;

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
                dia.dias(i);
                fpnlCalendario.Controls.Add(dia);
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
                dia.dias(i);
                fpnlCalendario.Controls.Add(dia);
            }
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
                dia.dias(i);
                fpnlCalendario.Controls.Add(dia);
            }
        }
    }
}
