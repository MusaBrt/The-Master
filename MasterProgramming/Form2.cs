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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {

                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Aladağ");
                comboBox2.Items.Add("Ceyhan");
                comboBox2.Items.Add("Çukurova");
                comboBox2.Items.Add("Feke");
                comboBox2.Items.Add("İmamoğlu");
                comboBox2.Items.Add("Karaisalı");
                comboBox2.Items.Add("Karataş");
                comboBox2.Items.Add("Kozan");
                comboBox2.Items.Add("Pozantı");
                comboBox2.Items.Add("Saimbeyli");
                comboBox2.Items.Add("Sarıçam");
                comboBox2.Items.Add("Seyhan");
                comboBox2.Items.Add("Tufanbeyli");
                comboBox2.Items.Add("Yumurtalık");
                comboBox2.Items.Add("Yüreğir");
            }
            else if (comboBox1.SelectedIndex == 1) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Besni");
                comboBox2.Items.Add("Çelikhan");
                comboBox2.Items.Add("Gerger");
                comboBox2.Items.Add("Gölbaşı");
                comboBox2.Items.Add("Kahta");
                comboBox2.Items.Add("Samsat");
                comboBox2.Items.Add("Sincik");
                comboBox2.Items.Add("Tut");
            }
            else if (comboBox1.SelectedIndex == 2) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Başmakçı");
                comboBox2.Items.Add("Bayat");
                comboBox2.Items.Add("Bolvadin");
                comboBox2.Items.Add("Çay");
                comboBox2.Items.Add("Çobanlar");
                comboBox2.Items.Add("Dazkırı");
                comboBox2.Items.Add("Dinar");
                comboBox2.Items.Add("Emirdağ");
                comboBox2.Items.Add("Evciler");
                comboBox2.Items.Add("Hocalar");
                comboBox2.Items.Add("İhsaniye");
                comboBox2.Items.Add("İscehisar");
                comboBox2.Items.Add("Kızılören");
                comboBox2.Items.Add("Sandıklı");
                comboBox2.Items.Add("Sincanlı");
                comboBox2.Items.Add("Sultandağı");
                comboBox2.Items.Add("Şuhut");
            }
            else if (comboBox1.SelectedIndex == 3) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Diyadin");
                comboBox2.Items.Add("Doğubayazıt");
                comboBox2.Items.Add("Eleşkirt");
                comboBox2.Items.Add("Hamur");
                comboBox2.Items.Add("Patnos");
                comboBox2.Items.Add("Taşlıçay");
                comboBox2.Items.Add("Tutak");
            }
            else if (comboBox1.SelectedIndex == 4) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Göynücek");
                comboBox2.Items.Add("Gümüşhacıköy");
                comboBox2.Items.Add("Hamamözü");
                comboBox2.Items.Add("Merzifon");
                comboBox2.Items.Add("Suluova");
                comboBox2.Items.Add("Taşova");
            }
            else if (comboBox1.SelectedIndex == 5) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Akyurt");
                comboBox2.Items.Add("Altındağ");
                comboBox2.Items.Add("Ayaş");
                comboBox2.Items.Add("Bala");
                comboBox2.Items.Add("Beypazarı");
                comboBox2.Items.Add("Çamlıdere");
                comboBox2.Items.Add("Çankaya");
                comboBox2.Items.Add("Çubuk");
                comboBox2.Items.Add("Elmadağ");
                comboBox2.Items.Add("Etimesgut");
                comboBox2.Items.Add("Evren");
                comboBox2.Items.Add("Gölbaşı");
                comboBox2.Items.Add("Güdül");
                comboBox2.Items.Add("Haymana");
                comboBox2.Items.Add("Kalecik");
                comboBox2.Items.Add("Kazan");
                comboBox2.Items.Add("Keçiören");
                comboBox2.Items.Add("Kızılcahamam");
                comboBox2.Items.Add("Mamak");
                comboBox2.Items.Add("Nallıhan");
                comboBox2.Items.Add("Polatlı");
                comboBox2.Items.Add("Pursaklar");
                comboBox2.Items.Add("Sincan");
                comboBox2.Items.Add("Şereflikoçhisar");
                comboBox2.Items.Add("Yenimahalle");

            }
            else if (comboBox1.SelectedIndex == 6) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Akseki");
                comboBox2.Items.Add("Aksu");
                comboBox2.Items.Add("Alanya");
                comboBox2.Items.Add("Demre");
                comboBox2.Items.Add("Döşemealtı");
                comboBox2.Items.Add("Elmalı");
                comboBox2.Items.Add("Finike");
                comboBox2.Items.Add("Gazipaşa");
                comboBox2.Items.Add("Gündoğmuş");
                comboBox2.Items.Add("İbradı");
                comboBox2.Items.Add("Kaş");
                comboBox2.Items.Add("Kemer");
                comboBox2.Items.Add("Kepez");
                comboBox2.Items.Add("Konyaaltı");
                comboBox2.Items.Add("Korkuteli");
                comboBox2.Items.Add("Kumluca");
                comboBox2.Items.Add("Manavgat");
                comboBox2.Items.Add("Muratpaşa");
                comboBox2.Items.Add("Serik");
            }
            else if (comboBox1.SelectedIndex == 7) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Ardanuç");
                comboBox2.Items.Add("Arhavi");
                comboBox2.Items.Add("Borçka");
                comboBox2.Items.Add("Hopa");
                comboBox2.Items.Add("Kemalpaşa");
                comboBox2.Items.Add("Murgul");
                comboBox2.Items.Add("Şavşat");
                comboBox2.Items.Add("Yusufeli");
            }
            else if (comboBox1.SelectedIndex == 8) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Bozdoğan");
                comboBox2.Items.Add("Buharkent");
                comboBox2.Items.Add("Çine");
                comboBox2.Items.Add("Didim");
                comboBox2.Items.Add("Efeler");
                comboBox2.Items.Add("Germencik");
                comboBox2.Items.Add("İncirliova");
                comboBox2.Items.Add("Karacasu");
                comboBox2.Items.Add("Karpuzlu");
                comboBox2.Items.Add("Koçarlı");
                comboBox2.Items.Add("Köşk");
                comboBox2.Items.Add("Kuşadası");
                comboBox2.Items.Add("Kuyucak");
                comboBox2.Items.Add("Nazilli");
                comboBox2.Items.Add("Söke");
                comboBox2.Items.Add("Sultanhisar");
                comboBox2.Items.Add("Yenipazar");
            }
            else if (comboBox1.SelectedIndex == 9) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Altıeylül");
                comboBox2.Items.Add("Ayvalık");
                comboBox2.Items.Add("Balya");
                comboBox2.Items.Add("Bandırma");
                comboBox2.Items.Add("Bigadiç");
                comboBox2.Items.Add("Burhaniye");
                comboBox2.Items.Add("Dursunbey");
                comboBox2.Items.Add("Edremit");
                comboBox2.Items.Add("Erdek");
                comboBox2.Items.Add("Gömeç");
                comboBox2.Items.Add("Gönen");
                comboBox2.Items.Add("Havran");
                comboBox2.Items.Add("İvrindi");
                comboBox2.Items.Add("Karesi");
                comboBox2.Items.Add("Kepsut");
                comboBox2.Items.Add("Manyas");
                comboBox2.Items.Add("Marmara");
                comboBox2.Items.Add("Savaştepe");
                comboBox2.Items.Add("Sındırgı");
                comboBox2.Items.Add("Susurluk");
            }
            else if (comboBox1.SelectedIndex == 10) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Bozüyük");
                comboBox2.Items.Add("Gölpazarı");
                comboBox2.Items.Add("İnhisar");
                comboBox2.Items.Add("Osmaneli");
                comboBox2.Items.Add("Pazaryeri");
                comboBox2.Items.Add("Söğüt");
                comboBox2.Items.Add("Yenipazar");
            }
            else if (comboBox1.SelectedIndex == 11) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Adaklı");
                comboBox2.Items.Add("Genç");
                comboBox2.Items.Add("Karlıova");
                comboBox2.Items.Add("Kiğı");
                comboBox2.Items.Add("Solhan");
                comboBox2.Items.Add("Yayladere");
                comboBox2.Items.Add("Yedisu");
            }
            else if (comboBox1.SelectedIndex == 12) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Adilcevaz");
                comboBox2.Items.Add("Ahlat");
                comboBox2.Items.Add("Güroymak");
                comboBox2.Items.Add("Hizan");
                comboBox2.Items.Add("Mutki");
                comboBox2.Items.Add("Tatvan");
            }
            else if (comboBox1.SelectedIndex == 13) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Dörtdivan");
                comboBox2.Items.Add("Gerede");
                comboBox2.Items.Add("Göynük");
                comboBox2.Items.Add("Kıbrıscık");
                comboBox2.Items.Add("Mengen");
                comboBox2.Items.Add("Mudurnu");
                comboBox2.Items.Add("Seben");
                comboBox2.Items.Add("Yeniçağa");

            }
            else if (comboBox1.SelectedIndex == 14) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Ağlasun");
                comboBox2.Items.Add("Altınyayla");
                comboBox2.Items.Add("Bucak");
                comboBox2.Items.Add("Çavdır");
                comboBox2.Items.Add("Çeltikçi");
                comboBox2.Items.Add("Gölhisar");
                comboBox2.Items.Add("Karamanlı");
                comboBox2.Items.Add("Kemer");
                comboBox2.Items.Add("Tefenni");
                comboBox2.Items.Add("Yeşilova");
            }
            else if (comboBox1.SelectedIndex == 15) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Büyükorhan");
                comboBox2.Items.Add("Gemlik");
                comboBox2.Items.Add("Gürsü");
                comboBox2.Items.Add("Harmancık");
                comboBox2.Items.Add("İnegöl");
                comboBox2.Items.Add("İznik");
                comboBox2.Items.Add("Karacabey");
                comboBox2.Items.Add("Keles");
                comboBox2.Items.Add("Kestel");
                comboBox2.Items.Add("Mudanya");
                comboBox2.Items.Add("Mustafakemalpaşa");
                comboBox2.Items.Add("Nilüfer");
                comboBox2.Items.Add("Orhaneli");
                comboBox2.Items.Add("Orhangazi");
                comboBox2.Items.Add("Osmangazi");
                comboBox2.Items.Add("Yenişehir");
                comboBox2.Items.Add("Yıldırım");
            }
            else if (comboBox1.SelectedIndex == 16) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Ayvacık");
                comboBox2.Items.Add("Bayramiç");
                comboBox2.Items.Add("Biga");
                comboBox2.Items.Add("Bozcaada");
                comboBox2.Items.Add("Çan");
                comboBox2.Items.Add("Eceabat");
                comboBox2.Items.Add("Ezine");
                comboBox2.Items.Add("Gelibolu");
                comboBox2.Items.Add("Gökçeada");
                comboBox2.Items.Add("Lapseki");
                comboBox2.Items.Add("Yenice");
            }
            else if (comboBox1.SelectedIndex == 17) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Atkaracalar");
                comboBox2.Items.Add("Bayramören");
                comboBox2.Items.Add("Çerkeş");
                comboBox2.Items.Add("Eldivan");
                comboBox2.Items.Add("Ilgaz");
                comboBox2.Items.Add("Kızılırmak");
                comboBox2.Items.Add("Korgun");
                comboBox2.Items.Add("Kurşunlu");
                comboBox2.Items.Add("Orta");
                comboBox2.Items.Add("Şabanözlü");
                comboBox2.Items.Add("Yapraklı");
            }
            else if (comboBox1.SelectedIndex == 18) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Alaca");
                comboBox2.Items.Add("Bayat");
                comboBox2.Items.Add("Boğazkale");
                comboBox2.Items.Add("Dodurga");
                comboBox2.Items.Add("İskilip");
                comboBox2.Items.Add("Kargı");
                comboBox2.Items.Add("Laçin");
                comboBox2.Items.Add("Mecitözü");
                comboBox2.Items.Add("Oğuzlar");
                comboBox2.Items.Add("Ortaköy");
                comboBox2.Items.Add("Osmancık");
                comboBox2.Items.Add("Sungurlu");
                comboBox2.Items.Add("Uğurludağ"); // çorum sonuncu
            }
            else if (comboBox1.SelectedIndex == 19) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Acıpayam");
                comboBox2.Items.Add("Babadağ");
                comboBox2.Items.Add("Baklan");
                comboBox2.Items.Add("Bekilli");
                comboBox2.Items.Add("Beyağaç");
                comboBox2.Items.Add("Bozkurt");
                comboBox2.Items.Add("Buldan");
                comboBox2.Items.Add("Çal");
                comboBox2.Items.Add("Çameli");
                comboBox2.Items.Add("Çardak");
                comboBox2.Items.Add("Çivril");
                comboBox2.Items.Add("Güney");
                comboBox2.Items.Add("Honaz");
                comboBox2.Items.Add("Kale");
                comboBox2.Items.Add("Merkezefendi");
                comboBox2.Items.Add("Pamukkale");
                comboBox2.Items.Add("Sarayköy");
                comboBox2.Items.Add("Serinhisar");
                comboBox2.Items.Add("Tavas");
            }
            else if (comboBox1.SelectedIndex == 20) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Bağlar");
                comboBox2.Items.Add("Bismil");
                comboBox2.Items.Add("Çermik");
                comboBox2.Items.Add("Çınar");
                comboBox2.Items.Add("Dicle");
                comboBox2.Items.Add("Eğil");
                comboBox2.Items.Add("Ergani");
                comboBox2.Items.Add("Hani");
                comboBox2.Items.Add("Hazro");
                comboBox2.Items.Add("Kayapınar");
                comboBox2.Items.Add("Kocaköy");
                comboBox2.Items.Add("Kulp");
                comboBox2.Items.Add("Lice");
                comboBox2.Items.Add("Silvan");
                comboBox2.Items.Add("Sur");
                comboBox2.Items.Add("Yenişehir");//diyarbakır bitti
            }
            else if (comboBox1.SelectedIndex == 21) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Enez");
                comboBox2.Items.Add("Havsa");
                comboBox2.Items.Add("İpsala");
                comboBox2.Items.Add("Keşan");
                comboBox2.Items.Add("Lalapaşa");
                comboBox2.Items.Add("Meriç");
                comboBox2.Items.Add("Süloğlu");
                comboBox2.Items.Add("Uzunköprü");
            }
            else if (comboBox1.SelectedIndex == 22) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Ağın");
                comboBox2.Items.Add("Alacakaya");
                comboBox2.Items.Add("Arıcak");
                comboBox2.Items.Add("Baskil");
                comboBox2.Items.Add("Karakoçan");
                comboBox2.Items.Add("Keban");
                comboBox2.Items.Add("Kovancılar");
                comboBox2.Items.Add("Maden");
                comboBox2.Items.Add("Palu");
                comboBox2.Items.Add("Sivrice"); //elazığ
            }
            else if (comboBox1.SelectedIndex == 23) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Çayırlı");
                comboBox2.Items.Add("İliç");
                comboBox2.Items.Add("Kemah");
                comboBox2.Items.Add("Kemaliye");
                comboBox2.Items.Add("Otlukbeli");
                comboBox2.Items.Add("Refahiye");
                comboBox2.Items.Add("Tercan");
                comboBox2.Items.Add("Üzümlü"); // erzincan
            }
            else if (comboBox1.SelectedIndex == 24) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Aşkale");
                comboBox2.Items.Add("Aziziye");
                comboBox2.Items.Add("Çat");
                comboBox2.Items.Add("Hınıs");
                comboBox2.Items.Add("Horasan");
                comboBox2.Items.Add("İspir");
                comboBox2.Items.Add("Karaçoban");
                comboBox2.Items.Add("Karayazı");
                comboBox2.Items.Add("Köprüköy");
                comboBox2.Items.Add("Narman");
                comboBox2.Items.Add("Oltu");
                comboBox2.Items.Add("Olur");
                comboBox2.Items.Add("Palandöken");
                comboBox2.Items.Add("Pasinler");
                comboBox2.Items.Add("Pazaryolu");
                comboBox2.Items.Add("Şenkaya");
                comboBox2.Items.Add("Tekman");
                comboBox2.Items.Add("Tortum");
                comboBox2.Items.Add("Uzundere");
                comboBox2.Items.Add("Yakutiye"); // erzurum
            }
            else if (comboBox1.SelectedIndex == 25) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Alpu");
                comboBox2.Items.Add("Beylikova");
                comboBox2.Items.Add("Çifteler");
                comboBox2.Items.Add("Günyüzü");
                comboBox2.Items.Add("Han");
                comboBox2.Items.Add("İnönü");
                comboBox2.Items.Add("Mahmudiye");
                comboBox2.Items.Add("Mihalgazi");
                comboBox2.Items.Add("Mihalıççık");
                comboBox2.Items.Add("Odunpazarı");
                comboBox2.Items.Add("Sarıcakaya");
                comboBox2.Items.Add("Seyitgazi");
                comboBox2.Items.Add("Sivrihisar");
                comboBox2.Items.Add("Tepebaşı"); // eskişehir
            }
            else if (comboBox1.SelectedIndex == 26) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Araban");
                comboBox2.Items.Add("İlahiye");
                comboBox2.Items.Add("Karkamış");
                comboBox2.Items.Add("Nizip");
                comboBox2.Items.Add("Nurdağı");
                comboBox2.Items.Add("Oğuzeli");
                comboBox2.Items.Add("Şahinbey");
                comboBox2.Items.Add("Şehitkamil");
                comboBox2.Items.Add("Yavuzeli"); // gaziantep

            }
            else if (comboBox1.SelectedIndex == 27) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Alucra");
                comboBox2.Items.Add("Bulancak");
                comboBox2.Items.Add("Çamoluk");
                comboBox2.Items.Add("Çanakçı");
                comboBox2.Items.Add("Dereli");
                comboBox2.Items.Add("Doğankent");
                comboBox2.Items.Add("Espiye");
                comboBox2.Items.Add("Eynesil");
                comboBox2.Items.Add("Görele");
                comboBox2.Items.Add("Güce");
                comboBox2.Items.Add("Keşap");
                comboBox2.Items.Add("Piraziz");
                comboBox2.Items.Add("Şebinkarahisar");
                comboBox2.Items.Add("Tirebolu");
                comboBox2.Items.Add("Yağlıdere"); // giresun
            }
            else if (comboBox1.SelectedIndex == 28) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Kelkit");
                comboBox2.Items.Add("Köse");
                comboBox2.Items.Add("Kürtün");
                comboBox2.Items.Add("Şiran");
                comboBox2.Items.Add("Torul"); // gümüşhane
            }
            else if (comboBox1.SelectedIndex == 29) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Çukurca");
                comboBox2.Items.Add("Şemdinli");
                comboBox2.Items.Add("Yüksekova"); // hakkari
            }
            else if (comboBox1.SelectedIndex == 30) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Altınözü");
                comboBox2.Items.Add("Arsuz");
                comboBox2.Items.Add("Belen‎");
                comboBox2.Items.Add("Defne");
                comboBox2.Items.Add("Dörtyol‎");
                comboBox2.Items.Add("Erzin‎");
                comboBox2.Items.Add("Hassa‎");
                comboBox2.Items.Add("İskenderun‎");
                comboBox2.Items.Add("Kırıkhan");
                comboBox2.Items.Add("Kumlu");
                comboBox2.Items.Add("Payas");
                comboBox2.Items.Add("Reyhanlı‎");
                comboBox2.Items.Add("Samandağ‎");
                comboBox2.Items.Add("Yayladağı‎"); // hatay
            }
            else if (comboBox1.SelectedIndex == 31) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Aksu");
                comboBox2.Items.Add("Atabey");
                comboBox2.Items.Add("Eğirdir");
                comboBox2.Items.Add("Gelendost");
                comboBox2.Items.Add("Gönen");
                comboBox2.Items.Add("Keçiborlu");
                comboBox2.Items.Add("Sütçüler");
                comboBox2.Items.Add("Şarkikaraağaç");
                comboBox2.Items.Add("Uluborlu");
                comboBox2.Items.Add("Yalvaç");
                comboBox2.Items.Add("Yenişarbademli"); // Isparta
            }
            else if (comboBox1.SelectedIndex == 32) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Akdeniz");
                comboBox2.Items.Add("Anamur");
                comboBox2.Items.Add("Aydıncık");
                comboBox2.Items.Add("Bozyazı");
                comboBox2.Items.Add("Çamlıyayla");
                comboBox2.Items.Add("Erdemli");
                comboBox2.Items.Add("Gülnar");
                comboBox2.Items.Add("Mezitli");
                comboBox2.Items.Add("Mut");
                comboBox2.Items.Add("Silifke");
                comboBox2.Items.Add("Tarsus");
                comboBox2.Items.Add("Toroslar");
                comboBox2.Items.Add("Yenişehir"); // mersin
            }
            else if (comboBox1.SelectedIndex == 33) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Adalar");
                comboBox2.Items.Add("Arnavutköy");
                comboBox2.Items.Add("Ataşehir");
                comboBox2.Items.Add("Avcılar");
                comboBox2.Items.Add("Bağcılar");
                comboBox2.Items.Add("Bahçelievler");
                comboBox2.Items.Add("Bakırköy");
                comboBox2.Items.Add("Başakşehir");
                comboBox2.Items.Add("Bayrampaşa");
                comboBox2.Items.Add("Beşiktaş");
                comboBox2.Items.Add("Beykoz");
                comboBox2.Items.Add("Beylikdüzü");
                comboBox2.Items.Add("Beyoğlu");
                comboBox2.Items.Add("Büyükçekmece");
                comboBox2.Items.Add("Çatalca");
                comboBox2.Items.Add("Çekmeköy");
                comboBox2.Items.Add("Esenler");
                comboBox2.Items.Add("Esenyurt");
                comboBox2.Items.Add("Eyüpsultan");
                comboBox2.Items.Add("Fatih");
                comboBox2.Items.Add("Gaziosmanpaşa");
                comboBox2.Items.Add("Güngören");
                comboBox2.Items.Add("Kadıköy");
                comboBox2.Items.Add("Kağıthane");
                comboBox2.Items.Add("Kartal");
                comboBox2.Items.Add("Küçükçekmece");
                comboBox2.Items.Add("Maltepe");
                comboBox2.Items.Add("Pendik");
                comboBox2.Items.Add("Sancaktepe");
                comboBox2.Items.Add("Sarıyer");
                comboBox2.Items.Add("Silivri");
                comboBox2.Items.Add("Sultanbeyli");
                comboBox2.Items.Add("Sultangazi");
                comboBox2.Items.Add("Şile");
                comboBox2.Items.Add("Şişli");
                comboBox2.Items.Add("Tuzla");
                comboBox2.Items.Add("Ümraniye");
                comboBox2.Items.Add("Üsküdar");
                comboBox2.Items.Add("Zeytinburnu"); // istanbul
            }
            else if (comboBox1.SelectedIndex == 34) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Aliağa");
                comboBox2.Items.Add("Balçova");
                comboBox2.Items.Add("Bayındır");
                comboBox2.Items.Add("Bayraklı");
                comboBox2.Items.Add("Bergama");
                comboBox2.Items.Add("Beydağ");
                comboBox2.Items.Add("Bornova");
                comboBox2.Items.Add("Buca");
                comboBox2.Items.Add("Çeşme");
                comboBox2.Items.Add("Çiğli");
                comboBox2.Items.Add("Dikili");
                comboBox2.Items.Add("Foça");
                comboBox2.Items.Add("Gaziemir");
                comboBox2.Items.Add("Güzelbahçe");
                comboBox2.Items.Add("Karabağlar");
                comboBox2.Items.Add("Karaburun");
                comboBox2.Items.Add("Karşıyaka");
                comboBox2.Items.Add("Kemalpaşa");
                comboBox2.Items.Add("Kınık");
                comboBox2.Items.Add("Kiraz");
                comboBox2.Items.Add("Konak");
                comboBox2.Items.Add("Menderes");
                comboBox2.Items.Add("Menemen");
                comboBox2.Items.Add("Narlıdere");
                comboBox2.Items.Add("Ödemiş");
                comboBox2.Items.Add("Seferihisar");
                comboBox2.Items.Add("Selçuk");
                comboBox2.Items.Add("Tire");
                comboBox2.Items.Add("Torbalı");
                comboBox2.Items.Add("Urla"); //izmir
            }
            else if (comboBox1.SelectedIndex == 35) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Akyaka");
                comboBox2.Items.Add("Arpaçay");
                comboBox2.Items.Add("Digor");
                comboBox2.Items.Add("Kağızman");
                comboBox2.Items.Add("Sarıkamış");
                comboBox2.Items.Add("Selim");
                comboBox2.Items.Add("Susuz"); // kars
            }
            else if (comboBox1.SelectedIndex == 36) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                comboBox2.Items.Add("Abana");
                comboBox2.Items.Add("Ağlı");
                comboBox2.Items.Add("Araç");
                comboBox2.Items.Add("Azdavay");
                comboBox2.Items.Add("Bozkurt");
                comboBox2.Items.Add("Cide");
                comboBox2.Items.Add("Çatalzeytin");
                comboBox2.Items.Add("Daday");
                comboBox2.Items.Add("Devrekani");
                comboBox2.Items.Add("Doğanyurt");
                comboBox2.Items.Add("Hanönü");
                comboBox2.Items.Add("İhsangazi");
                comboBox2.Items.Add("İnebolu");
                comboBox2.Items.Add("Küre");
                comboBox2.Items.Add("Merkez");
                comboBox2.Items.Add("Pınarbaşı"); //kastamonu
                comboBox2.Items.Add("Seydiler");
                comboBox2.Items.Add("Şenpazar");
                comboBox2.Items.Add("Taşköprü");
                comboBox2.Items.Add("Tosya");
            }
            else if (comboBox1.SelectedIndex == 37) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                 //kayseri
            }
            else if (comboBox1.SelectedIndex == 38) {}
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İl Merkezi");
                

        }
    }
}
