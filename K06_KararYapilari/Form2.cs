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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            // Girilen sifrenin uzunlugu 8 karakterden kucukse sifre guvensiz; (length)
            //Esitse daha guclu sifre kullanilabilir 
            // buyukse guclu sifre yazacak bir uygulama yaziniz
            // length burada metot degil ozelliktir

            //var sifre = txtSifre.Text; // text burada txtSifre clasinin text ozelligi

            //if (sifre.Length<8)
            //{
            //    MessageBox.Show("Sifre Guvensiz");
            //}
            //else if (sifre.Length==8)
            //{
            //    MessageBox.Show("Daha guclu sifre");
            //}
            //else
            //{
            //    MessageBox.Show("Guclu Sifre");
            //}

            // Solution explore daki kirmizi tikler orada bir degisiklik var demek 
            // + demek henuz hic bir sey yapmamissiniz git hub a yonelik

            // HOCANIN YAPTI{I

            var sifre = txtSifre.Text; // text burada txtSifre clasinin text ozelligi
            var uzunluk = sifre.Length; // Boyle yapmak daha iyi degisiklik yapmak istedigimiz 


            if (uzunluk < 8)
            {
                MessageBox.Show("Sifre Guvensiz");
            }
            else if (uzunluk == 8)
            {
                MessageBox.Show("Daha guclu sifre");
            }
            else
            {
                MessageBox.Show("Guclu Sifre");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Kullanici adi admin ve parola 1234 ise hosgeldin yazisi yazdiralim,
            //Kullanici adi admin degilse kullanici adiniz hatali;
            //Parola 1234 degilse parolaniz hatali
            // ikisi de yanlissa kullanici adi ve parolaniz hatali mesaji gosterelim

            //var kullaniciAdi = txtKullaniciAdi.Text;
            //var parolatext = txtParola.Text;
            //var parola = Convert.ToInt32(parolatext);

            //if (kullaniciAdi=="admin"&&parola==1234)
            //{
            //    MessageBox.Show("Hosgeldin");
            //}
            //else if (kullaniciAdi != "admin")
            //{
            //    MessageBox.Show("Kullanici adiniz hatali");
            //}
            //else if (parola != 1234)
            //{
            //    MessageBox.Show("Parolaniz hatali");
            //}
            //else
            //{
            //    MessageBox.Show("Kullanici adi ve parolaniz hatali");


            // HOCANIN YAPTIGI'

            var kullaniciAdi = txtKullaniciAdi.Text.ToLower();
            var parola = txtParola.Text;

            if (kullaniciAdi == "admin"&& parola=="1234")
            {
                MessageBox.Show("Hosgeldin");
            }
            else if (kullaniciAdi != "admin"&& parola == "1234")
            {
                MessageBox.Show("Kullanici Adiniz Yanlis");
            }
            else if (kullaniciAdi=="admin"&&parola!="1234")
            {
                MessageBox.Show("Parolaniz yanlis");
            }
            else
            {
                MessageBox.Show("Kullanici adi ve parola yanlis");
            }
            
            // checkbox'in kisminin tiklanip tiklanmadigini anlama /true ise checklenmistir
            // bunu degisken uzerinde de tutabiliriz veya if uzerinde de tutabiliriz
            if(chbBeniHatirla.Checked) // true donduruyor
            {

                MessageBox.Show("Beni hatirla isaretlendi");
            }


        }






    }
    }

