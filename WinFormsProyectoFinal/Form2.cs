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
    public partial class Form2 : Form
    {
        string cuentasRegistradas;//variable que almacena las cuentas registradas en la base de datos
        string contrasRegistradas;//variable que almacena las contrasenas registradas en la base de datos
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {//al momento de querer ingresar se establece la conexion con la base de datos
            try
            {
                Conexion conection = new Conexion();//variable que nos permite establecer la conexion con la base de datos
                conection.conexionBD();//llamamos al metodo que conecta a la base de datos
                MySqlCommand cmd = new MySqlCommand("select * from cuentas", conection.conexionBD());
                MySqlDataReader reader = cmd.ExecuteReader();
                bool cuentaValida = false;
                string rol = "admin";//variable que almacena el rol del ingresado ( si es admin o un usuario)
                //ciclo para leer los datos dentro de la base de datos
                while (reader.Read())//va ir pasando fila por fila para asi ir comprobando fila por fila 
                {
                    cuentasRegistradas = reader["cuenta"].ToString();//leer el campo de cuenta y almacenarlo para asi despues comprobar que coincida
                    contrasRegistradas = reader["contrasena"].ToString();//leer el campo de contrasena y almacenarlo para asi depues comprobar que coincida
                    //si lo escrito en los textbox de cuenta y contrasena coinciden con alguna cuenta registrada en la base de datos
                    if (textBoxCuenta.Text == cuentasRegistradas && textBoxConstrasena.Text == contrasRegistradas)
                    {
                        cuentaValida = true;//indica que la cuenta si existe ya que se encontro
                        break;//salir de bucle cuando se encuentra la cuenta deseada
                    }
                }
                if (cuentaValida)
                {
                    //si la cuenta encontrada es del admin se abre el form4
                   if (cuentasRegistradas == rol)
                   {
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                   }
                   else//si la cuenta encontrada es de algun usuario se abre el form 3
                   {
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                   }
                }
                else
                {
                    MessageBox.Show(" ERROR Cuenta no encontrada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());//mostrar si hay algun error 
            }
         }
         
    }
}
