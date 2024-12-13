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
    public partial class FormAltas : Form
    {
        public FormAltas()
        {
            InitializeComponent();
        }

        private void buttonLogoutA_Click(object sender, EventArgs e)
        {
            Form2 form2a = new Form2();
            form2a.Show();
            this.Hide();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form4 inicio = new Form4();
            inicio.Show();
            this.Close();
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexion conn = new Conexion();//variable que nos permite establecer la conexion con la base de datos
                conn.conexionBD();//llamamos al metodo que conecta a la base de datos
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand cmd1 = new MySqlCommand("insert into productos (id,imagen,descripcion,precio,existencias,ventas) values (@id, @imagen, @descripcion, @precio, @existencias, @ventas)", conn.conexionBD());
                cmd1.Parameters.AddWithValue("@id", numId.Value);
                cmd1.Parameters.AddWithValue("@imagen", img);
                cmd1.Parameters.AddWithValue("@descripcion", richTextBoxAlDes.Text);
                cmd1.Parameters.AddWithValue("@precio", textBoxAlPre.Text);
                cmd1.Parameters.AddWithValue("@existencias", numExistencias.Value);
                cmd1.Parameters.AddWithValue("@ventas", numVentas.Value);
                cmd1.ExecuteNonQuery();//comando que da entender que no devuelve resultados, osea un conjunto de datos
                MessageBox.Show("Se han agregado los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
