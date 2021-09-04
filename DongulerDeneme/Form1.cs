using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongulerDeneme
{
    public partial class btnOrnek5 : Form
    {
        public btnOrnek5()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //lstSonuc.Items.Add("listbox a girmek istedigim degeri buraya yaziyorum");

            //lstSonuc.Items.Add("Ankara");
            //lstSonuc.Items.Add(1);
            //lstSonuc.Items.Add(true);

            for (int i = 1; i <= 100; i++)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            for (int i = 100; i >= 1; i--)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {//10'dan 50 ye 3'er 3'er artirarak yaziniz
            for (int i = 10; i <= 50; i += 3)
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {




            for (char i = 'A'; i <= 'Z'; i++)
            {
                lstSonuc.Items.Add($" sembol --> {i}  ASCII --> {Convert.ToInt32(i)}");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 20; i <= 100; i++)
            {
                if (i%2==0)
                {
                    lstSonuc.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var toplam = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;


            }
            lstSonuc.Items.Add(toplam);
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            for (int i = 10; i < 30; i++)
            {
                if (i%2==1)
                {
                    lstSonuc.Items.Add(i);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i =2000;  i <= 2020; i++)
            {
                cmbYillar.Items.Add(i);
            }
        }

        private void cmbYillar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYillar.SelectedIndex!=-1)
            {

                var secilenYil = cmbYillar.SelectedItem;
                txtSecilenYil.Text = secilenYil.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            var rastgeleSayi=rdm.Next(1, 100);
            MessageBox.Show(rastgeleSayi.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            for (int i = 1; i <= 10; i++)
            {
                lstSonuc.Items.Add($"=================");
                for (int j = 1; j <= 10; j++)
                {
                    lstSonuc.Items.Add($"{i}x{j}={i * j}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++)
            {
                    lblYaziTahtasi.Text += "X ";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lstSonuc.Items.Add("X"); 

                for (int j = 0; j <=10; j++)
                {
                    lstSonuc.Items.Add("X");

                }

            }
        }
    }
}
