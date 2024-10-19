using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region VOİD METODLAR  (GERİYE DÖNMEYEN METODLAR)
            // Bir yapının metod olduğunu anlamak için sonuna mutlaka parantez açıp kaanması gerekiyor. ()  
            // console.writeline() console.read()  bunlar metod mesela parse çevirme metodu mesella
            // Metoodlar solunda mor renkli bir küp vardır oradan metod olduğunu anlayabilirsin.
            // Geriye dönmeyen metodlar var. Mesela veri tabanında Customer- Listele, ekle, güncelle, sil, işlemlerini yaparken  her işlemden sonra bir şeyi yeniden çağırman gerekebilir.
            // Mesela silme işlemi yaptın sonra silinmiş halini son alii tekrara bakmak isteyebilirsin. mesela güncelledin son halini tekrar bakman gerekebilir .
            // VOİD veriye dönmeyen metodlarda kullanılıyor.

            void customerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");
            }

            customerList();        // Ekrana bu listeyi yazdırdık

            void sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }
            sum();



            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN PARAMETRELİ METODLAR
            void WriteMethod(string customerethod)
            {
                Console.WriteLine(customerethod);
            }
            WriteMethod("Mehmet Yıldırım");

            void customerCard(string name, string surname)
            {
                Console.WriteLine("Müşteri: " + name + " " + surname);
            }
            customerCard("Mehmet", "Yıldız");
            customerCard("Ayşegül", "Kaya");

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN int PARAMETRELİ METODLAR

            void sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            sum(4, 5, 6);

            #endregion

            #region GERİYE DEĞER DÖNDÜREN METODLAR

            string customerName()
            {
                return "Buse Yıldırım";
            }
            customerName();

            string studentCard()
            {
                string name = "Ali";
                string surname = "Kaya";

                return name + " " + surname;
            }
            Console.WriteLine(studentCard());     //EKRANA ALİ KAYA YAZDIRDI

            #endregion

            #region GERİYE DEĞER DÖNDÜREN STRİNG PARAMETRELLİ METODLAR

            string countryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "ÜLKE: " + countryName + " " + "BAŞKENT: " + capital + " " + flagColor + "BAYRAK RENGİ: ";
                return cardInfo;
            }
            string x, y, z;
            Console.Write("ÜLKE ADINI GİRİNİZ: ");
            x = Console.ReadLine();

            Console.Write("BAŞKENTİ GİRİNİZ: ");
            y = Console.ReadLine();

            Console.Write("BAYRAK RENGİNİ GİRİNİZ: ");
            z = Console.ReadLine();

            Console.WriteLine(countryCard(x, y, z));   // BURADA KENDİMİZ BİLGİLERİ GİRDİK

            Console.WriteLine(countryCard("TÜRKİYE", "ANKARA", "KIIRMIZI-BEYAZ"));  // BURADA BİZİM BURAYA YAZDIĞIMIZ DEPERİ EKRANA YAZDIRDI. CONSOLDAN GİRMEDİK.
            #endregion

            #region GERİYE DEĞER DÖNDÜREN Int METODLAR
            int Sum(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Sum(45, 98));   // BUNLARI TOPLAYARAK EKRANA YAZDIRDI 
            Console.WriteLine(Sum(36, 25));
            Console.WriteLine(Sum(44, 36));
            Console.WriteLine(Sum(14, 20));

            #endregion

            string examResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 +  exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return "İsimli öğrenci sınavı geçti  " + "Ortalama: " + result;               // BURADA EĞER ÖĞRENCİ NOT ORTALAMASI 50 VE ÜZERİNDE İSE BAŞARILI OLUD DEĞİLSE BAŞARISIZ OLDU YAZDIRACAK
                }

                else 
                {
                    return " İsimli öğrenci dersi geçemedi  " + "ortalama: " + result;
                }

                
            }
            Console.WriteLine(examResult("ALİ", 25, 41, 85));             // sınav notlarını burada girdik. consoldan almadık
            Console.WriteLine(examResult("Ayşe", 36, 88, 33));
            Console.Read();
        }
    }
}
