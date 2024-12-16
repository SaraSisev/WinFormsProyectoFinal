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

            MostrarProductosEnListBox();
        }

        private void MostrarProductosEnListBox()
        {
            // Limpia el ListBox por si tiene elementos previos
            listBox1.Items.Clear();

            // Itera sobre la lista de productos y añade cada elemento
            foreach (var producto in productos)
            {
                // Si productos tiene una clase personalizada, usa ToString o formatea como prefieras
                listBox1.Items.Add($"{producto.Id} - {producto.Nombre} - Cantidad: {producto.Cantidad}");
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

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que haya un elemento seleccionado
            if (listBox1.SelectedItem != null)
            {
                // Obtiene el índice del elemento seleccionado en el ListBox
                int indexSeleccionado = listBox1.SelectedIndex;

                // Validar que el índice está dentro del rango de la lista
                if (indexSeleccionado >= 0 && indexSeleccionado < productos.Count)
                {
                    banderas[productos[indexSeleccionado].IndiceBand] = false;
                    // Elimina el producto correspondiente de la lista
                    productos.RemoveAt(indexSeleccionado);

                    // Actualiza el ListBox
                    MostrarProductosEnListBox();

                    MessageBox.Show("Producto eliminado correctamente.");
                    lblProducto.Text = "";
                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            // Obtén el índice seleccionado
            int indiceSeleccionado = listBox1.SelectedIndex;

            // Valida que se ha seleccionado un elemento
            if (indiceSeleccionado >= 0 && indiceSeleccionado < productos.Count)
            {
                // Obtén el producto seleccionado
                var productoSeleccionado = productos[indiceSeleccionado];

                // Muestra la información en el Label
                lblProducto.Text = $"ID: {productoSeleccionado.Id}\n" +
                                   $"Nombre: {productoSeleccionado.Nombre}\n" +
                                   $"Cantidad: {productoSeleccionado.Cantidad}";
            }
            else
            {
                lblProducto.Text = "Seleccione un producto para ver los detalles.";
            }
        }
    }
}
