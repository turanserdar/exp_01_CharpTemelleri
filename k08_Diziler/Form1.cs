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
    public partial class Form1 : Form
    {
        /*   
        Diziler

        Bir degisken uzerinde birden fazla ayni veri tipindeki degerleri tutmak icin diziler kullanilir.
        
        int sayi1=10 ;
        string isim="bahar";
        bool dogruMu=true;
        decimal par=1029.32m;
        float not=50.33f;
        double ortalama=13.0d;
        Normalde degiskenleri tanimlarken icine tek bir deger koyabiliriz.
        Cogu durumda daha gelismis olarak bir degiskenin icerisinde birden fazla deger tanimlamak istiyor olabiliirim.


        sinif icin

        string ogr1="bahar";
        string ogr2="serdar"; 


        Boyle uzun uzun ugrasamam bunun icin diziler ve listeler denilen yontemler var
        Diziler-- daha ilkel bir yontem
        Listeler-- daha gelismis bir yontem

        Tanimlanmasi icin birden fazla yontem vardir:

        1.Yontem

        int[] -- boyle yazdigimiz zaman int lerden olusan bir dizi tanimlamak istedigimizi soyluyorum. var icin boyle yapamiyoruz
        
        int[] ={1,2,3,4,5,6,7};
        string[] isimler1={"bahar","serdar","eray"};

        2.Yontem
        string dizisi olsun
        string[] isimler= new string[]{"bahar","serdar","eray"};
        var isimler = new string[] { "bahar", "serdar", "eray" }; // burada var i boyle kullanabilirsiniz

        3.Yontem 
        var iller=new string[5]; burada kapasitesini vermek gerekiyor. Yukarida zaten tanimlarken degerlerini girdigimiz icin gerek yoktu.

        ** DIZILERDE INDEX 0'dan baslar

         */



        public Form1()
        {
            InitializeComponent();

            int sayi1 = 10;
            string isim = "bahar";
            bool dogruMu = true;
            decimal par = 1029.32m;
            float not = 50.33f;
            double ortalama = 13.0d;


            string ogr1 = "bahar";
            string ogr2 = "serdar";

            // diziler 
            //var sayilar = { 1, 2, 3, 4, 5, 6, 7 }; // var diye tanimlama yapmaya izin vermez


            var isimler = new string[] { "bahar", "serdar", "eray" };
            var iller = new string[3];
            iller[0] = "Ankara"; // Sadece bunu tanimlarsak diger ikisi null kalir.
            iller[1] = "Izmir";
            iller[2] = "Eskisehir";
            /* iller[3] = "Istanbul";*/ // syntax olarak bir problem cikmaz fakat calisma zamaninda hata verircunku ben 3 elemanli olacagini bildirip 4 eleman girdim.

            // System.IndexOutOfRangeException : "Dizin , dizi sinirlarinin disindaydi." dizinizi tanimlarken belirttiginiz eleman sayisindan fazla eleman yuklemeye calisiyorsunuz demek

            // Dizilerde sadece her bir veri tipinden bir degisken olusturabilirim.




        }
    }
}
