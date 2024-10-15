using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR EACH DÖNGÜSÜ

            // Foreach(1;2;3;4)     // 4 tane parametra laan bir döngüdür.
            // 1: Değişken türü
            // 2:Değişkenin adı
            // 3:In
            // 4:Liste , Koleksiyon, Dizi

            string[] cities = { "milano", "roma", "ankara", "istanbul", "varşova" };

            foreach (string x in cities)  // X değişkeni cities dizisinin içine gidip bütün değerleri tek tek üzerine alacak.
            {
                Console.WriteLine(x);     // For döngüsüne göre avantajı  ForEach  nerde başlıyor kaçar kaçar artıyo nerede bitiyor gibi kurallarla uğraşmıyorsun. foreach senin yerine bunu ayarlıyor.
            }

            int[] numbers = { 16, 28, 93, 84, 65, 56, 457, 28, 963, 1405, 1145 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            int[] numbers = { 16, 28, 93, 84, 65, 56, 457, 28, 963, 1405, 1145 };    // Busefer bu dizideki çift sayıları listeleyelim.

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }


            int[] numbers = { 16, 28, 93, 84, 65, 56, 457, 28, 963, 1405, 1145 }; // dizideki sayıların toplamını yazdırdık.

            int total = 0;
            foreach (int i in numbers)
            {
                total += i;              // total değerinin üzeri her defasnda İ den gelen veriyi ekle dedik. 
            }
            Console.WriteLine(total);


            List<int> numbers = new List<int>()  // Liste oluşturduk. < > bu işaretin arasına yazdığımız değişken türü yani listenin hangi türde ollacağını yadık.
                                                 // Listenin adı numbers 
            {
                1,2,3,4,5,6,8                    // Listenin elemanlarını bu şekildede tanımlaya bilirisn
            };

            foreach (int number in numbers)      // For each kullandık çünkü ekrana yazdırmak için 
            {
                Console.WriteLine(number);
            }


            string word = "MERHABA";           // Yazdığımız kelimeyi ekrana  harflerinne ayırarak yyazdırıyor 

            foreach (char c in word)          // kelimeyi char a göre parçala  c' ye ata ve alt alta yazdır ve yazdır 
            {
                Console.WriteLine(c);
            }



            #endregion

            #region KLAVYEDEN ÖĞRENCİ SAYISI ADI NOTLARINI ALIP ORTALMA HESAPLAYALIM

            Console.Write("*************** C# EĞİTİM KAMPI SINAV UYGULAMASI***************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // SINIFTAKİİ ÖĞRENCİ SAYISINI KULLANICIDAN ALMA
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");
            
            //ÖĞRENCİ İSİMLERİNİ VE ORTALAMALARINI SAKLAYACAK DİZİLER
            string[] studentNames = new string[studentCount];  // Burada öğrenci isimlerini studentCount dan alacaksın dedik.
            double[] studentExam = new double[studentCount];   // Bunuda student countdan alacak çünkü kaç öğrenci varsa ortalamayı ona göre hesaplıcak.

            for (int i = 0; i < studentCount; i++)            // i değeri 0 dan başlayıp student count kadar ilerleyerek tek tek i değeri artsın. 
            {
                Console.Write($"{i+1}. Öğrenci İsmini Giriniz:  ");  // burada i+1 '. değeri yazdırdık çünkü dizilerin indexi 0 dan başlıyor. kullanıcı 0. öğrenci adını girin görmesin ekranda.
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;           // TotalExam başlangıçta 0 olsun 


                //HER ÖĞRENCİ İÇİN 3 SINAV NOTU GİRİŞİ

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Notunu Girin: ");  // studentNames adlı dizinin İ'. değeri adlı öğrencinin j+1'. sınav notunu giriniiz. 
                                                                                                        // 
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;    // Notları topluyoruz
                }

                Console.WriteLine();
                studentExam[i] = totalExamResult / 3;    // Toplamı 3 e böldük ve ortalamasını bulduk.
            }

            // SINAV ORTALAMALARI
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması: {studentExam[i]} "); // studentNames i inci değeri adlı öğrecinin Ortalaması:: studentExam i inci değeri  oluyor.

                // ÖĞRENCİLERİN ORTALAMALARI VE GEÇİP KALMA DURUMLARI 

                if (studentExam[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti");
                }
                else 
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");




            #endregion


            Console.Read();
        }
    }
}
