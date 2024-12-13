using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WinFormsProyectoFinal
{
    internal class Conexion
    {
        public MySqlConnection conexionBD()
        {
            MySqlConnection cadenaConexion = null;//declaramos una variable que nos ayude a conectarnos a la base de datos
            try
            {
                cadenaConexion = new MySqlConnection("server=localhost;database=proyectogina;uid=root;pwd='';port=3306");//datebase se pone el nombre de la base de datos que vamos a usar
                if (cadenaConexion.State == System.Data.ConnectionState.Closed)//si el estado de la conexion esta cerrada
                {
                    cadenaConexion.Open();//se abre la conexion
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());//si sucede un error nos muestra el error que estamos teniendo para acceder
            }
            return cadenaConexion;//retornamos la variable para asi poder usarla en cualquier form
        }
    }
}
