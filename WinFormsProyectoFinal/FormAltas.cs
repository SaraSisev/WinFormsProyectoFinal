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
            try
            {
                Conexion conn = new Conexion();//variable que nos permite establecer la conexion con la base de datos
                conn.conexionBD();//llamamos al metodo que conecta a la base de datos
                MySqlCommand cmd1 = new MySqlCommand("insert into productos (id,imagen,descripcion,precio,existencias) values (@id, @imagen, @descripcion, @precio, @existencias)", conn.conexionBD());
                cmd1.Parameters.AddWithValue("@id", textBoxAlID);
                //cmd1.Parameters.AddWithValue("@imagen", );
                cmd1.Parameters.AddWithValue("@descripcion", richTextBoxAlDes.Text);
                cmd1.Parameters.AddWithValue("@precio", textBoxAlPre.Text);
                cmd1.Parameters.AddWithValue("@existencias", textBoxAlExi.Text);
                cmd1.ExecuteNonQuery();//comando que da entender que no devuelve resultados, osea un conjunto de datos
                MessageBox.Show("Se han agregado los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
