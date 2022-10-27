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

namespace Software_del_Pañol.PrestamosDirectos
{
    public partial class frmLibrosPrestamo : Form
    {
        ePrestamoLibro prestamoLi = new ePrestamoLibro();
        List<eLibro> _libros = new List<eLibro>();
        dPrestamoLibro unPL = new dPrestamoLibro();

        public frmLibrosPrestamo(int idPrestamo)
        {
            InitializeComponent();

            prestamoLi.id = idPrestamo;
            prestamoLi = unPL.buscarPrestamoLibro(prestamoLi);
            _libros = prestamoLi._libros;

            lblTitulo.Text = "Libros asociados al préstamo N°:" + idPrestamo;

        }
        private void frmLibrosPrestamo_Load(object sender, EventArgs e)
        {
            foreach (eLibro unLi in _libros)
            {
                dgvLibros.Rows.Add(unLi.id, unLi.titulo, unLi.autor, unLi.disponible);
            }
        }
    }
}
