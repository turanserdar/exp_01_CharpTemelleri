using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkranKoruyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //interval 
            // timer tick event i ile tetiklenir
            Random rnd = new Random();
            var formunGenisligi = this.Width - pictureBox1.Width;
            var formunYuksekligi = this.Height - pictureBox1.Height;

            var rastgeleSayi1 = rnd.Next(0, formunGenisligi);

            pictureBox1.Left = rastgeleSayi1; // bu sadece sola dogru hareket etmesini saglar

            var rastgeleSayi2 = rnd.Next(0, formunYuksekligi);
            pictureBox1.Top = rastgeleSayi2;


        }

        


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Formun icindekiler yuklendikten sonra resmin rastgele olarak yer degistirmesini istiyoruz

            Application.Exit();
        }
    }
}
