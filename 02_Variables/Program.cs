using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //ondalıklı işlemler için kullanlır. küsüratlı para üstü vermek için mesela. integer kullanırsan olmaz para üstünü veremez.
            //double number;
            //number = 4.85;          // burada yazdığımız 4.85 oradaki nokta bize çıktıda virgül, olarak gözükür.
            //Console.WriteLine(number); ;
            //Console.Read();

            

            Console.WriteLine("******Fiyta Listesi******");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + "TL" );
            Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice + "TL");
            Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + "TL");
            Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + "TL");  //Her parçadan sonra test et. mesela 10 parçadan oluşuyorsa proje her parçadan sonra test et.

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            Console.WriteLine();
            Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyat: " + applePrice + "-Gramaj:" + appleGram + "-Toplam Tutar:" + appleTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyat: " + orangePrice + "-Gramaj:" + orangeGram + "-Toplam Tutar:" + orangeTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyat: " + strawberryPrice + "-Gramaj:" + strawberryGram +  "-Toplam Tutar:" + strawberryTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün: Patates -" + "Birim Fiyat: " + potatoPrice + "-Gramaj:" + potatoGram  + "-Toplam Tutar:" + potatoTotalPrice + "TL");
            Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fiyat: " + tomatoPrice + "-Gramaj:" + tomatoGram + "-Toplam Tutar:" + tomatoTotalPrice + "TL");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice; 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alışveri Toplam Tutarı:" + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler

            // Karater türünde değişkenler oluşturur.Bir yerden sonra string yetersiz gelir. Mesela şifreleme algoritması tutacaksın.
            // sezar şifreleme yazacaksın. Sezar şifreleme her bir karakterin (türkçe karakter hariç) 3 sonraki karakterle değiştirir. A yerine D yazıyor mesela.
            // Herharfe tek tek ulaşman lazım burada da char değişkeler devreye giriyor.

            char symbol;
            symbol = 'a';                        // char yazım formatı tek tırnak içine yazılır yoksa hata alırsın.
            Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("***** CSharp Hava Yollları Yolcu Bilgisi");  //havayolu şirketi için müşteri bilgilerini alacağız
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdebtityNumber;

            Console.Write("Yolcu Adı: ");                    //Yani önce kendimiz klavyeden giricez veriyi. bize yolcu adı ve soyadını yaz diyecek.
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı:");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();
            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdebtityNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdebtityNumber + "Yolcu Ad Soyad:" + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);
            //Yani önce yukarıda kendimiz klavyeden giricez. Sonra klavyeden girdiğpimiz veriyi bize geri yazdıracak.

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

               //C# dili konsol ekranı üzerinde girilen değerleri başlangıçta STRİNG değer kabuul ediyor.
             //Eğer buraya true / false şeklinde değer yada sayıasl değer gireceksen dönüşüm uygulaman lazım.
             //mesela memlekete gideceksin PEGASS saa rezervasyon kodu veriyor.  ABC12D buradaki 12 bir sayı değil aslında herhangi ir şeyi temsil etmiyor sayısal olarak.
             //Bir E-TİCARET sitesi için satış paneli yapalım.

            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());      // Parse dönüştürme formatı ben bu integer değere dönüştürdük.  değerini 32 byte formatında dönüştürücem.
            Console.Write("Lütfen aldığınız bilgisayar sayısını girin:");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız koltuk sayısını girin:");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız kelevizyon sayısını girin:");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar" + totalPrice);





            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;
            Console.Write("Lütfen 1. sınav notunu girin);");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sınav notunu girin);");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 3. sınav notunu girin);");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınav Ortalamanız:" + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());         // burada yine çeviriyoruz ve parantez içinde konsoldan gelen değer.

            Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);   //Birden fazla değer girersek K yada E yerine erkek yada kız yazarsak hata varir.



            #endregion

            Console.Read() ;

        }
    }
}
