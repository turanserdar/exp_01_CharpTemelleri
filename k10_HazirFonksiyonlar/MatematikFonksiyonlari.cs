using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_HazirFonksiyonlar
{
    public partial class MatematikFonksiyonlari : Form
    {

        /*  
         Matematik fonksiyonlari: Math kutuphanesinde yer alan metotlari inceleyelim.

        Overload: Fonksiyonlara birden fazla islev tanimlamasi yapilabilir. Metot ismi ayni ancak aldigi parametreler degiserek yaptigi islemler farkli olan metotlardir.
        
         */
     


        public MatematikFonksiyonlari()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //pi sayisini alalim
            var piSayisi = Math.PI;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            // Kullanicidan alinan bir yaricapa gore dairenin alanini hesaplayiniz.
            var girilenCap = txtGiris.Text;
            int girilenCap1 = Convert.ToInt32(girilenCap);
            var piSayisi = Math.PI;

            var alan = piSayisi * girilenCap1*girilenCap1;

            lblSonuc.Text = alan.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnBuyuk_Click(object sender, EventArgs e)
        {
            var sayi1 = Convert.ToInt32(txtSayi1.Text);
            var Sayi2= Convert.ToInt32(txtSayi2.Text);
            var Sayi3 = Convert.ToInt32(txtSayi3.Text);

            var sayi1sayi2 = Math.Max(sayi1,Sayi2);
            var sayi1sayi3 = Math.Max(sayi1, Sayi3);
            var sayi2sayi3 = Math.Max(Sayi2, Sayi3);


            if (sayi1sayi2==sayi1&&sayi1sayi3==sayi1)
            {
                MessageBox.Show("Sayi 1 En buyuktur");
            }

            if (sayi2sayi3 == Sayi2 && sayi2sayi3 == Sayi2)
            {
                MessageBox.Show("Sayi 2 En buyuktur");
            }

            if (sayi2sayi3 == Sayi3 && sayi1sayi3 == Sayi3)
            {
                MessageBox.Show("Sayi 3 En buyuktur");
            }

           








        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mutlak Deger - Absolute
            // Icine ne verirsen onu dondurur.
            // Double yazarsan double dondurur

            var mutlakDeger = Math.Abs(-143);
            var md1 = Math.Abs(-1.43);


        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            // En yakin ust sayiya yuvarlama yapar.

            var tamSayi = Math.Ceiling(1.23m);
            var tamSayi2 = Math.Ceiling(3.85);
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            // En yakin alt sayiya yuvarlama yapar
            var tamSayi = Math.Floor(1.55);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ondalikli Kisim 50'den buyuksek ust tamsayiya yuvarlar, kucukse alt tamsayiya yuvarlar
        }

        private void MatematikFonksiyonlari_Load(object sender, EventArgs e)
        {

        }
    }
}
