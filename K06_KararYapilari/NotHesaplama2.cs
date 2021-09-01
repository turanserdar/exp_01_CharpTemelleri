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
    public partial class NotHesaplama2 : Form
    {
        public NotHesaplama2()
        {
            InitializeComponent();
        }

        private void txtVize_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

          
           
            var girilenVize = txtVize.Text;
            var vize = Convert.ToDouble(girilenVize);

            var girilenFinal = txtFinal.Text;
            var final = Convert.ToDouble(girilenFinal);

            double ortalama = vize * 0.3 + final * 0.7;
            string ort = Convert.ToString(ortalama);

                var harfNotu = ""; // string ama icinde herhangi bir deger yok

            if (ortalama >= 85 && ortalama <= 100)
            {
                this.ortalama.Text = ort;
                HarfNotu.Text = "AA";
                Durum.Text = "Gecti"; 
                    MessageBox.Show("TEBRİKLER GEÇTİN. HADİ SEVİNELİM Mİ?");

                }
            else if (ortalama < 85 && ortalama >= 60)
            {
                this.ortalama.Text = ort;
                HarfNotu.Text = "BA";
                Durum.Text = "Gecti";
                    MessageBox.Show("TEBRİKLER GEÇTİN. HADİ SEVİNELİM Mİ? ");
                }
            else if (ortalama < 60 && ortalama >= 50)
            {
                this.ortalama.Text = ort;
                HarfNotu.Text = "CC";
                Durum.Text = "Gecti";
                    MessageBox.Show("TEBRİKLER GEÇTİN. HADİ SEVİNELİM Mİ? ");

                }
            else if (ortalama < 50 && ortalama >= 30)
            {
                this.ortalama.Text = ort;
                HarfNotu.Text = "DD";
                Durum.Text = "KALDI";
                    MessageBox.Show("MALESEF KALDIN. BİRLİKTE ÜZÜLELİM Mİ? ");
                }
            else if (ortalama < 30 && ortalama >= 0)
            {
                this.ortalama.Text = ort;
                HarfNotu.Text = "DD";
                Durum.Text = "KALDI";
                    MessageBox.Show("MALESEF KALDIN. BİRLİKTE ÜZÜLELİM Mİ? ");
                }
            else
            {
                MessageBox.Show("0 ile 100 arasinda bir deger giriniz!");
            }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gecerli bir sayi giriniz!");


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NotHesaplama2_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}


