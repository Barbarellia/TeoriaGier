using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TeoriaGierZapałki
{
    public partial class NIM1 : Form
    {
        public NIM1()
        {
            InitializeComponent();
        }



        private void button_back1_Click(object sender, EventArgs e)
        {
            var menu = new MainWindow();
            menu.Show();
            this.Hide();
        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            
            int numberOfMatches = Convert.ToInt32(numericUpDown_numberOfMatches.Value);
            string maximum = (numericUpDown_maximum.Value).ToString();
            label_max.Text = maximum;

            string[] list = Directory.GetFiles(@"D:\STUDIA\TeoriaGierZapałki\TeoriaGierZapałki", "*.png");
                PictureBox[] picturebox = new PictureBox[list.Length];
                int y = 0;
            
                for (int index = 0; index < picturebox.Length; index++)
                {
                    for (int match = 0; match < numberOfMatches; match++)
                    {
                         picturebox[index] = new PictureBox();
                         picturebox[index].Size = new Size(101, 50);
                         pictureBox1.Controls.Add(picturebox[index]);
                         picturebox[index].Location = new Point(match * 50 + 2, y);
                         picturebox[index].Size = new Size(50, 101);
                         picturebox[index].Image = Image.FromFile(list[index]);      
                    }
                }
        }



     
    }
}
