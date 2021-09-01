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
            var girilenUrunAdi = txtUrunAdi.Text.ToLower();// Kullanici kucukte buyukte girse kucultur
            string reyonBilgisi; // bos bir degisken atiyorum
            if (girilenUrunAdi=="bilgisayar"||girilenUrunAdi=="cep telefonu"|| girilenUrunAdi=="minibook")
            {
                reyonBilgisi = "Bilgisyaar reyonuna ilerleyiniz";
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
