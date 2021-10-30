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
        string kelime,harf;
        int uzunluk;
        int bilinenHarfler;
        int kalanHak = 5;
        int kalanSure = 60;
        string[] harfler;

        private void Form1_Load(object sender, EventArgs e)
        {
            kelime = "aslan";
            uzunluk = kelime.Length;
            harfler= new string[uzunluk];

            labelAktar();
            diziyeAktar();
        }
        
        void labelAktar()
        {
            lblBulKlm.Text = "";
            for (int i = 1; i <=uzunluk; i++)
            {
                lblBulKlm.Text += "-";

            }
        }
        void diziyeAktar()
        {
            for (int i = 0; i < uzunluk; i++)
            {
                harfler[i] = kelime.Substring(i, 1);
                
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            sureHak();
            timer1.Start();
            if (txtHarf.Text !="")
            {
                harf = txtHarf.Text;
                lblGirilenSayi.Text += harf + ", ";
                int sorgula = 0;
                for (int i = 0; i < uzunluk; i++)
                {
                    if (harf==harfler[i])
                    {
                        string metin = lblBulKlm.Text;
                       lblBulKlm.Text= yazdir(metin, i, harf);
                        bilinenHarfler++;
                        sorgula = 1;
                    }
                }
                if (sorgula == 0)//eğer yanlış bilirse
                {
                    kalanHak--;                   
                }
            }
            oyunBitti();
        }
        void oyunBitti()
        {
            if (bilinenHarfler == uzunluk)
            {
                timer1.Stop();
                MessageBox.Show("TEBRİKLER KELİMEYİ BULDUNUZ");
                
            }
            if (kalanSure<=0 || kalanHak<=0)
            {
                timer1.Stop();
                MessageBox.Show("ÜZGÜNÜZ HAKKINIZ TÜKENDİ OYUNU KAYBETTİNİZ");
                
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