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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Kullanicidan alinan urun bilgisine gore yonlendirilecek reyonu gosteren bir uygulama yapiniz.
            // Bir markette oldugunuzu dusunun
            //Bilgisayar, cep telefonu,minibook yazarsa teknoloji reyonuna ilerleyiniz.
            // Parfum, deodorant, sampuan yazarsa kisisel bakim reyonu
            // Domates, biber, patlican yazarsa sebze reyonu
            // Bunlar disinda bir sey yazilirsa urun bulunmamaktadir bilgisi gosteren bir uygulama yapiniz

            var urun = txtUrunAdi.Text;

            if (true)
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mevsim = txtMevsim.Text.ToLower();


            switch (mevsim)
            {
                case "kis":

                    MessageBox.Show("Aralik Ocak Subat");


                    break;

                case "ilkbahar":

                    MessageBox.Show("Mart Nisan Mayis");


                    break;

                case "yaz":

                    MessageBox.Show("Haziran Temmuz Agustos");


                    break;

                case "sonbahar":

                    MessageBox.Show("Eylul Ekim Kasim");


                    break;

                default: MessageBox.Show("Boyle bir mevsim yok"); break;

            }


        }
    }
}
