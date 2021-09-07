using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K07_Donguler
{
    public partial class ForeachDongusu : Form
    {
        /*   
         
         Foreach dongusu liste veya dizi gibi bir koleksiyonda doner ve her donuste gelen degeri bir degisken uzerinde tutar.

        // Koleksiyon
         
         
         
         
         
         */





        public ForeachDongusu()


        {
            InitializeComponent();

            string[] isimler = { "bahar", "serdar", "omer", "leyla", "batuhan", "cigdem", "eray", "orkun", "batuhan", "mustafa" };

            foreach (var isim in isimler)
            {
                MessageBox.Show(isim);
            }

            //for (int i = 0; i < isimler.Length; i++)  // for u da foreach gibi calistirabiliriz
            //{
            //    var  isim = isimler[i];
            //    MessageBox.Show($"{i}.ogrenci{isim}");
            //}
        }
    }
}
