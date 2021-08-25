using System;

namespace k03_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aritmetik Operatorler
            /* 
             * + toplama sadece bunu hep string hem sayisal islemlerde  kullanabilir
             * = sagdaki degeri soldaki degiskene atar.
             * - cikarma
             * * carpma
             * / bolme
             * % mod alma
             
        
             */
            //Artirma-Azaltma Operatorleri
            //++ mevcut degeri 1 artirir
            //-- mevcut degeri 1 azaltir
            // diyelim ki bir int tanimlayacagim 
            //int sayi1 = 10;
            //int sayi2 = 20;
            ////sayi1++; //sayiyi once yazdirir sonra artirir sonra tekrar yazdirmadi
            ////sayi2--;
            ////++sayi1; // degiskeni artirir sonra degerini yazar
            ////--sayi2;
            //var ornek1 = sayi1++;
            //Console.WriteLine(ornek1);
            //var ornek2 = ++sayi1;
            //Console.WriteLine(ornek2);

            // Eger operatorler sonda yazilirsa once atama yapar sonra artirma/azaltma yapar.
            // Eger operatorler basta yazilirsa once artirma/azaltma yapar sonra atama yapar.


            // Bilesik atama operatorleri
            /* 
             += acilimi -- > sayi +=4> sayi=sayi+4
             -= acilimi ---> sayi -= > sayi=sayi-5
             *= acilimi ---> sayi = sayi
             /=
             %=
             
             */

            var sayi3 = 30;
            sayi3 += 10;
            Console.WriteLine(sayi3); //40

            //Karsilastirma Operatorleri
            /*
             >
             <
             >=
             <=
             ==
             !=

            */

            var esitMi = 3 == 2;//false
            var buyukEsitMi = 50 >= 30; //true

            //Mantiksal Operatorler
            //&& and Karsilastirma sonuclarinin her birinin true olmasini ister 
            //|| (pipe isareti) or karsilastirma sonuclarindan herhangi birinin true olmasi sonucunda calisir.

            var sonuc1 = (3 == 3) && (4 != 3);//true
            var sonuc2 = ("serdar" == "ozturk") || (1 == 3); //false



        }
    }
}
