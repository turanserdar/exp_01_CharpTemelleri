using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K07_Donguler
{
    public partial class Form1 : Form
    {


        /* 
            DONGULER
        Tekrarli olarak yapilmasi istenen islemler varsa belirli bir sayida bu islemleri tekrar eden yapilardir.
         
         1)For

            Bir Baslangic degeri;
            Bir Bitis Degeri; ve
            Artis miktari belirtilir
        for(int=0;i<10(sonlanacagi kisim); i++(artis miktari) ){
        
            //tekrarli olarak yapilmasini istediginiz kodlar yazilir

        // Design ekraninda listbox icerisinde birden fazla sonucu tutabiliyor
        
        }

         2) While
         
         
         
         
         
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //1'den 100 e kadar olan sayilari listeye ekleyiniz

            //lstSonuc.Items.Add("Ankara"); // Listbox'a yeni eleman eklemek icin kullaniiriz. object veri tipinde deger tutar 
            //                              //Object tum veri tiplerini kapsar
            //                              //icerisinde object veri tipi kabul ediyorum diyorsa istedigimiz veri tipini ekleriz
            //                              //Items lar butun veri tiplerini kabul ediyor. Cunku object veri tipi
            //lstSonuc.Items.Add(1);
            //lstSonuc.Items.Add(true);


            //Normalde 1 den 100 e kadar asagidaki gibi tek tek yazabiliriz
            //lstSonuc.Items.Add(1);
            //lstSonuc.Items.Add(2);
            //lstSonuc.Items.Add(1);
            // ...
            //lstSonuc.Items.Add(100);

            //Dongu ile yazarsak
            for (int i = 1/*burasi bir defa calisacak*/; i <= 100; i++)
            {

                lstSonuc.Items.Add(i);
            }

            //Azalan dongude kurabilirsiniz
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            for (int i = 100; i >= 1; i--)
            {
                //100 den 1'e dogru sayilari listbox'a ekleyiniz
                lstSonuc.Items.Add(i); // listbox in itemlerina i degerini ekledim
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //A'dan Z'ye kadar olan harfleri yazdiriniz // char harf='A' ASCII tablosunda buna karsilik gelen bir sayi vardir.Bunun uzerinden bir deger dongu kurulabilir. Char in hem karaktersel hem de sayisal bir karsiligi oldugu icin bu sekilde bir dongu kurulabilir
            for (char i = 'A'; i <= 'Z'; i++)
            {  // arka tarafta buyuk A icin i nin degerini 65 alip sirasiyla Z ye kadar gidiyor

                lstSonuc.Items.Add(i);

            }
            /* for (char i = 'A'; i <= 'Z'; i++)
             {  // arka tarafta buyuk A icin i nin degerini 65 alip sirasiyla Z ye kadar gidiyor

                 lstSonuc.Items.Add(i);
            Bu da ASCII karsiligini verir 
             } */

            for (char i = 'A'; i <= 'Z'; i++)
            {  // arka tarafta buyuk A icin i nin degerini 65 alip sirasiyla Z ye kadar gidiyor

                lstSonuc.Items.Add($"sembol -> {i} ASCII -> {Convert.ToInt32(i)}");
                //Bu da hem ASCII hem de char  karsiligini verir
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            for (int i = 20; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    lstSonuc.Items.Add(i);
                }

            }
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            // 1-10 arasindaki sayilarin toplamini mesajbox ile gosteriniz
            //Matematiksel islemle yapmayiniz

            var toplam = 0;


            for (int i = 1; i <= 10; i++)
            {

                toplam = toplam + i;

            }
            MessageBox.Show(toplam.ToString());
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {

            //7.10-30 arasindaki tek sayilarin toplamini bulunuz.
            // artis miktari ile degil, if ile yapiniz
            var toplam = 0;
            for (int i = 10; i <= 30; i++)
            {
                if (i % 2 == 1)
                {
                    lstSonuc.Items.Add(i);
                    toplam += i;
                }

            }
            MessageBox.Show(toplam.ToString());
        }

        private void btnOrnek8_Click(object sender, EventArgs e)
        {
            // combobox in ismi dropdown 
            //2000-2020 arasindaki yillari comboboxa yazdiralim, sonrasinda comboboxdan bir yil secelim ve textbox'da gosterelim
            for (int i = 2000; i <= 2020; i++)
            {
                cmbYillar.Items.Add(i);// Herhangi bir veri tipini object tipine cevirdigimiz zaman  Boxing yapmis olursunuz.
                // belirsiz bir veri tipi olur// Bilincli bir sekilde cevirmiyorsunuz. Siz Item lara veri eklemek istediginiz zaman otomatikmen object veri tipine donusturur.
            }
        }

        private void cmbYillar_SelectedIndexChanged(object sender, EventArgs e)// SelectedIndexChanged bu event secilen deger calistirildigi zaman calisir// comboboxtan veri secimi yapmak icin
        {
            if (cmbYillar.SelectedIndex != -1) // herhangi bir secim yapilmadigi zaman -1 geliyor. // Selected index degeri herhangi bir secim olmazsa otomatik olarak -1 degerini alir
                                               // 2000 nin indeksi 0 dan basliyor . Burada indexlerimizin hic biri -1 olamayacagi icin dongunun icine giriyor
            {
                var secilenYil = cmbYillar.SelectedItem;  // Unboxing // diyelim ki 2000 yilini sectik o yuzden selectedItem dedik
                txtSecilenYil.Text = secilenYil.ToString();

                //var secilenYil = Convert.ToInt32(cmbYillar.SelectedItem);  // boyle de yazabilirsin
                //var secilenYil = Convert.ToString(cmbYillar.SelectedItem);// ok
                //var secilenYil = Convert.ToBoolean(cmbYillar.SelectedItem);// Boyle bir donusum olamiyor.Cunku yil degeri bool degerine cevirilemez

            }
        }

        private void btnOrnek9_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //var rastgeleSayi = rnd.Next(1, 11);
            //MessageBox.Show(rastgeleSayi.ToString()); // 1 tane rastgele sayi urettim

            // 10 tane rastgele sayi ureterek listbox da gosteriniz
            Random rnd2 = new Random();
            for (int i = 1; i <= 10; i++)
            {


                var sayi = rnd2.Next(1, 51);

                lstSonuc.Items.Add(sayi);
                // Ayni sayi gelse bile listeye eklenmeseydi deseydim
            }



        }

        private void lstSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //1-10 arasindaki sayilar icin carpim tablosu olusturalim

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    lstSonuc.Items.Add($"{i}x{j}={i * j}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lblyazitahtasina  yan yana 10 tane x yazdiriniz
            for (int i = 0; i < 10; i++)
            {
                lblYaziTahtasi.Text += "X ";
            }
        }

        private void btnOrnek2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {

                lblYaziTahtasi.Text += "X";
                for (int j = 0; j <= 9; j++)
                {
                    lblYaziTahtasi.Text += "X";
                }



            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            // 3 tane kesen veya atlatan komutlar var
            // Continue
            // Break
            // Return


            /* 1.CONTINUE   
                
            dongude bazi durumlarda o anki iterasyonun atlanip sonraki iterasyonlardan devam etmesini saglar
            
            1'den 30' a kadar ki sayilari ekrana yazdirmak istiyoruz ancak 8'in kati olan sayilarin yazilmasini istemiyoruz.
            arada bir kosul var 8'in kati olanlari yazdirmasini istemiyoruz.   */


            for (int i = 1; i <= 30; i++)
            {
                //burada bir kosul yazmak istedigim zaman if kullaniyordum.
                if (i % 8 == 0)
                {
                    continue;//bunu gordugu icin burayi isletmyecek 8 i gordu yazmadi, 16 yi gordu yazmadi, 24 u gordu yazmadi.
                    // Continue gorunce alttaki add kismini calistirmadan direk for'a donuyor. Direk donguyu kesip basa donuyor. O anki iterasyonu calistirmayacak.// Genellikle bir kosula bagli olarak kosul saglandigi zaman onu atlasin istiyoruz. While dongusunde birseyler donuyor sonuc ariyoruz. Bilge adam da bahar kaydini ariyoruz. Kacinci iterasyonda bahari gorunce duracagini bu sekilde belirleyebiliriz. O ankini isletme ama bi sonrakinden devam et demek.
                }
                lstSonuc.Items.Add(i);

            }



        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            // Break Komutu
            // Belli bir kosul saglandiginda dongunun calismasini durdurmak icin Break kullanilir. Donguyu kiriyor. Continue donguyu atlatiyordu. Sadece o iterasyonu gostermiyor. Break direk donguden cikiyor
            // Donguden ciktiktan sonra kodlar varsa bunlar calisir cunku break komutu sadece dongunun sonlanmasini saglar. Mbox da goruldugu gibi break donguyu sonlandirdi ama mbox calisti.

            // 1-30 arasindaki sayilari yazdiriniz. 4 un kati olan ilk sayiyi buldugu zaman donguden cikilsin.

            for (int i = 1; i <= 30; i++)
            {

                if (i % 4 == 0)
                {
                    lstSonuc.Items.Add(i);
                    break;
                }
                lstSonuc.Items.Add(i);
            }
            MessageBox.Show("Dongu Sonlandi. Mesaj kutusu acildi.");

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Return komutu donguden ve icinde bulunulan metottan cikilmasi icin kullanilir. Donguden sonra kod parcalari varsa bunlar calismaz.
            // Donguden cikilmasini veya metottan da cikilmasini saglar.

            for (int i = 1; i <= 30; i++)
            {

                if (i %4==0)
                {
                    return;
                }

                lstSonuc.Items.Add(i);
            }

            MessageBox.Show("Dongu Sonlandi. Mesaj Kutusu Acilmayacak ve Buradaki Mesaj Gorunmeyecek."); // i%4 == 0 oldugunda hic buraya ugramayacak// Buradaki mesaj kutusu gorulmeyecek



        }// i%4 == 0 oldugunda direk olarak buraya gelecek

        private void btnOrnek16_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=10;i++)
            {
                lblYaziTahtasi.Text = "X";
                for (int j = 1; j <= 10; j++)
                {
                    lblYaziTahtasi.Text += "X";
                }
            }
        }
    }
}

// Continue, Break ve Return de anlatilan her sey butun dongulerde gecerlidir.