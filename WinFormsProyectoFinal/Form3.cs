using Microsoft.VisualBasic.ApplicationServices;
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

namespace WinFormsProyectoFinal
{
    public partial class Form3 : Form
    {
        //lista de productos
        private List<Productos> productos = new List<Productos>();
        List<int> listaExistencias = new List<int>();
        bool[] band = new bool[10] { false, false, false, false, false, false, false, false, false, false };
        string nombreUsu;

        public Form3()
        {
            InitializeComponent();
            

        }

        public Form3(List<Productos> productosAct, bool[] bandAct, List<int> exist)
        {
            InitializeComponent();
            //inicializando la lista de productos
            productos = productosAct;
            band = bandAct;
            listaExistencias = exist;
        }

        public Form3(string nombreUusario)//constructor del form que recibe el nombre del usuario que accedio al punbto de venta
        {
            InitializeComponent();
            nombreUsu = nombreUusario; //Se manda el nombre de usuario del usuario actual
            labelNombreUsuario.Text = nombreUsu;

            Conexion con3 = new Conexion();
            MySqlConnection conexion = con3.conexionBD();

            //Se selecionan las existencias de cada producto para poder poder trabajar sobre ellas y no sobre la BD
            try
            {
                string consulta = "SELECT existencias FROM proyectogina.productos";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                MySqlDataReader lectura = cmd.ExecuteReader();//ejecutar una variable que leerá la base de datos para encontrar el id buscado

                //si la variable se esta leyendo se mandan las existencias a la lista
                while (lectura.Read())
                {
                    listaExistencias.Add(Convert.ToInt32(lectura["existencias"]));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            CargarProductos(); //Se llama al método de actuazliacion e inicializacion de productos

        }

        private void CargarProductos()
        {
            try
            {
                /*Cada vez que se ejecuta esta funcion se actualizan los productos del formualrio, si se ejecuta por primera vez
                 * se posicionan los productos en un lugar especfífico y dpeendiendo de la reduccion o el aumento de las existencias se
                 * van a poder hacer visible o no
                 * */
                Conexion connn = new Conexion();
                MySqlConnection conn = connn.conexionBD();

                string consulta = "SELECT id, imagen, nombre, precio, existencias FROM proyectogina.productos";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                //Se iniciailzan todos los espacios para los 10 productos (imagenes, titulo, precio y botones)
                List<PictureBox> pictureBoxes = new List<PictureBox> { imgProd1, pictureBox1, pictureBox2, pictureBox3, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
                List<Label> labels = new List<Label> { lblNombre1, label1, label2, label3, label4, label5, label6, label7, label8, label9 };
                List<PictureBox> agregarPic = new List<PictureBox> { agregar1, agregar2, agregar3, agregar4, agregar5, agregar6, agregar7, agregar8, agregar9, agregar10 };
                List<Label> preciosLbl = new List<Label> { label10, label11, label12, label13, label14, label15, label16, label17, label18, label19 };

                int index = 0;

                while (reader.Read() && index < pictureBoxes.Count)
                {
                    int existenciasActuales = listaExistencias[index]; 

                    if (existenciasActuales > 0)
                    {
                        //se carga la imagen
                        byte[] imgBytes = (byte[])reader["imagen"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureBoxes[index].Image = Image.FromStream(ms);
                        }

                        //Se visualizan los productos que estan disponlbles en la BD
                        pictureBoxes[index].Visible = true;
                        pictureBoxes[index].Tag = Convert.ToInt32(reader["id"]);
                        labels[index].Text = reader["nombre"].ToString();
                        labels[index].Visible = true;
                        preciosLbl[index].Text = reader["precio"].ToString();
                        preciosLbl[index].Visible = true;
                        agregarPic[index].Visible = true;
                    }
                    else
                    {
                        //Se deshabilitan los productos que NO estan disponlbles en la BD
                        preciosLbl[index].Visible = false;
                        pictureBoxes[index].Visible = false;
                        labels[index].Visible = false;
                        agregarPic[index].Visible = false;
                    }

                    index++;
                }

                //se ocultan controles restantes
                for (int i = index; i < pictureBoxes.Count; i++)
                {
                    preciosLbl[i].Visible = false;
                    pictureBoxes[i].Visible = false;
                    labels[i].Visible = false;
                    agregarPic[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void mostrarProductos()
        {

        }

        private void dataGridViewProductosCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridViewProductosCellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Usando la funcion de DateTime se obtiene la fecha y la hora y se inserta en labels
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void prod1_Enter(object sender, EventArgs e)
        {




        }

        public void mandar(int indice, string producto, Image imagenProd)
        {
            //Dependiendo de la imagen que se presione se van a mandar los datos del producto a un form que muestra más detalladamente el prod
            Conexion con2 = new Conexion();
            MySqlConnection conexion = con2.conexionBD();

            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from proyectogina.productos where nombre = @nombre", conexion);
                cmd.Parameters.AddWithValue("@nombre", producto);
                MySqlDataReader lectura = cmd.ExecuteReader();//ejecutar una variable que lee la DB para encontrar el id

                if (lectura.Read())
                {
                    //Se mandan los datos al form
                    string nombreUsuario = labelNombreUsuario.Text;
                    FormProducto formProducto = new FormProducto(imagenProd, lectura["nombre"].ToString(), lectura["descripcion"].ToString(), lectura["precio"].ToString(), listaExistencias[indice].ToString(), nombreUsuario);
                    formProducto.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imgProd1_Click(object sender, EventArgs e)
        {

        }
        //Cada imagen presionada manda el id, el nombre del producto y la imagen
        private void imgProd1_Click_1(object sender, EventArgs e)
        {
            mandar(0, lblNombre1.Text, imgProd1.Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mandar(1, label1.Text, pictureBox1.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mandar(2, label2.Text, pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mandar(3, label3.Text, pictureBox3.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mandar(4,label4.Text, pictureBox5.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mandar(5, label5.Text, pictureBox6.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mandar(6, label6.Text, pictureBox7.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            mandar(7, label7.Text, pictureBox8.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            mandar(8, label8.Text, pictureBox9.Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            mandar(9, label9.Text, pictureBox10.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Se manda al formulario del carrito
            Carrito formCarrito = new Carrito(productos, band, listaExistencias, nombreUsu);
            formCarrito.Show();
            this.Hide();
        }

        public void agregar(int indice, int idProd, string nombreProd, string precioProd)
        {
            //Dependiendo de que boton de agregar se preisone, y si se presionó por primera vez o no, se 
            //va a ejecutar un codigo que agrega por primera vez al producto a la lista y cambia la variable de boton preisonado a verdadero
            //o ejecuta el codigo que aumenta la cantidad del producto ya insertado 
            if (band[indice] == false)
            {
                band[indice] = true;
                int cantidad = 1;

                listaExistencias[indice] -= 1;//Se reducen las existencias

                //y se agrega el producto al carrito
                productos.Add(new Productos(indice, idProd, nombreProd, cantidad, precioProd));

                //Mnesaje de que se realizó la adicion
                MessageBox.Show($"Producto agregado: {nombreProd}, Cantidad: {cantidad}", "Nuevo Producto");
            }
            else
            {
                //si ya está el producto en el carrito nada mas se agrega 1 a la cantidad en lugar de volver a agregar el producto
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Id == idProd)
                    {
                        productos[i].Cantidad += 1; 
                        listaExistencias[indice] -= 1; //y se reducen las existencias

                        MessageBox.Show($"Cantidad actualizada: {productos[i].Nombre}");
                        break;
                    }
                }
            }

            //Pero si las existencias llegaron a 0 se muestra un mensaje y se vuelve a cargar los productos para mostrar el cambio
            if (listaExistencias[indice] <= 0)
            {
                listaExistencias[indice] = 0; 
                MessageBox.Show($"{nombreProd} se agotó y será removido.", "Producto agotado");
            }

            CargarProductos();
        }


        //Dependiendo de que btotn de agregar se preisone se manda el indice del botonPresionado, el id del producto
        //el nombre dle producto y el precio
        private void agregar1_Click(object sender, EventArgs e)
        {
            agregar(0, (int)imgProd1.Tag, lblNombre1.Text, label10.Text);
        }

        private void agregar2_Click(object sender, EventArgs e)
        {
            agregar(1, (int)pictureBox1.Tag, label1.Text, label11.Text);
        }

        private void agregar3_Click(object sender, EventArgs e)
        {
            agregar(2, (int)pictureBox2.Tag, label2.Text, label12.Text);
        }

        private void agregar4_Click(object sender, EventArgs e)
        {
            agregar(3, (int)pictureBox3.Tag, label3.Text, label13.Text);
        }

        private void agregar5_Click(object sender, EventArgs e)
        {
            agregar(4, (int)pictureBox5.Tag, label4.Text, label14.Text);
        }

        private void agregar6_Click(object sender, EventArgs e)
        {
            agregar(5, (int)pictureBox6.Tag, label5.Text, label15.Text);
        }

        private void agregar7_Click(object sender, EventArgs e)
        {
            agregar(6, (int)pictureBox7.Tag, label6.Text, label16.Text);
        }

        private void agregar8_Click(object sender, EventArgs e)
        {
            agregar(7, (int)pictureBox8.Tag, label7.Text, label17.Text);
        }

        private void agregar9_Click(object sender, EventArgs e)
        {
            agregar(8, (int)pictureBox9.Tag, label8.Text, label18.Text);
        }

        private void agregar10_Click(object sender, EventArgs e)
        {
            agregar(9, (int)pictureBox10.Tag, label9.Text, label19.Text);
        }

        private void agregar3_Click_1(object sender, EventArgs e)
        {
            agregar(2, (int)pictureBox2.Tag, label2.Text, label12.Text);
        }

        private void agregar4_Click_1(object sender, EventArgs e)
        {
            agregar(3, (int)pictureBox3.Tag, label3.Text, label13.Text);
        }

        private void agregar3_Click_2(object sender, EventArgs e)
        {
            agregar(2, (int)pictureBox2.Tag, label2.Text, label12.Text);
        }
    }

}
