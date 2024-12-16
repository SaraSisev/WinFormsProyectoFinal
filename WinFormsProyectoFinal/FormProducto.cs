using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{
    public partial class FormProducto : Form
    {
        private string nombreUsuario;
        public FormProducto()
        {
            InitializeComponent();
        }
        public FormProducto(Image imagen, string nombres, string descripcion, string precio, string existencias,string NombreUsuario)
        {
            InitializeComponent();
            pictureBoxImagenProd.Image = imagen;
            lblNombreProd.Text = nombres;
            labelDescripcionProd.Text = descripcion;
            labelPrecioProd.Text = precio;
            labelExistenciasProd.Text = existencias;
            this.nombreUsuario = NombreUsuario;

        }
        private void FormProducto_Load(object sender, EventArgs e)
        {
            labelNombreUsu.Text = nombreUsuario;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al boton de inicio
            this.Close();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            int existencias = int.Parse(labelExistenciasProd.Text);
            decimal gastado = decimal.Parse(labelPrecioProd.Text);

            if (existencias > 0)//condicional para comporbar que las existencias no esten en 0
            {
                try
                {
                    //parte para actualizar las existencias en la base de datos
                    Conexion conection = new Conexion();
                    MySqlConnection con = conection.conexionBD();
                    string nuevaExi = "update productos set existencias = existencias -1 where nombre = @nombre";
                    MySqlCommand cmd = new MySqlCommand(nuevaExi, con);
                    cmd.Parameters.AddWithValue("@nombre", lblNombreProd.Text);
                    cmd.ExecuteNonQuery();
                    //parte para aumentar el monto en la tabla de cuentas del usuario 
                    string nuevoMonto = "update cuentas set monto = monto + @monto where nombre = @nombreUsuario";
                    MySqlCommand cmd2 = new MySqlCommand(nuevoMonto, con);
                    cmd2.Parameters.AddWithValue("@monto", gastado);
                    cmd2.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd2.ExecuteNonQuery();
                    labelExistenciasProd.Text = (existencias - 1).ToString();
                    //parte del codigo para aumentar la venta del producto
                    string nuevaVenta = "update productos set ventas = ventas +1 where nombre = @nombre";
                    MySqlCommand cmd3 = new MySqlCommand(nuevaVenta, con);
                    cmd3.Parameters.AddWithValue("@nombre", lblNombreProd.Text);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Compra realizada con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Producto agotado");
            }
        }
    }
}
