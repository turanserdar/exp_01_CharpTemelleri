using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K06_KararYapilari
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            // Application.Run(new NotHesaplama()); // NotHesaplama bir class tir//Bunu yaptigimizda F5 e bastigimizda artik NotHesaplama F5 e basinca bu calisiyor
            //Application.Run(new NotHesaplama2());
            //Application.Run(new Form3());
            //Application.Run(new UrunNeredeHoca());
            ////Application.Run(new Form4());
            //Application.Run(new KitapciSiparis());
            //Application.Run(new Form5());

            //Application.Run(new TurnerIf());
            //Application.Run(new __IcIceSwitchCase());
            Application.Run(new UrunNerede());
        }
    }
}
