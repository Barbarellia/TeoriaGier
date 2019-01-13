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
        public int Sum = 0;

        public NIM1()
        {
            InitializeComponent();
        }

        private void FillPicturebox(int matchesNumber)
        {
            string[] list = Directory.GetFiles(@"D:\STUDIA\TeoriaGierZapałki\TeoriaGierZapałki", "*.png");
            PictureBox[] picturebox = new PictureBox[list.Length];
            int y = 0;

            int index = 1;
            for (int match = 0; match < matchesNumber; match++)
            {
                picturebox[index] = new PictureBox();
                int fittedWidth = pictureBox1.Width / matchesNumber;

                picturebox[index].Size = new Size(101, fittedWidth);
                pictureBox1.Controls.Add(picturebox[index]);
                picturebox[index].Location = new Point(match * fittedWidth + 2, y);
                picturebox[index].Size = new Size(fittedWidth, 101);
                picturebox[index].Image = Image.FromFile(list[index]);
            }
        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            var menu = new MainWindow();
            menu.Show();
            this.Hide();
        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Controls.Count != 0)
                pictureBox1.Controls.Clear();
            

            int numberOfMatches = Convert.ToInt32(numericUpDown_numberOfMatches.Value);
            label_number.Text = numberOfMatches.ToString();
            string maximum = (numericUpDown_maximum.Value).ToString();
            label_max.Text = maximum;

            FillPicturebox(numberOfMatches);
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            int maximum = Convert.ToInt32(label_max.Text);
            int matchesToRemove = Convert.ToInt32(numericUpDown_choice.Value);
            int matches = Convert.ToInt32(label_number.Text);

            if ((matches - Sum) >= matchesToRemove)
            {
                if (matchesToRemove <= maximum)
                {
                    Sum += matchesToRemove;
                    if (pictureBox1.Controls.Count != 0)
                        pictureBox1.Controls.Clear();
                    FillPicturebox(matches - Sum);
                    label_action.Text = "You take " + matchesToRemove.ToString() +" matches";
                }
            }

        }
    }
}
