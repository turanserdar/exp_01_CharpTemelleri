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
    public partial class TurnerIf : Form
    {

        /* Ternary=if
         arka planda bir farklilik yok sadece gosterimsel bir basitlik var 
        Tek bir satira donusturuyor
        
         if (Kosul){
        
        // Normalde burada  birden fazla satir yazilabiliyor
        //Kosul true calisacaklar
        
            }
        

        else
        {
        //Kosul false ise calisacaklar
        
        }
         
         // Karsilastirma sonucunun bir degiskene atanmasi gerekir
        // Birden fazla kod yazilamiyor // Normalde If in icinde birde fazla satir yazilabiliyor
         
        var degisken==kosul?true ise calisacak kod: false ise calisacak kod;
         
         */



        public TurnerIf()
        {
            InitializeComponent();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            // girilen sayinin Tek mi cift mi oldgunu bulup gosteren uygulamayi yaziniz.

            var girilenDeger = txtSayi.Text;
            var sayi = Convert.ToInt32(girilenDeger);

            //var sonuc = "";
            //if (sayi % 2 == 0;)
            //{
            //    sonuc = "cift";

            //}
            //else
            //{
            //    sonuc = "tektir";
            //}

            var sonuc =  (sayi % 2 == 0) ? "cift" : "tek";
            MessageBox.Show(sonuc);

            // var sonuc =  (sayi % 2 == 0&& sayi==10) ? "cift" : "tek";
            // ayni if gibi yazilan hersey burada da yazilabilir baglaclar...

        }
    }
}
