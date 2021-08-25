

using System;

namespace k02_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert
            //Kullanicidan iki sayi aldirip toplama islemi yapalim ve ekrana toplam sonucu gosterelim
            // string karsiliginda degerini bilseydim tanimlayabilirdim. Var diye tanimlarsak verinin tipini otomatik olarak belirler.
            //Ctrl+ space intelisense acar
            //Ctrl+ . onerileri acar
            // Diyelimki using system yazan en bastaki kismi sildim. Console'in uzerine gelince otomatik altin isareti var oradan tekrar yazdirabilirsiniz

            Console.WriteLine("1.sayiyi yaz");
            var sayi1 = Console.ReadLine();
            int intSayi1 = Convert.ToInt32(sayi1);   // toint32 bizim integer a cevirmek icin kullandigimiz metod


            Console.WriteLine("2.sayiyi yaz");
            var  sayi2 = Console.ReadLine();
            var intSayi2 = Convert.ToInt32(sayi2);


            var toplam = sayi1 + sayi2; //string olarak toplar

            var gercekToplam = intSayi1 + intSayi2;//Sayisal olarak toplar
            Console.WriteLine($"Toplam:{ toplam}");
            Console.WriteLine($"Gercek Toplam:{gercekToplam}");


            //Convert. dedigimiz zaman to ile baslayanlarin cogunlugu veri tipi cevirmek icin kullanilir
           var ondaliklisayi= Convert.ToSingle(" 12/44 "); // Bir metodun nasil yazildigini overload lari gormek icin imleci metodun uzerine getirip F12 tusuna basin

            //ToString(): string'e cevirir.

            var stringSayi = Convert.ToString(10);

            // bunu su sekilde de yazabiliriz gercekToplam.ToString();
            gercekToplam.ToString();

            // ingiliz anahtarinin adi property
            //pembe kup metot
            // simsek isareti event 

        }
    }
}
