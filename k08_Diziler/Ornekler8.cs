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
    public partial class Ornekler8 : Form
    {
        public Ornekler8()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Sifre ve sifre(tekrar) larin ayni olmasi gerekiyor
            // Sifrenin uzunlugunun 8 karakterden fazla olmasi gerekiyor
            // En az 1 buyuk harf; 1 kucuk harf; 1 rakam ve 1 sembol icermesi gerekiyor.
            // Burada her bir karaktere inceleme yapilacak
            // Her bir karakter char tipinde charlarin ASCII
            // ASCII tablosunda Turkce karakterler yok biz basit olmasi acisindan Turkce karakterlere gore yapiyoruz

            var sifre = txtSifre.Text;
            var sifreTekrar = txtSifreTekrar.Text;

            //1.Kontrol
            if (sifre!=sifreTekrar)
            {
                MessageBox.Show("Sifreler Birbiri ile Uyusmuyor!");
                return;
            }

            //2.Kontrol

            if (sifre.Length<8)
            {
                MessageBox.Show("Sifrenizin Uzunlugu En az 8 Karakter Olmalidir");
                return;
            }
            if (sifre.Contains(' '))
            {
                MessageBox.Show("Bosluk Kullanamazsiniz");
            }


            //3.Kontrol 
            var buyukHarfVarMi = false;
            var kucukHarfVarMi = false;
            var rakamVarMi = false;
            var sembolVarMi = false;


            foreach (var karakter in sifre)
            {
                if (karakter>='A'&&karakter<='Z')
                {
                    //Karakter Buyuk Harftir
                    buyukHarfVarMi = true;
                }

                if (karakter<='a'&&karakter>='z')
                {
                    //karakter kucuk harftir
                    kucukHarfVarMi = true;
                }

                if (karakter>='0'&&karakter<='9')
                {
                    //Karakter Rakamdir
                    rakamVarMi = true;
                }
                if (karakter>='!'&&karakter<='/')
                {
                    //Karakter Semboldur
                    sembolVarMi = true;
                }

            }

            if (buyukHarfVarMi&&kucukHarfVarMi&&rakamVarMi&&sembolVarMi)
            {
                MessageBox.Show("Sifreniz Guclu, Kayit Ediliyor");
            }
            else
            {
                if (!buyukHarfVarMi)
                {
                    MessageBox.Show("En az bir buyuk harf kullanmalisiniz.");
                }
                if (!kucukHarfVarMi)
                {
                    MessageBox.Show("En az bir kucuk harf kullanmalisiniz");
                }
                if (!rakamVarMi)
                {
                    MessageBox.Show("En az bir rakam kullanmalisiniz");
                }
                if (!sembolVarMi)
                {
                    MessageBox.Show("En az bir sembol kullanmalisiniz");
                }
            }






            
        }
    }
}
