using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }
        public FormProducto(Image imagen, string descripcion, decimal precio, int existencias)
        {
            InitializeComponent();
            pictureBoxImagenProd.Image = imagen;
            labelDescripcionProd.Text = descripcion;
            labelPrecioProd.Text = precio.ToString("N2");
            labelExistenciasProd.Text = existencias.ToString();
        }
        private void FormProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
