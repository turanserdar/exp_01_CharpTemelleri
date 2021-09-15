using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_HazirFonksiyonlar
{
    public partial class DatetimeFonksiyonlari : Form
    {
        public DatetimeFonksiyonlari()
        {
            InitializeComponent();
        }
        DateTime simdikiZaman = DateTime.Now;
        private void btnSimdikiZaman_Click(object sender, EventArgs e)
        {

            lblSonuc.Text = simdikiZaman.ToString();

            // y : year
            // M : month
            // d : day
            // m : minute
            // H : hour
            // s : second
            lblSonuc.Text = simdikiZaman.ToString("dd/MMM//yyyy HH:mm:ss");
        }

        private void btnUzunZaman_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.ToLongDateString(); /// Sadece date i uzun versiyonu ile gosteriyor 
            MessageBox.Show(simdikiZaman.ToLongTimeString());  /// Sadece time i uzun versiyonu ile gosteriyor 
        }

        private void btnKisaZaman_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.ToShortDateString();
            MessageBox.Show(simdikiZaman.ToShortTimeString());
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.Day.ToString();
        }

        private void btnAy_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.Month.ToString();
        }

        private void btnYil_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = simdikiZaman.Year.ToString();

            // Saat ve dakikalari da bu sekilde alabiliyoruz
        }

        private void btnZamanEkle_Click(object sender, EventArgs e)
        {
            var zaman1 = simdikiZaman.AddDays(35);    //Time Span 1970 lerden gunumuze kadar gelen kisim . Yine de google dan bak. Ama time span cok kullanilmaz.

            var zaman2 = simdikiZaman.AddMonths(4);
            var zaman3 = simdikiZaman.AddYears(45); // Hoca breakpoint ile takip etti
        }

        private void btnYasHesapla_Click(object sender, EventArgs e)
        {
            // Burada timespan i gormus olacagiz
            // Datetime cinsinden dogum tarihi

            DateTime dogumTarihi = new DateTime(1991, 6, 2); // iki datetime in farki bulunabilir
            var fark = simdikiZaman - dogumTarihi; //Burada timespan cinsinden garip bir deger verdi bunu cevirmemiz gerekir
            var yas = fark.Days / 365; // Sadece gune ceviriyor.Gune cevirip 365 e bolersem yas kismini gorururm.
            lblSonuc.Text = yas.ToString();
          }

        private void btnParseTryParse_Click(object sender, EventArgs e)
        {
            var tarih1 = DateTime.Parse("2021-05-06"); // String olan bir seyi datetime fonksiyonuna cevirmek icin kullaniyoruz
            // isterseniz - isterseniz / kullanabilirsiniz

            // Bazende ingiliz tarih formati farkli oluyor // Once gun sonra ay yaziyor// O yuzden bilgisayarin dili neyse ona gore davranir.Bizim ki Turk formatina gore calistigi icin bu donusumu yapamaz. 13. ay yok cunku// Ceviremezse run time hatasi gonderir// Parse islemleri try catch icine alinirsa faydasi olur.
            var tarih2 = DateTime.Parse("2021/13/05");

            // Try parse diye de bir yontem
            // 1. yontem system globalization
            // 2. yontem ilk overload da

            DateTime cevirilenTarih;
            var cevirebildinMi = DateTime.TryParse("2021/13/05", out cevirilenTarih);


        }
    }
}
