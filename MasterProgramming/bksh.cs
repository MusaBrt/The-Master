﻿using System;
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
    public partial class bksh : Form
    {
        public bksh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }
        double sayi1 = 0, sayi2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("Sayı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Sayı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else {

                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);

                if  (sayi1 > sayi2) {
                    MessageBox.Show("Büyük olan sayı = " + sayi1, "Büyük", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                }
                else if (sayi2 > sayi1) {
                    MessageBox.Show("Büyük olan sayı = " + sayi2, "Büyük", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                
            }
        }

        private void bksh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void teksbax_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kb kb = new kb();
            kb.Show();
            this.Hide();
        }
        
    }
}
