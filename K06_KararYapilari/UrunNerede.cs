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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtUrun_TextChanged(object sender, EventArgs e)
        {
            // Kullanicidan alinan urun bilgisine gore yonlendirilecek reyonu gosteren bir uygulama yapiniz.
            // Bir markette oldugunuzu dusunun
            //Bilgisayar, cep telefonu,minibook yazarsa teknoloji reyonuna ilerleyiniz.
            // Parfum, deodorant, sampuan yazarsa kisisel bakim reyonu
            // Domates, biber, patlican yazarsa sebze reyonu
            // Bunlar disinda bir sey yazilirsa urun bulunmamaktadir bilgisi gosteren bir uygulama yapiniz

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var girilenDeger = txtUrun.Text;
            var reyon = "";


            if (girilenDeger == "bilgisayar" || girilenDeger == "cep Telefonu" ||girilenDeger == "minibook")
            {
                reyon = "Teknoloji";
            }
            else if (girilenDeger == "parfum" || girilenDeger == "deodorant" || girilenDeger == "sampuan")
            {
                reyon = "Kisisel Bakim Reyonu";
            }
            else if (girilenDeger == "domates" || girilenDeger == "biber" || girilenDeger == "patlican")
            {
                reyon = "Sebze Reyonu";
            }
            else
            {
                MessageBox.Show("Aradiginiz Urun Bulunamamaktadir");
            }

            txtReyon.Text = reyon;
        }
    }
}
