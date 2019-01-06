using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeoriaGierZapałki
{
    public partial class NIM3 : Form
    {
        //wybor powrot = new wybor();

        public NIM3()
        {
            InitializeComponent();
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            var menu = new MainWindow();
            menu.Show();
            this.Hide();
        }
    }
}
