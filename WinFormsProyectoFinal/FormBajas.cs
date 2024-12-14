using MySql.Data.MySqlClient;
using OpenTK.Audio.OpenAL;
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
    public partial class FormBajas : Form
    {
        //Conexion conn1 = new Conexion();//variable que nos permite establecer la conexion con la base de datos
        Conexion conn = new Conexion();//variable que nos permite establecer la conexion con la base de datos



        public FormBajas()
        {
            InitializeComponent();
        }

        private void buttonLogoutB_Click(object sender, EventArgs e)
        {
            Form2 form2b = new Form2();
            form2b.Show();
            this.Hide();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from productos where id = @id", conn.conexionBD());
                cmd.Parameters.AddWithValue("@id", boxId.SelectedValue);
                MySqlDataReader lectura = cmd.ExecuteReader();//ejecutar una variable que leera la base de datos para encontrar el id buscado
                //si la variable esta leyendo
                if (lectura.Read())
                {
                    labelIDBus.Text = lectura["id"].ToString();
                    byte[] img = (byte[])lectura["imagen"];
                    labelDesBus.Text = lectura["descripcion"].ToString();
                    labelPrecioBus.Text = lectura["precio"].ToString();
                    labelExiBus.Text = lectura["existencias"].ToString();
                    labelVenBus.Text = lectura["ventas"].ToString();

                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from productos where id = @id", conn.conexionBD());
                cmd.Parameters.AddWithValue("@id", boxId.SelectedValue);//num que sera buscado para eliminar

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("El registro ha sido eliminado");
                }
                else
                {
                    MessageBox.Show("\"El id igresado no existe dentro de la BD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormBajas_Load(object sender, EventArgs e)
        {
            string query = "SELECT id FROM productos";
            boxId.DataSource = getData(query);
            boxId.ValueMember = "id";

            boxId_SelectedIndexChanged(null, null);
        }

        public DataTable getData(string query)
        {
            MySqlCommand comand = new MySqlCommand(query, conn.conexionBD());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void labelPrecioBus_Click(object sender, EventArgs e)
        {

        }

        private void labelExiBus_Click(object sender, EventArgs e)
        {

        }

        private void boxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(boxId.SelectedValue.ToString(), out val);
            //string query = "SELECT 'id', 'imagen', 'descripcion', 'precio', 'existencias', 'ventas' FROM 'productos' WHERE 'id' = " + val;

        }

        private void labelDesBus_Click(object sender, EventArgs e)
        {

        }
    }
}
