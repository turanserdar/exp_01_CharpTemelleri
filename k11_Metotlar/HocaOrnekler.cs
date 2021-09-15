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
    public partial class HocaOrnekler : Form
    {
        #region Metotlar

        private void DonguKur()
        {
            lstSonuc.Items.Clear();
            for (int i = 0; i <=100; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private int[] SayilarDizisiniver()
        {
            lstSonuc.Items.Clear();
            int[] sayilar = new int[100];
            for (int i = 1; i <=100; i++) 
            {
                sayilar[i - 1] = i;
            }
            return sayilar; // void yazmadigim icin bir deger dondurmek zorundayim yoksa metot olusturamiyorum.Bunu bir yerde kullanmadim. sadece metot yazmak icin bunu yazmak zorunda oldugum icin yazdim.
        }

        private void DonguKur(int bitis)
        {
            for (int i = 1; i <=bitis; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void DonguKur(int baslangic, int bitis)
        {
            for (int i = baslangic; i <= bitis; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }


        #endregion
        public HocaOrnekler()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            DonguKur();
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            var sayilar = SayilarDizisiniver();
            foreach (var sayi in sayilar)
            {
                lstSonuc.Items.Add(sayi);
                cmbSayilar.Items.Add(sayi);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();
            var bitis = Convert.ToInt32(txtBitis.Text);
            DonguKur(bitis);
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            var baslangic = Convert.ToInt32(txtBaslangic.Text);
            var bitis = Convert.ToInt32(txtBitis2.Text);
            DonguKur(baslangic, bitis);
        }
    }
}
