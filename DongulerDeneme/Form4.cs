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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void btn1100_Click(object sender, EventArgs e)
        {
            for (int i = 2000;  i <= 2020; i++)
            {
                
              
                comboBox1.Items.Add(i);
               

            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex!=-1)
            {
                var secilmisYil = comboBox1.SelectedItem;
                txtSecilenYil.Text = secilmisYil.ToString();
            }
        }
    }
}
