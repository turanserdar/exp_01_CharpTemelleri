using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k04_YasamDongusu
{
    public partial class Form1 : Form
    {
        //Yapici metot(constructor) Bir sinif ilk olsuturduldugunda ilk olarak bu metot kendi kendine calisir
        //uzerine geldiginde pembe kup isareti metot demektir ayni zamanda metot acilip kapaniyorsa metotdur
        // Form olusturulurken arka tarafta kod alani ve on tarafta dizayn alani otomatik olarak olusur
        public Form1()
        {
            InitializeComponent();
            btnKabulEt.Text = "Merhaba Dunya";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReddet_Click(object sender, EventArgs e)
        {

        }

        private void btnKabulEt_Click(object sender, EventArgs e)
        {

        }
    }
}
