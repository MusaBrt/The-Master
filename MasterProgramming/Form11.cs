using System;
using System.IO;
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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Temp\TextFormatter.txt"))
            {
                File.Delete(@"C:\Windows\Temp\TextFormatter.txt");
                StreamWriter txt = File.CreateText(@"C:\Windows\Temp\TextFormatter.txt");
                txt.Close();
                
            }
            else {
                StreamWriter txt = File.CreateText(@"C:\Windows\Temp\TextFormatter.txt");
                txt.Close();
            }
            string onek;
            string sonek;
            onek = textBox1.Text;
            sonek = textBox2.Text;
            string yol = @"C:\Windows\Temp\TextFormatter.txt";
            FileStream oku = new FileStream(yol, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter yaz = new StreamWriter(oku);
            yaz.WriteLine(onek);
            yaz.WriteLine(sonek);
            MessageBox.Show("Kayıt işlemi başarılı!", "Text Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            yaz.Close();
            oku.Close();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
