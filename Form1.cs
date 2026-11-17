
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TopTutmaOyunu
{
    public partial class Form1 : Form
    {
        int xal = 0;
        int suret = 6;
        bool asagi = true;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 20;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            xal = 0;
            label1.Text = "Xal: 0";

            panel1.Left = (ClientSize.Width - panel1.Width) / 2;

            pictureBox1.Left = random.Next(
                20, ClientSize.Width - pictureBox1.Width - 20);

            pictureBox1.Top = 60;

            asagi = true;
            suret = 6;

            timer1.Start();

            buttonStart.Visible = false;
            ActiveControl = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (asagi == true)
            {
            
                pictureBox1.Top = pictureBox1.Top + suret;

             
                if (pictureBox1.Bottom >= panel1.Top &&
                    pictureBox1.Bottom <= panel1.Top + suret + 2 &&
                    pictureBox1.Right > panel1.Left &&
                    pictureBox1.Left < panel1.Right)
                {
              
                    asagi = false;

                    xal = xal + 1;
                    label1.Text = "Xal: " + xal;
                }

              
                if (pictureBox1.Top > ClientSize.Height)
                {
                    timer1.Stop();

                    MessageBox.Show("Oyun bitdi! Xalınız: " + xal,
                        "Oyun bitdi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    buttonStart.Visible = true;
                    buttonStart.Text = "Yenidən başla";

                    pictureBox1.Top = 40;
                    asagi = true;
                }
            }
            else
            {
              
                pictureBox1.Top = pictureBox1.Top - suret;

             
                if (pictureBox1.Bottom <= 0)
                {
                    pictureBox1.Top = 40;

                    pictureBox1.Left = random.Next(
                        20, ClientSize.Width - pictureBox1.Width - 20);

                    asagi = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && panel1.Left > 0)
            {
                panel1.Left = panel1.Left - 20;
            }

            if (e.KeyCode == Keys.Right &&
                panel1.Right < ClientSize.Width)
            {
                panel1.Left = panel1.Left + 20;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
