using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metotlar
{
    public partial class Ornekler : Form
    {
        /*
         * 
        a.1-100 arasinda dongu kuran ve listbox'a yazdiran bir metot yaziniz.   
        b. Bitis degerini parametre olarak alip 1'den bitise kadar dongu kuran ve listbox a yazdiran bir metot yaziniz
        c.Baslangic ve bitis degerini parametre olarak alan ve baslangictan bitise dongu kuran , listbox a yazdiran bir metot yaziniz.
         
         
         */

        private void BirdenYuze()
        {
            for (int i = 1; i <=100; i++)
            {
                lstSonuc.Items.Add(i);
            }
           
        }

        private void BirdenYuze(int sayi)
        {

            
            

            for (int i = 1; i < sayi+1; i++)
            {
                
                lstSonuc.Items.Add(i);

            }

        }
        private void BirdenYuze(int sayi1,int sayi2)
        {
            for (int i = sayi1; i <= sayi2 ; i++)
            {

                lstSonuc.Items.Add(i);

            }
        }


        private int [] SayilarDizisiniVer(int baslangic, int bitis)
        {
            var sayilar = new int[0];

            for (int i = baslangic; i <= bitis; i++)
            {
                Array.Resize(ref sayilar, sayilar.Length+1);
                sayilar[sayilar.Length - 1] = i;
            }
            return sayilar;

        }

        private string[] MailAyristir(string metin)
        {
            var ayrilanlar = metin.Split(',', ';');
            return ayrilanlar;
           
        }
        public Ornekler()
        {
            InitializeComponent();
        }

        private void Ornekler_Load(object sender, EventArgs e)
        {

        }

        private void btnBirdenYuzeDongu_Click(object sender, EventArgs e)
        {
            BirdenYuze();
        }

        private void btnBitis_Click(object sender, EventArgs e)
        {
            var girilenSayi =Convert.ToInt32( txtSayi1.Text);
            BirdenYuze(girilenSayi);
        }

        private void btnBasBitis_Click(object sender, EventArgs e)
        {
            var girilenSayi1 =Convert.ToInt32( txtBaslangic.Text);
            var girilenSayi2 = Convert.ToInt32(txtBitis.Text);
            BirdenYuze(girilenSayi1, girilenSayi2);
        }

        private void btnDizi_Click(object sender, EventArgs e)
        {
            var baslangic = Convert.ToInt32(txtBaslangic2.Text);
            var bitis = Convert.ToInt32(txtBitis2.Text);
            var sayilar=SayilarDizisiniVer(baslangic, bitis);
            foreach (var sayi in sayilar)
            {
            
                cmb2.Items.Add(sayi);
            }
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            var giris = txtMailler.Text;
            
        
        }
    }
}
