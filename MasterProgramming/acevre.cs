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
    public partial class acevre : Form
    {
        public acevre()
        {
            InitializeComponent();
        }

        private void acevre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void acevre_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(902, 626);
            tabControl1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double sayi1, sayi2, sayi3;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sayi3 = Convert.ToDouble(textBox3.Text);
                if (checkBox1.Checked == true)
                {
                    double alansonuc;
                    alansonuc = (sayi1 + sayi2 + sayi3) / 2;
                    MessageBox.Show("Verilen üçgenin alanı: " + alansonuc + "", "Alan Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else {
                    double cevresonuc;
                    cevresonuc = sayi1 + sayi2 + sayi3;
                    MessageBox.Show("Verilen üçgenin çevresi: " + cevresonuc + "", "Çevre Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            else {
                MessageBox.Show("Lütfen uzunlukları giriniz!", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                textBox1.Location = new Point(245, 287);
                

            }
            else {
                textBox1.Location = new Point(165, 190);
                checkBox2.Checked = true;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                checkBox1.Checked = true;
            }
            else {
                checkBox1.Checked = false;
            }
        }
    }
}
