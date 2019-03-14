//Beynelmilel Futbol
//All rights reserved. AVA 2009

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace futbol
{
    public partial class Form1 : Form
    {
        public int tSav_1, tHuc_1,
            tSav_2, tHuc_2, tSav_3,
            tHuc_3, tSav_4, tHuc_4,
            p1_Huc, p1_Sav, p2_Huc,
            p2_Sav, tSav_5, tHuc_5, flag;
        int j, k, takimH, takimA;
        public const int KADRO = 18;
        public List<Takim> team = new List<Takim>();
        Takim eleven = new Takim();
        public int armut = 5;
        Boolean control, anahtar;

        public Form1()
        {
            InitializeComponent();
        }

        //kapanırken...
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //çıkış
            Close();
        }

        //çıkış butonu
        private void label2_Click(object sender, EventArgs e)
        {
            //çıkış
            this.Close();
        }

        //dostluk maçı butonu
        private void label1_Click(object sender, EventArgs e)
        {
            //oyun başlar tüm menü görünür
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            pboxH.Visible = true;
            pboxA.Visible = true;
            anaPanel.Visible = true;
            label5.Visible = true;
            prevBut.Visible = true;
            nextBut.Visible = true;
            p2NextBut.Visible = true;
            p2PrevBut.Visible = true;
            label6.Visible = true;
            taktikBut.Visible = true;
            label11.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Arjantin
            setTakim("Arjantin");
            team[0].setOyuncu("J. P. Carrizo", 80, 20);
            team[0].setOyuncu("M. Demichelis", 85, 50);
            team[0].setOyuncu("D. Diaz", 86, 48);
            team[0].setOyuncu("J. Zanetti", 77, 77);
            team[0].setOyuncu("G. Heinze", 76, 75);
            team[0].setOyuncu("J. Mascherano", 75, 60);
            team[0].setOyuncu("E. Cambiasso", 80, 80);
            team[0].setOyuncu("Lucho Gonzales", 70, 85);
            team[0].setOyuncu("Maxi Rodriguez", 56, 83);
            team[0].setOyuncu("L. Messi", 40, 95);
            team[0].setOyuncu("S. Agüero", 40, 91);
            team[0].setOyuncu("F. Vilar", 83, 35);
            team[0].setOyuncu("W. Samuel", 79, 37);
            team[0].setOyuncu("G. Milito", 78, 31);
            team[0].setOyuncu("J. S. Veron", 71, 63);
            team[0].setOyuncu("C. Tevez", 45, 83);
            team[0].setOyuncu("E. Lavezzi", 37, 81);
            team[0].setOyuncu("D. Milito", 40, 86);

            //Brezilya
            setTakim("Brezilya");
            team[1].setOyuncu("J. Cesar", 99, 20);
            team[1].setOyuncu("Lucio", 87, 57);
            team[1].setOyuncu("Juan", 77, 20);
            team[1].setOyuncu("Maicon", 78, 75);
            team[1].setOyuncu("Dani Alves", 73, 75);
            team[1].setOyuncu("Robinho", 10, 87);
            team[1].setOyuncu("Elano", 55, 84);
            team[1].setOyuncu("Gilberto Silva", 80, 67);
            team[1].setOyuncu("Kaka", 55, 98);
            team[1].setOyuncu("L. Fabiano", 40, 89);
            team[1].setOyuncu("Adriano", 35, 85);
            team[1].setOyuncu("Dida", 85, 45);
            team[1].setOyuncu("Luisao", 83, 47);
            team[1].setOyuncu("Alex", 85, 53);
            team[1].setOyuncu("Ronaldinho", 32, 81);
            team[1].setOyuncu("Anderson", 75, 77);
            team[1].setOyuncu("Pato", 35, 83);
            team[1].setOyuncu("Jo", 20, 80);

            //Hollanda
            setTakim("Hollanda");
            team[2].setOyuncu("M. Stekelenburg", 81, 20);
            team[2].setOyuncu("A. Ooijer", 83, 50);
            team[2].setOyuncu("J. Mathjisen", 85, 48);
            team[2].setOyuncu("J. Heitinga", 84, 77);
            team[2].setOyuncu("B. Edson", 76, 75);
            team[2].setOyuncu("N. de Jong", 77, 69);
            team[2].setOyuncu("M. van Bommel", 75, 75);
            team[2].setOyuncu("W. Sneijder", 54, 85);
            team[2].setOyuncu("R. van der Vaart", 32, 83);
            team[2].setOyuncu("A. Robben", 40, 89);
            team[2].setOyuncu("D. Kuijt", 23, 86);
            team[2].setOyuncu("H. Timmer", 79, 35);
            team[2].setOyuncu("W. Bouma", 78, 31);
            team[2].setOyuncu("G. van Bronckhorst", 79, 61);
            team[2].setOyuncu("D. de Zeuw", 69, 62);
            team[2].setOyuncu("O. Engelaar", 70, 70);
            team[2].setOyuncu("R. van Persie", 54, 85);
            team[2].setOyuncu("R. Babel", 40, 86);

            //İngiltere
            setTakim("İngiltere");
            team[3].setOyuncu("P. Robinson", 83, 20);
            team[3].setOyuncu("J. Terry", 90, 50);
            team[3].setOyuncu("R. Ferdinand", 93, 48);
            team[3].setOyuncu("M. Richards", 80, 45);
            team[3].setOyuncu("A. Cole", 82, 66);
            team[3].setOyuncu("F. Lampard", 80, 84);
            team[3].setOyuncu("G. Barry", 75, 80);
            team[3].setOyuncu("S. Gerrard", 81, 85);
            team[3].setOyuncu("J. Cole", 40, 79);
            team[3].setOyuncu("W. Rooney", 40, 90);
            team[3].setOyuncu("M. Owen", 20, 85);
            team[3].setOyuncu("R. Green", 80, 20);
            team[3].setOyuncu("M. Upson", 76, 25);
            team[3].setOyuncu("G. Johnson", 75, 30);
            team[3].setOyuncu("D. Beckham", 60, 82);
            team[3].setOyuncu("S. R Philips", 42, 85);
            team[3].setOyuncu("T. Walcott", 37, 86);
            team[3].setOyuncu("J. Defoe", 24, 85);


            //Türkiye
            setTakim("Türkiye");
            team[4].setOyuncu("Volkan D.", 75, 20);
            team[4].setOyuncu("Gökhan Z.", 65, 10);
            team[4].setOyuncu("Servet Ç.", 67, 20);
            team[4].setOyuncu("Hakan B.", 71, 45);
            team[4].setOyuncu("Gökhan G.", 71, 60);
            team[4].setOyuncu("M. Aurelio", 73, 61);
            team[4].setOyuncu("Hamit A.", 65, 67);
            team[4].setOyuncu("Arda T.", 40, 69);
            team[4].setOyuncu("Tuncay Ş.", 70, 68);
            team[4].setOyuncu("Semih Ş.", 40, 70);
            team[4].setOyuncu("Nihat K.", 20, 73);
            team[4].setOyuncu("Tolga Z.", 73, 19);
            team[4].setOyuncu("Emre A.", 69, 15);
            team[4].setOyuncu("Sabri S.", 65, 64);
            team[4].setOyuncu("Emre B.", 74, 66);
            team[4].setOyuncu("Ayhan A.", 65, 63);
            team[4].setOyuncu("Nuri Ş.", 40, 65);
            team[4].setOyuncu("Gökhan Ü.", 35, 67);
        }

        //Takım classına bağlı team objecti oluşturma
        public void setTakim(string adi)
        {
            team.Add(new Takim
            {
                ad = adi
            });
        }

        //oyuncu takım seçme
        //**bir sonraki takım
        private void nextBut_Click(object sender, EventArgs e)
        {
            taktikBut.Enabled = true;
            if (k < 4)
            {
                label5.Text = team[k].ad;
                k++;
                prevBut.Enabled = true;
            }
            else if (k == 4)
            {
                label5.Text = team[k].ad;
                nextBut.Enabled = false;
            }
        }
        //**bir önceki takım
        private void prevBut_Click(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
                nextBut.Enabled = true;
                label5.Text = team[k].ad;
            }
            else if (k == 0)
            {
                label5.Text = team[k].ad;
                prevBut.Enabled = false;
                nextBut.Enabled = true;
            }
        }

        //rakip takım seçme
        //**bir sonraki takım
        private void p2NextBut_Click(object sender, EventArgs e)
        {
            if (j < 4)
            {
                label6.Text = team[j].ad;
                j++;
                p2PrevBut.Enabled = true;
            }
            else if (j == 4)
            {
                label6.Text = team[j].ad;
                p2NextBut.Enabled = false;      //göstergenin son takımı göstermesi
            }
        }

        //rakip takım seçme
        //**bir önceki takım
        private void p2PrevBut_Click(object sender, EventArgs e)
        {
            if (j > 0)
            {
                j--;
                p2NextBut.Enabled = true;
                label6.Text = team[j].ad;
            }
            else if (j == 0)
            {
                label6.Text = team[j].ad;
                p2PrevBut.Enabled = false;      //göstergenin ilk takımı göstermesi
                p2NextBut.Enabled = true;
            }
        }

        //**ülkenin değişmesine göre ayarlananlar (oyuncu takımı)
        private void label5_TextChanged(object sender, EventArgs e)
        {
            if (k == 0)
            {
                //seçilen ülkeye göre bayrak
                pboxH.Image = Properties.Resources.arg;
            }
            else if (k == 1)
            {
                //seçilen ülkeye göre bayrak
                pboxH.Image = Properties.Resources.bra;
            }

            else if (k == 2)
            {
                //seçilen ülkeye göre bayrak
                pboxH.Image = Properties.Resources.hol;
            }

            else if (k == 3)
            {
                //seçilen ülkeye göre bayrak
                pboxH.Image = Properties.Resources.eng;
            }

            else if (k == 4)
            {
                //seçilen ülkeye göre bayrak
                pboxH.Image = Properties.Resources.tur;
            }
        }

        //**ülkenin değişmesine göre ayarlananlar (rakip takım)
        private void label6_TextChanged(object sender, EventArgs e)
        {
            if (j == 0)
            {
                //seçilen ülkeye göre bayrak
                pboxA.Image = Properties.Resources.arg;
                takimA = 0;     //seçilen ülkeyi belirler (index no.)
            }
            else if (j == 1)
            {
                pboxA.Image = Properties.Resources.bra;
                takimA = 1;     //seçilen ülkeyi belirler (index no.)
            }

            else if (j == 2)
            {
                pboxA.Image = Properties.Resources.hol;
                takimA = 2;     //seçilen ülkeyi belirler (index no.)
            }

            else if (j == 3)
            {
                pboxA.Image = Properties.Resources.eng;
                takimA = 3;     //seçilen ülkeyi belirler (index no.)
            }

            else if (j == 4)
            {
                pboxA.Image = Properties.Resources.tur;
                takimA = 4;     //seçilen ülkeyi belirler (index no.)
            }
        }

        //taktik butonu. dropdown menü açar
        private void taktikBut_Click(object sender, EventArgs e)
        {
            Form frmm = new Form2();
            frmm.Show();            
            if (!(control && anahtar))
            {
                //üzerindeki elementleri görünür kılar
                tacBox.Visible = true;
                nextBut.Enabled = false;
                prevBut.Enabled = false;

                //çekmeceyi açık/kapalı durumunun kontrolünü tutar
                control = true;
                anahtar = true;

                if (label5.Text == "Arjantin")
                {
                    takimH = 0;

                    //oyuncuları kadroya ekler
                    gklbl.Text = team[0].player[0].oyuncuAd;
                    dllbl.Text = team[0].player[2].oyuncuAd;
                    drlbl.Text = team[0].player[3].oyuncuAd;
                    drclbl.Text = team[0].player[4].oyuncuAd;
                    dlclbl.Text = team[0].player[5].oyuncuAd;
                    mllbl.Text = team[0].player[6].oyuncuAd;
                    mrlbl.Text = team[0].player[7].oyuncuAd;
                    mrclbl.Text = team[0].player[8].oyuncuAd;
                    mlclbl.Text = team[0].player[9].oyuncuAd;
                    fllbl.Text = team[0].player[10].oyuncuAd;
                    frlbl.Text = team[0].player[11].oyuncuAd;
                    s1lbl.Text = team[0].player[1].oyuncuAd;
                    s2lbl.Text = team[0].player[12].oyuncuAd;
                    s3lbl.Text = team[0].player[13].oyuncuAd;
                    s4lbl.Text = team[0].player[14].oyuncuAd;
                    s5lbl.Text = team[0].player[15].oyuncuAd;
                    s6lbl.Text = team[0].player[16].oyuncuAd;
                    s7lbl.Text = team[0].player[17].oyuncuAd;
                }

                else if (label5.Text == "Brezilya")
                {
                    takimH = 1;

                    //oyuncuları kadroya ekler
                    gklbl.Text = team[1].player[0].oyuncuAd;
                    dllbl.Text = team[1].player[1].oyuncuAd;
                    drlbl.Text = team[1].player[2].oyuncuAd;
                    drclbl.Text = team[1].player[3].oyuncuAd;
                    dlclbl.Text = team[1].player[4].oyuncuAd;
                    mllbl.Text = team[1].player[5].oyuncuAd;
                    mrlbl.Text = team[1].player[6].oyuncuAd;
                    mrclbl.Text = team[1].player[7].oyuncuAd;
                    mlclbl.Text = team[1].player[8].oyuncuAd;
                    fllbl.Text = team[1].player[9].oyuncuAd;
                    frlbl.Text = team[1].player[10].oyuncuAd;
                    s1lbl.Text = team[1].player[11].oyuncuAd;
                    s2lbl.Text = team[1].player[12].oyuncuAd;
                    s3lbl.Text = team[1].player[13].oyuncuAd;
                    s4lbl.Text = team[1].player[14].oyuncuAd;
                    s5lbl.Text = team[1].player[15].oyuncuAd;
                    s6lbl.Text = team[1].player[16].oyuncuAd;
                    s7lbl.Text = team[1].player[17].oyuncuAd;

                }

                else if (label5.Text == "Hollanda")
                {
                    takimH = 2;

                    //oyuncuları kadroya ekler
                    gklbl.Text = team[2].player[0].oyuncuAd;
                    dllbl.Text = team[2].player[1].oyuncuAd;
                    drlbl.Text = team[2].player[2].oyuncuAd;
                    drclbl.Text = team[2].player[3].oyuncuAd;
                    dlclbl.Text = team[2].player[4].oyuncuAd;
                    mllbl.Text = team[2].player[5].oyuncuAd;
                    mrlbl.Text = team[2].player[6].oyuncuAd;
                    mrclbl.Text = team[2].player[7].oyuncuAd;
                    mlclbl.Text = team[2].player[8].oyuncuAd;
                    fllbl.Text = team[2].player[9].oyuncuAd;
                    frlbl.Text = team[2].player[10].oyuncuAd;
                    s1lbl.Text = team[2].player[11].oyuncuAd;
                    s2lbl.Text = team[2].player[12].oyuncuAd;
                    s3lbl.Text = team[2].player[13].oyuncuAd;
                    s4lbl.Text = team[2].player[14].oyuncuAd;
                    s5lbl.Text = team[2].player[15].oyuncuAd;
                    s6lbl.Text = team[2].player[16].oyuncuAd;
                    s7lbl.Text = team[2].player[17].oyuncuAd;

                }

                else if (label5.Text == "İngiltere")
                {
                    takimH = 3;

                    //oyuncuları kadroya ekler
                    gklbl.Text = team[3].player[0].oyuncuAd;
                    dllbl.Text = team[3].player[2].oyuncuAd;
                    drlbl.Text = team[3].player[3].oyuncuAd;
                    drclbl.Text = team[3].player[4].oyuncuAd;
                    dlclbl.Text = team[3].player[5].oyuncuAd;
                    mllbl.Text = team[3].player[6].oyuncuAd;
                    mrlbl.Text = team[3].player[7].oyuncuAd;
                    mrclbl.Text = team[3].player[8].oyuncuAd;
                    mlclbl.Text = team[3].player[9].oyuncuAd;
                    fllbl.Text = team[3].player[10].oyuncuAd;
                    frlbl.Text = team[3].player[11].oyuncuAd;
                    s1lbl.Text = team[3].player[1].oyuncuAd;
                    s2lbl.Text = team[3].player[12].oyuncuAd;
                    s3lbl.Text = team[3].player[13].oyuncuAd;
                    s4lbl.Text = team[3].player[14].oyuncuAd;
                    s5lbl.Text = team[3].player[15].oyuncuAd;
                    s6lbl.Text = team[3].player[16].oyuncuAd;
                    s7lbl.Text = team[3].player[17].oyuncuAd;

                }

                else if (label5.Text == "Türkiye")
                {
                    takimH = 4;

                    //oyuncuları kadroya ekler
                    gklbl.Text = team[4].player[0].oyuncuAd;
                    dllbl.Text = team[4].player[1].oyuncuAd;
                    drlbl.Text = team[4].player[2].oyuncuAd;
                    drclbl.Text = team[4].player[3].oyuncuAd;
                    dlclbl.Text = team[4].player[4].oyuncuAd;
                    mllbl.Text = team[4].player[5].oyuncuAd;
                    mrlbl.Text = team[4].player[6].oyuncuAd;
                    mrclbl.Text = team[4].player[7].oyuncuAd;
                    mlclbl.Text = team[4].player[8].oyuncuAd;
                    fllbl.Text = team[4].player[9].oyuncuAd;
                    frlbl.Text = team[4].player[10].oyuncuAd;
                    s1lbl.Text = team[4].player[11].oyuncuAd;
                    s2lbl.Text = team[4].player[12].oyuncuAd;
                    s3lbl.Text = team[4].player[13].oyuncuAd;
                    s4lbl.Text = team[4].player[14].oyuncuAd;
                    s5lbl.Text = team[4].player[15].oyuncuAd;
                    s6lbl.Text = team[4].player[16].oyuncuAd;
                    s7lbl.Text = team[4].player[17].oyuncuAd;
                }
            }
            else
            {
                //çekmece açıksa kapatır kapalıysa açar
                tacBox.Visible = false;
                control = !control;
            }
        }

        //tactics butonu
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            uygula.Enabled = true;              //uygula butonunu aktive eder
            if (tactics.SelectedIndex == 0)     //listedeki ilk taktik(4-3-3)
            {
                gk.Visible = true;
                dl4.Visible = true;
                dc4.Visible = true;
                dc4_2.Visible = true;
                dr4.Visible = true;
                ml5.Visible = true;
                mc5.Visible = true;
                mr5.Visible = true;
                scL.Visible = true;
                scR.Visible = true;
                ss433.Visible = true;
                ml442.Visible = false;
                mc442.Visible = false;
                mc442_2.Visible = false;
                mr442.Visible = false;
                dc532.Visible = false;
                mc532.Visible = false;
                scL.Left = 426;
                scR.Left = 472;
                scL.Left -= 21;
                scR.Left += 21;
                dc4.Left = 423;
                dc4_2.Left = 474;
                ml442.Top = 123;
                mr442.Top = 123;

                //yukarıdaki pozisyon gösteren butonlar
                p1.Enabled = true;
                p2.Enabled = true;
                p3.Enabled = true;
                p4.Enabled = true;
                p5.Enabled = true;
                p6.Enabled = true;
                p7.Enabled = true;
                p8.Enabled = true;
                p9.Enabled = true;
                p10.Enabled = true;
                p11.Enabled = true;
                y1.Enabled = true;
                y2.Enabled = true;
                y3.Enabled = true;
                y4.Enabled = true;
                y5.Enabled = true;
                y6.Enabled = true;
                y7.Enabled = true;

                //taktiğin bulundurduğu mevkiiler
                p1.Text = "GK";
                p2.Text = "DL";
                p3.Text = "DR";
                p4.Text = "DC";
                p5.Text = "DC";
                p6.Text = "MC";
                p7.Text = "MC";
                p8.Text = "MC";
                p9.Text = "LWF";
                p10.Text = "ST";
                p11.Text = "RWF";
                y1.Text = "S1";
                y2.Text = "S2";
                y3.Text = "S3";
                y4.Text = "S4";
                y5.Text = "S5";
                y6.Text = "S6";
                y7.Text = "S7";

                //combobox pozisyonlar
                comboBox1.Items.Clear();
                comboBox1.Items.Add("GK");
                comboBox1.Items.Add("DL");
                comboBox1.Items.Add("DR");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("LWF");
                comboBox1.Items.Add("ST");
                comboBox1.Items.Add("RWF");
                comboBox1.Items.Add("S1");
                comboBox1.Items.Add("S2");
                comboBox1.Items.Add("S3");
                comboBox1.Items.Add("S4");
                comboBox1.Items.Add("S5");
                comboBox1.Items.Add("S6");
                comboBox1.Items.Add("S7");

                //combobox pozisyonlar
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GK");
                comboBox2.Items.Add("DL");
                comboBox2.Items.Add("DR");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("LWF");
                comboBox2.Items.Add("ST");
                comboBox2.Items.Add("RWF");
                comboBox2.Items.Add("S1");
                comboBox2.Items.Add("S2");
                comboBox2.Items.Add("S3");
                comboBox2.Items.Add("S4");
                comboBox2.Items.Add("S5");
                comboBox2.Items.Add("S6");
                comboBox2.Items.Add("S7");

                //combobox pozisyonlar
                comboBox3.Items.Clear();
                comboBox3.Items.Add("GK");
                comboBox3.Items.Add("DL");
                comboBox3.Items.Add("DR");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("LWF");
                comboBox3.Items.Add("ST");
                comboBox3.Items.Add("RWF");
                comboBox3.Items.Add("S1");
                comboBox3.Items.Add("S2");
                comboBox3.Items.Add("S3");
                comboBox3.Items.Add("S4");
                comboBox3.Items.Add("S5");
                comboBox3.Items.Add("S6");
                comboBox3.Items.Add("S7");

                //combobox pozisyonlar
                comboBox4.Items.Clear();
                comboBox4.Items.Add("GK");
                comboBox4.Items.Add("DL");
                comboBox4.Items.Add("DR");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("LWF");
                comboBox4.Items.Add("ST");
                comboBox4.Items.Add("RWF");
                comboBox4.Items.Add("S1");
                comboBox4.Items.Add("S2");
                comboBox4.Items.Add("S3");
                comboBox4.Items.Add("S4");
                comboBox4.Items.Add("S5");
                comboBox4.Items.Add("S6");
                comboBox4.Items.Add("S7");

                //combobox pozisyonlar
                comboBox5.Items.Clear();
                comboBox5.Items.Add("GK");
                comboBox5.Items.Add("DL");
                comboBox5.Items.Add("DR");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("LWF");
                comboBox5.Items.Add("ST");
                comboBox5.Items.Add("RWF");
                comboBox5.Items.Add("S1");
                comboBox5.Items.Add("S2");
                comboBox5.Items.Add("S3");
                comboBox5.Items.Add("S4");
                comboBox5.Items.Add("S5");
                comboBox5.Items.Add("S6");
                comboBox5.Items.Add("S7");

                //combobox pozisyonlar
                comboBox6.Items.Clear();
                comboBox6.Items.Add("GK");
                comboBox6.Items.Add("DL");
                comboBox6.Items.Add("DR");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("LWF");
                comboBox6.Items.Add("ST");
                comboBox6.Items.Add("RWF");
                comboBox6.Items.Add("S1");
                comboBox6.Items.Add("S2");
                comboBox6.Items.Add("S3");
                comboBox6.Items.Add("S4");
                comboBox6.Items.Add("S5");
                comboBox6.Items.Add("S6");
                comboBox6.Items.Add("S7");

                //combobox pozisyonlar
                comboBox7.Items.Clear();
                comboBox7.Items.Add("GK");
                comboBox7.Items.Add("DL");
                comboBox7.Items.Add("DR");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("LWF");
                comboBox7.Items.Add("ST");
                comboBox7.Items.Add("RWF");
                comboBox7.Items.Add("S1");
                comboBox7.Items.Add("S2");
                comboBox7.Items.Add("S3");
                comboBox7.Items.Add("S4");
                comboBox7.Items.Add("S5");
                comboBox7.Items.Add("S6");
                comboBox7.Items.Add("S7");

                //combobox pozisyonlar
                comboBox8.Items.Clear();
                comboBox8.Items.Add("GK");
                comboBox8.Items.Add("DL");
                comboBox8.Items.Add("DR");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("LWF");
                comboBox8.Items.Add("ST");
                comboBox8.Items.Add("RWF");
                comboBox8.Items.Add("S1");
                comboBox8.Items.Add("S2");
                comboBox8.Items.Add("S3");
                comboBox8.Items.Add("S4");
                comboBox8.Items.Add("S5");
                comboBox8.Items.Add("S6");
                comboBox8.Items.Add("S7");

                //combobox pozisyonlar
                comboBox9.Items.Clear();
                comboBox9.Items.Add("GK");
                comboBox9.Items.Add("DL");
                comboBox9.Items.Add("DR");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("LWF");
                comboBox9.Items.Add("ST");
                comboBox9.Items.Add("RWF");
                comboBox9.Items.Add("S1");
                comboBox9.Items.Add("S2");
                comboBox9.Items.Add("S3");
                comboBox9.Items.Add("S4");
                comboBox9.Items.Add("S5");
                comboBox9.Items.Add("S6");
                comboBox9.Items.Add("S7");

                //combobox pozisyonlar
                comboBox10.Items.Clear();
                comboBox10.Items.Add("GK");
                comboBox10.Items.Add("DL");
                comboBox10.Items.Add("DR");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("LWF");
                comboBox10.Items.Add("ST");
                comboBox10.Items.Add("RWF");
                comboBox10.Items.Add("S1");
                comboBox10.Items.Add("S2");
                comboBox10.Items.Add("S3");
                comboBox10.Items.Add("S4");
                comboBox10.Items.Add("S5");
                comboBox10.Items.Add("S6");
                comboBox10.Items.Add("S7");

                //combobox pozisyonlar
                comboBox11.Items.Clear();
                comboBox11.Items.Add("GK");
                comboBox11.Items.Add("DL");
                comboBox11.Items.Add("DR");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("LWF");
                comboBox11.Items.Add("ST");
                comboBox11.Items.Add("RWF");
                comboBox11.Items.Add("S1");
                comboBox11.Items.Add("S2");
                comboBox11.Items.Add("S3");
                comboBox11.Items.Add("S4");
                comboBox11.Items.Add("S5");
                comboBox11.Items.Add("S6");
                comboBox11.Items.Add("S7");

                //combobox pozisyonlar
                comboBox12.Items.Clear();
                comboBox12.Items.Add("GK");
                comboBox12.Items.Add("DL");
                comboBox12.Items.Add("DR");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("LWF");
                comboBox12.Items.Add("ST");
                comboBox12.Items.Add("RWF");
                comboBox12.Items.Add("S1");
                comboBox12.Items.Add("S2");
                comboBox12.Items.Add("S3");
                comboBox12.Items.Add("S4");
                comboBox12.Items.Add("S5");
                comboBox12.Items.Add("S6");
                comboBox12.Items.Add("S7");

                //combobox pozisyonlar
                comboBox13.Items.Clear();
                comboBox13.Items.Add("GK");
                comboBox13.Items.Add("DL");
                comboBox13.Items.Add("DR");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("LWF");
                comboBox13.Items.Add("ST");
                comboBox13.Items.Add("RWF");
                comboBox13.Items.Add("S1");
                comboBox13.Items.Add("S2");
                comboBox13.Items.Add("S3");
                comboBox13.Items.Add("S4");
                comboBox13.Items.Add("S5");
                comboBox13.Items.Add("S6");
                comboBox13.Items.Add("S7");

                //combobox pozisyonlar
                comboBox14.Items.Clear();
                comboBox14.Items.Add("GK");
                comboBox14.Items.Add("DL");
                comboBox14.Items.Add("DR");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("LWF");
                comboBox14.Items.Add("ST");
                comboBox14.Items.Add("RWF");
                comboBox14.Items.Add("S1");
                comboBox14.Items.Add("S2");
                comboBox14.Items.Add("S3");
                comboBox14.Items.Add("S4");
                comboBox14.Items.Add("S5");
                comboBox14.Items.Add("S6");
                comboBox14.Items.Add("S7");

                //combobox pozisyonlar
                comboBox15.Items.Clear();
                comboBox15.Items.Add("GK");
                comboBox15.Items.Add("DL");
                comboBox15.Items.Add("DR");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("LWF");
                comboBox15.Items.Add("ST");
                comboBox15.Items.Add("RWF");
                comboBox15.Items.Add("S1");
                comboBox15.Items.Add("S2");
                comboBox15.Items.Add("S3");
                comboBox15.Items.Add("S4");
                comboBox15.Items.Add("S5");
                comboBox15.Items.Add("S6");
                comboBox15.Items.Add("S7");

                //combobox pozisyonlar
                comboBox16.Items.Clear();
                comboBox16.Items.Add("GK");
                comboBox16.Items.Add("DL");
                comboBox16.Items.Add("DR");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("LWF");
                comboBox16.Items.Add("ST");
                comboBox16.Items.Add("RWF");
                comboBox16.Items.Add("S1");
                comboBox16.Items.Add("S2");
                comboBox16.Items.Add("S3");
                comboBox16.Items.Add("S4");
                comboBox16.Items.Add("S5");
                comboBox16.Items.Add("S6");
                comboBox16.Items.Add("S7");

                //combobox pozisyonlar
                comboBox17.Items.Clear();
                comboBox17.Items.Add("GK");
                comboBox17.Items.Add("DL");
                comboBox17.Items.Add("DR");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("LWF");
                comboBox17.Items.Add("ST");
                comboBox17.Items.Add("RWF");
                comboBox17.Items.Add("S1");
                comboBox17.Items.Add("S2");
                comboBox17.Items.Add("S3");
                comboBox17.Items.Add("S4");
                comboBox17.Items.Add("S5");
                comboBox17.Items.Add("S6");
                comboBox17.Items.Add("S7");

                //combobox pozisyonlar
                comboBox18.Items.Clear();
                comboBox18.Items.Add("GK");
                comboBox18.Items.Add("DL");
                comboBox18.Items.Add("DR");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("LWF");
                comboBox18.Items.Add("ST");
                comboBox18.Items.Add("RWF");
                comboBox18.Items.Add("S1");
                comboBox18.Items.Add("S2");
                comboBox18.Items.Add("S3");
                comboBox18.Items.Add("S4");
                comboBox18.Items.Add("S5");
                comboBox18.Items.Add("S6");
                comboBox18.Items.Add("S7");

                if (label5.Text == "Arjantin")              //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.LightSkyBlue;
                    dl4.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc4.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc4_2.BackColor = System.Drawing.Color.LightSkyBlue;
                    dr4.BackColor = System.Drawing.Color.LightSkyBlue;
                    ml5.BackColor = System.Drawing.Color.LightSkyBlue;
                    mc5.BackColor = System.Drawing.Color.LightSkyBlue;
                    mr5.BackColor = System.Drawing.Color.LightSkyBlue;
                    scL.BackColor = System.Drawing.Color.LightSkyBlue;
                    scR.BackColor = System.Drawing.Color.LightSkyBlue;
                    ss433.BackColor = System.Drawing.Color.LightSkyBlue;
                    gk.ForeColor = System.Drawing.Color.Black;
                    dl4.ForeColor = System.Drawing.Color.Black;
                    dc4.ForeColor = System.Drawing.Color.Black;
                    dc4_2.ForeColor = System.Drawing.Color.Black;
                    dr4.ForeColor = System.Drawing.Color.Black;
                    ml5.ForeColor = System.Drawing.Color.Black;
                    mc5.ForeColor = System.Drawing.Color.Black;
                    mr5.ForeColor = System.Drawing.Color.Black;
                    scL.ForeColor = System.Drawing.Color.Black;
                    scR.ForeColor = System.Drawing.Color.Black;
                    ss433.ForeColor = System.Drawing.Color.Black;
                }

                else if (label5.Text == "Brezilya")         //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.Yellow;
                    dl4.BackColor = System.Drawing.Color.Yellow;
                    dc4.BackColor = System.Drawing.Color.Yellow;
                    dc4_2.BackColor = System.Drawing.Color.Yellow;
                    dr4.BackColor = System.Drawing.Color.Yellow;
                    ml5.BackColor = System.Drawing.Color.Yellow;
                    mc5.BackColor = System.Drawing.Color.Yellow;
                    mr5.BackColor = System.Drawing.Color.Yellow;
                    scL.BackColor = System.Drawing.Color.Yellow;
                    scR.BackColor = System.Drawing.Color.Yellow;
                    ss433.BackColor = System.Drawing.Color.Yellow;

                    gk.ForeColor = System.Drawing.Color.ForestGreen;
                    dl4.ForeColor = System.Drawing.Color.ForestGreen;
                    dc4.ForeColor = System.Drawing.Color.ForestGreen;
                    dc4_2.ForeColor = System.Drawing.Color.ForestGreen;
                    dr4.ForeColor = System.Drawing.Color.ForestGreen;
                    ml5.ForeColor = System.Drawing.Color.ForestGreen;
                    mc5.ForeColor = System.Drawing.Color.ForestGreen;
                    mr5.ForeColor = System.Drawing.Color.ForestGreen;
                    scL.ForeColor = System.Drawing.Color.ForestGreen;
                    scR.ForeColor = System.Drawing.Color.ForestGreen;
                    ss433.ForeColor = System.Drawing.Color.ForestGreen;
                }

                else if (label5.Text == "Hollanda")         //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.OrangeRed;
                    dl4.BackColor = System.Drawing.Color.OrangeRed;
                    dc4.BackColor = System.Drawing.Color.OrangeRed;
                    dc4_2.BackColor = System.Drawing.Color.OrangeRed;
                    dr4.BackColor = System.Drawing.Color.OrangeRed;
                    ml5.BackColor = System.Drawing.Color.OrangeRed;
                    mc5.BackColor = System.Drawing.Color.OrangeRed;
                    mr5.BackColor = System.Drawing.Color.OrangeRed;
                    scL.BackColor = System.Drawing.Color.OrangeRed;
                    scR.BackColor = System.Drawing.Color.OrangeRed;
                    ss433.BackColor = System.Drawing.Color.OrangeRed;

                    gk.ForeColor = System.Drawing.Color.White;
                    dl4.ForeColor = System.Drawing.Color.White;
                    dc4.ForeColor = System.Drawing.Color.White;
                    dc4_2.ForeColor = System.Drawing.Color.White;
                    dr4.ForeColor = System.Drawing.Color.White;
                    ml5.ForeColor = System.Drawing.Color.White;
                    mc5.ForeColor = System.Drawing.Color.White;
                    mr5.ForeColor = System.Drawing.Color.White;
                    scL.ForeColor = System.Drawing.Color.White;
                    scR.ForeColor = System.Drawing.Color.White;
                    ss433.ForeColor = System.Drawing.Color.White;
                }

                else if (label5.Text == "İngiltere")        //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.White;
                    dl4.BackColor = System.Drawing.Color.White;
                    dc4.BackColor = System.Drawing.Color.White;
                    dc4_2.BackColor = System.Drawing.Color.White;
                    dr4.BackColor = System.Drawing.Color.White;
                    ml5.BackColor = System.Drawing.Color.White;
                    mc5.BackColor = System.Drawing.Color.White;
                    mr5.BackColor = System.Drawing.Color.White;
                    scL.BackColor = System.Drawing.Color.White;
                    scR.BackColor = System.Drawing.Color.White;
                    ss433.BackColor = System.Drawing.Color.White;

                    gk.ForeColor = System.Drawing.Color.Navy;
                    dl4.ForeColor = System.Drawing.Color.Navy;
                    dc4.ForeColor = System.Drawing.Color.Navy;
                    dc4_2.ForeColor = System.Drawing.Color.Navy;
                    dr4.ForeColor = System.Drawing.Color.Navy;
                    ml5.ForeColor = System.Drawing.Color.Navy;
                    mc5.ForeColor = System.Drawing.Color.Navy;
                    mr5.ForeColor = System.Drawing.Color.Navy;
                    scL.ForeColor = System.Drawing.Color.Navy;
                    scR.ForeColor = System.Drawing.Color.Navy;
                    ss433.ForeColor = System.Drawing.Color.Navy;
                }

                else if (label5.Text == "Türkiye")          //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.Red;
                    dl4.BackColor = System.Drawing.Color.Red;
                    dc4.BackColor = System.Drawing.Color.Red;
                    dc4_2.BackColor = System.Drawing.Color.Red;
                    dr4.BackColor = System.Drawing.Color.Red;
                    ml5.BackColor = System.Drawing.Color.Red;
                    mc5.BackColor = System.Drawing.Color.Red;
                    mr5.BackColor = System.Drawing.Color.Red;
                    scL.BackColor = System.Drawing.Color.Red;
                    scR.BackColor = System.Drawing.Color.Red;
                    ss433.BackColor = System.Drawing.Color.Red;

                    gk.ForeColor = System.Drawing.Color.White;
                    dl4.ForeColor = System.Drawing.Color.White;
                    dc4.ForeColor = System.Drawing.Color.White;
                    dc4_2.ForeColor = System.Drawing.Color.White;
                    dr4.ForeColor = System.Drawing.Color.White;
                    ml5.ForeColor = System.Drawing.Color.White;
                    mc5.ForeColor = System.Drawing.Color.White;
                    mr5.ForeColor = System.Drawing.Color.White;
                    scL.ForeColor = System.Drawing.Color.White;
                    scR.ForeColor = System.Drawing.Color.White;
                    ss433.ForeColor = System.Drawing.Color.White;
                }
            }

            else if (tactics.SelectedIndex == 1)        //listedeki ilk taktik(4-3-3)
            {
                gk.Visible = true;
                dl4.Visible = true;
                dc4.Visible = true;
                dc4_2.Visible = true;
                dr4.Visible = true;
                ml442.Visible = true;
                mc442.Visible = true;
                mc442_2.Visible = true;
                mr442.Visible = true;
                scL.Visible = true;
                scR.Visible = true;
                ml5.Visible = false;
                mc5.Visible = false;
                mr5.Visible = false;
                ss433.Visible = false;
                dc532.Visible = false;
                mc532.Visible = false;
                scL.Left = 426;
                scR.Left = 472;
                dc4.Left = 423;
                dc4_2.Left = 474;
                ml442.Top = 123;
                mr442.Top = 123;

                //yukarıdaki pozisyon gösteren butonlar
                p1.Enabled = true;
                p2.Enabled = true;
                p3.Enabled = true;
                p4.Enabled = true;
                p5.Enabled = true;
                p6.Enabled = true;
                p7.Enabled = true;
                p8.Enabled = true;
                p9.Enabled = true;
                p10.Enabled = true;
                p11.Enabled = true;
                y1.Enabled = true;
                y2.Enabled = true;
                y3.Enabled = true;
                y4.Enabled = true;
                y5.Enabled = true;
                y6.Enabled = true;
                y7.Enabled = true;

                p1.Text = "GK";
                p2.Text = "DL";
                p3.Text = "DR";
                p4.Text = "DC";
                p5.Text = "DC";
                p6.Text = "ML";
                p7.Text = "MR";
                p8.Text = "MC";
                p9.Text = "MC";
                p10.Text = "ST";
                p11.Text = "ST";
                y1.Text = "S1";
                y2.Text = "S2";
                y3.Text = "S3";
                y4.Text = "S4";
                y5.Text = "S5";
                y6.Text = "S6";
                y7.Text = "S7";

                //combobox pozisyonlar
                comboBox1.Items.Clear();
                comboBox1.Items.Add("GK");
                comboBox1.Items.Add("DL");
                comboBox1.Items.Add("DR");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("ML");
                comboBox1.Items.Add("MR");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("ST");
                comboBox1.Items.Add("ST");
                comboBox1.Items.Add("S1");
                comboBox1.Items.Add("S2");
                comboBox1.Items.Add("S3");
                comboBox1.Items.Add("S4");
                comboBox1.Items.Add("S5");
                comboBox1.Items.Add("S6");
                comboBox1.Items.Add("S7");

                //combobox pozisyonlar
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GK");
                comboBox2.Items.Add("DL");
                comboBox2.Items.Add("DR");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("ML");
                comboBox2.Items.Add("MR");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("ST");
                comboBox2.Items.Add("ST");
                comboBox2.Items.Add("S1");
                comboBox2.Items.Add("S2");
                comboBox2.Items.Add("S3");
                comboBox2.Items.Add("S4");
                comboBox2.Items.Add("S5");
                comboBox2.Items.Add("S6");
                comboBox2.Items.Add("S7");

                //combobox pozisyonlar
                comboBox3.Items.Clear();
                comboBox3.Items.Add("GK");
                comboBox3.Items.Add("DL");
                comboBox3.Items.Add("DR");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("ML");
                comboBox3.Items.Add("MR");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("ST");
                comboBox3.Items.Add("ST");
                comboBox3.Items.Add("S1");
                comboBox3.Items.Add("S2");
                comboBox3.Items.Add("S3");
                comboBox3.Items.Add("S4");
                comboBox3.Items.Add("S5");
                comboBox3.Items.Add("S6");
                comboBox3.Items.Add("S7");

                //combobox pozisyonlar
                comboBox4.Items.Clear();
                comboBox4.Items.Add("GK");
                comboBox4.Items.Add("DL");
                comboBox4.Items.Add("DR");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("ML");
                comboBox4.Items.Add("MR");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("ST");
                comboBox4.Items.Add("ST");
                comboBox4.Items.Add("S1");
                comboBox4.Items.Add("S2");
                comboBox4.Items.Add("S3");
                comboBox4.Items.Add("S4");
                comboBox4.Items.Add("S5");
                comboBox4.Items.Add("S6");
                comboBox4.Items.Add("S7");

                //combobox pozisyonlar
                comboBox5.Items.Clear();
                comboBox5.Items.Add("GK");
                comboBox5.Items.Add("DL");
                comboBox5.Items.Add("DR");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("ML");
                comboBox5.Items.Add("MR");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("ST");
                comboBox5.Items.Add("ST");
                comboBox5.Items.Add("S1");
                comboBox5.Items.Add("S2");
                comboBox5.Items.Add("S3");
                comboBox5.Items.Add("S4");
                comboBox5.Items.Add("S5");
                comboBox5.Items.Add("S6");
                comboBox5.Items.Add("S7");

                //combobox pozisyonlar
                comboBox6.Items.Clear();
                comboBox6.Items.Add("GK");
                comboBox6.Items.Add("DL");
                comboBox6.Items.Add("DR");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("ML");
                comboBox6.Items.Add("MR");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("ST");
                comboBox6.Items.Add("ST");
                comboBox6.Items.Add("S1");
                comboBox6.Items.Add("S2");
                comboBox6.Items.Add("S3");
                comboBox6.Items.Add("S4");
                comboBox6.Items.Add("S5");
                comboBox6.Items.Add("S6");
                comboBox6.Items.Add("S7");

                comboBox7.Items.Clear();
                comboBox7.Items.Add("GK");
                comboBox7.Items.Add("DL");
                comboBox7.Items.Add("DR");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("ML");
                comboBox7.Items.Add("MR");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("ST");
                comboBox7.Items.Add("ST");
                comboBox7.Items.Add("S1");
                comboBox7.Items.Add("S2");
                comboBox7.Items.Add("S3");
                comboBox7.Items.Add("S4");
                comboBox7.Items.Add("S5");
                comboBox7.Items.Add("S6");
                comboBox7.Items.Add("S7");

                comboBox8.Items.Clear();
                comboBox8.Items.Add("GK");
                comboBox8.Items.Add("DL");
                comboBox8.Items.Add("DR");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("ML");
                comboBox8.Items.Add("MR");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("ST");
                comboBox8.Items.Add("ST");
                comboBox8.Items.Add("S1");
                comboBox8.Items.Add("S2");
                comboBox8.Items.Add("S3");
                comboBox8.Items.Add("S4");
                comboBox8.Items.Add("S5");
                comboBox8.Items.Add("S6");
                comboBox8.Items.Add("S7");

                //combobox pozisyonlar
                comboBox9.Items.Clear();
                comboBox9.Items.Add("GK");
                comboBox9.Items.Add("DL");
                comboBox9.Items.Add("DR");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("ML");
                comboBox9.Items.Add("MR");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("ST");
                comboBox9.Items.Add("ST");
                comboBox9.Items.Add("S1");
                comboBox9.Items.Add("S2");
                comboBox9.Items.Add("S3");
                comboBox9.Items.Add("S4");
                comboBox9.Items.Add("S5");
                comboBox9.Items.Add("S6");
                comboBox9.Items.Add("S7");

                //combobox pozisyonlar
                comboBox10.Items.Clear();
                comboBox10.Items.Add("GK");
                comboBox10.Items.Add("DL");
                comboBox10.Items.Add("DR");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("ML");
                comboBox10.Items.Add("MR");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("ST");
                comboBox10.Items.Add("ST");
                comboBox10.Items.Add("S1");
                comboBox10.Items.Add("S2");
                comboBox10.Items.Add("S3");
                comboBox10.Items.Add("S4");
                comboBox10.Items.Add("S5");
                comboBox10.Items.Add("S6");
                comboBox10.Items.Add("S7");

                //combobox pozisyonlar
                comboBox11.Items.Clear();
                comboBox11.Items.Add("GK");
                comboBox11.Items.Add("DL");
                comboBox11.Items.Add("DR");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("ML");
                comboBox11.Items.Add("MR");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("ST");
                comboBox11.Items.Add("ST");
                comboBox11.Items.Add("S1");
                comboBox11.Items.Add("S2");
                comboBox11.Items.Add("S3");
                comboBox11.Items.Add("S4");
                comboBox11.Items.Add("S5");
                comboBox11.Items.Add("S6");
                comboBox11.Items.Add("S7");

                //combobox pozisyonlar
                comboBox12.Items.Clear();
                comboBox12.Items.Add("GK");
                comboBox12.Items.Add("DL");
                comboBox12.Items.Add("DR");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("ML");
                comboBox12.Items.Add("MR");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("ST");
                comboBox12.Items.Add("ST");
                comboBox12.Items.Add("S1");
                comboBox12.Items.Add("S2");
                comboBox12.Items.Add("S3");
                comboBox12.Items.Add("S4");
                comboBox12.Items.Add("S5");
                comboBox12.Items.Add("S6");
                comboBox12.Items.Add("S7");

                //combobox pozisyonlar
                comboBox13.Items.Clear();
                comboBox13.Items.Add("GK");
                comboBox13.Items.Add("DL");
                comboBox13.Items.Add("DR");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("ML");
                comboBox13.Items.Add("MR");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("ST");
                comboBox13.Items.Add("ST");
                comboBox13.Items.Add("S1");
                comboBox13.Items.Add("S2");
                comboBox13.Items.Add("S3");
                comboBox13.Items.Add("S4");
                comboBox13.Items.Add("S5");
                comboBox13.Items.Add("S6");
                comboBox13.Items.Add("S7");

                //combobox pozisyonlar
                comboBox14.Items.Clear();
                comboBox14.Items.Add("GK");
                comboBox14.Items.Add("DL");
                comboBox14.Items.Add("DR");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("ML");
                comboBox14.Items.Add("MR");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("ST");
                comboBox14.Items.Add("ST");
                comboBox14.Items.Add("S1");
                comboBox14.Items.Add("S2");
                comboBox14.Items.Add("S3");
                comboBox14.Items.Add("S4");
                comboBox14.Items.Add("S5");
                comboBox14.Items.Add("S6");
                comboBox14.Items.Add("S7");

                //combobox pozisyonlar
                comboBox15.Items.Clear();
                comboBox15.Items.Add("GK");
                comboBox15.Items.Add("DL");
                comboBox15.Items.Add("DR");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("ML");
                comboBox15.Items.Add("MR");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("ST");
                comboBox15.Items.Add("ST");
                comboBox15.Items.Add("S1");
                comboBox15.Items.Add("S2");
                comboBox15.Items.Add("S3");
                comboBox15.Items.Add("S4");
                comboBox15.Items.Add("S5");
                comboBox15.Items.Add("S6");
                comboBox15.Items.Add("S7");

                //combobox pozisyonlar
                comboBox16.Items.Clear();
                comboBox16.Items.Add("GK");
                comboBox16.Items.Add("DL");
                comboBox16.Items.Add("DR");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("ML");
                comboBox16.Items.Add("MR");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("ST");
                comboBox16.Items.Add("ST");
                comboBox16.Items.Add("S1");
                comboBox16.Items.Add("S2");
                comboBox16.Items.Add("S3");
                comboBox16.Items.Add("S4");
                comboBox16.Items.Add("S5");
                comboBox16.Items.Add("S6");
                comboBox16.Items.Add("S7");

                //combobox pozisyonlar
                comboBox17.Items.Clear();
                comboBox17.Items.Add("GK");
                comboBox17.Items.Add("DL");
                comboBox17.Items.Add("DR");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("ML");
                comboBox17.Items.Add("MR");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("ST");
                comboBox17.Items.Add("ST");
                comboBox17.Items.Add("S1");
                comboBox17.Items.Add("S2");
                comboBox17.Items.Add("S3");
                comboBox17.Items.Add("S4");
                comboBox17.Items.Add("S5");
                comboBox17.Items.Add("S6");
                comboBox17.Items.Add("S7");

                //combobox pozisyonlar
                comboBox18.Items.Clear();
                comboBox18.Items.Add("GK");
                comboBox18.Items.Add("DL");
                comboBox18.Items.Add("DR");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("ML");
                comboBox18.Items.Add("MR");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("ST");
                comboBox18.Items.Add("ST");
                comboBox18.Items.Add("S1");
                comboBox18.Items.Add("S2");
                comboBox18.Items.Add("S3");
                comboBox18.Items.Add("S4");
                comboBox18.Items.Add("S5");
                comboBox18.Items.Add("S6");
                comboBox18.Items.Add("S7");

                if (label5.Text == "Arjantin")              //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.LightSkyBlue;
                    dl4.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc4.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc4_2.BackColor = System.Drawing.Color.LightSkyBlue;
                    dr4.BackColor = System.Drawing.Color.LightSkyBlue;
                    ml442.BackColor = System.Drawing.Color.LightSkyBlue;
                    mc442.BackColor = System.Drawing.Color.LightSkyBlue;
                    mc442_2.BackColor = System.Drawing.Color.LightSkyBlue;
                    scL.BackColor = System.Drawing.Color.LightSkyBlue;
                    scR.BackColor = System.Drawing.Color.LightSkyBlue;
                    mr442.BackColor = System.Drawing.Color.LightSkyBlue;

                    gk.ForeColor = System.Drawing.Color.Black;
                    dl4.ForeColor = System.Drawing.Color.Black;
                    dc4.ForeColor = System.Drawing.Color.Black;
                    dc4_2.ForeColor = System.Drawing.Color.Black;
                    dr4.ForeColor = System.Drawing.Color.Black;
                    ml442.ForeColor = System.Drawing.Color.Black;
                    mc442.ForeColor = System.Drawing.Color.Black;
                    mc442_2.ForeColor = System.Drawing.Color.Black;
                    scL.ForeColor = System.Drawing.Color.Black;
                    scR.ForeColor = System.Drawing.Color.Black;
                    mr442.ForeColor = System.Drawing.Color.Black;
                }

                else if (label5.Text == "Brezilya")         //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.Yellow;
                    dl4.BackColor = System.Drawing.Color.Yellow;
                    dc4.BackColor = System.Drawing.Color.Yellow;
                    dc4_2.BackColor = System.Drawing.Color.Yellow;
                    dr4.BackColor = System.Drawing.Color.Yellow;
                    ml442.BackColor = System.Drawing.Color.Yellow;
                    mc442.BackColor = System.Drawing.Color.Yellow;
                    mc442_2.BackColor = System.Drawing.Color.Yellow;
                    scL.BackColor = System.Drawing.Color.Yellow;
                    scR.BackColor = System.Drawing.Color.Yellow;
                    mr442.BackColor = System.Drawing.Color.Yellow;

                    gk.ForeColor = System.Drawing.Color.ForestGreen;
                    dl4.ForeColor = System.Drawing.Color.ForestGreen;
                    dc4.ForeColor = System.Drawing.Color.ForestGreen;
                    dc4_2.ForeColor = System.Drawing.Color.ForestGreen;
                    dr4.ForeColor = System.Drawing.Color.ForestGreen;
                    ml442.ForeColor = System.Drawing.Color.ForestGreen;
                    mc442.ForeColor = System.Drawing.Color.ForestGreen;
                    mc442_2.ForeColor = System.Drawing.Color.ForestGreen;
                    scL.ForeColor = System.Drawing.Color.ForestGreen;
                    scR.ForeColor = System.Drawing.Color.ForestGreen;
                    mr442.ForeColor = System.Drawing.Color.ForestGreen;
                }

                else if (label5.Text == "Hollanda")         //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.OrangeRed;
                    dl4.BackColor = System.Drawing.Color.OrangeRed;
                    dc4.BackColor = System.Drawing.Color.OrangeRed;
                    dc4_2.BackColor = System.Drawing.Color.OrangeRed;
                    dr4.BackColor = System.Drawing.Color.OrangeRed;
                    ml442.BackColor = System.Drawing.Color.OrangeRed;
                    mc442.BackColor = System.Drawing.Color.OrangeRed;
                    mc442_2.BackColor = System.Drawing.Color.OrangeRed;
                    scL.BackColor = System.Drawing.Color.OrangeRed;
                    scR.BackColor = System.Drawing.Color.OrangeRed;
                    mr442.BackColor = System.Drawing.Color.OrangeRed;

                    gk.ForeColor = System.Drawing.Color.White;
                    dl4.ForeColor = System.Drawing.Color.White;
                    dc4.ForeColor = System.Drawing.Color.White;
                    dc4_2.ForeColor = System.Drawing.Color.White;
                    dr4.ForeColor = System.Drawing.Color.White;
                    ml442.ForeColor = System.Drawing.Color.White;
                    mc442.ForeColor = System.Drawing.Color.White;
                    mc442_2.ForeColor = System.Drawing.Color.White;
                    scL.ForeColor = System.Drawing.Color.White;
                    scR.ForeColor = System.Drawing.Color.White;
                    mr442.ForeColor = System.Drawing.Color.White;
                }

                else if (label5.Text == "İngiltere")        //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.White;
                    dl4.BackColor = System.Drawing.Color.White;
                    dc4.BackColor = System.Drawing.Color.White;
                    dc4_2.BackColor = System.Drawing.Color.White;
                    dr4.BackColor = System.Drawing.Color.White;
                    ml442.BackColor = System.Drawing.Color.White;
                    mc442.BackColor = System.Drawing.Color.White;
                    mc442_2.BackColor = System.Drawing.Color.White;
                    scL.BackColor = System.Drawing.Color.White;
                    scR.BackColor = System.Drawing.Color.White;
                    mr442.BackColor = System.Drawing.Color.White;

                    gk.ForeColor = System.Drawing.Color.Navy;
                    dl4.ForeColor = System.Drawing.Color.Navy;
                    dc4.ForeColor = System.Drawing.Color.Navy;
                    dc4_2.ForeColor = System.Drawing.Color.Navy;
                    dr4.ForeColor = System.Drawing.Color.Navy;
                    ml442.ForeColor = System.Drawing.Color.Navy;
                    mc442.ForeColor = System.Drawing.Color.Navy;
                    mc442_2.ForeColor = System.Drawing.Color.Navy;
                    scL.ForeColor = System.Drawing.Color.Navy;
                    scR.ForeColor = System.Drawing.Color.Navy;
                    mr442.ForeColor = System.Drawing.Color.Navy;
                }

                else if (label5.Text == "Türkiye")          //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.Red;
                    dl4.BackColor = System.Drawing.Color.Red;
                    dc4.BackColor = System.Drawing.Color.Red;
                    dc4_2.BackColor = System.Drawing.Color.Red;
                    dr4.BackColor = System.Drawing.Color.Red;
                    ml442.BackColor = System.Drawing.Color.Red;
                    mc442.BackColor = System.Drawing.Color.Red;
                    mc442_2.BackColor = System.Drawing.Color.Red;
                    scL.BackColor = System.Drawing.Color.Red;
                    scR.BackColor = System.Drawing.Color.Red;
                    mr442.BackColor = System.Drawing.Color.Red;

                    gk.ForeColor = System.Drawing.Color.White;
                    dl4.ForeColor = System.Drawing.Color.White;
                    dc4.ForeColor = System.Drawing.Color.White;
                    dc4_2.ForeColor = System.Drawing.Color.White;
                    dr4.ForeColor = System.Drawing.Color.White;
                    ml442.ForeColor = System.Drawing.Color.White;
                    mc442.ForeColor = System.Drawing.Color.White;
                    mc442_2.ForeColor = System.Drawing.Color.White;
                    scL.ForeColor = System.Drawing.Color.White;
                    scR.ForeColor = System.Drawing.Color.White;
                    mr442.ForeColor = System.Drawing.Color.White;
                }
            }

            else if (tactics.SelectedIndex == 2)        //Listedeki üçüncü taktik (5-3-2)
            {
                gk.Visible = true;
                dc532.Visible = true;
                dl4.Visible = false;
                dc4.Visible = true;
                dc4_2.Visible = true;
                dr4.Visible = false;
                ml442.Visible = true;
                mc442.Visible = true;
                mc442_2.Visible = true;
                mr442.Visible = true;
                scL.Visible = true;
                scR.Visible = true;
                ml5.Visible = false;
                mc532.Visible = true;
                mc5.Visible = false;
                mr5.Visible = false;
                ss433.Visible = false;
                scL.Left = 426;
                scR.Left = 472;
                dc4.Left = 423;
                dc4_2.Left = 474;
                ml442.Top = 123;
                mr442.Top = 123;
                dc4.Left -= 21;
                dc4_2.Left += 21;
                ml442.Top += 27;
                mr442.Top += 27;

                //yukarıdaki pozisyon gösteren butonlar
                p1.Enabled = true;
                p2.Enabled = true;
                p3.Enabled = true;
                p4.Enabled = true;
                p5.Enabled = true;
                p6.Enabled = true;
                p7.Enabled = true;
                p8.Enabled = true;
                p9.Enabled = true;
                p10.Enabled = true;
                p11.Enabled = true;
                y1.Enabled = true;
                y2.Enabled = true;
                y3.Enabled = true;
                y4.Enabled = true;
                y5.Enabled = true;
                y6.Enabled = true;
                y7.Enabled = true;

                p1.Text = "GK";
                p2.Text = "DC";
                p3.Text = "DC";
                p4.Text = "DC";
                p5.Text = "DML";
                p6.Text = "DMR";
                p7.Text = "DMC";
                p8.Text = "MC";
                p9.Text = "MC";
                p10.Text = "ST";
                p11.Text = "ST";
                y1.Text = "S1";
                y2.Text = "S2";
                y3.Text = "S3";
                y4.Text = "S4";
                y5.Text = "S5";
                y6.Text = "S6";
                y7.Text = "S7";

                //combobox pozisyonlar
                comboBox1.Items.Clear();
                comboBox1.Items.Add("GK");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("DC");
                comboBox1.Items.Add("DML");
                comboBox1.Items.Add("DMR");
                comboBox1.Items.Add("DMC");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("MC");
                comboBox1.Items.Add("ST");
                comboBox1.Items.Add("ST");
                comboBox1.Items.Add("S1");
                comboBox1.Items.Add("S2");
                comboBox1.Items.Add("S3");
                comboBox1.Items.Add("S4");
                comboBox1.Items.Add("S5");
                comboBox1.Items.Add("S6");
                comboBox1.Items.Add("S7");

                //combobox pozisyonlar
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GK");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("DC");
                comboBox2.Items.Add("DML");
                comboBox2.Items.Add("DMR");
                comboBox2.Items.Add("DMC");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("MC");
                comboBox2.Items.Add("ST");
                comboBox2.Items.Add("ST");
                comboBox2.Items.Add("S1");
                comboBox2.Items.Add("S2");
                comboBox2.Items.Add("S3");
                comboBox2.Items.Add("S4");
                comboBox2.Items.Add("S5");
                comboBox2.Items.Add("S6");
                comboBox2.Items.Add("S7");

                //combobox pozisyonlar
                comboBox3.Items.Clear();
                comboBox3.Items.Add("GK");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("DC");
                comboBox3.Items.Add("DML");
                comboBox3.Items.Add("DMR");
                comboBox3.Items.Add("DMC");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("MC");
                comboBox3.Items.Add("ST");
                comboBox3.Items.Add("ST");
                comboBox3.Items.Add("S1");
                comboBox3.Items.Add("S2");
                comboBox3.Items.Add("S3");
                comboBox3.Items.Add("S4");
                comboBox3.Items.Add("S5");
                comboBox3.Items.Add("S6");
                comboBox3.Items.Add("S7");

                //combobox pozisyonlar
                comboBox4.Items.Clear();
                comboBox4.Items.Add("GK");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("DC");
                comboBox4.Items.Add("DML");
                comboBox4.Items.Add("DMR");
                comboBox4.Items.Add("DMC");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("MC");
                comboBox4.Items.Add("ST");
                comboBox4.Items.Add("ST");
                comboBox4.Items.Add("S1");
                comboBox4.Items.Add("S2");
                comboBox4.Items.Add("S3");
                comboBox4.Items.Add("S4");
                comboBox4.Items.Add("S5");
                comboBox4.Items.Add("S6");
                comboBox4.Items.Add("S7");

                //combobox pozisyonlar
                comboBox5.Items.Clear();
                comboBox5.Items.Add("GK");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("DC");
                comboBox5.Items.Add("DML");
                comboBox5.Items.Add("DMR");
                comboBox5.Items.Add("DMC");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("MC");
                comboBox5.Items.Add("ST");
                comboBox5.Items.Add("ST");
                comboBox5.Items.Add("S1");
                comboBox5.Items.Add("S2");
                comboBox5.Items.Add("S3");
                comboBox5.Items.Add("S4");
                comboBox5.Items.Add("S5");
                comboBox5.Items.Add("S6");
                comboBox5.Items.Add("S7");

                //combobox pozisyonlar
                comboBox6.Items.Clear();
                comboBox6.Items.Add("GK");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("DC");
                comboBox6.Items.Add("DML");
                comboBox6.Items.Add("DMR");
                comboBox6.Items.Add("DMC");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("MC");
                comboBox6.Items.Add("ST");
                comboBox6.Items.Add("ST");
                comboBox6.Items.Add("S1");
                comboBox6.Items.Add("S2");
                comboBox6.Items.Add("S3");
                comboBox6.Items.Add("S4");
                comboBox6.Items.Add("S5");
                comboBox6.Items.Add("S6");
                comboBox6.Items.Add("S7");

                //combobox pozisyonlar
                comboBox7.Items.Clear();
                comboBox7.Items.Add("GK");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("DC");
                comboBox7.Items.Add("DML");
                comboBox7.Items.Add("DMR");
                comboBox7.Items.Add("DMC");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("MC");
                comboBox7.Items.Add("ST");
                comboBox7.Items.Add("ST");
                comboBox7.Items.Add("S1");
                comboBox7.Items.Add("S2");
                comboBox7.Items.Add("S3");
                comboBox7.Items.Add("S4");
                comboBox7.Items.Add("S5");
                comboBox7.Items.Add("S6");
                comboBox7.Items.Add("S7");

                //combobox pozisyonlar
                comboBox8.Items.Clear();
                comboBox8.Items.Add("GK");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("DC");
                comboBox8.Items.Add("DML");
                comboBox8.Items.Add("DMR");
                comboBox8.Items.Add("DMC");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("MC");
                comboBox8.Items.Add("ST");
                comboBox8.Items.Add("ST");
                comboBox8.Items.Add("S1");
                comboBox8.Items.Add("S2");
                comboBox8.Items.Add("S3");
                comboBox8.Items.Add("S4");
                comboBox8.Items.Add("S5");
                comboBox8.Items.Add("S6");
                comboBox8.Items.Add("S7");

                //combobox pozisyonlar
                comboBox9.Items.Clear();
                comboBox9.Items.Add("GK");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("DC");
                comboBox9.Items.Add("DML");
                comboBox9.Items.Add("DMR");
                comboBox9.Items.Add("DMC");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("MC");
                comboBox9.Items.Add("ST");
                comboBox9.Items.Add("ST");
                comboBox9.Items.Add("S1");
                comboBox9.Items.Add("S2");
                comboBox9.Items.Add("S3");
                comboBox9.Items.Add("S4");
                comboBox9.Items.Add("S5");
                comboBox9.Items.Add("S6");
                comboBox9.Items.Add("S7");

                //combobox pozisyonlar
                comboBox10.Items.Clear();
                comboBox10.Items.Add("GK");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("DC");
                comboBox10.Items.Add("DML");
                comboBox10.Items.Add("DMR");
                comboBox10.Items.Add("DMC");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("MC");
                comboBox10.Items.Add("ST");
                comboBox10.Items.Add("ST");
                comboBox10.Items.Add("S1");
                comboBox10.Items.Add("S2");
                comboBox10.Items.Add("S3");
                comboBox10.Items.Add("S4");
                comboBox10.Items.Add("S5");
                comboBox10.Items.Add("S6");
                comboBox10.Items.Add("S7");

                //combobox pozisyonlar
                comboBox11.Items.Clear();
                comboBox11.Items.Add("GK");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("DC");
                comboBox11.Items.Add("DML");
                comboBox11.Items.Add("DMR");
                comboBox11.Items.Add("DMC");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("MC");
                comboBox11.Items.Add("ST");
                comboBox11.Items.Add("ST");
                comboBox11.Items.Add("S1");
                comboBox11.Items.Add("S2");
                comboBox11.Items.Add("S3");
                comboBox11.Items.Add("S4");
                comboBox11.Items.Add("S5");
                comboBox11.Items.Add("S6");
                comboBox11.Items.Add("S7");

                //combobox pozisyonlar
                comboBox12.Items.Clear();
                comboBox12.Items.Add("GK");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("DC");
                comboBox12.Items.Add("DML");
                comboBox12.Items.Add("DMR");
                comboBox12.Items.Add("DMC");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("MC");
                comboBox12.Items.Add("ST");
                comboBox12.Items.Add("ST");
                comboBox12.Items.Add("S1");
                comboBox12.Items.Add("S2");
                comboBox12.Items.Add("S3");
                comboBox12.Items.Add("S4");
                comboBox12.Items.Add("S5");
                comboBox12.Items.Add("S6");
                comboBox12.Items.Add("S7");

                //combobox pozisyonlar
                comboBox13.Items.Clear();
                comboBox13.Items.Add("GK");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("DC");
                comboBox13.Items.Add("DML");
                comboBox13.Items.Add("DMR");
                comboBox13.Items.Add("DMC");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("MC");
                comboBox13.Items.Add("ST");
                comboBox13.Items.Add("ST");
                comboBox13.Items.Add("S1");
                comboBox13.Items.Add("S2");
                comboBox13.Items.Add("S3");
                comboBox13.Items.Add("S4");
                comboBox13.Items.Add("S5");
                comboBox13.Items.Add("S6");
                comboBox13.Items.Add("S7");

                //combobox pozisyonlar
                comboBox14.Items.Clear();
                comboBox14.Items.Add("GK");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("DC");
                comboBox14.Items.Add("DML");
                comboBox14.Items.Add("DMR");
                comboBox14.Items.Add("DMC");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("MC");
                comboBox14.Items.Add("ST");
                comboBox14.Items.Add("ST");
                comboBox14.Items.Add("S1");
                comboBox14.Items.Add("S2");
                comboBox14.Items.Add("S3");
                comboBox14.Items.Add("S4");
                comboBox14.Items.Add("S5");
                comboBox14.Items.Add("S6");
                comboBox14.Items.Add("S7");

                //combobox pozisyonlar
                comboBox15.Items.Clear();
                comboBox15.Items.Add("GK");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("DC");
                comboBox15.Items.Add("DML");
                comboBox15.Items.Add("DMR");
                comboBox15.Items.Add("DMC");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("MC");
                comboBox15.Items.Add("ST");
                comboBox15.Items.Add("ST");
                comboBox15.Items.Add("S1");
                comboBox15.Items.Add("S2");
                comboBox15.Items.Add("S3");
                comboBox15.Items.Add("S4");
                comboBox15.Items.Add("S5");
                comboBox15.Items.Add("S6");
                comboBox15.Items.Add("S7");

                //combobox pozisyonlar
                comboBox16.Items.Clear();
                comboBox16.Items.Add("GK");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("DC");
                comboBox16.Items.Add("DML");
                comboBox16.Items.Add("DMR");
                comboBox16.Items.Add("DMC");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("MC");
                comboBox16.Items.Add("ST");
                comboBox16.Items.Add("ST");
                comboBox16.Items.Add("S1");
                comboBox16.Items.Add("S2");
                comboBox16.Items.Add("S3");
                comboBox16.Items.Add("S4");
                comboBox16.Items.Add("S5");
                comboBox16.Items.Add("S6");
                comboBox16.Items.Add("S7");

                //combobox pozisyonlar
                comboBox17.Items.Clear();
                comboBox17.Items.Add("GK");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("DC");
                comboBox17.Items.Add("DML");
                comboBox17.Items.Add("DMR");
                comboBox17.Items.Add("DMC");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("MC");
                comboBox17.Items.Add("ST");
                comboBox17.Items.Add("ST");
                comboBox17.Items.Add("S1");
                comboBox17.Items.Add("S2");
                comboBox17.Items.Add("S3");
                comboBox17.Items.Add("S4");
                comboBox17.Items.Add("S5");
                comboBox17.Items.Add("S6");
                comboBox17.Items.Add("S7");

                //combobox pozisyonlar
                comboBox18.Items.Clear();
                comboBox18.Items.Add("GK");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("DC");
                comboBox18.Items.Add("DML");
                comboBox18.Items.Add("DMR");
                comboBox18.Items.Add("DMC");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("MC");
                comboBox18.Items.Add("ST");
                comboBox18.Items.Add("ST");
                comboBox18.Items.Add("S1");
                comboBox18.Items.Add("S2");
                comboBox18.Items.Add("S3");
                comboBox18.Items.Add("S4");
                comboBox18.Items.Add("S5");
                comboBox18.Items.Add("S6");
                comboBox18.Items.Add("S7");

                if (label5.Text == "Arjantin")              //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc532.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc4.BackColor = System.Drawing.Color.LightSkyBlue;
                    dc4_2.BackColor = System.Drawing.Color.LightSkyBlue;
                    ml442.BackColor = System.Drawing.Color.LightSkyBlue;
                    mc532.BackColor = System.Drawing.Color.LightSkyBlue;
                    mc442.BackColor = System.Drawing.Color.LightSkyBlue;
                    mc442_2.BackColor = System.Drawing.Color.LightSkyBlue;
                    mr442.BackColor = System.Drawing.Color.LightSkyBlue;
                    scL.BackColor = System.Drawing.Color.LightSkyBlue;
                    scR.BackColor = System.Drawing.Color.LightSkyBlue;

                    gk.ForeColor = System.Drawing.Color.Black;
                    dc532.ForeColor = System.Drawing.Color.Black;
                    dc4.ForeColor = System.Drawing.Color.Black;
                    dc4_2.ForeColor = System.Drawing.Color.Black;
                    ml442.ForeColor = System.Drawing.Color.Black;
                    mc532.ForeColor = System.Drawing.Color.Black;
                    mc442.ForeColor = System.Drawing.Color.Black;
                    mc442_2.ForeColor = System.Drawing.Color.Black;
                    mr442.ForeColor = System.Drawing.Color.Black;
                    scL.ForeColor = System.Drawing.Color.Black;
                    scR.ForeColor = System.Drawing.Color.Black;
                }

                else if (label5.Text == "Brezilya")         //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.Yellow;
                    dc532.BackColor = System.Drawing.Color.Yellow;
                    dc4.BackColor = System.Drawing.Color.Yellow;
                    dc4_2.BackColor = System.Drawing.Color.Yellow;
                    ml442.BackColor = System.Drawing.Color.Yellow;
                    mc532.BackColor = System.Drawing.Color.Yellow;
                    mc442.BackColor = System.Drawing.Color.Yellow;
                    mc442_2.BackColor = System.Drawing.Color.Yellow;
                    mr442.BackColor = System.Drawing.Color.Yellow;
                    scL.BackColor = System.Drawing.Color.Yellow;
                    scR.BackColor = System.Drawing.Color.Yellow;

                    gk.ForeColor = System.Drawing.Color.ForestGreen;
                    dc532.ForeColor = System.Drawing.Color.ForestGreen;
                    dc4.ForeColor = System.Drawing.Color.ForestGreen;
                    dc4_2.ForeColor = System.Drawing.Color.ForestGreen;
                    ml442.ForeColor = System.Drawing.Color.ForestGreen;
                    mc532.ForeColor = System.Drawing.Color.ForestGreen;
                    mc442.ForeColor = System.Drawing.Color.ForestGreen;
                    mc442_2.ForeColor = System.Drawing.Color.ForestGreen;
                    mr442.ForeColor = System.Drawing.Color.ForestGreen;
                    scL.ForeColor = System.Drawing.Color.ForestGreen;
                    scR.ForeColor = System.Drawing.Color.ForestGreen;
                }

                else if (label5.Text == "Hollanda")         //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.OrangeRed;
                    dc532.BackColor = System.Drawing.Color.OrangeRed;
                    dc4.BackColor = System.Drawing.Color.OrangeRed;
                    dc4_2.BackColor = System.Drawing.Color.OrangeRed;
                    ml442.BackColor = System.Drawing.Color.OrangeRed;
                    mc532.BackColor = System.Drawing.Color.OrangeRed;
                    mc442.BackColor = System.Drawing.Color.OrangeRed;
                    mc442_2.BackColor = System.Drawing.Color.OrangeRed;
                    mr442.BackColor = System.Drawing.Color.OrangeRed;
                    scL.BackColor = System.Drawing.Color.OrangeRed;
                    scR.BackColor = System.Drawing.Color.OrangeRed;

                    //fg renk
                    gk.ForeColor = System.Drawing.Color.White;
                    dc532.ForeColor = System.Drawing.Color.White;
                    dc4.ForeColor = System.Drawing.Color.White;
                    dc4_2.ForeColor = System.Drawing.Color.White;
                    ml442.ForeColor = System.Drawing.Color.White;
                    mc532.ForeColor = System.Drawing.Color.White;
                    mc442.ForeColor = System.Drawing.Color.White;
                    mc442_2.ForeColor = System.Drawing.Color.White;
                    mr442.ForeColor = System.Drawing.Color.White;
                    scL.ForeColor = System.Drawing.Color.White;
                    scR.ForeColor = System.Drawing.Color.White;
                }

                else if (label5.Text == "İngiltere")        //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.White;
                    dc532.BackColor = System.Drawing.Color.White;
                    dc4.BackColor = System.Drawing.Color.White;
                    dc4_2.BackColor = System.Drawing.Color.White;
                    ml442.BackColor = System.Drawing.Color.White;
                    mc532.BackColor = System.Drawing.Color.White;
                    mc442.BackColor = System.Drawing.Color.White;
                    mc442_2.BackColor = System.Drawing.Color.White;
                    mr442.BackColor = System.Drawing.Color.White;
                    scL.BackColor = System.Drawing.Color.White;
                    scR.BackColor = System.Drawing.Color.White;

                    gk.ForeColor = System.Drawing.Color.Navy;
                    dc532.ForeColor = System.Drawing.Color.Navy;
                    dc4.ForeColor = System.Drawing.Color.Navy;
                    dc4_2.ForeColor = System.Drawing.Color.Navy;
                    ml442.ForeColor = System.Drawing.Color.Navy;
                    mc532.ForeColor = System.Drawing.Color.Navy;
                    mc442.ForeColor = System.Drawing.Color.Navy;
                    mc442_2.ForeColor = System.Drawing.Color.Navy;
                    mr442.ForeColor = System.Drawing.Color.Navy;
                    scL.ForeColor = System.Drawing.Color.Navy;
                    scR.ForeColor = System.Drawing.Color.Navy;
                }

                else if (label5.Text == "Türkiye")          //taktik tahtasındaki forma renkleri
                {
                    gk.BackColor = System.Drawing.Color.Red;
                    dc532.BackColor = System.Drawing.Color.Red;
                    dc4.BackColor = System.Drawing.Color.Red;
                    dc4_2.BackColor = System.Drawing.Color.Red;
                    ml442.BackColor = System.Drawing.Color.Red;
                    mc532.BackColor = System.Drawing.Color.Red;
                    mc442.BackColor = System.Drawing.Color.Red;
                    mc442_2.BackColor = System.Drawing.Color.Red;
                    mr442.BackColor = System.Drawing.Color.Red;
                    scL.BackColor = System.Drawing.Color.Red;
                    scR.BackColor = System.Drawing.Color.Red;

                    gk.ForeColor = System.Drawing.Color.White;
                    dc532.ForeColor = System.Drawing.Color.White;
                    dc4.ForeColor = System.Drawing.Color.White;
                    dc4_2.ForeColor = System.Drawing.Color.White;
                    ml442.ForeColor = System.Drawing.Color.White;
                    mc532.ForeColor = System.Drawing.Color.White;
                    mc442.ForeColor = System.Drawing.Color.White;
                    mc442_2.ForeColor = System.Drawing.Color.White;
                    mr442.ForeColor = System.Drawing.Color.White;
                    scL.ForeColor = System.Drawing.Color.White;
                    scR.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        //oyunculara atanacak pozisyonlar
        //tüm comboboxlar için
        //.
        //.
        //.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex
                || comboBox1.SelectedIndex == comboBox3.SelectedIndex
                || comboBox1.SelectedIndex == comboBox4.SelectedIndex
                || comboBox1.SelectedIndex == comboBox5.SelectedIndex
                || comboBox1.SelectedIndex == comboBox6.SelectedIndex
                || comboBox1.SelectedIndex == comboBox7.SelectedIndex
                || comboBox1.SelectedIndex == comboBox8.SelectedIndex
                || comboBox1.SelectedIndex == comboBox9.SelectedIndex
                || comboBox1.SelectedIndex == comboBox10.SelectedIndex
                || comboBox1.SelectedIndex == comboBox11.SelectedIndex
                || comboBox1.SelectedIndex == comboBox12.SelectedIndex
                || comboBox1.SelectedIndex == comboBox13.SelectedIndex
                || comboBox1.SelectedIndex == comboBox14.SelectedIndex
                || comboBox1.SelectedIndex == comboBox15.SelectedIndex
                || comboBox1.SelectedIndex == comboBox16.SelectedIndex
                || comboBox1.SelectedIndex == comboBox17.SelectedIndex
                || comboBox1.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)   //kaleci
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 1)  //442 ve 433 için 1-4 defans, 532 için 1-5 defans
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 9)  //forvetler. 433 için 8den başlar
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 11) //yedekler
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (gklbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == comboBox1.SelectedIndex
                || comboBox2.SelectedIndex == comboBox3.SelectedIndex
                || comboBox2.SelectedIndex == comboBox4.SelectedIndex
                || comboBox2.SelectedIndex == comboBox5.SelectedIndex
                || comboBox2.SelectedIndex == comboBox6.SelectedIndex
                || comboBox2.SelectedIndex == comboBox7.SelectedIndex
                || comboBox2.SelectedIndex == comboBox8.SelectedIndex
                || comboBox2.SelectedIndex == comboBox9.SelectedIndex
                || comboBox2.SelectedIndex == comboBox10.SelectedIndex
                || comboBox2.SelectedIndex == comboBox11.SelectedIndex
                || comboBox2.SelectedIndex == comboBox12.SelectedIndex
                || comboBox2.SelectedIndex == comboBox13.SelectedIndex
                || comboBox2.SelectedIndex == comboBox14.SelectedIndex
                || comboBox2.SelectedIndex == comboBox15.SelectedIndex
                || comboBox2.SelectedIndex == comboBox16.SelectedIndex
                || comboBox2.SelectedIndex == comboBox17.SelectedIndex
                || comboBox2.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox2.SelectedIndex = -1;
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                }
                else if (comboBox2.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == comboBox1.SelectedIndex
                || comboBox3.SelectedIndex == comboBox2.SelectedIndex
                || comboBox3.SelectedIndex == comboBox4.SelectedIndex
                || comboBox3.SelectedIndex == comboBox5.SelectedIndex
                || comboBox3.SelectedIndex == comboBox6.SelectedIndex
                || comboBox3.SelectedIndex == comboBox7.SelectedIndex
                || comboBox3.SelectedIndex == comboBox8.SelectedIndex
                || comboBox3.SelectedIndex == comboBox9.SelectedIndex
                || comboBox3.SelectedIndex == comboBox10.SelectedIndex
                || comboBox3.SelectedIndex == comboBox11.SelectedIndex
                || comboBox3.SelectedIndex == comboBox12.SelectedIndex
                || comboBox3.SelectedIndex == comboBox13.SelectedIndex
                || comboBox3.SelectedIndex == comboBox14.SelectedIndex
                || comboBox3.SelectedIndex == comboBox15.SelectedIndex
                || comboBox3.SelectedIndex == comboBox16.SelectedIndex
                || comboBox3.SelectedIndex == comboBox17.SelectedIndex
                || comboBox3.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox3.SelectedIndex = -1;
            }
            else
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox3.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == comboBox1.SelectedIndex
                || comboBox4.SelectedIndex == comboBox2.SelectedIndex
                || comboBox4.SelectedIndex == comboBox3.SelectedIndex
                || comboBox4.SelectedIndex == comboBox5.SelectedIndex
                || comboBox4.SelectedIndex == comboBox6.SelectedIndex
                || comboBox4.SelectedIndex == comboBox7.SelectedIndex
                || comboBox4.SelectedIndex == comboBox8.SelectedIndex
                || comboBox4.SelectedIndex == comboBox9.SelectedIndex
                || comboBox4.SelectedIndex == comboBox10.SelectedIndex
                || comboBox4.SelectedIndex == comboBox11.SelectedIndex
                || comboBox4.SelectedIndex == comboBox12.SelectedIndex
                || comboBox4.SelectedIndex == comboBox13.SelectedIndex
                || comboBox4.SelectedIndex == comboBox14.SelectedIndex
                || comboBox4.SelectedIndex == comboBox15.SelectedIndex
                || comboBox4.SelectedIndex == comboBox16.SelectedIndex
                || comboBox4.SelectedIndex == comboBox17.SelectedIndex
                || comboBox4.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox4.SelectedIndex = -1;
            }
            else
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
                else if (comboBox4.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (drclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);

                        }
                    }
                }
            }
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == comboBox1.SelectedIndex
                || comboBox5.SelectedIndex == comboBox2.SelectedIndex
                || comboBox5.SelectedIndex == comboBox3.SelectedIndex
                || comboBox5.SelectedIndex == comboBox4.SelectedIndex
                || comboBox5.SelectedIndex == comboBox6.SelectedIndex
                || comboBox5.SelectedIndex == comboBox7.SelectedIndex
                || comboBox5.SelectedIndex == comboBox8.SelectedIndex
                || comboBox5.SelectedIndex == comboBox9.SelectedIndex
                || comboBox5.SelectedIndex == comboBox10.SelectedIndex
                || comboBox5.SelectedIndex == comboBox11.SelectedIndex
                || comboBox5.SelectedIndex == comboBox12.SelectedIndex
                || comboBox5.SelectedIndex == comboBox13.SelectedIndex
                || comboBox5.SelectedIndex == comboBox14.SelectedIndex
                || comboBox5.SelectedIndex == comboBox15.SelectedIndex
                || comboBox5.SelectedIndex == comboBox16.SelectedIndex
                || comboBox5.SelectedIndex == comboBox17.SelectedIndex
                || comboBox5.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox5.SelectedIndex = -1;
            }
            else
            {
                if (comboBox5.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox5.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (dlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == comboBox1.SelectedIndex
                || comboBox6.SelectedIndex == comboBox2.SelectedIndex
                || comboBox6.SelectedIndex == comboBox3.SelectedIndex
                || comboBox6.SelectedIndex == comboBox4.SelectedIndex
                || comboBox6.SelectedIndex == comboBox5.SelectedIndex
                || comboBox6.SelectedIndex == comboBox7.SelectedIndex
                || comboBox6.SelectedIndex == comboBox8.SelectedIndex
                || comboBox6.SelectedIndex == comboBox9.SelectedIndex
                || comboBox6.SelectedIndex == comboBox10.SelectedIndex
                || comboBox6.SelectedIndex == comboBox11.SelectedIndex
                || comboBox6.SelectedIndex == comboBox12.SelectedIndex
                || comboBox6.SelectedIndex == comboBox13.SelectedIndex
                || comboBox6.SelectedIndex == comboBox14.SelectedIndex
                || comboBox6.SelectedIndex == comboBox15.SelectedIndex
                || comboBox6.SelectedIndex == comboBox16.SelectedIndex
                || comboBox6.SelectedIndex == comboBox17.SelectedIndex
                || comboBox6.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox6.SelectedIndex = -1;
            }
            else
            {
                if (comboBox6.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox6.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == comboBox1.SelectedIndex
                || comboBox7.SelectedIndex == comboBox2.SelectedIndex
                || comboBox7.SelectedIndex == comboBox3.SelectedIndex
                || comboBox7.SelectedIndex == comboBox4.SelectedIndex
                || comboBox7.SelectedIndex == comboBox5.SelectedIndex
                || comboBox7.SelectedIndex == comboBox6.SelectedIndex
                || comboBox7.SelectedIndex == comboBox8.SelectedIndex
                || comboBox7.SelectedIndex == comboBox9.SelectedIndex
                || comboBox7.SelectedIndex == comboBox10.SelectedIndex
                || comboBox7.SelectedIndex == comboBox11.SelectedIndex
                || comboBox7.SelectedIndex == comboBox12.SelectedIndex
                || comboBox7.SelectedIndex == comboBox13.SelectedIndex
                || comboBox7.SelectedIndex == comboBox14.SelectedIndex
                || comboBox7.SelectedIndex == comboBox15.SelectedIndex
                || comboBox7.SelectedIndex == comboBox16.SelectedIndex
                || comboBox7.SelectedIndex == comboBox17.SelectedIndex
                || comboBox7.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox7.SelectedIndex = -1;
            }
            else
            {
                if (comboBox7.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox7.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == comboBox1.SelectedIndex
                || comboBox8.SelectedIndex == comboBox2.SelectedIndex
                || comboBox8.SelectedIndex == comboBox3.SelectedIndex
                || comboBox8.SelectedIndex == comboBox4.SelectedIndex
                || comboBox8.SelectedIndex == comboBox5.SelectedIndex
                || comboBox8.SelectedIndex == comboBox6.SelectedIndex
                || comboBox8.SelectedIndex == comboBox7.SelectedIndex
                || comboBox8.SelectedIndex == comboBox9.SelectedIndex
                || comboBox8.SelectedIndex == comboBox10.SelectedIndex
                || comboBox8.SelectedIndex == comboBox11.SelectedIndex
                || comboBox8.SelectedIndex == comboBox12.SelectedIndex
                || comboBox8.SelectedIndex == comboBox13.SelectedIndex
                || comboBox8.SelectedIndex == comboBox14.SelectedIndex
                || comboBox8.SelectedIndex == comboBox15.SelectedIndex
                || comboBox8.SelectedIndex == comboBox16.SelectedIndex
                || comboBox8.SelectedIndex == comboBox17.SelectedIndex
                || comboBox8.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox8.SelectedIndex = -1;
            }
            else
            {
                if (comboBox8.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox8.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mrclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == comboBox1.SelectedIndex
                || comboBox9.SelectedIndex == comboBox2.SelectedIndex
                || comboBox9.SelectedIndex == comboBox3.SelectedIndex
                || comboBox9.SelectedIndex == comboBox4.SelectedIndex
                || comboBox9.SelectedIndex == comboBox5.SelectedIndex
                || comboBox9.SelectedIndex == comboBox6.SelectedIndex
                || comboBox9.SelectedIndex == comboBox7.SelectedIndex
                || comboBox9.SelectedIndex == comboBox8.SelectedIndex
                || comboBox9.SelectedIndex == comboBox10.SelectedIndex
                || comboBox9.SelectedIndex == comboBox11.SelectedIndex
                || comboBox9.SelectedIndex == comboBox12.SelectedIndex
                || comboBox9.SelectedIndex == comboBox13.SelectedIndex
                || comboBox9.SelectedIndex == comboBox14.SelectedIndex
                || comboBox9.SelectedIndex == comboBox15.SelectedIndex
                || comboBox9.SelectedIndex == comboBox16.SelectedIndex
                || comboBox9.SelectedIndex == comboBox17.SelectedIndex
                || comboBox9.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox9.SelectedIndex = -1;
            }
            else
            {
                if (comboBox9.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox9.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (mlclbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == comboBox1.SelectedIndex
                || comboBox10.SelectedIndex == comboBox2.SelectedIndex
                || comboBox10.SelectedIndex == comboBox3.SelectedIndex
                || comboBox10.SelectedIndex == comboBox4.SelectedIndex
                || comboBox10.SelectedIndex == comboBox5.SelectedIndex
                || comboBox10.SelectedIndex == comboBox6.SelectedIndex
                || comboBox10.SelectedIndex == comboBox7.SelectedIndex
                || comboBox10.SelectedIndex == comboBox8.SelectedIndex
                || comboBox10.SelectedIndex == comboBox9.SelectedIndex
                || comboBox10.SelectedIndex == comboBox11.SelectedIndex
                || comboBox10.SelectedIndex == comboBox12.SelectedIndex
                || comboBox10.SelectedIndex == comboBox13.SelectedIndex
                || comboBox10.SelectedIndex == comboBox14.SelectedIndex
                || comboBox10.SelectedIndex == comboBox15.SelectedIndex
                || comboBox10.SelectedIndex == comboBox16.SelectedIndex
                || comboBox10.SelectedIndex == comboBox17.SelectedIndex
                || comboBox10.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox10.SelectedIndex = -1;
            }
            else
            {
                if (comboBox10.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox10.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (frlbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == comboBox1.SelectedIndex
                || comboBox11.SelectedIndex == comboBox2.SelectedIndex
                || comboBox11.SelectedIndex == comboBox3.SelectedIndex
                || comboBox11.SelectedIndex == comboBox4.SelectedIndex
                || comboBox11.SelectedIndex == comboBox5.SelectedIndex
                || comboBox11.SelectedIndex == comboBox6.SelectedIndex
                || comboBox11.SelectedIndex == comboBox7.SelectedIndex
                || comboBox11.SelectedIndex == comboBox8.SelectedIndex
                || comboBox11.SelectedIndex == comboBox9.SelectedIndex
                || comboBox11.SelectedIndex == comboBox10.SelectedIndex
                || comboBox11.SelectedIndex == comboBox12.SelectedIndex
                || comboBox11.SelectedIndex == comboBox13.SelectedIndex
                || comboBox11.SelectedIndex == comboBox14.SelectedIndex
                || comboBox11.SelectedIndex == comboBox15.SelectedIndex
                || comboBox11.SelectedIndex == comboBox16.SelectedIndex
                || comboBox11.SelectedIndex == comboBox17.SelectedIndex
                || comboBox11.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox11.SelectedIndex = -1;
            }
            else
            {
                if (comboBox11.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox11.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (fllbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == comboBox1.SelectedIndex
                || comboBox12.SelectedIndex == comboBox2.SelectedIndex
                || comboBox12.SelectedIndex == comboBox3.SelectedIndex
                || comboBox12.SelectedIndex == comboBox4.SelectedIndex
                || comboBox12.SelectedIndex == comboBox5.SelectedIndex
                || comboBox12.SelectedIndex == comboBox6.SelectedIndex
                || comboBox12.SelectedIndex == comboBox7.SelectedIndex
                || comboBox12.SelectedIndex == comboBox8.SelectedIndex
                || comboBox12.SelectedIndex == comboBox9.SelectedIndex
                || comboBox12.SelectedIndex == comboBox10.SelectedIndex
                || comboBox12.SelectedIndex == comboBox11.SelectedIndex
                || comboBox12.SelectedIndex == comboBox13.SelectedIndex
                || comboBox12.SelectedIndex == comboBox14.SelectedIndex
                || comboBox12.SelectedIndex == comboBox15.SelectedIndex
                || comboBox12.SelectedIndex == comboBox16.SelectedIndex
                || comboBox12.SelectedIndex == comboBox17.SelectedIndex
                || comboBox12.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox12.SelectedIndex = -1;
            }
            else
            {
                if (comboBox12.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox12.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s1lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.SelectedIndex == comboBox1.SelectedIndex
                || comboBox13.SelectedIndex == comboBox2.SelectedIndex
                || comboBox13.SelectedIndex == comboBox3.SelectedIndex
                || comboBox13.SelectedIndex == comboBox4.SelectedIndex
                || comboBox13.SelectedIndex == comboBox5.SelectedIndex
                || comboBox13.SelectedIndex == comboBox6.SelectedIndex
                || comboBox13.SelectedIndex == comboBox7.SelectedIndex
                || comboBox13.SelectedIndex == comboBox8.SelectedIndex
                || comboBox13.SelectedIndex == comboBox9.SelectedIndex
                || comboBox13.SelectedIndex == comboBox10.SelectedIndex
                || comboBox13.SelectedIndex == comboBox11.SelectedIndex
                || comboBox13.SelectedIndex == comboBox12.SelectedIndex
                || comboBox13.SelectedIndex == comboBox14.SelectedIndex
                || comboBox13.SelectedIndex == comboBox15.SelectedIndex
                || comboBox13.SelectedIndex == comboBox16.SelectedIndex
                || comboBox13.SelectedIndex == comboBox17.SelectedIndex
                || comboBox13.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox13.SelectedIndex = -1;
            }
            else
            {
                if (comboBox13.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox13.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s2lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox14.SelectedIndex == comboBox1.SelectedIndex
                || comboBox14.SelectedIndex == comboBox2.SelectedIndex
                || comboBox14.SelectedIndex == comboBox3.SelectedIndex
                || comboBox14.SelectedIndex == comboBox4.SelectedIndex
                || comboBox14.SelectedIndex == comboBox5.SelectedIndex
                || comboBox14.SelectedIndex == comboBox6.SelectedIndex
                || comboBox14.SelectedIndex == comboBox7.SelectedIndex
                || comboBox14.SelectedIndex == comboBox8.SelectedIndex
                || comboBox14.SelectedIndex == comboBox9.SelectedIndex
                || comboBox14.SelectedIndex == comboBox10.SelectedIndex
                || comboBox14.SelectedIndex == comboBox11.SelectedIndex
                || comboBox14.SelectedIndex == comboBox12.SelectedIndex
                || comboBox14.SelectedIndex == comboBox13.SelectedIndex
                || comboBox14.SelectedIndex == comboBox15.SelectedIndex
                || comboBox14.SelectedIndex == comboBox16.SelectedIndex
                || comboBox14.SelectedIndex == comboBox17.SelectedIndex
                || comboBox14.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox14.SelectedIndex = -1;
            }
            else
            {
                if (comboBox14.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox14.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s3lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex == comboBox1.SelectedIndex
                || comboBox15.SelectedIndex == comboBox2.SelectedIndex
                || comboBox15.SelectedIndex == comboBox3.SelectedIndex
                || comboBox15.SelectedIndex == comboBox4.SelectedIndex
                || comboBox15.SelectedIndex == comboBox5.SelectedIndex
                || comboBox15.SelectedIndex == comboBox6.SelectedIndex
                || comboBox15.SelectedIndex == comboBox7.SelectedIndex
                || comboBox15.SelectedIndex == comboBox8.SelectedIndex
                || comboBox15.SelectedIndex == comboBox9.SelectedIndex
                || comboBox15.SelectedIndex == comboBox10.SelectedIndex
                || comboBox15.SelectedIndex == comboBox11.SelectedIndex
                || comboBox15.SelectedIndex == comboBox12.SelectedIndex
                || comboBox15.SelectedIndex == comboBox13.SelectedIndex
                || comboBox15.SelectedIndex == comboBox14.SelectedIndex
                || comboBox15.SelectedIndex == comboBox16.SelectedIndex
                || comboBox15.SelectedIndex == comboBox17.SelectedIndex
                || comboBox15.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox15.SelectedIndex = -1;
            }
            else
            {
                if (comboBox15.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox15.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s4lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox16.SelectedIndex == comboBox1.SelectedIndex
                || comboBox16.SelectedIndex == comboBox2.SelectedIndex
                || comboBox16.SelectedIndex == comboBox3.SelectedIndex
                || comboBox16.SelectedIndex == comboBox4.SelectedIndex
                || comboBox16.SelectedIndex == comboBox5.SelectedIndex
                || comboBox16.SelectedIndex == comboBox6.SelectedIndex
                || comboBox16.SelectedIndex == comboBox7.SelectedIndex
                || comboBox16.SelectedIndex == comboBox8.SelectedIndex
                || comboBox16.SelectedIndex == comboBox9.SelectedIndex
                || comboBox16.SelectedIndex == comboBox10.SelectedIndex
                || comboBox16.SelectedIndex == comboBox11.SelectedIndex
                || comboBox16.SelectedIndex == comboBox12.SelectedIndex
                || comboBox16.SelectedIndex == comboBox13.SelectedIndex
                || comboBox16.SelectedIndex == comboBox14.SelectedIndex
                || comboBox16.SelectedIndex == comboBox15.SelectedIndex
                || comboBox16.SelectedIndex == comboBox17.SelectedIndex
                || comboBox16.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox16.SelectedIndex = -1;
            }
            else
            {
                if (comboBox16.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox16.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s5lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox17.SelectedIndex == comboBox1.SelectedIndex
                || comboBox17.SelectedIndex == comboBox2.SelectedIndex
                || comboBox17.SelectedIndex == comboBox3.SelectedIndex
                || comboBox17.SelectedIndex == comboBox4.SelectedIndex
                || comboBox17.SelectedIndex == comboBox5.SelectedIndex
                || comboBox17.SelectedIndex == comboBox6.SelectedIndex
                || comboBox17.SelectedIndex == comboBox7.SelectedIndex
                || comboBox17.SelectedIndex == comboBox8.SelectedIndex
                || comboBox17.SelectedIndex == comboBox9.SelectedIndex
                || comboBox17.SelectedIndex == comboBox10.SelectedIndex
                || comboBox17.SelectedIndex == comboBox11.SelectedIndex
                || comboBox17.SelectedIndex == comboBox12.SelectedIndex
                || comboBox17.SelectedIndex == comboBox13.SelectedIndex
                || comboBox17.SelectedIndex == comboBox14.SelectedIndex
                || comboBox17.SelectedIndex == comboBox15.SelectedIndex
                || comboBox17.SelectedIndex == comboBox16.SelectedIndex
                || comboBox17.SelectedIndex == comboBox18.SelectedIndex)
            {
                comboBox17.SelectedIndex = -1;
            }
            else
            {
                if (comboBox17.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox17.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s6lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox18.SelectedIndex == comboBox1.SelectedIndex
                || comboBox18.SelectedIndex == comboBox2.SelectedIndex
                || comboBox18.SelectedIndex == comboBox3.SelectedIndex
                || comboBox18.SelectedIndex == comboBox4.SelectedIndex
                || comboBox18.SelectedIndex == comboBox5.SelectedIndex
                || comboBox18.SelectedIndex == comboBox6.SelectedIndex
                || comboBox18.SelectedIndex == comboBox7.SelectedIndex
                || comboBox18.SelectedIndex == comboBox8.SelectedIndex
                || comboBox18.SelectedIndex == comboBox9.SelectedIndex
                || comboBox18.SelectedIndex == comboBox10.SelectedIndex
                || comboBox18.SelectedIndex == comboBox11.SelectedIndex
                || comboBox18.SelectedIndex == comboBox12.SelectedIndex
                || comboBox18.SelectedIndex == comboBox13.SelectedIndex
                || comboBox18.SelectedIndex == comboBox14.SelectedIndex
                || comboBox18.SelectedIndex == comboBox15.SelectedIndex
                || comboBox18.SelectedIndex == comboBox16.SelectedIndex
                || comboBox18.SelectedIndex == comboBox17.SelectedIndex)
            {
                comboBox18.SelectedIndex = -1;
            }
            else
            {
                if (comboBox18.SelectedIndex == 0)
                {
                    p1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 1)
                {
                    p2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 2)
                {
                    p3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 3)
                {
                    p4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 4)
                {
                    p5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 5)
                {
                    p6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 6)
                {
                    p7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 7)
                {
                    p8.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 8)
                {
                    p9.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 9)
                {
                    p10.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 10)
                {
                    p11.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 11)
                {
                    y1.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 12)
                {
                    y2.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 13)
                {
                    y3.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 14)
                {
                    y4.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 15)
                {
                    y5.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 16)
                {
                    y6.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
                else if (comboBox18.SelectedIndex == 17)
                {
                    y7.Enabled = false;
                    for (int a = 0; a < 18; a++)
                    {
                        if (s7lbl.Text == team[takimH].player[a].oyuncuAd)
                        {
                            eleven.setOyuncu(team[takimH].player[a].oyuncuAd,
                                             team[takimH].player[a].oyuncuSav,
                                             team[takimH].player[a].oyuncuHuc);
                        }
                    }
                }
            }
        }

        //uygula butonu
        private void button1_Click_2(object sender, EventArgs e)
        {
            int m;
            double hc1, df1, hc2, df2;

            listBox1.Clear();
            listBox2.Clear();

            //yeni ortalama hesaplama
            for (m = 0; m < 11; m++)
            {
                //11 oyuncuyu ayrı hesaplar
                eleven.setOyuncu(team[takimH].player[m].oyuncuAd,
                                 team[takimH].player[m].oyuncuSav,
                                 team[takimH].player[m].oyuncuHuc);
            }
            df1 = eleven.setDefans();
            hc1 = eleven.setHucum();
            df1 = df1 * 0.61;
            hc1 = hc1 * 0.61;

            for (int n = m + 1; n < 18; n++)
            {
                //yedekleri ayrı hesaplar
                eleven.setOyuncu(team[takimH].player[n].oyuncuAd,
                                 team[takimH].player[n].oyuncuSav,
                                 team[takimH].player[n].oyuncuHuc);
            }
            df2 = eleven.setDefans();
            hc2 = eleven.setHucum();
            df2 = df2 * 0.39;
            hc2 = hc2 * 0.39;

            p1_Huc = Convert.ToInt32(hc1 + hc2);
            p1_Sav = Convert.ToInt32(df1 + df2);

            //skoru üreten fonksiyon
            matchEng();

            //golü kimin attığını gösteren fonksiyon
            golAtan(Convert.ToInt32(label13.Text));
            golAtanAway(Convert.ToInt32(label14.Text));
        }

        //skoru üreten fonksiyon
        public void matchEng()
        {
            int sonuc0, sonuc1, rast1, rast2;
            Random rand = new Random();

            sonuc0 = 0;
            rast1 = 0;
            sonuc1 = 0;
            rast2 = 0;

            //takımlar için tek bir değer oluşturma
            //random değerler bu iki sayıya göre atanacak
            //büyük değere sahip takım_
            //gol atmaya ve yememeye yatkın olacak
            //p1 hücum - p2 defans
            //p1 hücum - p1 defans
            p2_Sav = team[takimA].setDefans();
            p2_Huc = team[takimA].setHucum();

            for (int s = 0; s < p1_Huc; s++)
            {
                rast1 = rand.Next(0, p2_Sav);
                if (rast1 == 1)
                {
                    sonuc0++;
                }
            }

            for (int d = 0; d < p2_Huc; d++)
            {
                rast2 = rand.Next(0, p1_Sav);
                if (rast2 == 1)
                {
                    sonuc1++;
                }
            }
            label13.Text = sonuc0.ToString();
            label14.Text = sonuc1.ToString();
        }

        //golü kimin attığını gösteren fonksiyon
        public void golAtan(int gol)
        {
            Random scorer = new Random();
            int pos, golcu;

            //takımın attığı gol sayısı kadar döner
            for (int i = 0; i < gol; i++)
            {
                //defans, ortasaha, forvet bölegelerinden birini seçer
                pos = scorer.Next(1, 8);

                //seçili taktiğe göre adamı belirler
                if (tactics.SelectedIndex == 2)
                {
                    if (pos == 3)
                    {
                        golcu = scorer.Next(1, 5);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 2)
                    {
                        golcu = scorer.Next(6, 8);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 1 || pos == 4 || pos == 5 || pos == 6 || pos == 7 ||
                            pos == 8)
                    {
                        golcu = scorer.Next(9, 10);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                }
                else if (tactics.SelectedIndex == 1)
                {
                    if (pos == 3)
                    {
                        golcu = scorer.Next(1, 4);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }

                    else if (pos == 2)
                    {
                        golcu = scorer.Next(5, 8);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 1 || pos == 4 || pos == 5 || pos == 6 || pos == 7 ||
                            pos == 8)
                    {
                        golcu = scorer.Next(9, 10);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                }
                else if (tactics.SelectedIndex == 0)
                {
                    if (pos == 3)
                    {
                        golcu = scorer.Next(1, 4);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }

                    else if (pos == 2)
                    {
                        golcu = scorer.Next(5, 7);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 1 || pos == 4 || pos == 5 || pos == 6 || pos == 7 ||
                            pos == 8)
                    {
                        golcu = scorer.Next(8, 10);
                        listBox1.Text += eleven.player[golcu].oyuncuAd + "\r\n";
                    }
                }
            }
        }

        //golü kimin attığını gösteren fonksiyon
        public void golAtanAway(int golA)
        {
            Random scorer = new Random();
            int pos, golcu;

            //takımın attığı gol sayısı kadar döner
            for (int i = 0; i < golA; i++)
            {
                //defans, ortasaha, forvet bölegelerinden birini seçer
                pos = scorer.Next(1, 8);

                //seçili taktiğe göre adamı belirler
                if (tactics.SelectedIndex == 2)
                {
                    if (pos == 3)
                    {
                        golcu = scorer.Next(1, 5);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 2)
                    {
                        golcu = scorer.Next(6, 8);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 1 || pos == 4 || pos == 5 || pos == 6 || pos == 7 ||
                            pos == 8)
                    {
                        golcu = scorer.Next(9, 10);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                }
                else if (tactics.SelectedIndex == 1)
                {
                    if (pos == 3)
                    {
                        golcu = scorer.Next(1, 4);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }

                    else if (pos == 2)
                    {
                        golcu = scorer.Next(5, 8);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 1 || pos == 4 || pos == 5 || pos == 6 || pos == 7 ||
                            pos == 8)
                    {
                        golcu = scorer.Next(9, 10);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                }
                else if (tactics.SelectedIndex == 0)
                {
                    if (pos == 3)
                    {
                        golcu = scorer.Next(1, 4);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }

                    else if (pos == 2)
                    {
                        golcu = scorer.Next(5, 7);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                    else if (pos == 1 || pos == 4 || pos == 5 || pos == 6 || pos == 7 ||
                            pos == 8)
                    {
                        golcu = scorer.Next(8, 10);
                        listBox2.Text += team[takimA].player[golcu].oyuncuAd + "\r\n";
                    }
                }
            }
        }

        //temizle
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox1.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox1.SelectedIndex = -1;
            }
            else if (comboBox2.SelectedIndex != -1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox2.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox2.SelectedIndex = -1;
            }
            else if (comboBox3.SelectedIndex != -1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox3.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox3.SelectedIndex = -1;
            }
            else if (comboBox4.SelectedIndex != -1)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox4.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox4.SelectedIndex = -1;
            }
            else if (comboBox5.SelectedIndex != -1)
            {
                if (comboBox5.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox5.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox5.SelectedIndex = -1;
            }
            else if (comboBox6.SelectedIndex != -1)
            {
                if (comboBox6.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox6.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox6.SelectedIndex = -1;
            }
            else if (comboBox7.SelectedIndex != -1)
            {
                if (comboBox7.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox7.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox7.SelectedIndex = -1;
            }
            else if (comboBox8.SelectedIndex != -1)
            {
                if (comboBox8.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox8.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox8.SelectedIndex = -1;
            }
            else if (comboBox9.SelectedIndex != -1)
            {
                if (comboBox9.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox9.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox9.SelectedIndex = -1;
            }
            else if (comboBox10.SelectedIndex != -1)
            {
                if (comboBox10.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox10.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox10.SelectedIndex = -1;
            }
            else if (comboBox11.SelectedIndex != -1)
            {
                if (comboBox11.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox11.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox11.SelectedIndex = -1;
            }
            else if (comboBox12.SelectedIndex != -1)
            {
                if (comboBox12.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox12.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox12.SelectedIndex = -1;
            }
            else if (comboBox13.SelectedIndex != -1)
            {
                if (comboBox13.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox13.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox13.SelectedIndex = -1;
            }
            else if (comboBox14.SelectedIndex != -1)
            {
                if (comboBox14.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox14.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox14.SelectedIndex = -1;
            }
            else if (comboBox15.SelectedIndex != -1)
            {
                if (comboBox15.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox15.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox15.SelectedIndex = -1;
            }
            else if (comboBox16.SelectedIndex != -1)
            {
                if (comboBox16.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox16.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox16.SelectedIndex = -1;
            }
            else if (comboBox17.SelectedIndex != -1)
            {
                if (comboBox17.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox17.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox17.SelectedIndex = -1;
            }
            else if (comboBox18.SelectedIndex != -1)
            {
                if (comboBox18.SelectedIndex == 0)
                {
                    p1.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 1)
                {
                    p2.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 2)
                {
                    p3.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 3)
                {
                    p4.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 4)
                {
                    p5.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 5)
                {
                    p6.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 6)
                {
                    p7.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 7)
                {
                    p8.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 8)
                {
                    p9.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 9)
                {
                    p10.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 10)
                {
                    p11.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 11)
                {
                    y1.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 12)
                {
                    y2.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 13)
                {
                    y3.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 14)
                {
                    y4.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 15)
                {
                    y5.Enabled = true;
                }
                else if (comboBox18.SelectedIndex == 16)
                {
                    y6.Enabled = true;
                }
                else
                {
                    y7.Enabled = true;
                }
                comboBox18.SelectedIndex = -1;
            }
        }

        //oyuncu özelliklerini gösterir (imleç üzerine gelince)
        private void gklbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + gklbl.Text + ".jpg";
            label15.Text = gklbl.Text;
        }

        private void gklbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void dllbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + dllbl.Text + ".jpg";
            label15.Text = dllbl.Text;
        }

        private void dllbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void drlbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + drlbl.Text + ".jpg";
            label15.Text = drlbl.Text;
        }

        private void drlbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void drclbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + drclbl.Text + ".jpg";
            label15.Text = drclbl.Text;
        }

        private void drclbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void dlclbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + dlclbl.Text + ".jpg";
            label15.Text = dlclbl.Text;
        }

        private void dlclbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void mllbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + mllbl.Text + ".jpg";
            label15.Text = mllbl.Text;
        }

        private void mllbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void mrlbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + mrlbl.Text + ".jpg";
            label15.Text = mrlbl.Text;
        }

        private void mrlbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void mrclbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + mrclbl.Text + ".jpg";
            label15.Text = mrclbl.Text;
        }

        private void mrclbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void mlclbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + mlclbl.Text + ".jpg";
            label15.Text = mlclbl.Text;
        }

        private void mlclbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void frlbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + frlbl.Text + ".jpg";
            label15.Text = frlbl.Text;
        }

        private void frlbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void fllbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + fllbl.Text + ".jpg";
            label15.Text = fllbl.Text;
        }

        private void fllbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s1lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s1lbl.Text + ".jpg";
            label15.Text = s1lbl.Text;
        }

        private void s1lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s2lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s2lbl.Text + ".jpg";
            label15.Text = s2lbl.Text;
        }

        private void s2lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s3lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s3lbl.Text + ".jpg";
            label15.Text = s3lbl.Text;
        }

        private void s3lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s4lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s4lbl.Text + ".jpg";
            label15.Text = s4lbl.Text;
        }

        private void s4lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s5lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s5lbl.Text + ".jpg";
            label15.Text = s5lbl.Text;
        }

        private void s5lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s6lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s6lbl.Text + ".jpg";
            label15.Text = s6lbl.Text;
        }

        private void s6lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void s7lbl_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.ImageLocation = "images/" + s7lbl.Text + ".jpg";
            label15.Text = s7lbl.Text;
        }

        private void s7lbl_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }        
    }
}
