using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WinFormsProyectoFinal
{
    public partial class Carrito : Form
    {
        private List<Productos> productos;
        bool[] banderas;
        private List<int> existencias;
        string nombreUsuario;

        public Carrito(List<Productos> productos, bool[] band, List<int> existencias, string nombreUsuario)
        {
            InitializeComponent();
            this.productos = productos;
            this.banderas = band;
            this.existencias = existencias;
            this.nombreUsuario = nombreUsuario;
            MostrarProductosEnListBox();
        }

        private void MostrarProductosEnListBox()
        {
            //Se borra lo que tenia anteriormente para insertar los nuevos datos
            listBox1.Items.Clear();

            foreach (var producto in productos)
            {
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
            //Regresar al form de inicio
            Form3 inicio = new Form3(productos, banderas, existencias);
            inicio.Show();
            this.Hide();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //verificar que hay un elemento selecionado
            if (listBox1.SelectedItem != null)
            {
                int indice = listBox1.SelectedIndex; //obtiene el indice del elemento seleccionado del listBox


                if ((indice >= 0) && (indice < productos.Count)) //Se verifica que el indice si este en un rango especifico
                {
                    var productoEliminado = productos[indice]; //Se obtiene el producto a eliminar

                    //Como se va a eliminar las existencias vuelven a su valor de antes de la compra
                    existencias[productoEliminado.IndiceBand] += productoEliminado.Cantidad;

                    //Se pone en false el valor de la bandera dl producto 
                    banderas[productoEliminado.IndiceBand] = false;

                    productos.RemoveAt(indice);//Se elimina de la lista

                    MostrarProductosEnListBox();

                    MessageBox.Show($"Producto eliminado"); //mnsj de confirmacion

                    //se limpia y deshabilita para eliminar otro producto hasta que se seleccione
                    lblProducto.Text = "";
                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
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
                lblProducto.Text = $"ID: {productoSeleccionado.Id}\n" + $"Nombre: {productoSeleccionado.Nombre}\n" + $"Cantidad: {productoSeleccionado.Cantidad}";
            }
            else
            {
                lblProducto.Text = "Seleccione un producto para mostrar los detalles";
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Mensaje para confirmar la compra
            var confirmacion = MessageBox.Show("¿Deseas finalizar la compra?", "Finalizar Compra", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += Imprimir;
                    printDocument1.Print();

                    double totalSinImpuesto = 0;
                    double totalConImpuesto = 0;
                    double impuesto = 0;

                    //conexion a la DB
                    Conexion conection = new Conexion();
                    MySqlConnection con = conection.conexionBD();

                    foreach (var producto in productos)
                    {
                        //parte para actualizar las existencias en la base de datos
                        string nuevaExi = "UPDATE productos SET existencias = existencias - @cantidad WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(nuevaExi, con);
                        cmd.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                        cmd.Parameters.AddWithValue("@id", producto.Id);
                        cmd.ExecuteNonQuery();

                        //parte del codigo para aumentar la venta del producto
                        string nuevaVenta = "UPDATE productos SET ventas = ventas + @cantidad WHERE id = @id";
                        MySqlCommand cmdVentas = new MySqlCommand(nuevaVenta, con);
                        cmdVentas.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                        cmdVentas.Parameters.AddWithValue("@id", producto.Id);
                        cmdVentas.ExecuteNonQuery();

                        double precio;
                        double.TryParse(producto.Precio, out precio);

                        // Calcular total sin impuesto
                        totalSinImpuesto += producto.Cantidad * precio;


                    }

                    // Calcular impuesto y total con impuesto
                    impuesto = totalSinImpuesto * 0.06; // 6% de impuesto
                    totalConImpuesto = totalSinImpuesto + impuesto;

                    //parte para aumentar el monto en la tabla de cuentas del usuario 
                    string nuevoMonto = "UPDATE cuentas SET monto = monto + @monto WHERE nombre = @nombreUsuario";
                    MySqlCommand cmdMonto = new MySqlCommand(nuevoMonto, con);
                    cmdMonto.Parameters.AddWithValue("@monto", totalConImpuesto);
                    cmdMonto.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmdMonto.ExecuteNonQuery();

                    //Limpiar las listas usadas y vaciar el carrito
                    productos.Clear();

                    //En el caso de la lista de banderas se inicializan a false
                    for (int i = 0; i < banderas.Length; i++)
                    {
                        banderas[i] = false;
                    }

                    MostrarProductosEnListBox();

                    MessageBox.Show("Compra Exitosa", "Compra Finalizada");

                    //Regresa al form principal
                    Form3 inicio = new Form3(new List<Productos>(), banderas, existencias);
                    inicio.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            // Fuentes y colores
            Font fontTitulo = new Font("Verdana", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Maiandra GD", 12, FontStyle.Italic);
            Font fontTexto = new Font("Nirmala UI", 12);
            Brush brush = Brushes.Black;

            int espacioHorizontal = 20; // Espacio entre el logo y el texto

            // Configuración de posicionamiento
            int anchoPagina = e.PageBounds.Width;
            int y = 20; // Posición vertical inicial

            // Configuración de posición y tamaño
            int x = 20; // Posición X inicial
            int anchoImagen = 120; // Ancho del logo (más grande)
            int altoImagen = 120;  // Alto del logo (más grande)

            // --- DIBUJAR EL LOGO ---
            if (pictureBox2.Image != null)
            {
                e.Graphics.DrawImage(pictureBox2.Image, new Rectangle(x, y, anchoImagen, altoImagen));
            }

            // --- DIBUJAR EL TÍTULO Y EL SLOGAN ---
            int xTexto = x + anchoImagen + espacioHorizontal; // Posición X del texto, a la derecha del logo
            int yTexto = y; // Alinear con la parte superior

            e.Graphics.DrawString("Tricotera", fontTitulo, brush, new PointF(xTexto, yTexto + 40));
            e.Graphics.DrawString("Tejiendo sueños, un punto a la vez", fontSubtitulo, brush, new PointF(xTexto, yTexto + 70));

            // Ajustar la posición después del logo
            y += altoImagen + 20;

            // Fecha y hora actuales
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            e.Graphics.DrawString($"Fecha: {fechaHora}", fontTexto, brush, new PointF(20, y));
            y += 30;


            // Información del cliente
            e.Graphics.DrawString($"Cliente: {nombreUsuario}", fontTexto, brush, new PointF(20, y));
            y += 30;

            // Columnas de la tabla
            e.Graphics.DrawString("Producto", fontTexto, brush, new PointF(20, y));
            e.Graphics.DrawString("Cantidad", fontTexto, brush, new PointF(200, y));
            e.Graphics.DrawString("Precio", fontTexto, brush, new PointF(350, y));
            y += 30;

            // Línea separadora
            e.Graphics.DrawLine(Pens.Black, 20, y, anchoPagina - 20, y);
            y += 10;

            // Variables para totales
            double totalSinImpuesto = 0;
            double totalConImpuesto = 0;
            double impuesto = 0;

            // Iterar sobre los productos
            foreach (var producto in productos)
            {
                // Convertir el precio a double
                double precio;
                double.TryParse(producto.Precio, out precio);


                // Imprimir datos del producto
                e.Graphics.DrawString(producto.Nombre, fontTexto, brush, new PointF(20, y));
                e.Graphics.DrawString(producto.Cantidad.ToString(), fontTexto, brush, new PointF(200, y));
                e.Graphics.DrawString($"${precio:F2}", fontTexto, brush, new PointF(350, y));

                // Calcular total sin impuesto
                totalSinImpuesto += producto.Cantidad * precio;

                y += 30; // Espacio para la siguiente línea
            }

            // Calcular impuesto y total con impuesto
            impuesto = totalSinImpuesto * 0.06; // 6% de impuesto
            totalConImpuesto = totalSinImpuesto + impuesto;

            // Línea separadora final
            e.Graphics.DrawLine(Pens.Black, 20, y, anchoPagina - 20, y);
            y += 10;

            // Imprimir totales
            e.Graphics.DrawString($"Total sin impuesto: ${totalSinImpuesto:F2}", fontSubtitulo, brush, new PointF(20, y));
            y += 30;
            e.Graphics.DrawString($"Impuesto (6%): ${impuesto:F2}", fontSubtitulo, brush, new PointF(20, y));
            y += 30;
            e.Graphics.DrawString($"Total con impuesto: ${totalConImpuesto:F2}", fontTitulo, brush, new PointF(20, y));
            y += 40;
        }




    }
}
