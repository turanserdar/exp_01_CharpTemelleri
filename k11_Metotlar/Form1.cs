using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metotlar
{
    public partial class Form1 : Form
    {

        /* 
          

         * Metotlar
         Hazir metotlar vardi.
        Simdi isleyceklerimiz Custom Mettolar. Bizim yazdigimiz metotlardir.
        Kod icerisinde tekrar tekrar yazdigimiz bazi durumlar var. Kod tekrari yapmak istemedigimiz durumlarda kullanilir.
        Kod Tekrarini Onler.
        Degisiklik yapmak istediginizde kolaylik saglar.
        1.Parametre almayan ve geriye deger dondurmeyen metotlar (VOID)
        2.Parametre alan ve geriye deger dondurmeyen metotlar (VOID)
        3.Parametre almayan geriye deger donduren metotlar
        4.Parametre alan ve geriye deger donduren metotlar
        Hepsinin tanimlanmasi ayni


        Metot tanimlanmasi:

        Erisim Belirleyici  geridegerdondurmedurumu(geriye hangi veri tipini don.yaziyorruz yoksa Void) MetotAdi(varsa parametreler)
        {
                
                //metodun yapmasini istediginiz islemler
        }

        Eger metot geriye deger dondurmeyecekse Void ile isaretlenir.

        Ilk once Void metotlardan basliyoruz.
        Metodu sinif icerisinde nerede tanimladigimiz onemli degil.
        Ama genellikle ya en ustte ya da en altta tanimlayin. Hepsi ayni yerde olsun ki bulmasi kolay olsun
        ctrl+k ve ctrl+s diye bir sey var region a gelince enter a basin
        Region sana bolge ayarliyor

         
        // Sonucunu merak etmedigim sadece islem yapmasini istedigim durumlarda Void yapiyorum. Geriye bana deger dondurmesin diye


          // Metot adi tanimlarken uyulacak kurallar:
          --Pascal Case notasyonu ile tanimlama yapilmalidir.Her kelimenin ilk harfi buyuk digerleri kucuktur   
          --Emir kipleriyle tanimlanirlar. Sunu yap felan diye. yapabilir misin diye degil.
          -- Degiskenlerdeki gibi isimlendirme kurallari burada da geceerli
        */

        #region Metotlar
        #region Geriye Deger Dondurmeyen Metotlar
        private void AdSoyadYazdir() // Parametre almayinca daha statik isler yapmis oluyor
        {
            MessageBox.Show("Serdar TURAN"); // Her kismin altina bunu yazabilmek icin bu metodu tanimladik
        }
        //Metotlar cagirildigi surece calisir // Bu metot sadece mbox a yazi yazdiriyo  

        private void AdSoyadYazdir(string adSoyad) // Yukaridakinin overload i oldu. Ayni isimde oldu parametreleri farkli oldu //2.overload
        {
            MessageBox.Show(adSoyad);
        }

        private void AdSoyadYazdir(string ad, string soyad) //3.overload oldu //isimler ayni parametreler farkli. Ayni isim var parametreden bir daha tanimlayamam.
        {
            MessageBox.Show($"{ad}{soyad}");
        }
        #endregion

        #region Geriye Deger Donduren Metotlar
        // Simdide geriye deger dondurecek bir metot yazalim
        //Geri deger Donduren Metotlar
        private string AdSoyadGetir() // Geriye deger donduren ama parametre almayan metotlar
        {
            var isim = "serdar turan";
            return isim; // metotlarin icersinde kullanilirsa yanina yazilan degeri sonuc olarak doner.
        }

        //Hem parametre alan hem geriye deger donduren
        // Toplama islemi yaptiracaz
        //Parametreleri kullanicidan aldiracaz ve islemlerin sonucunu kullaniciya gonderecez
       private int Topla(int sayi1, int sayi2)
        {
            var toplam = sayi1 + sayi2;
            return toplam;
        }
        // iki tane textbox dan sayi alip sonucu mbox da  gosterelim

        // Toplama islemi yapan bir overload yazalim
        //String 3 parametre alsin, sonuc olarak int dondursun
        //Aldigi stringleri int e cevirecek ve sonuc olarak donecek
        private string Topla(string sayi1,string sayi2, string sayi3) // private dan sonra string yazdigim icin return de de string donmek zorunda
        {
            var sayi1int = Convert.ToInt32(sayi1);
            var sayi2int = Convert.ToInt32(sayi2);
            var sayi3int = Convert.ToInt32(sayi2);
            var toplam = sayi1int + sayi2int + sayi3int;

            return Convert.ToString(toplam);
        }



        #endregion

        #endregion
        public Form1()
        {
            InitializeComponent();
            /*AdSoyadYazdir();*/ // Burada cagirdim
            //AdSoyadYazdir("Serdar TURAN");
            AdSoyadYazdir("serdar", "Turan");

        }

        private void btnAdSoyad_Click(object sender, EventArgs e)
        {
            //AdSoyadYazdir();
            AdSoyadYazdir("Serdar Turan");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // Kullanici adini ve soyadini girmesini istiyoruz yukarida yazdigimiz metotlardan uygun olani ile gosteriniz

            var ad = txtAdiniz.Text;
            var soyAd = txtSoyadiniz.Text;
            //AdSoyadYazdir(ad + " " + soyAd); // 2.overload
            AdSoyadYazdir(ad, soyAd);

           



        }

        private void btnIsmiYazdir_Click(object sender, EventArgs e)
        {
           var sonuc= AdSoyadGetir();
            txtAdiniz.Text = sonuc;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 =Convert.ToInt32( txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            var toplama = Topla(sayi1,sayi2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
