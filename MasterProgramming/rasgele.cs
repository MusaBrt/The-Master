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
    public partial class rasgele : Form
    {
        public rasgele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                label4.Text = "Boş";
            }
            else if (textBox2.Text == "")
            {
                label4.Text = "Boş";
            }
            else
            {
                int sayi1, sayi2;
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                if (sayi1 > sayi2) {
                    Random rnd = new Random();
                    double random = rnd.Next(sayi2, sayi1);

                    label4.Text = random.ToString();
                }
                else if (sayi2 > sayi1) {
                    Random rnd = new Random();
                    double random = rnd.Next(sayi1, sayi2);

                    label4.Text = random.ToString();
                }
            }
        }

        private void rasgele_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
        private void keydown(object sender, KeyEventArgs e)
        {

        }
    }
}
