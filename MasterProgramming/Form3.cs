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
    public partial class Form3 : Form
    {

       

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);

            if (textBox1.Text != "(")
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
            // && !char.IsControl(e.KeyChar);
            //  || textBox2.Text != "(" || textBox1.Text != ")" || textBox2.Text != ")"

        }

        int toplama = 0;
        double sayi1top;

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                sayi1top = Convert.ToDouble(textBox1.Text);

                textBox1.Text = "";
                label1.Text = "+ ";


                toplama += 1;
            }

        }
        double sayi2top;
        double sayi2cik;
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (toplama == 1)
                {
                    double sonuc;
                    


                    sayi2top = Convert.ToDouble(textBox1.Text); 

                    sonuc = sayi1top + sayi2top;

                    label4.Text = "" + sonuc;
                    
                }
                else if (cikarma == 1) {
                    double sonuc;
                    

                    sayi2cik = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1cik - sayi2cik;

                    label4.Text = "" + sonuc;
                    
                }
                else if (carpma == 1) {
                    double sonuc;
                    double sayi2carp;

                    sayi2carp = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1carp * sayi2carp;
                    label4.Text = "" + sonuc;
                    
                }
                else if (bolme == 1) {
                    double sonuc;
                    double sayi2bol;

                    sayi2bol = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1bol / sayi2bol;
                    label4.Text = "" + sonuc;
                }
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int cikarma = 0;
        double sayi1cik;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                
                sayi1cik = Convert.ToDouble(textBox1.Text);
                cikarma += 1;
                textBox1.Text = "";
                label1.Text = "- ";
            }



        }
        double sayi1carp;
        int carpma = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                sayi1carp = Convert.ToDouble(textBox1.Text);
                carpma += 1;
                textBox1.Text = "";
                label1.Text = "x ";

            }
        }
        double sayi1bol;
        int bolme = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                sayi1bol = Convert.ToDouble(textBox1.Text);
                bolme += 1;
                textBox1.Text = "";
                label1.Text = "/ ";
            }

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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double sayi1 = 0;
            double sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sqrt(sayi1);
            label4.Text = "" + sonuc;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double sayi, faktoriyel = 1;

            sayi = Convert.ToDouble(textBox1.Text); // Dışarıdan aldığımız string sayısını int’e çeviriyoruz.
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i; // her döngüde faktöriyel i ile çarpılıyor.
            }
            label4.Text = faktoriyel.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            label4.Text = "0";
            toplama = 0;
            cikarma = 0;
            carpma = 0;
            bolme = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            

            
            if (textBox1.Text != "") {

                if (textBox1.Text == "+ ")
                {
                    
                }

                else if (textBox1.Text != "")
                {
                    double sayi;
                    string son;

                    sayi = Convert.ToDouble(textBox1.Text);

                    son = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

                    textBox1.Text = son;
                }

                else { 
                    
                }
                
            }

            
            
            
        }
        int eksi = 0;
        private void button16_Click(object sender, EventArgs e)
        {
            if (eksi == 0) {
                double sayi = 0;

                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "-" + sayi;
                eksi += 1;
            }
        }

        
    }
}
