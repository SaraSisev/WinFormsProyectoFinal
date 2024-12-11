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
    }
}
