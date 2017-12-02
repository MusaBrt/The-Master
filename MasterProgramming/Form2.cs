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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Text = "Adana";
                label6.Text = "1";
                label7.Text = "322";
                label9.Text = "2.201.670";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Text = "Adıyaman";
                label6.Text = "2";
                label7.Text = "416";
                label9.Text = "610.484";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Text = "Afyonkarahisar";
                label6.Text = "3";
                label7.Text = "272";
                label9.Text = "714.523";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Text = "Ağrı";
                label6.Text = "4";
                label7.Text = "472";
                label9.Text = "542.255";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                label5.Text = "Amasya";
                label6.Text = "5";
                label7.Text = "358";
                label9.Text = "326.351";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                label5.Text = "Ankara";
                label6.Text = "6";
                label7.Text = "312";
                label9.Text = "5.346.518";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                label5.Text = "Antalya";
                label6.Text = "7";
                label7.Text = "242";
                label9.Text = "2.328.555";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                label5.Text = "Artvin";
                label6.Text = "8";
                label7.Text = "466";
                label9.Text = "168.068";
            }
            if (comboBox1.SelectedIndex == 8)
            {
                label5.Text = "Aydın";
                label6.Text = "9";
                label7.Text = "256";
                label9.Text = "1.068.260";
            }
            if (comboBox1.SelectedIndex == 9)
            {
                label5.Text = "Balıkesir";
                label6.Text = "10";
                label7.Text = "266";
                label9.Text = "1.196.176";
            }
            if (comboBox1.SelectedIndex == 10)
            {
                label5.Text = "Bilecik";
                label6.Text = "11";
                label7.Text = "228";
                label9.Text = "218.297";
            }
            if (comboBox1.SelectedIndex == 11)
            {
                label5.Text = "Bingöl";
                label6.Text = "12";
                label7.Text = "426";
                label9.Text = "269.560";
            }
            if (comboBox1.SelectedIndex == 12)
            {
                label5.Text = "Bitlis";
                label6.Text = "13";
                label7.Text = "434";
                label9.Text = "341.225";
            }
            if (comboBox1.SelectedIndex == 13)
            {
                label5.Text = "Bolu";
                label6.Text = "14";
                label7.Text = "474";
                label9.Text = "299.896";
            }
            if (comboBox1.SelectedIndex == 14)
            {
                label5.Text = "Burdur";
                label6.Text = "15";
                label7.Text = "248";
                label9.Text = "261.401";
            }
            if (comboBox1.SelectedIndex == 15)
            {
                label5.Text = "Bursa";
                label6.Text = "16";
                label7.Text = "224";
                label9.Text = "2.901.396";
            }
            if (comboBox1.SelectedIndex == 16)
            {
                label5.Text = "Çanakkale";
                label6.Text = "17";
                label7.Text = "286";
                label9.Text = "519.763";
            }
            if (comboBox1.SelectedIndex == 17)
            {
                label5.Text = "Çankırı";
                label6.Text = "18";
                label7.Text = "376";
                label9.Text = "183.880";
            }
            if (comboBox1.SelectedIndex == 18)
            {
                label5.Text = "Çorum";
                label6.Text = "19";
                label7.Text = "364";
                label9.Text = "527.863";
            }
            if (comboBox1.SelectedIndex == 19)
            {
                label5.Text = "Denizli";
                label6.Text = "20";
                label7.Text = "258";
                label9.Text = "1.005.687";
            }
            if (comboBox1.SelectedIndex == 20)
            {
                label5.Text = "Diyarbakır";
                label6.Text = "21";
                label7.Text = "412";
                label9.Text = "1.673.119";
            }
            if (comboBox1.SelectedIndex == 21)
            {
                label5.Text = "Edirne";
                label6.Text = "22";
                label7.Text = "284";
                label9.Text = "401.701";
            }
            if (comboBox1.SelectedIndex == 22)
            {
                label5.Text = "Elazığ";
                label6.Text = "23";
                label7.Text = "424";
                label9.Text = "578.789";
            }
            if (comboBox1.SelectedIndex == 23)
            {
                label5.Text = "Erzincan";
                label6.Text = "24";
                label7.Text = "446";
                label9.Text = "225.032";
            }
            if (comboBox1.SelectedIndex == 24)
            {
                label5.Text = "Erzurum";
                label6.Text = "25";
                label7.Text = "442";
                label9.Text = "762.021";
            }
            if (comboBox1.SelectedIndex == 25)
            {
                label5.Text = "Eskişehir";
                label6.Text = "26";
                label7.Text = "222";
                label9.Text = "844.842";
            }
            if (comboBox1.SelectedIndex == 26)
            {
                label5.Text = "Gaziantep";
                label6.Text = "27";
                label7.Text = "342";
                label9.Text = "1.974.244";
            }
            if (comboBox1.SelectedIndex == 27)
            {
                label5.Text = "Giresun";
                label6.Text = "28";
                label7.Text = "454";
                label9.Text = "444.467";
            }
            if (comboBox1.SelectedIndex == 28)
            {
                label5.Text = "Gümüşhane";
                label6.Text = "29";
                label7.Text = "456";
                label9.Text = "172.034";
            }
            if (comboBox1.SelectedIndex == 29)
            {
                label5.Text = "Hakkari";
                label6.Text = "30";
                label7.Text = "438";
                label9.Text = "267.813";
            }
            if (comboBox1.SelectedIndex == 30)
            {
                label5.Text = "Hatay";
                label6.Text = "31";
                label7.Text = "326";
                label9.Text = "1.555.165";
            }
            if (comboBox1.SelectedIndex == 31)
            {
                label5.Text = "Isparta";
                label6.Text = "32";
                label7.Text = "246";
                label9.Text = "427.324";
            }
            if (comboBox1.SelectedIndex == 32)
            {
                label5.Text = "İçel (Mersin)";
                label6.Text = "33";
                label7.Text = "324";
                label9.Text = "1.773.852";
            }
            if (comboBox1.SelectedIndex == 33)
            {
                label5.Text = "İstanbul";
                label6.Text = "34";
                label7.Text = "212 - 216";
                label9.Text = "14.804.116";
            }
            if (comboBox1.SelectedIndex == 34)
            {
                label5.Text = "İzmir";
                label6.Text = "35";
                label7.Text = "232";
                label9.Text = "4.223.545";
            }
            if (comboBox1.SelectedIndex == 35)
            {
                label5.Text = "Kars";
                label6.Text = "36";
                label7.Text = "474";
                label9.Text = "289.786";
            }
            if (comboBox1.SelectedIndex == 36)
            {
                label5.Text = "Kastamonu";
                label6.Text = "37";
                label7.Text = "366";
                label9.Text = "376.945";
            }
            if (comboBox1.SelectedIndex == 37)
            {
                label5.Text = "Kayseri";
                label6.Text = "38";
                label7.Text = "352";
                label9.Text = "1.358.980";
            }
            if (comboBox1.SelectedIndex == 38)
            {
                label5.Text = "Kırklareli";
                label6.Text = "39";
                label7.Text = "288";
                label9.Text = "351.684";
            }
            if (comboBox1.SelectedIndex == 39)
            {
                label5.Text = "Kırşehir";
                label6.Text = "40";
                label7.Text = "386";
                label9.Text = "229.975";
            }
            if (comboBox1.SelectedIndex == 40)
            {
                label5.Text = "Kocaeli";
                label6.Text = "41";
                label7.Text = "262";
                label9.Text = "1.830.772";
            }
            if (comboBox1.SelectedIndex == 41)
            {
                label5.Text = "Konya";
                label6.Text = "42";
                label7.Text = "332";
                label9.Text = "2.161.303";
            }
            if (comboBox1.SelectedIndex == 42)
            {
                label5.Text = "Kütahya";
                label6.Text = "43";
                label7.Text = "274";
                label9.Text = "573.642";
            }
            if (comboBox1.SelectedIndex == 43)
            {
                label5.Text = "Malatya";
                label6.Text = "44";
                label7.Text = "422";
                label9.Text = "781.305";
            }
            if (comboBox1.SelectedIndex == 44)
            {
                label5.Text = "Manisa";
                label6.Text = "45";
                label7.Text = "236";
                label9.Text = "1.396.945";
            }
            if (comboBox1.SelectedIndex == 45)
            {
                label5.Text = "Kahramanmaraş";
                label6.Text = "46";
                label7.Text = "344";
                label9.Text = "1.112.634";
            }
            if (comboBox1.SelectedIndex == 46)
            {
                label5.Text = "Mardin";
                label6.Text = "47";
                label7.Text = "482";
                label9.Text = "796.237";
            }
            if (comboBox1.SelectedIndex == 47)
            {
                label5.Text = "Muğla";
                label6.Text = "48";
                label7.Text = "252";
                label9.Text = "923.773";
            }
            if (comboBox1.SelectedIndex == 48)
            {
                label5.Text = "Muş";
                label6.Text = "49";
                label7.Text = "436";
                label9.Text = "406.501";
            }
            if (comboBox1.SelectedIndex == 49)
            {
                label5.Text = "Nevşehir";
                label6.Text = "50";
                label7.Text = "384";
                label9.Text = "290.895";
            }
            if (comboBox1.SelectedIndex == 50)
            {
                label5.Text = "Niğde";
                label6.Text = "51";
                label7.Text = "388";
                label9.Text = "351.468";
            }
            if (comboBox1.SelectedIndex == 51)
            {
                label5.Text = "Ordu";
                label6.Text = "52";
                label7.Text = "452";
                label9.Text = "750.588";
            }
            if (comboBox1.SelectedIndex == 52)
            {
                label5.Text = "Rize";
                label6.Text = "53";
                label7.Text = "464";
                label9.Text = "331.048";
            }
            if (comboBox1.SelectedIndex == 53)
            {
                label5.Text = "Sakarya";
                label6.Text = "54";
                label7.Text = "264";
                label9.Text = "976.948";
            }
            if (comboBox1.SelectedIndex == 54)
            {
                label5.Text = "Samsun";
                label6.Text = "55";
                label7.Text = "362";
                label9.Text = "1.295.927";
            }
            if (comboBox1.SelectedIndex == 55)
            {
                label5.Text = "Siirt";
                label6.Text = "56";
                label7.Text = "484";
                label9.Text = "322.664";
            }
            if (comboBox1.SelectedIndex == 56)
            {
                label5.Text = "Sinop";
                label6.Text = "57";
                label7.Text = "368";
                label9.Text = "205.478";
            }
            if (comboBox1.SelectedIndex == 57)
            {
                label5.Text = "Sivas";
                label6.Text = "58";
                label7.Text = "346";
                label9.Text = "621.224";
            }
            if (comboBox1.SelectedIndex == 58)
            {
                label5.Text = "Tekirdağ";
                label6.Text = "59";
                label7.Text = "282";
                label9.Text = "972.875";
            }
            if (comboBox1.SelectedIndex == 59)
            {
                label5.Text = "Tokat";
                label6.Text = "60";
                label7.Text = "356";
                label9.Text = "602.662";
            }
            if (comboBox1.SelectedIndex == 60)
            {
                label5.Text = "Trabzon";
                label6.Text = "61";
                label7.Text = "462";
                label9.Text = "779.379";
            }
            if (comboBox1.SelectedIndex == 61)
            {
                label5.Text = "Tunceli";
                label6.Text = "62";
                label7.Text = "428";
                label9.Text = "82.193";
            }
            if (comboBox1.SelectedIndex == 62)
            {
                label5.Text = "Şanlıurfa";
                label6.Text = "63";
                label7.Text = "414";
                label9.Text = "1.940.627";
            }
            if (comboBox1.SelectedIndex == 63)
            {
                label5.Text = "Uşak";
                label6.Text = "64";
                label7.Text = "276";
                label9.Text = "358.736";
            }
            if (comboBox1.SelectedIndex == 64)
            {
                label5.Text = "Van";
                label6.Text = "65";
                label7.Text = "432";
                label9.Text = "1.100.190";
            }
            if (comboBox1.SelectedIndex == 65)
            {
                label5.Text = "Yozgat";
                label6.Text = "66";
                label7.Text = "354";
                label9.Text = "421.324";
            }
            if (comboBox1.SelectedIndex == 66)
            {
                label5.Text = "Zonguldak";
                label6.Text = "67";
                label7.Text = "372";
                label9.Text = "597.524";
            }
            if (comboBox1.SelectedIndex == 67)
            {
                label5.Text = "Aksaray";
                label6.Text = "68";
                label7.Text = "382";
                label9.Text = "396.673";
            }
            if (comboBox1.SelectedIndex == 68)
            {
                label5.Text = "Bayburt";
                label6.Text = "69";
                label7.Text = "458";
                label9.Text = "90.154";
            }
            if (comboBox1.SelectedIndex == 69)
            {
                label5.Text = "Karaman";
                label6.Text = "70";
                label7.Text = "338";
                label9.Text = "245.610";
            }
            if (comboBox1.SelectedIndex == 70)
            {
                label5.Text = "Kırıkkale";
                label6.Text = "71";
                label7.Text = "318";
                label9.Text = "277.984";
            }
            if (comboBox1.SelectedIndex == 71)
            {
                label5.Text = "Batman";
                label6.Text = "72";
                label7.Text = "488";
                label9.Text = "576.899";
            }
            if (comboBox1.SelectedIndex == 72)
            {
                label5.Text = "Şırnak";
                label6.Text = "73";
                label7.Text = "486";
                label9.Text = "483.788";
            }
            if (comboBox1.SelectedIndex == 73)
            {
                label5.Text = "Bartın";
                label6.Text = "74";
                label7.Text = "378";
                label9.Text = "192.389";
            }
            if (comboBox1.SelectedIndex == 74)
            {
                label5.Text = "Ardahan";
                label6.Text = "75";
                label7.Text = "478";
                label9.Text = "98.335";
            }
            if (comboBox1.SelectedIndex == 75)
            {
                label5.Text = "Iğdır";
                label6.Text = "76";
                label7.Text = "476";
                label9.Text = "192.785";
            }
            if (comboBox1.SelectedIndex == 76)
            {
                label5.Text = "Yalova";
                label6.Text = "77";
                label7.Text = "226";
                label9.Text = "241.665";
            }
            if (comboBox1.SelectedIndex == 77)
            {
                label5.Text = "Karabük";
                label6.Text = "78";
                label7.Text = "370";
                label9.Text = "242.347";
            }
            if (comboBox1.SelectedIndex == 78)
            {
                label5.Text = "Kilis";
                label6.Text = "79";
                label7.Text = "348";
                label9.Text = "130.825";
            }
            if (comboBox1.SelectedIndex == 79)
            {
                label5.Text = "Osmaniye";
                label6.Text = "80";
                label7.Text = "328";
                label9.Text = "522.175";
            }
            if (comboBox1.SelectedIndex == 80)
            {
                label5.Text = "Düzce";
                label6.Text = "81";
                label7.Text = "380";
                label9.Text = "370.371";
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                    Alan Kodu Nedir? \n   Alan kodu illerde kullanılan sabit hatlı telefon yani ev telefonlarının başındaki 3 haneli rakamı belirlir. \n   Bu rakam ile sabit telefondan aranıyorsanız hangi ilden aradıklarını bulabilirsiniz." , "Alan Kodu", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nüfus bilgileri Aralık 2017 baz alınarak yapılmıştır.", "İl Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
