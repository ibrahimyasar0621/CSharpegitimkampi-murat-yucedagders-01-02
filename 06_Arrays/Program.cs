using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TEMEL DİZİ ÖRNEKLERİ
            // mesela 2 4 6 8 10 bir dizi
            // krımızı sarı mavi yeşil
            // ankara istanbul samsun            
            // Diziler 0. elenadan başlar ilk eleman 0. sıfırıncı elemandır. 
            //DeğişkenTürü [ ] DiziAdı = new DeğişkenTürü [ElemeanSayısı]  
            string[] colors = new string[4];

            colors[0] = "Kırmızı";   //Burada colorsın 4. elemanını yazmıcam çünkü zaten toplam 4 elemandan oluşuyor. 4 elemanıdayazdık 
            colors[1] = "Sarı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";
            Console.WriteLine(colors[2]); // Colors dizisinin 2 numaralı indexinde var olan elemanı  yazdır

            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Lyon";
            cities[3] = "Kahire";
            cities[4] = "Üsküp";
            Console.WriteLine(cities[5]); // Burada hata verecek çalışmayacak çünkü senin dizinin içinde 5 numaralı index yok diyecek. 

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[5]);   // Burada sonuç 0 çıkacak çünkü dizide tanımlı olmayan bir indexdeki elemanıı çağırmaya çalıştık.
                                             // Dizilerde tanımlı olmayan elemanı çağırınca hata vermez. 0 Değerini verir. 

            string[] cities = { "prag", "roma", "ankara", "atina" }; // index sayısını yazıp sonra tek tek tanımlama yapmana gerek ok böyle yazıncada aynı şey oluyor.
            Console.WriteLine(cities[2]);
            #endregion

            #region DİZİDEKİ TÜM ELEMANLARI LİSTELEME
            string[] colors = { "sarı", "kırmızı", "mavi", "sarı", "turuncu", "pembe", "eflatun" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);  // colorsın i ince değerini yazdır dedik her değere tek tek uğrayıp hepsini ekrana yazdırdı alt alta.
            }

            int[] numbers = { 1, 20, 33, 41, 50, 645, 757, 863, 999, };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);   // Eğer numbers dizisindeki sayıların 3 e bölümünden kalan 0 ise o sayının değerini ekrana yazdır.
                                                     // Çıktı = 33 645 999  ekrana bunu yazdıracak alt alta
                }
            }

            char[] symbols = { 'a', 'b', 'c', '*', '/', '-', '+', }; //DİZİLER CHAR DEĞİŞKEN İLE DE ATNIMLANIR TEK TIRINAK KULANMAK LAZIM.
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }


            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100, };
            int maxNumber = myArray[0];                         // Başta dizinin 0 . indexini en büyük değer gibi kabul ettim.
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)  // eğer myarray İ'. değeri maxNumberden büyükse 
                {
                    maxNumber = myArray[i];  // değişkene arrayın i. değerini ata.
                }
            }
            Console.WriteLine(maxNumber);   // ekrana 789 yazdıracak 


            string[] persons = { "ali", "veli", "ahmet", "mehmet", "mahmut", };
            Console.WriteLine(persons.Length);   // dizinin uzunnluğunu verdi . Çıktı= 4

            int[] numbers = { 18, 72, 31, 91, 53, 65, 84, 83, };
            Array.Sort(numbers);                                  // Dizieki sayıları küçükten büyüğe sıraladı.
            for (int i = 0; i < numbers.Length; i++)              //
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers = { 18, 72, 31, 91, 53, 65, 84, 83, };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)    // Buda komple diziyi tersten sıralıyor. 
            {
                Console.WriteLine(numbers[i]);
            }



            #endregion

            #region DİZİ METODLARI
            string[] customers = { "ali", "merve", "çınar", "buse", "mahmut", "demet", };
            int index = Array.IndexOf(customers, "merve");
            Console.WriteLine(index);   // merve kaçıncı indexte ise onu ekrana yazdırıyor. ÇIKTI =  1 

            int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36, };
            Console.WriteLine("Dizinin en büyük elemeanı: " + numbers.Max() + "Dizinin en küçük elemanı: " + numbers.Min());  //Dizinin max ve min değerini yazdırdık.

            #endregion

            #region KULLANICIDAN DEĞER ALMA
            string[] cities = new string[5];
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    Console.Write($"LÜTFEN {i + 1}. Şehri Giriniz: ");  // $ dolar işareti süslü paranteziçinde çift tırnak yada tek tırnak kullanmadan drekt yazmak için kullandık.
                                                                        // i + 1  yazma sebebimiz diziler normalde 0. sııfırıncı elemandan başlıyor. bir +1 yazıp 1. eleman  olduğunu anlamak için yazdık
                                                                        // kullanıcıya 1. şehri girin 2. şehrin giriniz demek için. yoksa 0. şehri girin derdi programm.
                    cities[i] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < cities.Length; i++)                                      // elle yazdığımız bütün şehirleri en son ekrana hepsini alt alta yazdırdı. hangi şehirleri yazdıysak.
            {
                Console.WriteLine(cities[i]);
            }


            #endregion

            #region TAMSAYI DİZİSİNDEKİ ELEMANLARIN TOPLAMINI EKRANA YADIRALIM

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)   // numbers dizisindeki eemanları tek tek gezerekk topladı ve ekrana yazdırdı.
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);      //ÇIKTI = 150 
            #endregion

            #region DİZİDEKİ TEK VE ÇİFT SAYILARI AYRI AYRI LİSTELEYELİM

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 }; 
            Console.WriteLine("Çift Sayılar: ");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)   // Eğer numbers İ'. elmanının 2 ye bölümünden kalan 0 ise bunu yazdır
                {
                    Console.WriteLine(numbers[i]);
                } 
            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("TEksayılar: ");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)    // Eğer numbers İ'. elmanının 2 ye bölümünden kalan 1 ise bunu yazdır.
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
