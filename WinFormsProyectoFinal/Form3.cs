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
            mostrarProductos();
        }
        private void mostrarProductos()
        {
            try
            {
                Conexion conexio = new Conexion();
                MySqlConnection con = conexio.conexionBD();

                string busqueda = "select id, imagen, descripcion, precio, existencias from productos";
                MySqlCommand cmd = new MySqlCommand(busqueda, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);//adaptador que nos ayudara a llenar la tabla con los datos de la base de datos ejecutando la busqueda 
                DataTable tabla = new DataTable();//creamos una tabla para mostrar los datos en el data grid view
                adapter.Fill(tabla);//mandamos al metodo de llenar y mandamos como parametro la tabla para ahi guardar los datos obtenidos
                dataGridViewProductos.DataSource = tabla;//asignamos la tabla al datagrid

                //configuracion para la columna que tendra la imagen
                if (dataGridViewProductos.Columns["imagen"] != null)
                {
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridViewProductos.Columns["imagen"];//se crea la columna de imagen
                    imageColumn = (DataGridViewImageColumn)dataGridViewProductos.Columns["imagen"];
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;//establecer su modo de visualizacion
                }
                dataGridViewProductos.CellFormatting += dataGridViewProductosCellFormatting;//asingarle al evento Cellformatting una funcion que transforma la imagen para mostrarla
                dataGridViewProductos.CellClick += dataGridViewProductosCellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewProductosCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //comprobar que la columna actual sea imagen y comprobar que el valor de la celda no este en nulo
            if (dataGridViewProductos.Columns[e.ColumnIndex].Name == "imagen" && e.Value != null)
            {
                byte[] imagenBytes = e.Value as byte[];//convertir el valor de la celda byte[] a imagen
                if (imagenBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        e.Value = Image.FromStream(ms);//asignacion de la imagen convertida a la celda
                    }
                }
            }
        }

        private void dataGridViewProductosCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];
                byte[] imagenBytes = row.Cells["imagen"].Value as byte[];
                Image imagen = transformacionImagen(imagenBytes);
                string descripcion = row.Cells["descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                int existencias = Convert.ToInt32(row.Cells["existencias"].Value);

                FormProducto formProducto = new FormProducto(imagen, descripcion, precio, existencias);
                formProducto.Show();
            }
        }
        private Image transformacionImagen(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

    }

}
