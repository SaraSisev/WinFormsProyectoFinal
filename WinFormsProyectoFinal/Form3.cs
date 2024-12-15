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

        public Form3()
        {
            InitializeComponent();
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
                string consulta = "SELECT id, imagen, nombre, descripcion, precio, existencias FROM proyectogina.productos";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);


                MySqlDataReader reader = cmd.ExecuteReader();

                // Listas de PictureBox y Label
                List<PictureBox> pictureBoxes = new List<PictureBox> { imgProd1, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
                List<Label> labels = new List<Label> { lblNombre1, label1, label2, label3, label4, label5, label6, label7, label8, label9 };

                int index = 0;

                // Iterar sobre los datos de la base de datos
                while (reader.Read() && index < pictureBoxes.Count)
                {
                    // Mostrar imagen
                    byte[] imgBytes = (byte[])reader["imagen"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        pictureBoxes[index].Image = Image.FromStream(ms);
                    }
                    pictureBoxes[index].Visible = true; // Hacer visible el PictureBox

                    // Mostrar descripción
                    labels[index].Text = reader["nombre"].ToString();
                    labels[index].Visible = true; // Hacer visible el Label

                    index++;
                }

                // Ocultar controles restantes
                for (int i = index; i < pictureBoxes.Count; i++)
                {
                    pictureBoxes[i].Visible = false;
                    labels[i].Visible = false;
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
        private Image transformacionImagen(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
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

                    FormProducto formProducto = new FormProducto(imagenProd, lectura["nombre"].ToString(), lectura["descripcion"].ToString(), lectura["precio"].ToString(), lectura["existencias"].ToString());
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
            mandar(label4.Text, pictureBox4.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mandar(label5.Text, pictureBox5.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mandar(label6.Text, pictureBox6.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            mandar(label7.Text, pictureBox7.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            mandar(label8.Text, pictureBox8.Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            mandar(label9.Text, pictureBox9.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Carrito formCarrito = new Carrito();
            formCarrito.Show();
            this.Close();
        }
    }

}
