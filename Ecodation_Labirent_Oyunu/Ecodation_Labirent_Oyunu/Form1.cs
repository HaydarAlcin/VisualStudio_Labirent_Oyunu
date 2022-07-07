using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecodation_Labirent_Oyunu
{
    public partial class Form1 : Form
    {
        //MOUSE ENTER OLAYININ ANLATIMI İÇİN YAPILAN BASİT BİR OYUN


        int time = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara Çarptın Oyunu Kaybettin!");
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label47.Text = Convert.ToString(time);
            if (time==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süre Bitti Oyunu Kaybettin!");
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("TEBRİKLER OYUNU KAZANDIN!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
           
        }
    }
}
