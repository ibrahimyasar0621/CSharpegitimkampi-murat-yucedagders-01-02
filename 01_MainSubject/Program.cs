using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yzdırma Komutları


            Console.Write("Merhaba Dünya");
            Console.WriteLine("****** YEMEK KATEGORİLERİ ******");
            Console.WriteLine();
            Console.WriteLine("Selam");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlanngıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("****** YEMEK KATEGORİLERİ ******");
            Console.WriteLine();

            #endregion

            #region String Değişkenler

            //Değişkennler
            //String
            //Değişken_türü değişken_adı;
            string name;
            name = "Ibrahim";
            Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "ibrahim";
            customerSurname = "yasar";
            customerPhone = "+905462672921";
            customerEmail = "ibrahimyasar2106@gmail.com";
            district = "Etimesgut";
            city = "Ankara";

            Console.WriteLine("Rezervasyon Kartı");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email:" + customerEmail);
            Console.WriteLine("Adres:" + district + "/" + city);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();

            customerName = "Ayşe";
            customerSurname = "Kaya";
            customerPhone = "+905321562331";
            customerEmail = "Test@gmail.com";
            district = "Tuzla";
            city = "İstanbul";
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email:" + customerEmail);
            Console.WriteLine("Adres:" + district + "/" + city);
            Console.WriteLine("------------------------------------------");



            #endregion

            #region Int Değişkenler

            //int  sayısal tamsayı şeklindeki değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int fricesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("******Restoran Menü Fiyatı ******");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + "Tl");
            Console.WriteLine("------Pizza: " + pizzaPrice + "Tl");
            Console.WriteLine("------Kola: " + cokePrice + "Tl");
            Console.WriteLine("------Hamburger: " + lemonadePrice + "Tl");
            Console.WriteLine("------Kızartma: " + fricesPrice + "Tl");
            Console.WriteLine("------Su: " + waterPrice + "Tl");


            Console.WriteLine();
            Console.WriteLine("******Restoran Menü Fiyatı ******");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int fricesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFricesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            fricesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFricesPrice = fricesCount * fricesPrice;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hamburger Tutarı" + " " + totalHamburgerPrice + "Tl");
            Console.WriteLine("Kola Tutarı" + " " + totalCokePrice + "Tl");
            Console.WriteLine("Su Tutarı" + " " + totalWaterPrice + "Tl");
            Console.WriteLine("Kızartma Tutarı" + " " + totalFricesPrice + "Tl");
            Console.WriteLine("Pizza Tutarı" + " " + totalPizzaPrice + "Tl");
            Console.WriteLine("Limonata Tutarı" + " " + totalLemonadePrice + "Tl");
            Console.WriteLine();

            int totalPrice = totalCokePrice + totalFricesPrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;
            Console.WriteLine("TOPLAM ÖDENECEK TUTAR: " + totalPrice + " " + "TL");



            #endregion


            Console.Read();

        }
    }
}
