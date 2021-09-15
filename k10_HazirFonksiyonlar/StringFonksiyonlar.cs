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
    public partial class StringFonksiyonlar : Form
    {
        public StringFonksiyonlar()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {

        }

        private void btnStartsEndsWith_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMailOlustur_Click(object sender, EventArgs e)
        {
            var Ad = txtAd.Text;
            var soyAd = txtSoyAd.Text;


            var adSoyad = Ad + soyAd;

            adSoyad.ToLower().Replace('ş', 's').Replace('İ', 'I').Replace('ç', 'c').Replace('ü', 'u').Replace('ğ', 'g').Replace('Ü', 'U').Replace('ö', 'o').Replace('Ö', 'O');

            MessageBox.Show($"Mail adresiniz:{adSoyad}@gmail.com ");

        }
    }
}
