using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MasterProgramming
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string yol = @"C:\Windows\Temp\TextFormatter.txt";
            if (File.Exists(yol))
            {

                string yol1 = @"C:\Windows\Temp\TextKaydet.txt";
                FileStream oku = new FileStream(yol, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader okut = new StreamReader(oku);
                string onek = okut.ReadLine();
                string sonek = okut.ReadLine();
                int a = 32;
                FileStream yaz = new FileStream(yol1, FileMode.OpenOrCreate);
                StreamWriter kaydet = new StreamWriter(yaz);
                string satir;
                for (int i = 0; i < 16; i++)
                {
                    string kutu = ((TextBox)this.Controls["textBox" + (i + 1).ToString()]).Text;
                    string yazi = onek + kutu + sonek;
                    byte[] utyaz = System.Text.Encoding.UTF8.GetBytes(yazi);
                    string sonyazi = System.Text.Encoding.UTF8.GetString(utyaz);
                    ((TextBox)this.Controls["textBox" + (a).ToString()]).Text = sonyazi;
                    satir = Convert.ToString(((TextBox)this.Controls["textBox" + (a).ToString()]).Text);
                    kaydet.WriteLine(Convert.ToString(satir));
                    a--;
                }
                kaydet.Dispose();
                okut.Dispose();
                oku.Dispose();
                yaz.Dispose();
                

            }
            else {
                MessageBox.Show("Lütfen ekleri ayarlayınız.", "Text Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer hepsinin aynı parametrelerden oluşmasını istiyorsanız sadece ilk 2 sini doldurmanız yeter.\nAma istemiyorsanız hepsini doldurabilirsiniz. (Doldurmadığınız alanlar boş çıkacak.)", "Text Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form11 f2 = new Form11();
            f2.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, EventArgs e)
        {
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (File.Exists(@"C:\Windows\Temp\TextFormatter.txt"))
            {
                if (File.Exists(@"C:\Windows\Temp\TextKaydet.txt"))
                {
                    string yol2 = @"C:\Windows\Temp\TextKaydet.txt";
                    File.Delete(yol2);
                }

                string yol = @"C:\Windows\Temp\TextFormatter.txt";
                File.Delete(yol);
            }
            else if (File.Exists(@"C:\Windows\Temp\TextKaydet.txt")) {
                string yol = @"C:\Windows\Temp\TextKaydet.txt";
                File.Delete(yol);
            }
            Application.Exit();
        }

        private void teks_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                gecis();
            }
            if (e.KeyChar == 22)
            {
                if (Clipboard.GetText().Contains("\n"))
                {
                    string[] dizi = new string[0];
                    dizi = Clipboard.GetText().Split('\n');
                    for (int i = 0; i < dizi.Length; i++) {
                        try
                        {
                            ((TextBox)this.Controls["textBox" + (i + 1).ToString()]).Text = dizi[i].ToString();
                        }
                        catch {
                            MessageBox.Show("textbox bitti");
                            break;
                        }
                    }
                    e.Handled = true;
                }
            }
        }
        private void gecis() {
            /*if (this.ActiveControl == textBox1) {
                this.ActiveControl = textBox2;
            }
            else if (this.ActiveControl == textBox2) {
                this.ActiveControl = textBox3;
            }
            else if (this.ActiveControl == textBox3) {
                this.ActiveControl = textBox4;
            }
            else if (this.ActiveControl == textBox4) { 
                this.ActiveControl = textBox5;
            }
            else if (this.ActiveControl == textBox5) {
                this.ActiveControl = textBox6;   
            }
            else if (this.ActiveControl == textBox6) {
                this.ActiveControl = textBo7; 
            }
             
             
             */
            for (int i = 0; i <= 16; i++) {
                if (this.ActiveControl == (TextBox)this.Controls["textBox" + (i + 1).ToString()]) {
                    this.ActiveControl = (TextBox)this.Controls["textBox" + (i + 2).ToString()];
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string yol1 = @"C:\Windows\Temp\TextKaydet.txt";
            FileStream oku = new FileStream(yol1, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader okut = new StreamReader(oku);
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (File.Exists(desktop + @"\TextKaydet.txt"))
            {
                File.Move(desktop + @"\TextKaydet.txt", desktop + @"\OldTextKaydet.txt");
                File.Copy(yol1, desktop + @"\TextKaydet.txt");
            }
            else
            {
                File.Copy(yol1, desktop + @"\TextKaydet.txt");
            }
            oku.Dispose();
            okut.Dispose();
        }

        private void texter_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            ToolTip yeni = new ToolTip();
            yeni.SetToolTip(this.button1, "Girdiğiniz metinleri değiştirme işlemini başlatır.");
            yeni.ToolTipTitle = "Çalıştır!";

            yeni.AutoPopDelay = 5000;
            yeni.InitialDelay = 1000;
            yeni.ReshowDelay = 500;

            ToolTip but3 = new ToolTip();
            but3.SetToolTip(this.button3, "Ön ek ve son ekleri değiştirmenizi sağlayacak olan pencere açılır.");
            but3.ToolTipTitle = "Düzenle!";

            but3.AutoPopDelay = 5000;
            but3.InitialDelay = 1000;
            but3.ReshowDelay = 500;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 16; i++) {
                ((TextBox)this.Controls["textBox" + (i + 1).ToString()]).Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
        }

    }
}