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
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

            //        //Kullanicidan kac karakterli bir sifre olusturmak istedigini alalim, sonrasinda sifrenin icinde hangi tip karakter gecmesini istedigini soralim. Buyuk harf, Kucuk harf, Rakam veya Sembol. En az bir secim yapmak zorunda
            //        //Her biri icin dizi olusturalim.
            //        //Hangi diziden secim yapacagini rastgele secmesi gerekir.
            //        //Butun karakterleri tek bir char[] ' e koyarak rastgele bu char dizisinden secebilirdik

            //        var karakterSayisi = Convert.ToInt32(txtKarakterSayisi.Text);

            //        var buyukHarfler = new char[0];
            //        var kucukHarfler = new char[0];
            //        var rakamlar = new char[0];
            //        var semboller = new char[0];

            //        for (char i = 'A'; i <= 'Z'; i++)
            //        {
            //            Array.Resize(ref buyukHarfler, buyukHarfler.Length + 1);
            //            buyukHarfler[buyukHarfler.Length - 1] = i; // donenlerin hepsi her defasinda i nin icine ataniyor
            //        }
            //        for (char i = 'A'; i <= 'Z'; i++)
            //        {
            //            Array.Resize(ref kucukHarfler, kucukHarfler.Length + 1);
            //            kucukHarfler[kucukHarfler.Length - 1] = i; // donenlerin hepsi her defasinda i nin icine ataniyor
            //        }
            //        for (char i = '0'; i <= '9'; i++)
            //        {
            //            Array.Resize(ref rakamlar, rakamlar.Length + 1);
            //            buyukHarfler[kucukHarfler.Length - 1] = i; // donenlerin hepsi her defasinda i nin icine ataniyor
            //        }
            //        for (int i = 33; i <= 47; i++)
            //        {
            //            Array.Resize(ref semboller, semboller.Length + 1);
            //            semboller[semboller.Length - 1] = i; // donenlerin hepsi her defasinda i nin icine ataniyor
            //        }




            //        //if (hangiDizidenSecimYapilsin==0)
            //        //{
            //        //    // buyuk harflerden rastgele birsey secip sifrenin icine eklyecegiz
            //        //}
            //        //esitlik kontrollerinde switch-case
            //        Random rnd = new Random();
            //        var sifre = "";

            //        //for (int i = 0; i < karakterSayisi; i++) yerine while kullanicam cunku icerideki ifler sknti olsturuyor
            //        //length degeri hic karakter yoksa 0 alir.

            //            var hangiDizidenSecimYapilsin = rnd.Next(0, 4); //0,1,2,3,4

            //        switch (sifre.Length < karakterSayisi)// bu bir defa calisacak bunu bir dongu icersine koymamiz gerekir
            //        {
            //            case 0:
            //                { //buyuklerden sec;
            //                        if (chbBuyukHarf.Checked)
            //                        {
            //                            var rastgeleIndex = rnd.Next(0, buyukHarfler.Length);
            //                            var secilenHarf = buyukHarfler[rastgeleIndex];
            //                            sifre += secilenHarf;
            //                        }

            //                    break;
            //                }
            //            case 1:
            //                    {
            //                        if (chbKucukHarf.Checked)
            //                        {
            //                            var rastgeleIndex = rnd.Next(0, kucukHarfler.Length);
            //                            var secilenHarf = kucukHarfler[rastgeleIndex];
            //                            sifre += secilenHarf;
            //                        }//kucuklerden sec;

            //                    break;
            //                } //bu scope acip kapamayi rastgeleIndex i tekrar kullanmak icin yaptim cunku degiskenler scope tan ciktiktan sonra silinirler
            //            case 2:
            //                    {
            //                        if (chbRakam.Checked)
            //                        {
            //                            var rastgeleIndex = rnd.Next(0, rakamlar.Length);
            //                            var secilenHarf = rakamlar[rastgeleIndex];
            //                            sifre += secilenHarf;
            //                        }
            //                    //rakamlardan sec;

            //                    break;
            //                }
            //            case 3:
            //                    {
            //                        if (chbSembol.Checked) //checked=true ise if calisir
            //                        {
            //                            var rastgeleIndex = rnd.Next(0, semboller.Length);
            //                            var secilenHarf = semboller[rastgeleIndex];
            //                            sifre += secilenHarf;
            //                        }
            //                    //sembollerden sec;

            //                    break;
            //                }

            //            }



        }









    }
}
    

