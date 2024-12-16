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
        bool[] band;

        public Form3()
        {
            InitializeComponent();
            band = new bool[10] { false, false, false, false, false, false, false, false, false, false };

        }

        public Form3(List<Productos> productosAct, bool[] bandAct)
        {
            InitializeComponent();
            //inicializando la lista de productos
            productos = productosAct;
            band = bandAct;
        }

        public Form3(string nombreUusario)//constructor del form que recibe el nombre del usuario que accedio al punbto de venta
        {
            InitializeComponent();
            labelNombreUsuario.Text = nombreUusario;



        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            //mostrarProductos();
            try
            {

                Conexion connn = new Conexion();
                MySqlConnection conn = connn.conexionBD();

                // Consulta para obtener los datos
                string consulta = "SELECT id, imagen, nombre, existencias FROM proyectogina.productos";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);


                MySqlDataReader reader = cmd.ExecuteReader();

                List<PictureBox> pictureBoxes = new List<PictureBox> { imgProd1, pictureBox1, pictureBox2, pictureBox3, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
                List<Label> labels = new List<Label> { lblNombre1, label1, label2, label3, label4, label5, label6, label7, label8, label9 };
                List<PictureBox> agregarPic = new List<PictureBox> { agregar1, agregar2, agregar3, agregar4, agregar5, agregar6, agregar7, agregar8, agregar9, agregar10 };
                List<int> listaExistencias = new List<int>();

                int index = 0;

                while (reader.Read() && index < pictureBoxes.Count)
                {
                    listaExistencias.Add(Convert.ToInt32(reader["existencias"]));
                    if (Convert.ToInt32(reader["existencias"]) > 0)
                    {

                        byte[] imgBytes = (byte[])reader["imagen"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureBoxes[index].Image = Image.FromStream(ms);
                        }
                        pictureBoxes[index].Visible = true; //hace visible la imagen
                        pictureBoxes[index].Tag = Convert.ToInt32(reader["id"]); //hace visible la imagen
                        labels[index].Text = reader["nombre"].ToString();
                        labels[index].Visible = true; //hace visible el Label

                        agregarPic[index].Visible = true;
                        index++;
                    }
                    else
                    {
                        agregarPic[index].Visible = false;
                        pictureBoxes[index].Visible = false;
                        labels[index].Visible = false;
                    }

                }
                int[] vectorExistencias = listaExistencias.ToArray();
                //oculta controles restantes
                for (int i = index; i < pictureBoxes.Count; i++)
                {
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
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void prod1_Enter(object sender, EventArgs e)
        {




        }

        public void mandar(string producto, Image imagenProd)
        {
            Conexion con2 = new Conexion();
            MySqlConnection conexion = con2.conexionBD();

            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from proyectogina.productos where nombre = @nombre", conexion);
                cmd.Parameters.AddWithValue("@nombre", producto);
                MySqlDataReader lectura = cmd.ExecuteReader();//ejecutar una variable que leera la base de datos para encontrar el id buscado
                //si la variable esta leyendo
                if (lectura.Read())
                {
                    string nombreUsuario = labelNombreUsuario.Text;
                    FormProducto formProducto = new FormProducto(imagenProd, lectura["nombre"].ToString(), lectura["descripcion"].ToString(), lectura["precio"].ToString(), lectura["existencias"].ToString(),nombreUsuario);
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

        private void imgProd1_Click_1(object sender, EventArgs e)
        {
            mandar(lblNombre1.Text, imgProd1.Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mandar(label1.Text, pictureBox1.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mandar(label2.Text, pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mandar(label3.Text, pictureBox3.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mandar(label4.Text, pictureBox5.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mandar(label5.Text, pictureBox6.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mandar(label6.Text, pictureBox7.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            mandar(label7.Text, pictureBox8.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            mandar(label8.Text, pictureBox9.Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            mandar(label9.Text, pictureBox10.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Carrito formCarrito = new Carrito(productos, band);
            formCarrito.Show();
            this.Hide();
        }

        public void agregar(int indice, int idProd, string nombreProd)
        {
            if (band[indice] == false)
            {
                band[indice] = true;
                //agregar un nuevo producto desde controles del formulario
                int id = idProd;
                string nombre = nombreProd;
                int cantidad = 1;

                productos.Add(new Productos(id, nombre, cantidad));
                MessageBox.Show($"Producto agregado: {nombre}, Cantidad: {cantidad}", "Nuevo Producto");
            }
            else
            {
                // Buscar el producto por ID en la lista y actualizar su cantidad
                int id = idProd;
                bool encontrado = false;

                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Id == id)
                    {
                        productos[i].Cantidad += 1; // Incrementar la cantidad
                        encontrado = true;

                        // Mensaje de confirmación o actualización de la interfaz
                        MessageBox.Show($"Cantidad actualizada: {productos[i].Nombre}, Nueva Cantidad: {productos[i].Cantidad}", "Cantidad Incrementada");
                        break;
                    }
                }
            }
        }


        private void agregar1_Click(object sender, EventArgs e)
        {
            agregar(0, (int)imgProd1.Tag, lblNombre1.Text);
        }

        private void agregar2_Click(object sender, EventArgs e)
        {
            agregar(1, (int)pictureBox1.Tag, label1.Text);
        }

        private void agregar3_Click(object sender, EventArgs e)
        {
            agregar(2, (int)pictureBox2.Tag, label2.Text);
        }

        private void agregar4_Click(object sender, EventArgs e)
        {
            agregar(3, (int)pictureBox3.Tag, label3.Text);
        }

        private void agregar5_Click(object sender, EventArgs e)
        {
            agregar(4, (int)pictureBox5.Tag, label4.Text);
        }

        private void agregar6_Click(object sender, EventArgs e)
        {
            agregar(5, (int)pictureBox6.Tag, label5.Text);
        }

        private void agregar7_Click(object sender, EventArgs e)
        {
            agregar(6, (int)pictureBox7.Tag, label6.Text);
        }

        private void agregar8_Click(object sender, EventArgs e)
        {
            agregar(7, (int)pictureBox8.Tag, label7.Text);
        }

        private void agregar9_Click(object sender, EventArgs e)
        {
            agregar(8, (int)pictureBox9.Tag, label8.Text);
        }

        private void agregar10_Click(object sender, EventArgs e)
        {
            agregar(9, (int)pictureBox10.Tag, label9.Text);
        }

        private void agregar3_Click_1(object sender, EventArgs e)
        {
            agregar(2, (int)pictureBox2.Tag, label2.Text);
        }

        private void agregar4_Click_1(object sender, EventArgs e)
        {
            agregar(3, (int)pictureBox3.Tag, label3.Text);
        }

        private void agregar3_Click_2(object sender, EventArgs e)
        {
            agregar(2, (int)pictureBox2.Tag, label2.Text);
        }
    }

}
