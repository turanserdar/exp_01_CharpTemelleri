using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongulerDeneme
{
    public partial class deneme3 : Form
    {
        public deneme3()
        {
            InitializeComponent();
            // Listbox'a rastgele urettigimiz 10 tane sayiyi eklyelim. Ancak listede olan bir sayi tekrar eklenemesin.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();



        }

        //ORNEK 6/THIS

        // Sayilar dizisi olusturalim 7 tane sayi eklensin (rastgele sayilar olusturulsun)
        // Butona her bastigimda dizideki elemanlari listeye eklesin ve eklenen sayilarin toplami formun basliginda gosterilsin

        /// var rastgeleSayilar = new int[7]; // var diye bir degisken sinif duzeyinde tanimlanamaz. Yani global olarak var tanimlayamayiz
        /// 

        int[] rastgeleSayilar = new int[7];
        private void btnRastgeleSayilarOlustur_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                var rastgeleSayi = rnd.Next(0, 101);
                rastgeleSayilar[i] = rastgeleSayi;
            }
        }
    }
}
