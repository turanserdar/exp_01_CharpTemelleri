using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metotlar
{
    public partial class Ornekler2 : Form
    {
        /*
          params
          out
          ref 

     
        
         */
        Random rnd = new Random();
        #region metotlar

        private int RandomSayiUret(int sayi)
        {

            int sayac = 0;
            while (listBox1.Items.Count<sayi)
            {


                var rastgeleSayi = rnd.Next(1, 100);
                if (!listBox1.Items.Contains(rastgeleSayi))
                {
                    listBox1.Items.Add(rastgeleSayi);
                }
                sayac++;
                
            }
            MessageBox.Show($"Toplamda : {sayac} sayi uretildi");
            return sayi;


        }

        private int[] RastgeleSayilarUret(int uretilecekRastgeleSayi, out int donusSayisi)
        {
            var sayilar = new int[0];
            Random rnd = new Random();
            int sayac = 0;
            while (sayilar.Length<uretilecekRastgeleSayi)
            {
                Array.Resize(ref sayilar, sayilar.Length + 1);
                var rastgeleSayi = rnd.Next(1, 100);
                if (!sayilar.Contains(rastgeleSayi))
                {
                    sayilar[sayilar.Length - 1] = rastgeleSayi;
                }
                sayac++;
            }
            donusSayisi = sayac;
            return sayilar;
        }

        #endregion
        public Ornekler2()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //Random sayi ireterek listboxa bu sayilari ekleyen bir metot yaziniz
            // Kac tane random sayi uretmek isedigimizi kullaniciya soralim
            // Listboxa daha once eklenen bir sayi tekrar etmesin
            // RandomSayiUret(10);
            var girilenDeger =Convert.ToInt32(txt1.Text);

            RandomSayiUret(girilenDeger);
        }

        private void btnRastgeleSayi_Click(object sender, EventArgs e)
        {
            int donusSayisi = 0;

            var uretilecekSayi =Convert.ToInt32(txtRastgeleSayi.Text);
            var sayilar = RastgeleSayilarUret(uretilecekSayi, out donusSayisi);
            foreach (var sayi in sayilar)
            {
                cmbSayilar.Items.Add(sayi);
            }
            MessageBox.Show(donusSayisi.ToString());
        }

        private void ToplamiVer(int sayi1, int sayi2, int toplamaSonucu)
        {
            //sayi3=sayi1+sayi2
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            // REF: metotlara parametre gectiginiz zaman ana degisken uzerinde bir degisiklik olmaz cunku metotlara gonderilen parametreler icin kopya olusturulur 
            /* refereans verdiginiz zaman onun aslinda ram deki yerine ulasmis oluyorsunuz */
            //var sayi = 10;
            //var sayi = 20;
            //var toplam = 0;
            //ToplamiVer(sayi1,sayi2,ref toplam);


        }

        //private double UsAl(int sayi, int us)
        private double UsAl(int sayi, int us=2)
        {
            return Math.Pow(sayi, us);
        }

        private string mailOlustur(string ad, string soyad, int? uzantiTipi) { }
        private void btnDefaultDeger_Click(object sender, EventArgs e)
        {
            //Metotlarin parametrelerini opsiyonel yapmak istiyebilirsiniz. Bu durumda o parametre bos gecilirse default olarak bir deger vermeniz gerekir.
            // Value type'lar normalde default degeri ile ram'de olusturulurlar.

            //var sonuc = UsAl(2, 3);
            //var sonuc = UsAl(5);

            var sonuc = UsAl(5, 5);

        }
    }
}
