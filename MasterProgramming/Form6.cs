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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        double tekba = 0;
        double tekbasonuc = 0;

        double sayi1 = 0, sayi2 = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                tekba = Convert.ToDouble(textBox1.Text);
                tekbasonuc = (tekba / 100) * 1;
                label4.Text = "" + tekbasonuc;
            }
            else
            {
                label4.Text = "0";
            }

        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double sonuc1 = 0;
                double sonuc2 = 0;

                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);

                sonuc1 = sayi1 / 100;
                sonuc2 = sonuc1 * sayi2;

                MessageBox.Show(" Ana sayı = " + sayi1 + "\n İstenilen % değeri = " + sayi2 + "\n Sonuc = " + sonuc2, "Yüzde Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Sayı girmediniz!", "Yüzde Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
