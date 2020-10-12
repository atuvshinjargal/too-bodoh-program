using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int i = 1;
        int s = 0;
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.FromArgb(255, 0, 0);
        }
        private void getRandomNumber()
        {
            int t = rnd.Next(100);
            label1.ForeColor = Color.FromArgb(rnd.Next(255), 
                                rnd.Next(255), rnd.Next(255));
            label1.Text = t.ToString();
            s += t; //2 6 1 7 9
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.getRandomNumber();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 10)
            {
                i++;
                this.getRandomNumber();
            }
            else
            {
                label1.Font = new Font("Arial", 100, FontStyle.Regular);
                label1.Text = s.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value * 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.ForeColor = Color.FromArgb(255,0,0);
            label1.Text = "start";
            s = 0;
            i = 0;
        }
    }
}
