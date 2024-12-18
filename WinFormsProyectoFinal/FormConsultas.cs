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
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }

        private void buttonLogoutC_Click(object sender, EventArgs e)
        {
            Form2 form2c = new Form2();
            form2c.Show();
            this.Hide();
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            ventasTotales();
            productosMasVendidos();
            mejoresClientes();
        }
        private void ventasTotales()
        {
            try
            {
                Conexion con = new Conexion();
                MySqlConnection conn = con.conexionBD();

                string consulta = "select sum(monto) as ventasTotales from cuentas";//sintaxis qu eindica que se realalizara una suma de los montos registrados
                MySqlCommand cmd = new MySqlCommand(consulta, conn);

                object resultado = cmd.ExecuteScalar();
                //condicional para comprobar si el resultado no es nulo(ninguna venta)
                if (resultado != DBNull.Value)
                {
                    decimal totalVentas = Convert.ToDecimal(resultado);
                    labelVentasTotales.Text = $"Ventas Totales: ${totalVentas:N2}";//N indica los decimales a tomar en cuenta
                }
                else//entonces fue nulo y mostramos que no hay ventas registradas
                {
                    labelVentasTotales.Text = "Ventas Totales: $0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void productosMasVendidos()
        {
            try
            {
                Conexion con = new Conexion();
                MySqlConnection conn = con.conexionBD();
                string consultaProductos = "select nombre, ventas from productos ORDER BY ventas DESC";
                MySqlCommand cmd = new MySqlCommand(consultaProductos, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dataGridViewProductosOrdenados.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mejoresClientes()
        {
            try
            {
                Conexion con = new Conexion();
                MySqlConnection conn = con.conexionBD();
                string consultaCuentas = "select nombre, monto from cuentas where nombre <> 'admin' ORDER BY monto DESC";
                MySqlCommand cmd = new MySqlCommand(consultaCuentas, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dataGridViewMejoresCli.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Regresar al boton de inicio
            Form4 inicio = new Form4();
            inicio.Show();
            this.Close();
        }
    }
}
