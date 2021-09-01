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
    public partial class NotHesaplama : Form
    {
        public NotHesaplama()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVize_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vizeDeger = txtVize.Text;
            var vize = Convert.ToDouble(vizeDeger);

            var finalDeger = txtFinal.Text;
            var final = Convert.ToDouble(vizeDeger);
            var ortalama = vize * 0.3 + final * 0.7;


            if (ortalama >= 0 && ortalama < 30)
            {
                MessageBox.Show("FF/KALDI" + $" ortalamasi:" + ortalama);
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                MessageBox.Show("DD/KALDI" + $" Ortalamasi:" + ortalama);
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                MessageBox.Show("CC/GECTI" + $" Ortalamasi:" + ortalama);
            }
            else if (ortalama >= 60 && ortalama < 85)
            {
                MessageBox.Show("BA/GECTI" + $" Ortalamasi:" + ortalama);
            }
            else if (ortalama > 85)
            {
                MessageBox.Show("AA/GECTI" + $" Ortalamasi:" + ortalama);
            }

            //Kullanicidan vize ve final notlarinin girilmesini isteyiniz
            //Vizenin %30, finalin %70 ini alarak ortalama hesaplayiniz
            //0-30 ise FF
            // 30-50 ise DD
            //50-60 ise CC
            //60-85 ise BA
            // 85+ ise AA
            // CC ve ustu harf notu gecer
            //KUllaniciya ortalamasini, harf notunu ve gecti/kaldi durumunu gosteriniz






        }


    }
}
