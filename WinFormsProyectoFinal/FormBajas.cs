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
    public partial class FormBajas : Form
    {
        public FormBajas()
        {
            InitializeComponent();
        }

        private void buttonLogoutB_Click(object sender, EventArgs e)
        {
            Form2 form2b = new Form2();
            form2b.Show();
            this.Hide();
        }
    }
}
