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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                double cevresonuc, alansonuc, sayi1, sayi2, sayi3, sayi4;
                sayi1 = Convert.ToDouble(textBox4.Text);
                sayi2 = Convert.ToDouble(textBox5.Text);
                sayi3 = Convert.ToDouble(textBox6.Text);
                sayi4 = Convert.ToDouble(textBox7.Text);
                cevresonuc = sayi1 + sayi2 + sayi3 + sayi4;
                alansonuc = sayi2 * sayi4;
                MessageBox.Show("Verilen dörtgenin çevresi= " + cevresonuc + "\nVerilen dörtgenin alanı= " + alansonuc + "", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                MessageBox.Show("Lütfen uzunlukları giriniz!", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clear() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox9.Text != "")
            {
                double sayi1, sayi2, cevresonuc, alansonuc;
                sayi1 = Convert.ToDouble(textBox8.Text);
                sayi2 = Convert.ToDouble(textBox9.Text);
                cevresonuc = 5 * sayi1;
                alansonuc = 5 * ((sayi1 * sayi2) / 2);
                MessageBox.Show("Verilen beşgenin çevresi= " + cevresonuc + "\nVerilen beşgenin alanı= " + alansonuc + "", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Lütfen uzunlukları giriniz!", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox11.Text != "")
            {
                double sayi1 = Convert.ToDouble(textBox10.Text), sayi2 = Convert.ToDouble(textBox11.Text);
                double cevresonuc = sayi2 * 6;
                double alansonuc = 6 * ((sayi1 * sayi2) / 2);
                MessageBox.Show("Verilen altıgenin çevresi= " + cevresonuc + "\nVerilen altıgenin alanı= " + alansonuc + "", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                MessageBox.Show("Lütfen uzunlukları giriniz!", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e) 
        { 
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox12.Text != "" && textBox13.Text != "")
            {
                double sayi1 = Convert.ToDouble(textBox12.Text), sayi2 = Convert.ToDouble(textBox13.Text);
                double cevresonuc = sayi2 * 8;
                double alansonuc = 8 * ((sayi1 * sayi2) / 2);
                MessageBox.Show("Verilen sekizgenin çevresi= " + cevresonuc + "\nVerilen sekizgenin alanı= " + alansonuc + "", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Lütfen uzunlukları giriniz!", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yedigenin alan hesaplama förmülü uzundu üşendim. Ama uğraşıcam!", "Alan Çevre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
