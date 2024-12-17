using System;
using System.Media;
using System.Numerics;

namespace WinFormsProyectoFinal
{
    public partial class Form1 : Form
    {
        //Reproductor compartido entre formularios
        private static SoundPlayer player;
        private static bool playing = true; //Bandera para saber si la m�sica est� sonando

        public Form1()
        {
            InitializeComponent();
            //Reproduce m�sica de club penguin c:
            PlayMusic("musicaProyecto.wav");
        }

        public static void PlayMusic(string path)
        {
            //Se usa un try catch para reproducir la musica por si no se encunetra en los archivos
            try
            {
                player = new SoundPlayer(path);
                player.PlayLooping(); //Se reproduce en bucle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form22 = new Form2();//crear una nueva instancia de la forma2
            form22.Show();//mostramos la nueva forma
            this.Hide();//ocultamos la forma 1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        // M�todos est�ticos para pausar y reanudar la m�sica
        public static void stop()
        {
            if (playing)
            {
                player.Stop();
                playing = false;
            }
        }

        public static void play()
        {
            if (!playing)
            {
                player.PlayLooping();
                playing = true;
            }
        }

        private void labelProfesor_Click(object sender, EventArgs e)
        {

        }
    }
}
