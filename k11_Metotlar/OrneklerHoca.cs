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
    public partial class btnOrnek1 : Form
    {


        #region Metotlar

        /* a. 1-100 arasinda dongu kuran ve listbox a yazdiran bir metot yaziniz.
           b. Bitis degerini parametre olarak alip 1 den bitise kadar dongu kuran ve listbox'a yazdiran bir metot yaziniz.
           c.Baslangic ve bitis degerini parametre olarak alan ve baslangictan bitise dongu kuran, listbox a yazdiran bir metot yaziniz.


         */
        private void DonguKur()
        {
            lstSonuc.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                lstSonuc.Items.Add(i);
            }

        }

        private int[] SayilarDizisiniVer()
        {
            int[] sayilar = new int[100];

            for (int i = 1; i <= 100; i++)
            {
                sayilar[i - 1] = i;
            }
            return sayilar;
        }



        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            DonguKur();
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            var sayilar = SayilarDizisiniVer();
            foreach (var sayi in sayilar)
            {
                lstSonuc.Items.Add(sayi);
                cmbSayilar.Items.Add(sayi);
            }
        }
    }
}
