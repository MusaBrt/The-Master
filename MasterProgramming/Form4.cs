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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        double sayi1 = 0, sayi2 = 0;
        double cevre = 0;
        double alan = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") {
                MessageBox.Show("Sayı Girmediniz!" , "Hata" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Sayı Girmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                cevre = (sayi1 * 2) + (sayi2 * 2);
                alan = sayi1 * sayi2;
                if (checkBox1.Checked == true) MessageBox.Show("   Çevre = " + cevre + "\n   Alan = " + alan + " m²", "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (checkBox2.Checked == true) MessageBox.Show("   Çevre = " + cevre + "\n   Alan = " + alan + " cm²", "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (checkBox1.Checked == false)
                {
                    if (checkBox2.Checked == false)
                    {
                        MessageBox.Show("   Çevre = " + cevre, "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                MessageBox.Show("Arkaplan rengini başarıyla değiştirdin.", "Renk Değiştirme");
            }
            if (tus == DialogResult.Cancel)
            {
                MessageBox.Show("Arkaplan rengini değiştirmediniz.", "Renk Değiştirme");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
