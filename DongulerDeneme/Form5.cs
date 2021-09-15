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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string[] isimler = { "omer", "leyla", "batuhan", "cigdem", "bahar", "serdar", "orkun", "batuhan", "anil", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" };
        private void button1_Click(object sender, EventArgs e)
        {
            string[] fizikselKatilimcilar = new string[9];
            Array.Copy(isimler, fizikselKatilimcilar, 9);
            foreach (var fk in fizikselKatilimcilar)
            {
                lstSonuc.Items.Add(fk);
            }
            
            var onlineKatilimcilar = new string[6];
            Array.Copy(isimler, 9, onlineKatilimcilar, 0, 6);
            foreach (var ok in onlineKatilimcilar)
            {
                lstSonuc2.Items.Add(ok);
            }

            
            
        }
    }
}
