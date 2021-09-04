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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // KARAR YAPILARI
        /*
         Programi yonlendirmek icin kullandigimiz yapi
        Bir kosul veriyorsunuz ve kosul saglaniyorsa bir kodu saglanmiyorsa farkli bir kodu calistiran yapidir.
        Programin akisini belli bir kosula gore yonlendirmek istedigimiz durumlarda kullanilir.
       3 FARKLI KARAR YAPISI VARDIR

        1.  if-else yapisi
        2. switch-case yapisi
        3. ternary if yapisi


       
         * 
         */

        // 1. If- Else Yapisi

        // direk class  alaninda calismaz . Design alanina gelip cift tiklarsaniz form load yuklenir
        //if -parantez ac kapat- icine kosul yazilir
        //-Suslu parantez ac kapat- kosul saglandigi zaman calisacak kodlar (kosulun true olmasi)

        // if (kosul){

        // kosul saglandigi zaman calisacak kodlar (kosulun true olmasi)
        // } 

        // Disaridan alinan bir degerin "nur" degerine esit olmasi durumunda calisan ve ekrana girilen deger NUR yazan uygulamayi yapalim. 

        // Birden fazla else-if yazabilirsiniz Bunlardan hicbiri calismazsa bu sefer else blogu calisir

        //if (kosul1)
        //{
        //    //Kosul 1 true ise calisir
        //}
        //else if (kosul2)
        //{
        //    //Kosul 2 true ise calisir
        //}
        //else if (kosul3)
        //{
        //    //Kosul 3 true ise calisir
        //}
        //else if (kosul3)
        //{
        //    //Kosul 3 true ise calisir
        //}
        //else  
        //{
        //    //Hic bir kosul saglanmadiginda calisir
        //}

        /* Karsilastirma operaotrler
        == 
        !=
        <
        >
        <=
        >=

        Mantiksal Operatorler
        && and
        || or (alt gr + z nin yanindaki buyuk kucuk pipe veya alt gr + tire isareti)
      

         

        */
        private void btnTikla_Click(object sender, EventArgs e)
        {
            // Disaridan alinan bir degerin "nur" degerine esit olmasi durumunda calisan ve ekrana girilen deger NUR yazan uygulamayi yapalim.

            var girilenDeger = txtAd.Text;

            if (girilenDeger == "nur")
            {

                MessageBox.Show("Girdiginiz Deger Nur'dur.");

            }

            // disardan alinan deger nur ise giris basarili, degilse giris hatali bilgilerinizi kontrol ediniz uyarisi versin
            if (girilenDeger == "nur")
            {
                MessageBox.Show("Giris Basarili"); // true ise calisir
            }

            else
            {
                // false ise bu blok calisir
                MessageBox.Show("Giris Hatali! Bilgilerinizi kontrol ediniz");
            }

            // Giris basarili ise else bloguna hic ugramaz


            /// Bir kosul degilde birden fazla kosul kontrol etmem gerekirse
            /// diyelim ki iki tane kullanici olsun
           

        }

        private void btnGectiKaldi_Click(object sender, EventArgs e)
        {
         

            // Birden fazla else-if yazabilirsiniz Bunlardan hicbiri calismazsa bu sefer else blogu calisir

            //if (kosul1)
            //{
            //    //Kosul 1 true ise calisir
            //}
            //else if (kosul2)
            //{
            //    //Kosul 2 true ise calisir
            //}
            //else if (kosul3)
            //{
            //    //Kosul 3 true ise calisir
            //}
            //else if (kosul3)
            //{
            //    //Kosul 3 true ise calisir
            //}
            //else  
            //{
            //    //Hic bir kosul saglanmadiginda calisir
            //}
            /// Kullanicidan alinan sayi 0-50 arasinda ise kaldiniz; 50-100 arasinda ise gectiniz,bunlar disinda bir sey girilmisse uygun aralikta deger girmediniz yazdiralim
            /// 
            //var girilenDeger = txtNot.Text;//txtNot class tir text bu class in icinde tanimlanmistir
            //var intGirilenDeger = Convert.ToInt32(girilenDeger);

            //if (intGirilenDeger>=0&&intGirilenDeger<50)
            //{
            //    MessageBox.Show("Kaldiniz");
            //}
            //else if (intGirilenDeger>=50&&intGirilenDeger<100)
            //{
            //    MessageBox.Show("Gectiniz");
            //}
            //else
            //{
            //    MessageBox.Show("Uygun aralikta bir deger girmediniz!");
            //}


            //HOCANIN YAPTIGI
            var girilenDeger = txtNot.Text;//txtNot class tir text bu class in icinde tanimlanmistir
            var not = Convert.ToInt32(girilenDeger);

            if (not >= 0 && not <= 50)
            {
                MessageBox.Show("Kaldiniz");
            }
            else if (not > 50 && not <=100)
            {
                MessageBox.Show("Gectiniz");
            }
            else
            {
                MessageBox.Show("Uygun aralikta bir deger girmediniz!");
            }


        }

    
        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            // Kullanicidan alinan sayinin tek mi cift mi oldugunu bularak ekranda bilgi veren uygulamayi yaziniz
            try
            {
                var girilenDeger = txtSayi.Text;
                var sayi = Convert.ToInt32(girilenDeger); //hata almasi muhtemel kod burasi

                // snippet lara iki kez tab tab yaparsaniz otomatik olarak olusturur

                if (sayi % 2 == 0)
                {
                    MessageBox.Show("sayi cifttir");
                }
                /*else if ( sayi %2 ==1) bunu yazmaya gerek yok islemimizin karmasikligini artirir
                {
                    MessageBox.Show("sayi tektir");  
                }*/
                else
                {
                    MessageBox.Show("sayi tektir");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lutfen sayisal bir deger giriniz" + ex.Message);// burdaki ex.messsage pc nin bize verdigi hata mesaji

            }
           


        }

        // throw hata patlatmak icin kullanilir
        //MessageBox.Show("Test"); hizli yazmak icin mbox tab a cift tikla


        // Bazen event tetikleyip o tetikledigimiz seyi silersek kodu calistirdigimizda textChanged hatasi verir go to code diyip o satiri silmemiz yeterli ya da o sildiginiz eventi tekrar calistirmaniz gerekir
    }

}
