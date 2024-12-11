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
    public partial class FormListado : Form
    {
        public FormListado()
        {
            InitializeComponent();
        }

        private void buttonLogoutL_Click(object sender, EventArgs e)
        {
            Form2 form2l = new Form2();
            form2l.Show();
            this.Hide();
        }
    }
}
