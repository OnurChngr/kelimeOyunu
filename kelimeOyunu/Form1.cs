using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string harf;
        string soru, cevap;
        int uzunluk;
        int bilinenHarfler;
        int kalanHak = 5;
        int kalanSure = 60;        
        string[] harfler;
        string[] sorular = { "ormanların kralı olarak bilinen hayvanın adı", "Türkiyenin en büyük dağı","Dünyanın en küçük hayvanı","Dünyanın en büyük hayvanı"};
        string[] cevaplar = {"aslan","ağrıdağı","bit","fil"};
        Random r = new Random();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int rastgele = r.Next(0, sorular.Length);
             soru= sorular[rastgele];
            int rnd = r.Next(0,cevaplar.Length);
            cevap = cevaplar[rnd];           
            if (rastgele==0)
            {
                lblSoru.Text = sorular[0];
                lblBulKlm.Text = cevaplar[0];
            }
            else if (rastgele==1)
            {
                lblSoru.Text = sorular[1];
                lblBulKlm.Text = cevaplar[1];
            }
            else if (rastgele == 2)
            {
                lblSoru.Text = sorular[2];
                lblBulKlm.Text = cevaplar[2];
            }
            else if (rastgele == 3)
            {
                lblSoru.Text = sorular[3];
                lblBulKlm.Text = cevaplar[3];
            }

            uzunluk = cevaplar.Length;
            harfler= new string[uzunluk];

            labelAktar();
            diziyeAktar();
        }
        
        void labelAktar()
        {
            lblBulKlm.Text = "";
            for (int i = 1; i <=uzunluk; i++)
            {
                lblBulKlm.Text += "-";//kelime kadar "-" koyar

            }
        }
        void diziyeAktar()
        {
            for (int i = 0; i < uzunluk; i++)
            {
                harfler[i] = cevaplar.Substring(i, 1);
                
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            sureHak();
            timer1.Start();

            if (txtHarf.Text !="")
            {
                harf = txtHarf.Text;
                lblGirilenSayi.Text += harf + ", ";// girilen harflerin aralarına "," koyar
                int sorgula = 0;
                for (int i = 0; i < uzunluk; i++)
                {
                    if (harf==harfler[i])// eğer girilen harf doğru ise
                    {
                        string metin = lblBulKlm.Text;
                       lblBulKlm.Text= yazdir(metin, i, harf);
                        bilinenHarfler++;
                        sorgula = 1;
                    }
                }

                if (sorgula == 0)// eğer girilen harf yanlış ise
                {
                    kalanHak--;                   
                }
            }
            oyunBitti();
        }
        void oyunBitti()
        {
            if (bilinenHarfler == uzunluk)// kelime bulunduğunda
            {
                timer1.Stop();
                MessageBox.Show("TEBRİKLER KELİMEYİ BULDUNUZ");
                Application.Exit();
                
            }

            if (kalanSure<=0 || kalanHak<=0)// hak bittiğinde veya süre dolduğunda
            {
                timer1.Stop();
                MessageBox.Show("ÜZGÜNÜZ HAKKINIZ TÜKENDİ OYUNU KAYBETTİNİZ");
                Application.Exit();
                
            }
        }
        void sureHak()
        {
            lblSure.Text = " : " + kalanSure;
            lblCan.Text = " : " + kalanHak;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oyunBitti();
            sureHak();
            if (kalanSure>0)
            {
                kalanSure--;
            }

            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        static string yazdir(string metin,int indis,string yeniDeger)
        {
            metin = metin.Remove(indis, 1);
            return metin.Insert(indis, yeniDeger);
        }
    }
}