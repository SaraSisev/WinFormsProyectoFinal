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
    public partial class FormListado : Form
    {
        
        public FormListado()
        {
            InitializeComponent();
            
        }

        private void buttonLogoutL_Click(object sender, EventArgs e)
        {
            Form2 form2l = new Form2();
            form2l.Show();
            this.Hide();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion(); //Conexion a la base de datos
                MySqlDataAdapter da;
                MySqlConnection conn = con.conexionBD();

                string consulta = "SELECT * FROM proyectogina.productos ORDER BY existencias ASC";//sintaxis que indica que se realizará una extracción de todos los datos de la base de datos productos
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                da = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable(); //Crear una tabla nueva para el dataGridView
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 70; //Altura de las 
                
                dataGridView1.AllowUserToAddRows = false;

                da.Fill(table); //Agregamos los datos a la tabla
                dataGridView1.DataSource = table; 


                // Ajustar automáticamente el ancho de todas las columnas según el contenido más largo
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                DataGridViewImageColumn imageColum = new DataGridViewImageColumn();
                imageColum = (DataGridViewImageColumn)dataGridView1.Columns[1];
                imageColum.ImageLayout = DataGridViewImageCellLayout.Stretch;
                
                //Imagen
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Desactivar el ajuste automático
                dataGridView1.Columns[1].Width = 75; // Establecer el ancho específico

                //Descripcion
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Desactivar el ajuste automático
                dataGridView1.Columns[3].Width = 298; // Establecer el ancho específico
                dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Configurar la columna específica

                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form4 inicio = new Form4();
            inicio.Show();
            this.Close();
        }
    }
}
