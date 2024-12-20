﻿using MySql.Data.MySqlClient;
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
            //Abrir el explorador de archivos para insertar una imagen usando openFile
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al boton de inicio
            Form4 inicio = new Form4();
            inicio.Show();
            this.Close();
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexion conn = new Conexion();//variable que nos permite establecer la conexion con la base de datos
                MySqlConnection con = conn.conexionBD();
                string countRegistros = "select count(*) from productos ";
                MySqlCommand cmdContar = new MySqlCommand(countRegistros,con);
                int numRegistros = Convert.ToInt32(cmdContar.ExecuteScalar());
                if(numRegistros >= 10)
                {
                    MessageBox.Show("ERROR registro de productos superado");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    MySqlCommand cmd1 = new MySqlCommand("insert into productos (id,imagen,nombre,descripcion,precio,existencias,ventas) values (@id, @imagen, @nombre, @descripcion, @precio, @existencias, @ventas)", conn.conexionBD());
                    //Insertamos los valores en el formulario dentro de los campos de la base de datos
                    cmd1.Parameters.AddWithValue("@id", numId.Value);
                    cmd1.Parameters.AddWithValue("@imagen", img);
                    cmd1.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                    cmd1.Parameters.AddWithValue("@descripcion", richTextBoxAlDes.Text);
                    cmd1.Parameters.AddWithValue("@precio", textBoxAlPre.Text);
                    cmd1.Parameters.AddWithValue("@existencias", numExistencias.Value);
                    cmd1.Parameters.AddWithValue("@ventas", numVentas.Value);
                    cmd1.ExecuteNonQuery();//comando que da entender que no devuelve resultados, osea un conjunto de datos
                    MessageBox.Show("Se han agregado los datos");

                    //Regresar al boton de inicio
                    Form4 inicio = new Form4();
                    inicio.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormAltas_Load(object sender, EventArgs e)
        {

        }
    }
}
