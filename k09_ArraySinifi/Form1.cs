using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k09_ArraySinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "omer", "leyla", "batuhan", "cigdem", "bahar", "serdar", "orkun", "batuhan", "anil", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" };
        private void btnCopy_Click(object sender, EventArgs e)
        {
            /*  
         Array sinifi : dizilerle ilgili bazi islemleri (kopyalama, yeniden boyutlandirma, siralama vb) yapmamiza yardimci olan metotlari icerir.
         
            //COPY() Metodu
         Copy bir dizideki elemanlari farkli bir diziye kopyalamk icin kullaniliyor.

        Ornek

        Bu siniftaki tum ogrencilerin isimlerini bir dizi olarak tanimlayiniz ve sonrasinda onlineKatilimcilar ve fizikselKatilimcilar isimli iki dizi yaparak buraya kopyalayiniz. */

            
            // Bu diziyi bolmek istiyorum 0 dan 9 a kadar olanlari bir yere kopyala geri kalani da baska bir diziye kopyala dememiz gerek.

            string[] fizikselKatilimcilar = new string[9];
            Array.Copy(isimler, fizikselKatilimcilar, 9);
             // oncelikle bir source istiyor isimler dizisi nereye koyacak destination

            // overload demek bir metodun ismi ayni kaliyor icerisindeki parametrelerin degismesi demek. Mesela copy nin 4 tane overload i var


            // Simdi online daki katilimcilara bakalim
            var onlineKatilimcilar = new string[6];
            Array.Copy(isimler, 9, onlineKatilimcilar, 0, 6);  // 3, overload metodunu kullaniyor. Isimler dizisinin 9. elemanindan basla 6 tane elemani buraya ekle

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //Clear
            // Temizledigi elemanlarin yerine null atar
            Array.Clear(isimler, 2, 3);  // 2. indeksten basla 3 tane elemani temizle. Silme degil temizliyor sadece.Yani o indeksi null yapiyor. Dizinin boyutuyla oynamiyor. Diziniz hala 15 elemanli

            // tumunu temizlemeek isteseydiniz
            Array.Clear(isimler, 0, isimler.Length);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // IndexOf()
            // Eger aradiginiz eleman dizi icinde gecmiyorsa -1 degerini doner
            // Bulursa da elemanin index degerini doner

            // Dizinin icerisinde bir sey ariyorsaniz o aradiginiz seyin kacinci indekste oldugunu size soyluyor
           var bulunanIndex= Array.IndexOf(isimler, "batuhan");   // 6 tane overload i var

            // copy ve clear uzerine geldigimiz zaman void yaziyor. Yani void bize sonuc dondurmuyor demektir. Void disinda bir sey geliyorsa sonuc donuyor demektir.
            // IndexOf da int yaziyor demek ki bunu bir degsikene atayabiliriz.

            if (bulunanIndex!=-1)
            {
                MessageBox.Show($"araduginiz isim {bulunanIndex}.indexte bulundu");

            }
            else
            {
                MessageBox.Show("Dizi icinde aradiginiz eleman bulunmuyor");
            }
            // Aranilan degeri ilk buldugu indeksi doner.
            // 2 tane batuhan var 2. indeksteki batuhani doner



        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // IndexOf gibi calisir tek farki sondan aramaya basliyor

            var bulunanIndex=Array.LastIndexOf(isimler, "batuhan");
            if (bulunanIndex!=-1)
            {
                MessageBox.Show($"Aranilan isim{bulunanIndex}.indexte bulundu.");
            }
            else
            {
                MessageBox.Show("Dizi icinde bu eleman bulunmuyor");
            }

            // 7. indeksteki batuhani gosterecek. Cunku sondan aramaya basliyor

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            // Reverse : Yer degistirme yapar diziyi ters cevirir.

            // Ters cevirme islemi yapiyor. Diziniz en sonundaki indeksi en basa alir.

            Array.Reverse(isimler); // Sonuc dondurmuyor void sonuc dondurmez sadece yapilmasi gereken islemi yapar
            ///string[] isimler = { "omer", "leyla", "batuhan", "cigdem", "bahar", "serdar", "orkun", "batuhan", "anil", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" }

            foreach (var isimlerim in isimler)
            {
                lstSonuc.Items.Add(isimlerim);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Sort 
            // Siralama islemi yapar. Tek yonludur. Yani
            // a'dan z'ye ya da 0'dan 9'a dogru artan siralama yapar
            Array.Sort(isimler);
            // z'den a'ya dogru siralamada ne yapabiliriz?
            // diziler ilkel oldugu icin bu islemi yapmak icin metot yok o yuzden iki islem yapmak gerekir.
            Array.Reverse(isimler);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {

            ///string[] isimler = { "omer", "leyla", "batuhan", "cigdem", "bahar", "serdar", "orkun", "batuhan", "anil", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" }// 15 eleman
            //Resize
            //Yeniden boyutlandirma yapar
            // Onemli bir metot
            // Dizilerin baslangicinda kac eleman alacagini biliyoruz ama degistirmemiz gerekebilir
            Array.Resize(ref isimler, 20); // ref dedigimiz bir anahtar kelime var referans olarak hangi diziyi alacagimizi soruyor
                // sort metodunda dizimiz gercek anlamda degismiyor ama burada degisiyor
                // Artik isimler dizisine istedigim kadar eleman atayabilirim.
        }
    }
}
