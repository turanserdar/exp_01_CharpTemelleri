using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K06_KararYapilari
{
    public partial class Form5 : Form
    {

        /* 
         
         Switch-Case: if ile farkli olduklari nokta
        ifin icerisinde buyuktur kucuktur gibi karsilastirmalar yapabiliyorsunuz
        Switch Case icerisinde sadece esitlik kontrolu yapilmasi gerektigi durumlarda bu yapi kullanilabilir. 
        Switch Case in kullanilma sebebi
        If'e gore daha hizlidir. Cunku esitlik durumunu kontrol ederken diger kosullari tek tek incelemez, direkt olarak kosulun saglandigi case'e gider.
        if a=b mi c=d mi diye tek tek ariyor
        Switch case ise direkt olarak c=d yi bulup getiriyor

        Switch(kosul/deger){
        
        
                case esitlik durumu:
                            //yapilacak islemler
                break;
        
        }
         
         
         
         
         */
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAylariGetir_Click(object sender, EventArgs e)
        {
            // Kullanicidan mevsimleri aldiktan sonra o mevsimdeki aylari gosteren bir uygulama yapiniz

            var girilenMevsim = txtMevsim.Text.ToLower();

            var aylar = "";

            //1.YONTEM IF ILE YAPILMASI
            //if (girilenMevsim=="kis")
            //{
            //    aylar = "aralik-ocak-subat";
            //}
            //else if (girilenMevsim=="ilkbahar")
            //{
            //    aylar = "mart-nisan-mayis";
            //}

            //else if (girilenMevsim=="yaz")
            //{
            //    aylar = "haziran-temmuz-agustos";
            //}
            //else if (girilenMevsim=="sonbahar")
            //{
            //    aylar = "eylul-ekim-kasim";
            //}
            //else
            //{
            //    aylar = "boyle bir mevsim yok!";
            //}

            //2.YONTEM SWITCH_CASE DAHA HIZLI


            switch (girilenMevsim)//neyi karsilastiriyorsam buraya yaziyoruz
            {
                case "kis": //karsilastirdigim sey
                    aylar = "aralik-ocak-subat";
                    break;
                case "ilkbahar": //karsilastirdigim sey
                    aylar = "mart-nisan-mayis";
                    break;
                case "yaz": //karsilastirdigim sey
                    aylar = "haziran-temmuz-agustos";
                    break;
                case "sonbahar": //karsilastirdigim sey /// arama butonuna sonbahar dedigimizde direk olarak bu satira bakacak.
                    aylar = "eylul-ekim-kasim";
                    break;

                default: // else karsilik geliyor       
                    aylar = "boyle bir mevsim yok!";
                    break;

            }


            MessageBox.Show(aylar);





        }

        private void btnMevsimGetir_Click(object sender, EventArgs e)
        {
            // Girilen ay bilgisini alip hangi mevsimde oldugunu gosteriniz
            // Simdide aylari girip hangi mevsimde oldugunu getirsin
            var girilenAy = txtAy.Text.ToLower();

            var mevsim = "";

            switch (girilenAy)//neyi karsilastiriyorsam buraya yaziyoruz
            {
                case "aralik":
                case "ocak": //girilen ay neye esit olacak
                case "subat":
                   mevsim = "kis";
                    break;

                case "mart":
                case "nisan":
                case "mayis":

                    mevsim = "ilkbahar";
                    break;
                case "haziran":
                case "temmuz":
                case "agustos":
                    mevsim = "yaz";
                    break;

                case "eylul":
                case "ekim":
                case "kasim":
                    mevsim = "sonbahar";
                    break;

                default: // else karsilik geliyor       
                    mevsim = "boyle bir ayyok!";
                    break;

            }
            MessageBox.Show(mevsim);

            // Karsilastirma yapilan veri tiplerinin ayni olmasi gerekir
            // Switch icine yazilan deger ile case' de yazilan karsilastirma degerinin veri tipi ayni olmak zorundadir

            //var sayi = 10;
            //switch (sayi)
            //{
            //    case "10";
            //        MessageBox.Show("Buldunuz");
            //        break;
            //    case 20:
            //        MessageBox.Show("Azalt");
            //        break;

            // Bunu kabul etmez

            }
        }
    }

