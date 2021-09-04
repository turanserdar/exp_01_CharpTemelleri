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
    public partial class _icice_NestedSwitchCase : Form
    {
        public _icice_NestedSwitchCase()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanici adi admin ve sifre 1234 ise giris basarili uyarisi verilsin

            var kullaniciAdi = txtKullaniciAdi.Text;
            var parola = txtParola.Text;

            switch (kullaniciAdi)// kullanici adinin admin olmasi durumu
            {
                case "admin":
                    switch (parola)
                    {
                        case "1234":
                            MessageBox.Show("Giris Basarili");
                            break;
                        default:
                            MessageBox.Show("Kullanici adiniz dogru ancak parolaniz yanlis");
                            break;


                    }
                    break;

                default:
                    MessageBox.Show("Kullanici adiniz yanlis oldugundan parolaniz kontrol bile edilemedi");
                    break;
            }
        }
    }
}
