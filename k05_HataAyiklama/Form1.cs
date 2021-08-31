using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k05_HataAyiklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Disaridan alinan sayinin karesini gosterme
            //try ve catch hata yakalama mekanizmasidir
            //try
            //{
            // hata almasi muhtemel kodlari yazilir.

            //}
            //{catch (exception ex)
            //{  
            // calisma zamani hatasi olusursa catch bloklarina duser

            //}

            try
            {



                //disaridan alinan sayiya ulasmam lazim
                var girilenSayi = txtSayi.Text; // bu deger string bunu convert edelim

                var sayi = Convert.ToInt32(girilenSayi);
                // karesini aliniz
                var karesi = sayi * sayi;
                //kullaniciya goster
                lblSonuc.Text = karesi.ToString();

            } catch (Exception ex) // exception hatanin turu sinifinin adi, ex de degiskenin adi. ex hatasi olan degiskenin veri tipi exception. int gibi sistemde hatalari tanimlayan veri tipi exception'dir. Exception hepsini kapsar
            {
                //MessageBox.Show("Hata olustu."+ex.Message);
                throw new Exception("Karakter girisi yapilamaz"); // Kendi istedigim exception hata mesajini gosterme // Run time hatasi gibi unhandled bir hata sistem disi gozukecek bir hata veriyor


            }// catch yaptigimiz icin proje calismaya devam edebilir

        }
    }
}
