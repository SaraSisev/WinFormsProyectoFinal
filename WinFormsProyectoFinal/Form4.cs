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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonAltas_Click(object sender, EventArgs e)
        {
            FormAltas formaltas = new FormAltas();//crear instancia del form de altas
            formaltas.Show();
            this.Hide();
        }

        private void buttonBajas_Click(object sender, EventArgs e)
        {
            FormBajas formBajas = new FormBajas();
            formBajas.Show();
            this.Hide();
        }

        private void buttonListado_Click(object sender, EventArgs e)
        {
            FormListado formListado = new FormListado();
            formListado.Show();
            this.Hide();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            formConsultas.Show();
            this.Hide();
        }

        private void buttonGrafica_Click(object sender, EventArgs e)
        {
            FormGrafica formGrafica = new FormGrafica();
            formGrafica.Show();
            this.Hide();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            //Se puede controlar la musica usando los metodos del form1
            if (btnMusica.Text == "Pausar Música")
            {
                Form1.stop();
                btnMusica.Text = "Reanudar Música";
            }
            else
            {
                Form1.play();
                btnMusica.Text = "Pausar Música";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2a = new Form2();
            form2a.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
