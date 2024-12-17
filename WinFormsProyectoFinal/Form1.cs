using System;
using System.Media;

namespace WinFormsProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //PlayMusic("musicaProyecto.mp3");
        }

            /*public static void PlayMusic(string path)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Play();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form22 = new Form2();//crear una nueva instancia de la forma2
            form22.Show();//mostramos la nueva forma
            this.Hide();//ocultamos la forma 1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
