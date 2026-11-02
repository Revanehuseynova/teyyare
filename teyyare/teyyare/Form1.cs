using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace teyyare
{
    public partial class Form1 : Form
    {
        bool k = false;

        SoundPlayer spEnis = new SoundPlayer(Properties.Resources.inishazirliklari);
        SoundPlayer spTurbulans = new SoundPlayer(Properties.Resources.turbulans);
        SoundPlayer spKemer = new SoundPlayer(Properties.Resources.kemerler);
        SoundPlayer spTesekkur = new SoundPlayer(Properties.Resources.tesekkurler);
        SoundPlayer spBeep = new SoundPlayer(Properties.Resources.beep);
        SoundPlayer spIsiq = new SoundPlayer(Properties.Resources.isikacmakapamasesi);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button8.Text = "OFF";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spEnis.Play();
            MessageBox.Show("Eniş hazırlığı");
            spEnis.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spTurbulans.Play();

            for (int i = 0; i < 4; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
                Thread.Sleep(40);
                Application.DoEvents();

                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                Thread.Sleep(40);
                Application.DoEvents();
            }

            MessageBox.Show("Turbulans");
            spTurbulans.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spKemer.Play();
            MessageBox.Show("Kəmərlər");
            spKemer.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spTesekkur.Play();
            MessageBox.Show("Təşəkkürlər");
            spTesekkur.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spBeep.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 20)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 20);
            }
            else
            {
                MessageBox.Show("Way end");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 362)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 20);
            }
            else
            {
                MessageBox.Show("Way end");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            spIsiq.Play();

            if (k == false)
            {
                k = true;
                button8.Text = "ON";
                pictureBox2.Visible = true;
            }
            else
            {
                k = false;
                button8.Text = "OFF";
                pictureBox2.Visible = false;
            }
        }
    }
}