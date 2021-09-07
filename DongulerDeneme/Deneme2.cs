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
    public partial class Deneme2 : Form
    {
        public Deneme2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var toplam = 0;

            for (int i = 10; i <= 30; i++)
            {

                if (i %2==1)
                {
                    listBox1.Items.Add(i);
                    toplam += i;
                }
                
                
            }
            listBox1.Items.Add(toplam);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 8. 2000 ile 2020 arasindaki yillari yazdiriniz.

            for (int i = 2000; i <= 2020; i++)
            {
                comboBox1.Items.Add(i);
                
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex !=-1)
            {
                var secilenYil = comboBox1.SelectedItem;
                textBox1.Text = secilenYil.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++)
            {
                listBox1.Items.Add($"{i}'ler");
                for (int j = 1; j <=10; j++)
                {
                    listBox1.Items.Add($" {i}x{j}= {i * j} ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++)
            {
                label1.Text += "X";

            }
        }
    }
}
