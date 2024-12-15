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
        public FormProducto(Image imagen, string nombres,  string descripcion, string precio, string existencias)
        {
            InitializeComponent();
            pictureBoxImagenProd.Image = imagen;
            lblNombreProd.Text = nombres;
            labelDescripcionProd.Text = descripcion;
            labelPrecioProd.Text = precio;
            labelExistenciasProd.Text = existencias;
            
        }
        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al boton de inicio
            this.Close();
        }
    }
}
