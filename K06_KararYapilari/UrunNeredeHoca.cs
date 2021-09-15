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
    public partial class UrunNeredeHoca : Form
    {
        public UrunNeredeHoca()
        {
            InitializeComponent();
        }

        private void btnUrunNerede_Click(object sender, EventArgs e)
        {
            ///// Kullanicidan alinan urun bilgisine gore yonlendirilecek reyonu gosteren bir uygulama yapiniz.
            // Bir markette oldugunuzu dusunun
            //Bilgisayar, cep telefonu,minibook yazarsa teknoloji reyonuna ilerleyiniz.
            // Parfum, deodorant, sampuan yazarsa kisisel bakim reyonu
            // Domates, biber, patlican yazarsa sebze reyonu
            // Bunlar disinda bir sey yazilirsa urun bulunmamaktadir bilgisi gosteren bir uygulama yapiniz

            var girilenUrunAdi = txtUrunAdi.Text.ToLower();// Kullanici kucukte buyukte girse kucultur
            string reyonBilgisi; // bos bir degisken atiyorum
            if (girilenUrunAdi=="bilgisayar"||girilenUrunAdi=="cep telefonu"|| girilenUrunAdi=="minibook")
            {
                reyonBilgisi = "Teknoloji reyonuna ilerleyiniz";
            }
            else if (girilenUrunAdi=="parfum"||girilenUrunAdi=="deodorant"||girilenUrunAdi=="sampuan")
            {
                reyonBilgisi = "Kisisel bakim reyonuna ilerleyiniz";
            }
            else if
                (girilenUrunAdi=="domates" || girilenUrunAdi=="biber"||girilenUrunAdi=="patlican")
            {
                reyonBilgisi = "sebze reyonuna ilerleyiniz";
            }
            else
            {
                reyonBilgisi = "boyle bir urun bulunamadi";
            }
            lblReyon.Text = reyonBilgisi;
            MessageBox.Show(reyonBilgisi);// istersek hem label da hem de mesaj box da gorebiliriz

        }
    }
}
