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
    public partial class KitapciSiparisBen : Form
    {
        public KitapciSiparisBen()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /*
Kullanici disaridan kac adet siparis edecegi bilgisini girsin.
Eger Siparis adedi 20 den kucukse birim fiyat uzerinden satis yapilsin;
20-50 arasinda siparis verilmisse  birim fiyat uzerinden %5 indirim yapilsin.
50-100 arasinda ise %10
100-200 arasinda ise %20
200'den fazla ise %25 indirim yapilarak kullaniciya odemesi gerek tutari gosteren bir uygulama yaziniz
birim fiyati:  10 TL olarak aliniz
*/

            var siparisSayisi = txtSiparis.Text;
            double siparis = Convert.ToDouble(siparisSayisi);

            double fiyat = 0.0;
            double birimFiyat = 10.0;

            if (siparis < 20)
            {
                fiyat = birimFiyat * siparis;

            }
            else if (siparis >= 20 && siparis < 50)
            {
                fiyat = (birimFiyat - birimFiyat * (5 / 100)) * siparis;
            }
            else if (siparis >= 50 && siparis < 100)
            {
                fiyat = (birimFiyat - birimFiyat * (10 / 100)) * siparis;
            }
            else if (siparis >= 100 && siparis < 200)
            {
                fiyat = (birimFiyat - birimFiyat * (20 / 100)) * siparis;
            }
            else if (siparis >= 200)
            {
                fiyat = (birimFiyat - birimFiyat * (25 / 100)) * siparis;
            }
            lblTutar.Text = fiyat.ToString();


        }

    }
}
