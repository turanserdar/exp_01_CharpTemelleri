using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace k04_YasamDongusu
{
    
    public partial class YasamDongusu : Form
    {
        int globalDegisken= 100;
        public YasamDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalDegisken += 5;
            txtDeger.Text = globalDegisken.ToString();

        }
    }
}
