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
    public partial class WhileDongusu : Form
    {

        /* 
         * While Dongusu
         * 
         * For un acilmis hali gibi dusunebilirsiniz.
         * Belirli bir kosulu sagladigi surece dongu calismaya devam eder.
        Kosulu kontrol etmeyi unutursaniz sonsuz donguye sokarsiniz.
        Donguden cikma kriterini unuttugunuzda sonsuz donguye girer.
        For da artisi cikisi herseyi belli oldugu icin boyle bir sey kolay kolay olmaz.


        while(kosul){
        
        //Tekrar etmesini istediginiz kodlar
        //Durdurma kriterini uutmayin!
        
        
        }

        */
      


        public WhileDongusu()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //1'den 100'e kadar olan sayilari while kullanarak listeye yazdiriniz

            //for (int i = 0; i < length; i++)
            //{

            //} bu for u asagida aciyoruz



            int i = 1;

            while (i<=100) // kosul buraya yazilir
            {
               // i = 1; boyle tanimlasaydim her defasinda i yi tekrardan 1 olarak alacak
                lstSonuc.Items.Add(i);
                i++;
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // Listbox'a rastgele urettigimiz 10 tane sayiyi eklyelim. Ancak listede olan bir sayi tekrar eklenemesin.


            // Rastgele sayi uretmek icin bir random sinifimiz var onu olusturuyoruz.

            //Random rnd = new Random();


            //for (int i = 1; i < 10; i++)
            //{
            //    var rastgeleSayi = rnd.Next(1, 5);
            //    if (lstSonuc.Items.Contains(rastgeleSayi) == false) 
            //    {
            //        lstSonuc.Items.Add(rastgeleSayi);

            //    }
            //}

            // listbox'in icinde kesin olarak 10 tane rastgele sayi olmasini istiyoruz
            // bu dongu kac kez dondu? saydirip mesaj box da gosteriniz.
            Random rnd = new Random();
            lstSonuc.Items.Clear(); // Her basista listbox in icini silsin

            int sayac = 0;
            while (lstSonuc.Items.Count< 10)
            {
               
                var rastgeleSayi = rnd.Next(1, 11);  // 11 yazdigimiz yerin 10 dan buyuk olmasi lazim ki sonsuz donguye girmesin
                if (!lstSonuc.Items.Contains(rastgeleSayi)) // icerdeki kosul false ise lstSonuc.Items.Contains(rastgeleSayi)==false bunun aynisi. Yani icermiyorsa
                {
                    lstSonuc.Items.Add(rastgeleSayi);
                    
                }

                sayac++;


            }

            MessageBox.Show($"sayac:{sayac}"); // Burdaki {} placeholder dir






        }
    }
}
