using System;

namespace k01_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //    // Degiskenler
            //    //    // Program icinde kullancagimiz verileri tutmak icin kullanilan yapilardir.
            //    //    //Ram uzerinde tutulurlar.

            //    //    //Degisken tanimlama 
            //    //    //Degisken_veritipi degisken_adi=deger;

            //    //    //Degisken ismi tanimlarken uyulmasi gereken kurallar
            //    //    /*
            //    //            -Tanimlanan bir degisken adi bir daha kullanilamaz
            //    //            -Degisken isimlerinde harf, rakam, alt tire('_') kullanilabilir.Alt tire ile baslayabilir ancak rakam ile baslayamaz.Sayi1,ad_soyad
            //    //            -Birden fazla kelimeden olusan degisken varsa araya bosluk birakilamaz.
            //    //            -Buyuk, kucuk harf duyarliligi var. ad, Ad,AD bunlarin hepsi farkli degisken olarak tutulur.
            //    //            -Programlama dilinde kullanilan ozel kelimeler degisken adi olarak kullanilmaz. For, if gibi ifadeler kullanilamaz. Forabcd kullanabilirsin.
            //    //            --Turkce karakterler kullanilmaz
            //    //            -Degisken ismi tanimlarken camelCase notasyonu kullanmaniz onerilir.
            //    //    Came Case Notasyonu
            //    //    --Her kelimenin tum harfleri kucuk olur, birden fazla kelimeden olusuyorsa diger kelimelerin sadece ilk harfi buyuk olur.

            //    //            --Word wrap acmak: tools> options> text editor> all languages> word wrap checkli olsun.
            //    //              - Ayni sekmeden Line number i da acabilirsin.

            //    //            ---Error List ise Wiev>Error List olarak acabilirsin

            //    //     */


            //    //    // bit en kucuk degere ve (0 ve 1 lerden olusuyor)
            //    //    // 1 byte = 8 bit   2^bitSayisi=2^8=256 tane veri tutuyor>0-255

            //    //    //byte sinifSayisi = 256; bunu yazamayiz cunku byte en fazla 255 alir yani byte sinifSayisi = 255; yazsaydim olurdu
            //    //    // 1 mb = 1.024 KB

            //    //    // Degisken veri tipleri
            //    //    // 1.Tamsayi veri tipleri
            //    //    /*  
            //    //     *byte : (Sadece pozitif tam sayilari tutar) Tam sayi tutarken kullandigimiz en kucuk veri tipi. 8 bit lik kapasitesi var.
            //    //     *short: 16 bit +,-        -32.768              0                 32.768
            //    //    //            short nufus = 32468; yazabilirim.
            //    //     *ushort: 32 bit -,+   unsinged isaretsiz sadece pozitifleri alir   0  +65.535
            //    //     //  ushort uzunluk=5236; yazabiliriz

            //    //    *integer: 32 bit -,+           negatif ve pozitifleri alir   -2.147.483.648     0       2.147.483.648

            //    //    *uint: 32 bit + 0 4.294.967.296

            //    //    *long 64 bit -,+ -9.223.372.036.854.775.808                 0     9.223.372.036.854.775.808 
            //    //    *ulong: 64 bit + 0  18.446.774.073.709.551.615


            //    //     */
            //    //    // 2.Ondalikli veri tipleri
            //    //    //Float: 32 bit tanimlanirken f ile belirtilir.Virgulden sonra 7-8 hane destegi vardir.
            //    //    float ondalikliSayi1 = 10.567f;
            //    //    //double: 64 bit  d ile de belirtilebilri, ama belirtilmezse de olur.Virgulden sonra 13-14 hane destegi vardir.en cok kullanilan
            //    //    double fiyat = 125.99; // veya double fiyat = 125.99d; boyle yazabilirsiniz

            //    //    //Decimal 128 bit virgulden sonra 27-28 hane destegi vardir. m harfi ile tanimlanir.
            //    //    decimal yuzOlcumu = 4576.1231m;


            //    //    // 3.Karakter veri tipleri
            //    //    //char sadece bir karakter tutabilir. Tanimlanirken tirnak ' arasinda tanimlanir
            //    //    char harf = 'a';
            //    //    char bosluk = '';
            //    //    char sembol = '@';

            //    //    //ASCII tablosundaki degerleri veriyor hem de yan tarafinda o karakterin atanmis degerlerini gosteriyor


            //    //    //String  karakterler dizisi tutabilir. Tanimlanirken " arasinda tanimlanir
            //    //    string adSoyad = "Nur Ozturk";

            //    //    string siir = "Kaliyoruz! Kus olup ucmak isterken, agac olup kok saliyoruz. Can Yucel";

            //    //    // Projeyi derlemek icin f6 kisayolu kullanilir 


            //    //    // 4.Mantiksal veri tipi

            //    //    //bool : sadece iki degeri vardir true and false degerleri alabilir.
            //    //    //genelde iflerle ve elserle kullandigimiz bir yapidir

            //    //    bool dogruMu = false;
            //    //    bool esitMi = 3 == 3; // 3 --3 e esit mi diyorum true donuyor
            //        bool esitMi = 3 >3; //false
            //        //byte sinifSayisi = 256; bunu yazamayiz cunku byte en fazla 255 alir yani byte sinifSayisi = 255; yazsaydim olurdu


            //        //break point atamak icin soldaki rakamlarin yanindaki bos bara tiklayarak yapilir.Proje calisirken o break pointi kontrol ediyorum


            // Disaridan alinan iki sayinin toplaminin karesini bulunuz ve ekrana yazdiriniz

           

        }
}
}
 