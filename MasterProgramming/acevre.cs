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
        
        private void büyükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.Visible == true)
            {
                
                tabControl1.Visible = false;
                tabControl2.Visible = true;
                this.Size = new System.Drawing.Size(1073, 674);
            }
            else if (tabControl1.Visible == false) { 
                
            }
        }

        private void küçükToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tabControl2.Visible == true) {
                tabControl1.Visible = true;
                tabControl2.Visible = false;
                this.Size = new System.Drawing.Size(745, 571);
            }
            else if (tabControl2.Visible == false) { 
                
            }
        }

        private void acevre_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(745, 571);
            tabControl1.Visible = true;
            tabControl2.Visible = false;
        }
    }
}
