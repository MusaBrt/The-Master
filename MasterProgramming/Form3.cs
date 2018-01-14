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
            e.Handled = Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar);
        }

        bool toplama = false;
        double sayi1top;
        bool top2 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (label4.Text == "0")
                {
                    sayi1top = Convert.ToDouble(textBox1.Text);

                    textBox1.Text = "";
                    label1.Text = "+ ";
                    toplama = true;
                }
                else if (label4.Text != "0") {
                    sayi1top = Convert.ToDouble(label4.Text);
                    textBox1.Text = "";
                    label1.Text = "+ ";
                    top2 = true;
                }
            }

        }
        double sayi2top;
        double sayi2cik;
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (toplama == true)
                {
                    double sonuc;
                    sayi2top = Convert.ToDouble(textBox1.Text); 
                    sonuc = sayi1top + sayi2top;
                    label4.Text = "" + sonuc;
                    
                    toplama = false;
                    
                }
                else if (top2 == true) {
                    double sonuc;
                    sayi2top = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1top + sayi2top;
                    label4.Text = "" + sonuc;
                    
                    top2 = false;
                }
                else if (cik2 == true)
                {
                    double sonuc;
                    sayi2cik = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1cik - sayi2cik;

                    label4.Text = "" + sonuc;
                    
                    cik2 = false;
                }
                else if (cikarma == true)
                {
                    double sonuc;


                    sayi2cik = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1cik - sayi2cik;

                    label4.Text = "" + sonuc;
                    
                    cikarma = false;
                }
                else if (carpma == true)
                {
                    double sonuc;
                    double sayi2carp;

                    sayi2carp = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1carp * sayi2carp;
                    label4.Text = "" + sonuc;
                    
                    carpma = false;

                }
                else if (carp2 == true) {
                    double sonuc;
                    double sayi2carp;
                    sayi2carp = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1carp * sayi2carp;
                    label4.Text = "" + sonuc;
                    carp2 = false;

                    
                }
                else if (bolme == true)
                {
                    double sonuc;
                    double sayi2bol;

                    sayi2bol = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1bol / sayi2bol;
                    label4.Text = "" + sonuc;

                    bolme = false;
                }
                else if (bol2 == true) {
                    double sonuc;
                    double sayi2bol;
                    sayi2bol = Convert.ToDouble(textBox1.Text);
                    sonuc = sayi1bol / sayi2bol;
                    label4.Text = "" + sonuc;
                    bol2 = false;
                }
                else if (uslu == true)
                {
                    double sonuc;
                    int us2;

                    us2 = Convert.ToInt32(textBox1.Text);
                    sonuc = Math.Pow(us1, us2);
                    label4.Text = "" + sonuc;

                    uslu = false;
                }
                else if (uss2 == true) {
                    double sonuc;
                    int us2;
                    us2 = Convert.ToInt32(textBox1.Text);
                    sonuc = Math.Pow(us1, us2);
                    label4.Text = "" + sonuc;
                    uss2 = false;
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
        bool cikarma = false;
        bool cik2 = false;
        double sayi1cik;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (label4.Text == "0")
                {
                    sayi1cik = Convert.ToDouble(textBox1.Text);
                    cikarma = true;
                    textBox1.Text = "";
                    label1.Text = "- ";
                }
                else if (label4.Text != "0") {
                    sayi1cik = Convert.ToDouble(label4.Text);
                    cik2 = true;
                    textBox1.Text = "";
                    label1.Text = "- ";
                }
            }
            



        }
        double sayi1carp;
        bool carpma = false;
        bool carp2 = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (label4.Text == "0")
                {
                    sayi1carp = Convert.ToDouble(textBox1.Text);
                    carpma = true;
                    textBox1.Text = "";
                    label1.Text = "x ";
                }
                else if (label4.Text != "0") {
                    sayi1carp = Convert.ToDouble(label4.Text);
                    carp2 = true;
                    textBox1.Text = "";
                    label1.Text = "x ";
                }


            }
        }
        double sayi1bol;
        bool bolme = false;
        bool bol2 = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (label4.Text == "0")
                {
                    sayi1bol = Convert.ToDouble(textBox1.Text);
                    bolme = true;
                    textBox1.Text = "";
                    label1.Text = "/ ";
                }
                else if (label4.Text != "0") {
                    sayi1bol = Convert.ToDouble(label4.Text);
                    bol2 = true;
                    textBox1.Text = "";
                    label1.Text = "/ ";
                }
                
            
            
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
            if (textBox1.Text != "")
            {
                if (label4.Text == "0")
                {
                    double sayi, faktoriyel = 1;

                    sayi = Convert.ToDouble(textBox1.Text); // Dışarıdan aldığımız string sayısını int’e çeviriyoruz.
                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel *= i; // her döngüde faktöriyel i ile çarpılıyor.
                    }
                    label4.Text = faktoriyel.ToString();
                }
                else if (label4.Text != "0") {
                    double sayi, faktoriyel = 1;
                    sayi = Convert.ToDouble(label4.Text);
                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel *= i; // her döngüde faktöriyel i ile çarpılıyor.
                    }
                    label4.Text = faktoriyel.ToString();

                }
            }
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
            toplama = false;
            cikarma = false;
            carpma = false;
            bolme = false;
            uslu = false;
            eksi = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            

            
            if (textBox1.Text != "") {

                if (textBox1.Text == "+ ")
                {
                    
                }

                else if (textBox1.Text != "")
                {

                    if (textBox1.Text == "-")
                    {
                        object sayi;
                        string son;
                        sayi = Convert.ToString(textBox1.Text);

                        son = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

                        textBox1.Text = son;
                        eksi = false;
                    }
                    else {
                        object sayi;
                        string son;

                        sayi = textBox1.Text;

                        son = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

                        textBox1.Text = son;
                    }
                }
                

                else
                {

                }
                
                
            }

            
            
            
        }
        bool eksi = false;
        private void button16_Click(object sender, EventArgs e)
        {
            if (eksi == false) {
                if (textBox1.Text == "")
                {
                    string sayi;

                    sayi = Convert.ToString(textBox1.Text);
                    textBox1.Text = "-" + sayi;
                    eksi = true;
                }
                else if (textBox1.Text != "") {
                    double sayi = 0;

                    sayi = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "-" + sayi;
                    eksi = true;
                }
            }
        }
        int us1 = 0;
        bool uslu = false;
        bool uss2 = false;
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (label4.Text == "0")
                {
                    us1 = Convert.ToInt32(textBox1.Text);
                    uslu = true;
                    textBox1.Text = "";
                    label1.Text = "Üs";
                }
                else if (label4.Text != "0") {
                    us1 = Convert.ToInt32(label4.Text);
                    uss2 = true;
                    textBox1.Text = "";
                    label1.Text = "Üs";
                }

            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { }
            else
            {
                textBox1.Text += ",";
            }
        }
    }
}
