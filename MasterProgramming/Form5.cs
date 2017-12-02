using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterProgramming
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ortalama2 ort2 = new ortalama2();
            ort2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ortalama3 ort3 = new ortalama3();
            ort3.Show();
            this.Hide();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ortalama4 ort4 = new ortalama4();
            ort4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ortalama5 ort5 = new ortalama5();
            ort5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ortalama6 ort6 = new ortalama6();
            ort6.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ortalama8 ort8 = new ortalama8();
            ort8.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ortalama7 ort7 = new ortalama7();
            ort7.Show();
            this.Hide();
        }
    }
}
