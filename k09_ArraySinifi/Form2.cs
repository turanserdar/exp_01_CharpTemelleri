using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k09_ArraySinifi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] ziyaretciler = new string[0];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //textbox'dan alinan adi soyadi bir dizide toplayalim sonrasinda listbox'a atalim
            var adSoyad = txtAdSoyad.Text;

            //string[] ziyaretciler = new string[0]; // Kac kisi gelecegini bilmedigim icin 0 dan basladim. Hic kimse gelmezse bosuna 10 kisilik yer // Burada tanimlarsam her defasinda diziyi sifirlamis olurum. o yuzden bunu globala aliyorum.
            Array.Resize(ref ziyaretciler, ziyaretciler.Length + 1);
            ziyaretciler[ziyaretciler.Length - 1] = adSoyad; // En son elemana ekleme yapiyor.
            lstZiyaretciler.Items.Add(adSoyad);
        }
    }
}
