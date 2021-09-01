using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K06_KararYapilari
{
    public partial class KitapciSiparis : Form
    {
        public KitapciSiparis()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            var girilenKitapSayisi = txtKitapSayisi.Text;
            var kitapSayisi = Convert.ToInt32(girilenKitapSayisi);

            double birimFiyati = 10;
            double tutar = 0; // double ve integer gibi numerik tanimlamalarin ilk degerlerini girmek gerekir
            double indirimOrani = 0;

            if (kitapSayisi>0&& kitapSayisi<=20)
            {

                indirimOrani = 0;


            }
            else if (kitapSayisi>20&&kitapSayisi<=50)
            {
                indirimOrani = 0.05;
            }
            else if (kitapSayisi>50 && kitapSayisi<=100)
            {
                indirimOrani = 0.10;

            }
            else if (kitapSayisi>100&&kitapSayisi<=200)
            {
                indirimOrani = 0.25;
            }
            else if(kitapSayisi>200)
            {
                indirimOrani = 0.25;
            }
            else
            {
                MessageBox.Show("Uygun olmayan bir giris yapildi");
            }
            // Tekrar ettigini dusundugumuz seyleri buraya tasiyalim

            tutar = birimFiyati * kitapSayisi * (1 - indirimOrani);
            txtTutar.Text = tutar.ToString();



        }
    }
}
