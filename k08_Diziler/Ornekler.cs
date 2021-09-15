using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class Ornekler : Form
    {
        public Ornekler()
        {
            InitializeComponent();

        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // Oncelikle bir dizi tanimlayalim sonrasinda dizinin elemanlarini hem tek tek hem de tek seferde listeye ekleyelim.
            // iller diye bir dizi tanimlayalim

            string[] iller = { "ankara", "eskisehir", "adana", "erzincan", "nevsehir", "trabzon", "nigde" };

            //lstSonuc.Items.Add(iller[0]);
            //lstSonuc.Items.Add(iller[1]);
            //lstSonuc.Items.Add(iller[2]);

            // elemanlari for veya foreach kullanarak tek tek ekleyebiliriz. // Bu karmasikligi artirir iyi bir sey degil
            // index ihtiyac varsa genelde for kullanilir
            //for (int i = 0; i < iller.Length; i++) // esitlik koymadim cunku index 0 dan baslayip 6 degerine kadar gelecek
            //{
            //    lstSonuc.Items.Add(iller[i]);
            //}

            //foreach (var il in iller)  // iller dizisinin icinde gez ve her bir veriyi il degiskenin icinde tut
            //{
            //    lstSonuc.Items.Add(il); // Bu tek tek eklemek istedigim zaman // Kullanimi for 'a gore daha kolay
            //}

            // tek seferde ekleme islemi

            lstSonuc.Items.AddRange(iller); // AddRange metodu ile Hepsini tek seferde ekliyor 

        }

        private void btnCiftleriEkle_Click(object sender, EventArgs e)
        {
            // 1'den 10' a kadar dizi olusturunuz. Sonrasinda cift olan listeye lstCiftSayilar listesine ciftleri tek olanlarida lstTekSayilar Ekleyiniz olan sayilari ekleyiniz.

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    lstCiftSayilar.Items.Add(sayi); // Cifttir   // addrange metodu boyle calismiyor
                }
                else
                {
                    lstTekSayilar.Items.Add(sayi);//Tektir
                }
            }



        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //20 elemanli bir bos dizi olsuturunuz, sonrasinda for dongusu ile 1'den 20'ye kadar olan sayilari diziye ekleyiniz.
            //Sonrasinda dizideki elemanlarin hepsini lstSonuc listesine tek seferde ekleyiniz.


            var sayilar = new int[20];
            //sayilar[0] = 1;
            //sayilar[1] = 2; // Normalde boyle tek tek yapiyordum.

            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = i + 1; // en son 19. indekse 20 degerini atayacak //sayilar dizisini olusturduk
            }
            //lstSonuc.Items.AddRange(sayilar); hoca buna tekrar bakacak???

            foreach (var sayi in sayilar)
            {
                lstSonuc.Items.Add(sayi);  // Diziyi listeye eklemek istedigimizde boyle ekliyoruz
            }
        }

        private void btnSonElemaniAl_Click(object sender, EventArgs e)
        {
            // Iller dizisi tanimlayalim icine 5 tane il ekleyelim, sonrasinda son elemani secip mbox ta gosterelim

            //string[] Iller = { "Ankara", "Izmir", "Istanbul", "Bursa", "Kocaeli" };
            //MessageBox.Show($"Son Eleman:{Iller[4]}");



            // HOCANIN YAPTIGI

            string[] Iller = { "Ankara", "Izmir", "Istanbul", "Bursa", "Kocaeli" };
            //var sonEleman = Iller[4];

            var sonEleman = Iller[Iller.Length - 1];

            // Iller.Length dizi uzunlugunu verir
            // Iller.Length-1 son indeksi verir.
            MessageBox.Show(sonEleman);
        }


        string[] isimler = { "leyla", "utku", "yasemin", "bahar", "omer", "serdar", "orkun", "eray", "batuhan", "cigdem", "mustafa", "mert" };
        private void btnRastgeleElemanEkle_Click(object sender, EventArgs e)
        {
            // Global olarak isimler dizisi olusturunuz
            // Butona her bastigimizda rastgele bir index olustursun ve bu indeksteki isim listbox a eklensin
            // Dikkat edilmesi gereken onemli nokta 15. index gibi bir sey uretirse sorun olur
            // Listbox a bir kez eklenen kisi bir daha eklenmesin ve dizideki tum elemanlar listbox a eklendiyse mbox da ekleyecek eleman kalmadi uyarisi yapilsin

            Random rnd = new Random(); // Rastgele sayi uretmek icin random sinifini kullaniyorduk




            //var rastgeleSayi = rnd.Next(1, 12); // Rastgele sayi uretmek icin 

            //if (lstSonuc.Items.Contains(isimler[rastgeleSayi])==false)
            //{
            //    lstSonuc.Items.Add(isimler[rastgeleSayi]);
            //}
            //else
            //{
            //    MessageBox.Show($"Bu isim daha once eklenmisti:{isimler[rastgeleSayi]}");
            //}

            var rastgeleIndex = rnd.Next(0, isimler.Length); // rastgele sayi uretmek icin next metodunu kullaniyoruz .  0 dan 13 e kadar uretecek(13 dahil), ama dizinin eleman sayisi 14 olarak gelecek.

            var rastgeleSecilenEleman = isimler[rastgeleIndex];

            if (!lstSonuc.Items.Contains(rastgeleSecilenEleman))
            {
                lstSonuc.Items.Add(rastgeleSecilenEleman);
            }
            else
            { 
                
                    //MessageBox.Show($"Bu isim daha onceden eklenmistir:{rastgeleSecilenEleman}");
            }



            if (isimler.Length == lstSonuc.Items.Count) // Diziin icindeki elemanlarin hepsi eklendiyse
            {
                btnRastgeleElemanEkle.Enabled = false; // butona tekrar basmanizi engelleyecek. Butonun aktifligini kapatiyor
                MessageBox.Show("Dizideki tum elemanlar listeye eklendi.");
            }


            



        }


       //ORNEK 6/THIS

        // Sayilar dizisi olusturalim 7 tane sayi eklensin (rastgele sayilar olusturulsun)
        // Butona her bastigimda dizideki elemanlari listeye eklesin ve eklenen sayilarin toplami formun basliginda gosterilsin

        /// var rastgeleSayilar = new int[7]; // var diye bir degisken sinif duzeyinde tanimlanamaz. Yani global olarak var tanimlayamayiz
        int[] rastgeleSayilar = new int[7];
        private void button1_Click(object sender, EventArgs e)
        {
            //var rastgeleSayilar = rnd.Next(1, 8);
            //var sayilarDizisi = new int[5];

            //for (int i = 0; i < 7; i++)
            //{
            //    
            //} BEnim yapmaya calistigim


            // Sayilar dizisi olusturalim 7 tane sayi eklensin (rastgele sayilar olusturulsun) ilk once bunu yapalim



            Random rnd = new Random(); // Instance: nesneden kopya almak demektir
            for (int i = 0; i < 7; i++)
            {
                var rastgeleSayi = rnd.Next(0, 101);
                rastgeleSayilar[i] = rastgeleSayi;
            }


        }
        int sayac = 0;
        int toplam = 0;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            //butona her bastigimda dizide elemanlari listeye eklesin ve eklenen sayilarin toplami formun basliginda gosterilsin
            if (sayac<rastgeleSayilar.Length)
            {
                
            var secilenEleman = rastgeleSayilar[sayac];
                lstSonuc.Items.Add(secilenEleman);


                toplam += secilenEleman;
                //this icinde bulundugunuz sinifi temsil eder.Yani burada Ornekler i temsil eder
                this.Text = toplam.ToString();
                sayac++;
            }
            else
            {
                btnTopla.Enabled = false;
                MessageBox.Show("Dizideki butun elemanlar toplandi!");
            }
        }

        private void btnAyir_Click(object sender, EventArgs e)
        {
            //textbox a yazilan metni alip sesli harflerini ve sessiz harflerini ayirarak lblSesliler ve lblSessizler'de gosterelim.
            // 8 tane sesli harfi tanimladiktan sonra metnin herbir harfini tek tek inceleriz. Eger gelen harf sesliHarfler dizisinde yer aliyorsa sesli, almiyorsa sessiz label'ina eklenir.

            //string:karakterler dizisidir. Demek ki for ve foreach ile gezebilirim. For ile yaptigim herseyi foreach ile yapamiyorum. Fakat foreach ile yaptigim herseyi for ile yaparim.

            

            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            //var girilen = "merhaba"; // bu girdigimiz string aslinda bir char lar dizisidir.//statik bir deger

            var girilen = txtMetin.Text;

            //for (int i = 0; i <girilen.Length; i++)
            //{
            //    var harf = girilen[0];
            //}

            foreach (var harf in girilen)
            {

                if (sesliHarfler.Contains(harf))
                {
                    // harf seslidir
                    lblSesliler.Text += harf.ToString() + ",";
                }
                else
                {
                    //harf sessizdir
                    lblSessizler.Text += harf.ToString() + ",";
                }



            }


        }
    }
}

