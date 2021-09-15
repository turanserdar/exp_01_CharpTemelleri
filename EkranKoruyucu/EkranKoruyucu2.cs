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
    public partial class EkranKoruyucu2 : Form
    {
        public EkranKoruyucu2()
        {
            InitializeComponent();
        }

        private void EkranKoruyucu2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var formunGenisligi = this.Width-pictureBox1.Width;
            var formunYuksekligi = this.Height-pictureBox1.Height;

            var rastgeleSayi2 = rnd.Next(0, formunGenisligi);

            pictureBox1.Left = rastgeleSayi2;

            var rastgeleSayi3 = rnd.Next(0, formunYuksekligi);
            pictureBox1.Top = rastgeleSayi3;
        }

        private void EkranKoruyucu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var formunGenisligi = this.Width - pictureBox2.Width;
            var formunYuksekligi = this.Height - pictureBox2.Height;

            var rastgeleSayi2 = rnd.Next(0, formunGenisligi);

            pictureBox2.Left = rastgeleSayi2;

            var rastgeleSayi3 = rnd.Next(0, formunYuksekligi);
            pictureBox2.Top = rastgeleSayi3;
        }
    }
}
