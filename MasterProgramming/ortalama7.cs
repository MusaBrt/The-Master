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
    public partial class ortalama7 : Form
    {
        public ortalama7()
        {
            InitializeComponent();
        }

        private void ortalama7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 lobi = new Form1();
            lobi.Show();
            this.Hide();
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        double sayi1 = 0, sayi2 = 0, sayi3 = 0, sayi4 = 0, sayi5 = 0, sayi6 = 0, sayi7 = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            double sonuc = 0;

            if (textBox1.Text == "") {
                label4.Text = "Boş";
            }
            else if (textBox2.Text == "") {
                label4.Text = "Boş";
            }
            else if (textBox3.Text == "") {
                label4.Text = "Boş";
            }
            else if (textBox4.Text == "") {
                label4.Text = "Boş";
            }
            else if (textBox5.Text == ""){
                label4.Text = "Boş";
            }
            else if (textBox6.Text == "")
            {
                label4.Text = "Boş";
            }
            else if (textBox7.Text == "")
            {
                label4.Text = "Boş";
            }
            else
            {

                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sayi3 = Convert.ToDouble(textBox3.Text);
                sayi4 = Convert.ToDouble(textBox4.Text);
                sayi5 = Convert.ToDouble(textBox5.Text);
                sayi6 = Convert.ToDouble(textBox6.Text);
                sayi7 = Convert.ToDouble(textBox7.Text);

                sonuc = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7) / 7;

                label4.Text = "" + sonuc;
            }
        }
    }
}
