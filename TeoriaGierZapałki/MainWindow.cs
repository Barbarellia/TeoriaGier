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
    public partial class MainWindow : Form
    {
        NIM1 gra1 = new NIM1();
        NIM2 gra2 = new NIM2();
        NIM3 gra3 = new NIM3();
        

        public MainWindow()
        {
            InitializeComponent();
            //var wybor = new MainWindow();
        }

        private void button_NIM1_Click(object sender, EventArgs e)
        {
            gra1.Show();
            this.Hide();
        }

        private void button_NIM2_Click(object sender, EventArgs e)
        {
            gra2.Show();
            this.Hide();
        }

        private void button_NIM3_Click(object sender, EventArgs e)
        {
            gra3.Show();
            this.Hide();
        }
    }
}
