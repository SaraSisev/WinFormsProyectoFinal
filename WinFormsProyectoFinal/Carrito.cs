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
using Google.Protobuf.WellKnownTypes;

namespace WinFormsProyectoFinal
{
    public partial class Carrito : Form
    {

        //Se inicializan los elementos globales que se van a estar actualizando constantemente y estar pasandose entre formularios
        private List<Productos> productos;
        bool[] banderas;
        private List<int> existencias;
        string nombreUsuario;

        public Carrito(List<Productos> productos, bool[] band, List<int> existencias, string nombreUsuario)
        {
            //Se inicializan la lista de productos y de botones que van a ir cambiando dependiendo de las existencias de los productos
            InitializeComponent();
            this.productos = productos;
            this.banderas = band;
            this.existencias = existencias;
            this.nombreUsuario = nombreUsuario;
            lblNombre.Text = nombreUsuario;
            MostrarProductos();//Se muestran los productos en el listView
            btnEliminar.Enabled = false;
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
            if (listView1.SelectedItems.Count > 0)
            {
                int indice = listView1.SelectedIndices[0]; //obtiene el indice del elemento seleccionado del ListView

                if ((indice >= 0) && (indice < productos.Count)) //Se verifica que el indice si este en un rango especifico
                {
                    var prodEliminar = productos[indice]; //Se obtiene el producto a eliminar

                    //Como se va a eliminar las existencias vuelven a su valor de antes de la compra
                    existencias[prodEliminar.IndiceBand] += prodEliminar.Cantidad;

                    //Se pone en false el valor de la bandera dl producto 
                    banderas[prodEliminar.IndiceBand] = false;

                    productos.RemoveAt(indice);//Se elimina de la lista

                    MostrarProductos();//Se actualizan otra vez los datos del ListView

                    MessageBox.Show($"Producto eliminado");//Mensaje de confirmacion

                    //se limpia y deshabilita para eliminar otro producto hasta que se seleccione
                    lblProducto.Text = "";
                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Mensaje para confirmar la compra
            var confirmacion = MessageBox.Show("¿Deseas finalizar la compra?", "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    //Se crea un ticket(pdf) con los datos de las listas, de la compra que va a realizar el comprador
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += Imprimir;
                    printDocument1.Print();

                    //Variables que se usan para actualizar el monto del usuario
                    double tot = 0;
                    double totFinal = 0;

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

                        //Se suman los precios de los productos y se pasan a una variable que todavia no tiene el impuesto
                        double precio;
                        double.TryParse(producto.Precio, out precio);
                        tot += producto.Cantidad * precio;


                    }

                    //Se calcula el total con el impuesto
                    totFinal = tot + (tot * 0.06);

                    //parte para aumentar el monto en la tabla de cuentas del usuario 
                    string nuevoMonto = "UPDATE cuentas SET monto = monto + @monto WHERE nombre = @nombreUsuario";
                    MySqlCommand cmdMonto = new MySqlCommand(nuevoMonto, con);
                    cmdMonto.Parameters.AddWithValue("@monto", totFinal);
                    cmdMonto.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmdMonto.ExecuteNonQuery();

                    //Limpiar las listas usadas y vaciar el carrito
                    productos.Clear();

                    //En el caso de la lista de banderas se inicializan a false
                    for (int i = 0; i < banderas.Length; i++)
                    {
                        banderas[i] = false;
                    }

                    MostrarProductos();

                    MessageBox.Show("Compra Exitosa", "Compra Finalizada"); //Se muestra un mensaje de que se realizó la compra correctamente

                    //Regresa al form principal
                    Form3 inicio = new Form3(new List<Productos>(), banderas, existencias);
                    inicio.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    //Si existe algun error lo muestra en el messageBox
                    MessageBox.Show($"Error al realizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Fuentes y colores
            Font fontTitulo = new Font("Verdana", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Maiandra GD", 12, FontStyle.Italic);
            Font fontTexto = new Font("Nirmala UI", 12);
            Brush pincel = Brushes.Black;

            int espacio = 20; //Espacio entre el logo y el texto

            // Configuración de las posiciones
            int anchoPag = e.PageBounds.Width;
            int y = 20;
            int x = 20;

            int anchoImg = 120; //Ancho del logo
            int altoImg = 120;  //Alto del logo

            //Se inserta el logo
            if (pictureBox2.Image != null)
            {
                e.Graphics.DrawImage(pictureBox2.Image, new Rectangle(x, y, anchoImg, altoImg));
            }

            //Se inserta el titulo y el slogan despues de la imagen
            int xTexto = x + anchoImg + espacio;
            int yTexto = y;
            e.Graphics.DrawString("Tricotera", fontTitulo, pincel, new PointF(xTexto, yTexto + 40));
            e.Graphics.DrawString("Tejiendo sueños, un punto a la vez", fontSubtitulo, pincel, new PointF(xTexto, yTexto + 70));
            y += altoImg + 20; //Se ajusta la posicion despues del logo y el slogan


            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"); //Se inserta fecha y hora actuales
            e.Graphics.DrawString($"Fecha: {fechaHora}", fontTexto, pincel, new PointF(20, y));
            y += 30;

            e.Graphics.DrawString($"Cliente: {nombreUsuario}", fontTexto, pincel, new PointF(20, y)); //Se inserta el nombre del cliente
            y += 30;

            //Se insertan las columnas para la  tabla de productos
            e.Graphics.DrawString("Producto", fontTexto, pincel, new PointF(20, y));
            e.Graphics.DrawString("Cantidad", fontTexto, pincel, new PointF(200, y));
            e.Graphics.DrawString("Precio", fontTexto, pincel, new PointF(350, y));
            y += 30;

            e.Graphics.DrawLine(Pens.Black, 20, y, anchoPag - 20, y); //Se pone una linea para dibujar una tabla
            y += 10;

            //Variables para calcular el monto total
            double totCrudo = 0;
            double totImpuesto = 0;
            double impuesto = 0;

            foreach (var producto in productos)
            {
                //Se obtiene el precio de cada producto
                double precio;
                double.TryParse(producto.Precio, out precio);

                //Se muestran los datos del producto
                e.Graphics.DrawString(producto.Nombre, fontTexto, pincel, new PointF(20, y));
                e.Graphics.DrawString(producto.Cantidad.ToString(), fontTexto, pincel, new PointF(200, y));
                e.Graphics.DrawString($"${precio:F2}", fontTexto, pincel, new PointF(350, y));

                //Se suman todos los precios de los productos con la cantidad de cada uno
                totCrudo += producto.Cantidad * precio;

                y += 30; //espacio para la siguiente línea
            }

            //Se calcula el impuesto y el total final
            impuesto = totCrudo * 0.06;
            totImpuesto = totCrudo + impuesto;

            e.Graphics.DrawLine(Pens.Black, 20, y, anchoPag - 20, y);
            y += 10;

            //Se imprimen los datos totales
            e.Graphics.DrawString($"Total sin impuesto: ${totCrudo:F2}", fontSubtitulo, pincel, new PointF(20, y));
            y += 30;
            e.Graphics.DrawString($"Impuesto (6%): ${impuesto:F2}", fontSubtitulo, pincel, new PointF(20, y));
            y += 30;
            e.Graphics.DrawString($"Total con impuesto: ${totImpuesto:F2}", fontTitulo, pincel, new PointF(20, y));
            y += 40;
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString(); //Se muestra le fecha
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;

            if (listView1.SelectedItems.Count > 0)
            {
                int indice = listView1.SelectedIndices[0];
                if (indice >= 0 && indice < productos.Count)
                {
                    var producto = productos[indice];
                    lblProducto.Text = $"ID: {producto.Id}\n" +
                                       $"Nombre: {producto.Nombre}\n" +
                                       $"Cantidad: {producto.Cantidad}\n" +
                                       $"Precio: {producto.Precio}";
                }
            }
            else
            {
                lblProducto.Text = "Seleccione un producto para mostrar los detalles";
            }
        }

        private void MostrarProductos()
        {
            //Se borra lo que tenia anteriormente para insertar los nuevos datos
            listView1.Items.Clear();

            //Se configuran las columnas
            if (listView1.Columns.Count == 0)
            {
                listView1.View = View.Details;
                listView1.Columns.Add("Nombre", 140, HorizontalAlignment.Left);
                listView1.Columns.Add("Cantidad", 70, HorizontalAlignment.Center);               
                listView1.Columns.Add("Precio", 100, HorizontalAlignment.Center);
                listView1.Columns.Add("Total", 100, HorizontalAlignment.Center);
            }

            //Variables que se usan para actualizar el monto del usuario
            double tot = 0;
            double totFinal = 0;
            double impuesto = 0;

            foreach (var producto in productos)
            {
                double precio;
                double.TryParse(producto.Precio, out precio);
                double totalProducto = producto.Cantidad * precio;

                //Se crea un ítem para mostrar los productos
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Cantidad.ToString());
                item.SubItems.Add($"${precio:F2}");
                item.SubItems.Add($"${totalProducto:F2}");
                listView1.Items.Add(item);

                tot += totalProducto;
            }

            //Se calcula el impuesto y el total final
            impuesto = tot * 0.06;
            totFinal = tot + impuesto;

            lblSubtot.Text = "$ " + tot.ToString("N2"); //Nada más se muestran dos decimales
            lblIva.Text = "$ " + impuesto.ToString("N2");
            lblTot.Text = "$ " + totFinal.ToString("N2");
            if (totFinal == 0)
            {
                btnComprar.Enabled = false;
            }
        }
    }
}
