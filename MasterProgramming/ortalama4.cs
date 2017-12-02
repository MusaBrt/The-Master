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
    public partial class ortalama4 : Form
    {
        public ortalama4()
        {
            InitializeComponent();
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 lobi = new Form5();
            lobi.Show();
            this.Hide();
        }

        double sayi1 = 0, sayi2 = 0, sayi3 = 0, sayi4 = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            double sonuc = 0;

            if (textBox1.Text == "")
            {
                label4.Text = "Boş";
            }
            else if (textBox2.Text == "")
            {
                label4.Text = "Boş";
            }
            else if (textBox3.Text == "")
            {
                label4.Text = "Boş";
            }
            else if (textBox4.Text == "")
            {
                label4.Text = "Boş";
            }
            else
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sayi3 = Convert.ToDouble(textBox3.Text);
                sayi4 = Convert.ToDouble(textBox4.Text);

                sonuc = (sayi1 + sayi2 + sayi3 + sayi4) / 4;

                label4.Text = "" + sonuc;
            }
        }

        private void ortalama4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 anan = new Form5();
            anan.Show();
            this.Hide();
        }
    }
}
