using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K07_Donguler
{
    public partial class DoWhileDongusu : Form
    {
        // Do while dongusu while dongusu calisir ancak while da once kosulu kontrol eder sonra icerideki islemleri kosul saglaniyorsa yapar, do while dongusunde oncelikle islemler yapilir sonra kosul kontrol edilir, kosul saglandigi surece dongu calismaya devam eder. Kosul saglanmasa da bir kez kontrol eder ondan sonra kosulu kontrol eder

        /*  
         
         do{
        
         //islemler

        
        } while (kosul)
         
         
         
         */

        public DoWhileDongusu()
        {

            InitializeComponent();
            int i = 0;
            do
            {

                MessageBox.Show("Merhaba Dunya");
                i++;
            } while (i < 3); 
        }
    }
}
