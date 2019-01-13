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
    public partial class NIM2 : Form
    {
        public int Sum = 0;

        public NIM2()
        {
            InitializeComponent();
        }


        private void FillPicturebox(int rows, int matches, int rowRemove, int matchRemove)
        {
            string[] list = Directory.GetFiles(@"D:\STUDIA\TeoriaGierZapałki\TeoriaGierZapałki", "*.png");
            PictureBox[,] picturebox = new PictureBox[rows,matches];
            int index = 0;
            int[,] arrayOfMatches = new int[matches, rows];

            if (rowRemove == 0 && matchRemove == 0)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int i = 0; i < matches; i++)
                    {
                        arrayOfMatches[i, j] = 1;
                    }
                }
            }


            if (rowRemove != 0 && matchRemove != 0)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int i = 0; i < matches; i++)
                    {
                        if (j == (rowRemove - 1))
                        {
                            for (int k = 0; k < matchRemove; k++)
                                arrayOfMatches[matches - k - 1, j] = 0;
                            for (int k = matchRemove; k < matches; k++)
                            {
                               
                                    arrayOfMatches[matches - k - 1, j] = 1;
                            }

                        }
                        else
                        {
                            if (arrayOfMatches[i, j] != 0)
                                arrayOfMatches[i, j] = 1;
                        }
                        
                    }

                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int match = 0; match < matches; match++)
                {
                    picturebox[row, match] = new PictureBox();
                    int fittedWidth = pictureBox1.Width / rows;
                    int fittedHeight = pictureBox1.Height / matches;
                    picturebox[row, match].Size = new Size(fittedHeight, fittedWidth);
                    pictureBox1.Controls.Add(picturebox[row, match]);
                    picturebox[row, match].Location = new Point(row * fittedWidth + 2, match * fittedHeight + 2);
                    picturebox[row, match].Size = new Size(fittedWidth, fittedHeight);
                    index = arrayOfMatches[match, row];
                    picturebox[row, match].Image = Image.FromFile(list[index]);
                }
            }
     
        }

        private void button_back2_Click(object sender, EventArgs e)
        {
            var menu = new MainWindow();
            menu.Show();
            this.Hide();
        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Controls.Count != 0)
                pictureBox1.Controls.Clear();
            
            int numberOfRows = Convert.ToInt32(numericUpDown_n.Value);
            int matches = Convert.ToInt32(numericUpDown_k.Value);

            label_rows.Text = numberOfRows.ToString();
            label_matches.Text = matches.ToString();

            FillPicturebox(numberOfRows, matches, 0, 0);
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            int matches = Convert.ToInt32(label_matches.Text);
            int rows = Convert.ToInt32(label_rows.Text);
            int matchesToRemove = Convert.ToInt32(numericUpDown_howMany.Value);
            int row = Convert.ToInt32(numericUpDown_whichRow.Value);

            if (pictureBox1.Controls.Count != 0)
                pictureBox1.Controls.Clear();

            if (row <= rows)
            {
                if (matchesToRemove <= matches)
                {
                        FillPicturebox(rows, matches, row, matchesToRemove);
                        label_action.Text = "You take " + matchesToRemove.ToString() + " matches from row number " +
                        row.ToString();
                    
                }
                
            }

        }
    }
}
