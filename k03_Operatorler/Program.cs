using System;

namespace k03_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Aritmetik Operatorler
            ///*    
            // * + toplama sadece bunu hep string hem sayisal islemlerde  kullanabilir
            // * = sagdaki degeri soldaki degiskene atar.
            // * - cikarma          
            // * * carpma
            // * / bolme
            // * % mod alma


            // */
            ////Artirma-Azaltma Operatorleri
            ////++ mevcut degeri 1 artirir
            ////-- mevcut degeri 1 azaltir
            //// diyelim ki bir int tanimlayacagim 
            ////int sayi1 = 10;
            ////int sayi2 = 20;
            //////sayi1++; //sayiyi once yazdirir sonra artirir sonra tekrar yazdirmadi
            //////sayi2--;
            //////++sayi1; // degiskeni artirir sonra degerini yazar
            //////--sayi2;
            ////var ornek1 = sayi1++;
            ////Console.WriteLine(ornek1);
            ////var ornek2 = ++sayi1;
            ////Console.WriteLine(ornek2);

            //// Eger operatorler sonda yazilirsa once atama yapar sonra artirma/azaltma yapar.
            //// Eger operatorler basta yazilirsa once artirma/azaltma yapar sonra atama yapar.


            //// Bilesik atama operatorleri
            ///* 
            // += acilimi -- > sayi +=4> sayi=sayi+4
            // -= acilimi ---> sayi -= > sayi=sayi-5
            // *= acilimi ---> sayi = sayi
            // /=
            // %=

            // */

            //var sayi3 = 30;
            //sayi3 += 10;
            //Console.WriteLine(sayi3); //40

            ////Karsilastirma Operatorleri
            ///*
            // >
            // <
            // >=
            // <=
            // ==
            // !=

            //*/

            //var esitMi = 3 == 2;//false       
            //var buyukEsitMi = 50 >= 30; //true

            ////Mantiksal Operatorler
            ////&& and Karsilastirma sonuclarinin her birinin true olmasini ister 
            ////|| (pipe isareti) or karsilastirma son  uclarindan herhangi birinin true olmasi sonucunda calisir.

            //var sonuc1 = (3 == 3) && (4 != 3);//true
            //var sonuc2 = ("serdar" == "ozturk") || (1 == 3); //false


            //Console.WriteLine("1.sayiyi yaziniz");
            //var sayi1 = Console.ReadLine();
            //int intsayi1 = Convert.ToInt32(sayi1);

            //Console.WriteLine("2.sayiyi yaziniz");
            //var sayi2 = Console.ReadLine();
            //int intsayi2 = Convert.ToInt32(sayi2);


            //var toplaminkaresi = (intsayi1 + intsayi2) * (intsayi1 + intsayi2);
            //Console.WriteLine(toplaminkaresi);

            // hocanin yaptigi  

            //Console.WriteLine("Birinci sayiyi giriniz");
            //var girilensayi1 = Console.ReadLine();
            //var sayi1 = Convert.ToInt32(girilensayi1);

            //Console.WriteLine("Ikinci sayiyi giriniz");
            //var girilensayi2 = Console.ReadLine();
            //var sayi2 = Convert.ToInt32(girilensayi2);

            //var toplam = sayi1 + sayi2;

            //var karesi = toplam + toplam; 

            //Console.WriteLine($"Toplamlarinin karesi={karesi}");



            // Vize notunun %30 u Final notunun %70 ini hesaplayarak ortalamayi bulunuz ve ekranda gosteriniz.


            //Console.WriteLine("Vize notunuzu giriniz");
            //var vize = Console.ReadLine();
            //var vizeNotu = Convert.ToDouble(vize);

            //Console.WriteLine("Final notunuzu giriniz");
            //var final = Console.ReadLine();
            //var finalNotu = Convert.ToDouble(final);


            //var vizeyuzdesi = vizeNotu * 0.3;
            //var finalyuzdesi = finalNotu * 0.7;
            //var toplam = vizeyuzdesi + finalyuzdesi;
            //Console.WriteLine($"Sinav notu={toplam}");

            //Hocanin yaptigi

            //Console.WriteLine("Vize notu giriniz");  // Bu degerleri girerken nokta degil virgul kullanin
            //var girilenVize = Console.ReadLine();
            //var vize = Convert.ToDouble(girilenVize); // Double kullanmamizin nedeni virgullu sayilari da girebilmek istememiz

            //Console.WriteLine("Final notu giriniz");
            //var girilenFinal = Console.ReadLine();
            //var final = Convert.ToDouble(girilenFinal);

            //var vizeAgirlik = vize * 0.3;   // double degilde decimal 'a cevirmek isteseydik burada 0.3m yazmamiz gerekirdi
            //var finalAgirlik = final * 0.7;

            //var ortalama = vizeAgirlik + finalAgirlik;

            //Console.WriteLine($"Dersin ortalamasi: {ortalama}  ");

            //int sayi1 = 10;
            //int sayi2 = 20;
            //var bolum = sayi1 / sayi2; // burada bolum yapamaz cunku iki degerde integer oldugu icin 0.5 in tam sayi kismini alir.
            // integerlarda toplama,cikarma ve carpmada problem cikmaz ama bolumlerde cikiyor

            // o yuzden double ile tanimlamamiz gerekir
            //double sayi1 = 10;
            //double sayi2 = 20;
            //var bolum = sayi1 / sayi2;


            // Kullanicidan adini, soyadini, mail uzantisini aliniz ve ad.soyad@uzanti.com mailini olusturunuz

            //Console.WriteLine("Adiniz");
            //var  ad =Console.ReadLine();

            //Console.WriteLine("Soyadiniz");
            //var soyad = Console.ReadLine();

            //Console.WriteLine("mail uzantiniz");
            //var uzanti = Console.ReadLine();

            //Console.WriteLine($"Kullanici maili:{ad}.{soyad}@{uzanti}.com");


            // Hocanin yaptigi

            //Console.WriteLine("Adinizi giriniz");
            //var ad = Console.ReadLine();

            //Console.WriteLine("Soyadinizi giriniz");
            //var soyad = Console.ReadLine();

            //Console.WriteLine("mail uzantiniz");
            //var uzanti = Console.ReadLine();

            //var mailAdresi = $"{ad}.{soyad}@{uzanti}.com";

            //Console.WriteLine($"Mail adresiniz:{mailAdresi}");

            //Console.WriteLine(ad + "" + soyad + "@" + uzanti + ".com");//bu sekilde de stringleri birlestirebiliriz

            //Escape Karakterler 
            //var metin = "benim adim 'nur' soyadim 'ozturk' dur.    ";

            //var siir = "Sair demiski:\"Yasayalim!\" ";


            //Console.WriteLine(metin);
            //Console.WriteLine(siir);

            //var siir2 = "Duydum ki bizi bırakmaya azmediyorsun, etme./n Başka bir yar, başka bir dosta meylediyorsun, etme./n Sen yadeller dünyasında ne arıyorsun yabancı? Hangi hasta gönüllüyü kastediyorsun, etme.";


            //var metin = "'leyla' ne haber . 'leyla' ne haber ";
            //Console.WriteLine(metin);

            //var metin = " \"leyla\" ne haber . leyla ne haber ";

            //Console.WriteLine(metin);

            var siir = "Duydum ki bizi bırakmaya azmediyorsun, etme. \n Başka bir yar, başka bir dosta meylediyorsun, etme.\nSen yadeller dünyasında ne arıyorsun yabancı.\nHangi hasta gönüllüyü kastediyorsun, etme.";
            Console.WriteLine(siir);
        }
    }
}
