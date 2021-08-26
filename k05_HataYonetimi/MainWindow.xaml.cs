using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace k05_HataYonetimi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //---Hatayonetimi dosyasini olusturduktan sonra formun arkasina gecmek icin F7 ye basiyoruz
//Hata Turleri
//1.Derleme zamani hatalari(syntax hatalari)(yazim hatalari)
//noktali virgul, parantez, scope kapatilmaasi
//Error listte gorunurler.Duzeltilmeden program derlenmez.F5 ve ya F6 programi derler.
//Program derlendikten sonra dll diline cevirir.Yani kodlarinizi makine diline cevirir.
//Error listi View kismindan Error Listi aciyoruz.
//2.Calisma zamani hatalari (Runtime errors)
//Derlemede bir problem olmadi ama diyelim ki calisirken hata almasi.Calistiktan sonra uyari veriyor.
//3.Mantiksal hatalari (Logical Errors)
//Bu hatalar bulunmasi en zor hatalardir.Diger hata tiplerinde uyari veriyor.Ama mantiksal hatalarda herhangi bir uyari vermiyor.Kdv hesabi yaparken 0.18 yerine 0.0018 yazdiniz
//karesi yerine toplama yaptiginizda bunlar mantik hatasi olur.
//Bunlari yakalamak icin Debug yapmaniz gerekir.
//Herhangi bir kod parcasina veya scope lar uzerine break point koyuyorsunuz F5 ile calistiriyorsunuz.Proje debug moduna girdigi zaman F10 ile adim adim ilerleyerek calisma zamaninda kodlar kontrol edilir.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
