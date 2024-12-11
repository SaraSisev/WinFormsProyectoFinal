namespace WinFormsProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            Form2 form22 = new Form2();//crear una nueva instancia de la forma2
            form22.Show();//mostramos la nueva forma
            this.Hide();//ocultamos la forma 1
        }
    }
}
