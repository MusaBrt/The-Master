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
                ((TextBox)this.Controls["textBox" + (a).ToString()]).Text = onek + kutu + sonek;
                satir = Convert.ToString(((TextBox)this.Controls["textBox" + (a).ToString()]).Text);
                kaydet.WriteLine(Convert.ToString(satir));
                a--;
            }
            kaydet.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer hepsinin aynı parametrelerden oluşmasını istiyorsanız sadece ilk 2 sini doldurmanız yeter.\nAma istemiyorsanız hepsini doldurabilirsiniz. (Doldurmadığınız alanlar boş çıkacak.)", "Text Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip yeni = new ToolTip();
            yeni.SetToolTip(this.button1, "Girdiğiniz metinleri değiştirme işlemini başlatır.");
            yeni.ToolTipTitle = "Çalıştır!";

            yeni.AutoPopDelay = 5000;
            yeni.InitialDelay = 1000;
            yeni.ReshowDelay = 500;
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\TextFormatter.txt"))
            {
                string yol = @"C:\Windows\Temp\TextFormatter.txt";
                File.Delete(yol);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            File.Delete(@"C:\Windows\Temp\TextFormatter.txt");
        }

        private void teks_keypress(object sender, KeyPressEventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Title = "Çıktı txt kaydet";
            sv.Filter = "(*.txt)|*.txt|Tüm dosyalar(*.*)|*.*";
            sv.FilterIndex = 1;
            sv.InitialDirectory = "C:\\";
            sv.ShowDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                string yol1 = @"C:\Windows\Temp\TextKaydet.txt";
                FileStream oku = new FileStream(yol1, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                FileStream son = new FileStream(sv.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter yaz = new StreamWriter(son);
                StreamReader okut = new StreamReader(oku);
                string yazi = okut.ReadLine();
                for (int i = 0; i < yazi.Length; i++)
                {
                    yaz.WriteLine(Convert.ToString(yazi));
                    yazi = okut.ReadLine();
                }
                yaz.Close();

            }
            else {
                MessageBox.Show("Dosyanız kaydedilmedi!", "Text Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void texter_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}