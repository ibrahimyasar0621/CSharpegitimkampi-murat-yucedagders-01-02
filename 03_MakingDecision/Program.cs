using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // KARAR YAPILARI 
            // Pogramda bir yerden sonra çıktıya göre işlem yapmak isteyebiliriz. Mesela ; Eğer şu sayıdan büyükse şöyle olsun. Eğer kullanıcı adı doğruysa şöyle olsun.
            #region İF ELSE

            Console.Write("Lütfen Şifre Girin: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")                    //   ==  EŞİT EŞİT B ir operatör aslında EŞİT Mİ ? Demek bir tane eşit olunca direkt atama opratörü demek yani bunu atadım buna eşit demek.
                                                       // Karar yapılarından sonra noktalı virgül konmaz. ingilizcedeki mantığıyla mesela = "Eğer hava yağmurluysa"  dedim ama cümle bitmedi noktalama gelmez.Devamı var demek. 
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            // Birden fazla şart olabilir mesela kullanıcıdan ülke şehir ve bir kaç şey alalım.

            string capital, country;
            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")  // Hepsini küçük harfle yazdım çünkü burada bir harfi küçük yazdın ama çıktı konsol ekranında küçük yazarsan kabul etrmez. Bütün harfler birebir uyumlu olmalı.

            {
                Console.Write("veriler doğrulandı");

            }

            else
            {
                Console.Write("hatalı bilgi");
            }

            int number;
            Console.WriteLine("Syi Giriniz");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Yanlış");
            }


            //Birden fazla if kullanabiliriz.Mesle sınav sonucuna göre metinsel ifade veren ir uygulama yazalım.

            int exam1, exam2, exam3, average;        // int sayısal değer ille  sınav değişkenleri ve ortalama tanımladım.    
            string result = "Hata!";                           // result diye değğişken tanımladım. sonucu yazdırcam
            Console.Write("Sınav1: ");               //fonksiyonu ile ekrana "Sınav1: " mesajı yazılıyor.
            exam1 = int.Parse(Console.ReadLine());    //int.Parse() fonksiyonu ile bu string, tam sayı(int) tipine dönüştürülerek exam1 değişkenine atanıyor.console readline kullanıcıdan sınav notu alınarak bir string olarak elde ediliyor. 
            Console.Write("Sınav2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;       //Sınav tnotlarını toplayıp 3 e böldüm. ortalamasını aldım. bu değer average değerim oldu.
            Console.WriteLine("Sınavların Ortalaması: " + average);    //konsol ekranına sınav ortalaması : averageden gelen değeri yazdıracak.

            if (average > 0 & average <= 50)
            {
                result = "Sonuç Vasat";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi";
            }
            if (average > 84)
            {
                result = "Sonuç Çok İyi";
            }
            Console.WriteLine(result);  // Burada result altını kırmızı ile çizm enedeni sonucu yazdırırken olurda buradaki 4 tane if değerinin dışında bir sonuç gelirse ne yapacağğim diyor. CS 00165 KODU
            //Ya buruada else ile değer atamsı yap yada result için ilk değer ataması yap.
             //70.satırdaki resultun yanında; vardı ama bir ilk değer ataması yapmak için result = ""; yazdık tırnağı hata! çünkü bunların dışında değer olursa yazdığımız yazı ekrana gelsn.

            string city;
            Console.Write("Lütfen Şehir Girişi Yapınız;");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("şehir mevcut");

            }
            else
            {
                Console.WriteLine("şehir mevcut değil");
            }

            Console.WriteLine("Lütfen Kullanıcı Adını Girin");
            string userName = Console.ReadLine();
            if (userName != "admin")
            {
                Console.Write("buu kullanıcı adıı kbul edilmiyor");

            }
            else
            {
                Console.WriteLine("Hoş Geldiniz");
            }




            #endregion

            #region MOD İŞLEMLERİ
            //MOD iki aritmetik işlemde birbirine bölümde kalanı veriyor.
            int number;
            number = 36;
            int result = number % 5;  // MOD yazılımda yüzde işareti " % "  ile ifade ediliyor. //so uç 1 olmalıı. 36 sayısının 5 e bölümünden kalanı yazacak. 
            Console.WriteLine(result);

            Console.Write("Lütfen Sayı Giriniz:");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen İkinci Sayıyı Giriniz:");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;
            Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            Console.Write("Lütfen sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.Write("Sayı Çifttir");
            }
            else
            {
                Console.Write("Sayı Tektir");
            }
            #endregion

            #region char DEĞİŞKENLER İLE KARAR YAPILARI

            char team;                  //Tek Karakter: char yalnızca bir karakter tutar. İki veya daha fazla karakter içeren bir dize (string) kullanmak istiyorsanız, string veri tipini kullanmalısınız.                             
            Console.Write("Lütfen takım sembolünü girin: ");      // Yazdığın harfe göre takım adını yazdırıyor ekrana.
            team = char.Parse(Console.ReadLine());
            if (team == 'g' | team == 'G')
            {
                Console.Write("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }

            // MENÜ PROJESİ YAPALIM DÖNGÜ VE KARAK YAPILARI KULLANALIMM.
            // NEYİ SEÇERSE O AÇILSIN İÇECEĞİ SEÇERSE O AÇILSIIN TATLIYI SEÇERSE O AÇILSIN
            #endregion

            #region ÖRNEK PROJE UYGUULAMASI

            Console.WriteLine("*******   C# EĞİTİM KAMPI RESTORAN   *******");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-ANA YEMEKLER");
            Console.WriteLine("2-ÇORBALAR");
            Console.WriteLine("3-PİZZALAR");
            Console.WriteLine("4-İÇECEKLER");
            Console.WriteLine("5-TATLILAR");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            string menuItem;

            Console.WriteLine("Lütfen Detayını Görmek İstediğiniz Menü Seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("------------------ANA YEMEKLER------------------");
                Console.WriteLine();
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasuye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("------------------ANA YEMEKLER------------------");
                Console.WriteLine();
            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("------------------Çorbalar------------------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine("3-Kelle Paça Çorbası");
                Console.WriteLine("4-Düğün Çorbası");
                Console.WriteLine("5-İşkembe Çorbası");
                Console.WriteLine("------------------Çorbalar------------------");
                Console.WriteLine();
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("------------------Pizzalar------------------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margarita Pizza");
                Console.WriteLine("3-Sucuklu Pizza");
                Console.WriteLine("4-Tavuklu Pizza");
                Console.WriteLine("5-Mantarlı Pizza");
                Console.WriteLine("------------------Pizzalar------------------");
                Console.WriteLine();
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------------------İçecekler------------------");
                Console.WriteLine();
                Console.WriteLine("1-Su");
                Console.WriteLine("2-Kola");
                Console.WriteLine("3-Fanta");
                Console.WriteLine("4-Ayran");
                Console.WriteLine("5-Soda");
                Console.WriteLine("------------------İçecekler------------------");
                Console.WriteLine();
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------------------Tatlılar------------------");
                Console.WriteLine();
                Console.WriteLine("1-Baklava");
                Console.WriteLine("2-Trileçe");
                Console.WriteLine("3-Kazanndibi");
                Console.WriteLine("4-Sütlaç");
                Console.WriteLine("5-Kemal Paşa");
                Console.WriteLine("------------------Tatlılar------------------");
                Console.WriteLine();
            }





            #endregion

            #region  Switch Case
            Console.Write("Lütfen Ay Girişi Yapınız: ");
            int mounthNumber = int.Parse(Console.ReadLine());
            switch (mounthNumber)            //switch yazdıktan sonra iki kere tab tuşuna bas otomatik geliyor. switch benim anahtarım mounthnumber ayy numaraı benim anahtarım ona göre işlem yapacam.
            {
                case 1: Console.Write("OCAK"); break;  // 1 yazarsam ocak yazısını getir ve bitir. bitirme için break yazmam lazım 
                case 2: Console.Write("ŞUBAT"); break;
                case 3: Console.Write("MART"); break;
                case 4: Console.Write("NİSAN"); break;
                case 5: Console.Write("MAYIS"); break;
                case 6: Console.Write("HAZİRAN"); break;
                case 7: Console.Write("TEMMUZ"); break;
                case 8: Console.Write("AĞUSTOS"); break;
                case 9: Console.Write("EYLÜL"); break;
                case 10: Console.Write("EKİM"); break;
                case 11: Console.Write("KASIM"); break;
                case 12: Console.Write("ARALIK"); break;
                default:
                    Console.Write("HATALI VERİ GİRİŞİ"); break;    // bunların dışında veri girişi olursa ne yapacağını yazdık. bunuda break ile kapatacağız

            }

            #endregion

            #region Switch Case HESAP MAKİNESİ
            int number1, number2, result;
            char symbol;
            Console.Write("Birinci Sayıyı Giriniz: ");
            number1=int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            number2=int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak İstediğiniiz İşlemi Giriniz: ");       //Kullanıcıdan hangi işlemi yapmak istediğini belirten bir karakter girmesi istenir.
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':                                          //Burada casenin yanına noktalı virgül olmayacak iki nokta olacak.
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;



            }


            #endregion

            Console.Read();
        }
    }
}
