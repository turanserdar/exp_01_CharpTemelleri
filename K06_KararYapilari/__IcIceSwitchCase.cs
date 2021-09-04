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
    public partial class __IcIceSwitchCase : Form
    {
        public __IcIceSwitchCase()
        {
            InitializeComponent();
        }

        private void btnGiriss_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txtKullaniciAdim.Text;
            var parola = txtParolam.Text;

            switch (kullaniciAdi)
            {

                case "admin":
                    switch (parola)
                    {

                        case "1234":
                            MessageBox.Show("Giris Basarili");
                            break;
                        default:
                            MessageBox.Show("Kullanici Adiniz dogru ancak paraolaniz yanlis");
                            break;
                    }
                    break;

                default:
                    MessageBox.Show("Kullanici Adiniz Yanlis oldugundan parolaniz kontrol edilemedi");
                    break;

            }





        }
    }
}
