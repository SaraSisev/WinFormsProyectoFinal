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
    public partial class Carrito : Form
    {
        private List<Productos> productos;
        bool[] banderas;
        public Carrito(List<Productos> productos, bool[] band)
        {
            InitializeComponent();
            this.productos = productos;
            this.banderas = band;
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            if (productos != null && productos.Count > 0)
            {
                // Concatenar la información de los productos
                string textoProductos = "";
                foreach (var producto in productos)
                {
                    textoProductos += producto.ToString() + Environment.NewLine;
                }

                // Asignar el texto concatenado al Label
                lblProductos.Text = textoProductos;
            }
            else
            {
                lblProductos.Text = "No hay productos en el carrito.";
            }
        }


        private void Carrito_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Regresar al boton de inicio
            Form3 inicio = new Form3(productos, banderas);
            inicio.Show();
            this.Hide();
        }
    }
}
