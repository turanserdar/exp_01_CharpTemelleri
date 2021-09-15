using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongulerDeneme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Disaridan alinan bir degerin "nur" degerine esit olmasi durumunda calisan ve ekrana girilen deger NUR yazan uygulamayi yapalim.

            var girilenDeger = textBox1.Text;

            if (girilenDeger == "nur")
            {
                MessageBox.Show("Giris Basarili");
            }
            else
            {
                MessageBox.Show("Giris Hatali Bilgilerinizi Kontrol Ediniz");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // b.Kullanicidan alinan sayi 0 - 50 arasinda ise kaldiniz; 50 - 100 arasinda ise gectiniz,bunlar disinda bir sey girilmisse uygun aralikta deger girmediniz yazdiralim

            var girilenSayi = textBox2.Text;
            var sayi = Convert.ToInt32(girilenSayi);

            if (sayi > 0 && sayi <= 50)
            {
                MessageBox.Show("Kaldiniz");
            }

            else if (sayi > 50 && sayi <= 100)
            {
                MessageBox.Show("Gectiniz");
            }
            else
            {
                MessageBox.Show("Uygun Aralikta Bir Deger Girmediniz.");
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //c.Kullanicidan alinan sayinin tek mi cift mi oldugunu bularak ekranda bilgi veren uygulamayi yaziniz(try-catch var)
            var girilenDeger = textBox3.Text;
            var sayi = Convert.ToInt32(girilenDeger);

            if (sayi % 2 == 0)
            {
                MessageBox.Show("Girilen Sayi cifttir");
            }
            else
            {
                MessageBox.Show("Girilen Sayi Tektir");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //d. Girilen sifrenin uzunlugu 8 karakterden kucukse sifre guvensiz; (length)Esitse daha guclu sifre kullanilabilir , buyukse guclu sifre yazacak bir uygulama yaziniz

            var girilenDeger = textBox4.Text;

            if (girilenDeger.Length < 8)
            {
                MessageBox.Show("Sifre Guvensiz");
            }
            else if (girilenDeger.Length == 8)
            {
                MessageBox.Show("Daha Guclu Bir Sifre Secmeniz Gerekmektedir");
            }
            else
            {
                MessageBox.Show("Guclu Bir Sifre Sectiniz. Tebrikler.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //e.Kullanici adi admin ve parola 1234 ise hosgeldin yazisi yazdiralim,Kullanici adi admin degilse kullanici adiniz hatali;Parola 1234 degilse parolaniz hatali, ikisi de yanlissa kullanici adi ve parolaniz hatali mesaji gosterelim, ikisi de yanlissa kullanici adi ve parolaniz hatali mesaji gosterelim

            var kullaniciAdi = txtKullaniciAdi.Text;
            var parola = txtSifre.Text;


            if (kullaniciAdi == "admin" && parola == "1234")
            {
                MessageBox.Show("Hosgeldiniz");
            }
            else if (kullaniciAdi != "admin" && parola == "1234")
            {
                MessageBox.Show("Kullanici Adiniz Hatalidir");
            }

            else if (parola != "1234" && kullaniciAdi == "admin")
            {
                MessageBox.Show("Parolaniz Hatali");
            }

            else
            {
                MessageBox.Show("Kullanici Adiniz ve Parolaniz Hatali");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Beni Hatirlayi Isaretlediniz!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* Kullanici disaridan kac adet siparis edecegi bilgisini girsin.
Eger Siparis adedi 20 den kucukse birim fiyat uzerinden satis yapilsin;
20-50 arasinda siparis verilmisse  birim fiyat uzerinden %5 indirim yapilsin.
50-100 arasinda ise %10
100-200 arasinda ise %20
200'den fazla ise %25 indirim yapilarak kullaniciya odemesi gerek tutari gosteren bir uygulama yaziniz
birim fiyati:  10 TL olarak aliniz */


            var kitapSayisi = Convert.ToInt32(txtSiparis.Text);
            double birimFiyat = 10;
            double indirimOrani = 0;


            if (kitapSayisi < 0 && kitapSayisi <= 20)
            {
                indirimOrani = 0;
            }
            else if (kitapSayisi > 20 && kitapSayisi <= 50)
            {
                indirimOrani = 0.05;
            }
            else if (kitapSayisi > 50 && kitapSayisi <= 100)
            {
                indirimOrani = 0.1;
            }
            else if (kitapSayisi > 100 && kitapSayisi <= 200)
            {
                indirimOrani = 0.2;
            }
            else if (kitapSayisi > 200)
            {
                indirimOrani = 0.25;
            }

            var tutar = kitapSayisi * birimFiyat * (1 - indirimOrani);
            txtTutar.Text = tutar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /* //Kullanicidan vize ve final notlarinin girilmesini isteyiniz
            //Vizenin %30, finalin %70 ini alarak ortalama hesaplayiniz
            //0-30 ise FF
            // 30-50 ise DD
            //50-60 ise CC
            //60-85 ise BA
            // 85+ ise AA
            // CC ve ustu harf notu gecer
            //KUllaniciya ortalamasini, harf notunu ve gecti/kaldi durumunu gosteriniz */

            var vize = Convert.ToDouble(txtVize.Text);
            var final = Convert.ToDouble(txtFinal.Text);

            var ortalama = vize * 0.3 + final * 0.7;

            var harfNotu = "";


            if (ortalama >= 0 && ortalama < 30)
            {
                MessageBox.Show("FF");
            }

        }
    }
}
