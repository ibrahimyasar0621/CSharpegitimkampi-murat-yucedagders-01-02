using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜSÜ

            // Döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21    programlama her defasında toplayı sonraki sayıyı üzerine ekleyip tekrar toplar.Mantığı böyle çalışır.
            // Mesela bazı yerlerde ekrana 10 defa bir ifadeyi yazdırman gerekebilir. 10Defa console.writeline yazdırmak sonuca ulaştırır ama uzun sürer.
            // Sonuca ulaşmak yeterli değil. Nasıl ulaştığında önemli. uzunve programı gereksiz yoracak şekilde gitmek MANTIKSIZ!!!
            // Senden sonraki gelecek olan mühendisin rahat okumasını sağmalalısın. Yoksa arakndan söver. 
            // ********* TEMİZ KOD YAZ ! **********

            // For(x;y;z)
            // x : Başlangıç değerini tutar.
            // y : Bitiş
            // z : Artış - Azalış
            //int i;   

            for (i = 1; i <= 5; i++)     //iki defa tab tuşuna basınca geliyor. // 1 den başladı değer vermeye 1 arrtırdı 2 oldu 5 ten küçükmü küçük ozman true oldu ekrana yazdırdı. en son 5 kere yazdırdı ve bitti. taa ki false olanakadar yazdırdı. 5 yazınca 1 arttır 6 oldu 5e eşit ada küçük mü ? değil false verdi ve program bitti. 
            {
                Console.WriteLine("Csharp Eğitim Kampi");

            }
            for (int i = 0; i <= 20; i++)   // 1 den 20 ye kadar olan sayıları alt alt yazdırdı. 
            {
                Console.WriteLine(i);
            }

            for (int i = 3; i <= 50; i += 3)   // 0 ile 50 arasında 3e ta bölünen sayıları getiriyor. i busefer 3ten başlayıp 3er 3er arttırdı.
            {
                Console.WriteLine(i);
            }

            Console.Write("Lütfen ekrana yazılmasını istediğiniz adeti giriniz: ");
            int finishValue = int.Parse(Console.ReadLine());      //finishValue diye bir değğişken oluşturduk.
            for (int i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın cumhuriyet");    //burada yaşasın cumhuriyet yazısınıı bizim verdiğimiz değer kadar yazdıracak.
            }



            #endregion

            #region FOR DÖNGÜSÜ İLE KARAR YAPILARI

            // Mesela 1 ile 100 arasındaki 5 ile tam bölünenleri yazdıralım.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)      // Yukarıda 1den başlayarak deniyor 1 yazdık aşşağı indik if(eğer) 1 bölü 5 0 a eşitmi değil. tekrak devam edecek denemeye. 5 bölü5 0 a eşitmi eşit ozaman o i değerini  alt alta yazır.
                {
                    Console.WriteLine(i);
                }

            }

            //ARDIŞIK SAYILARI TOPLAYALIM 1 İLE 10 ARASINDAKİ
            int totalValue = 0;
            for (int i = 1; i <= 10; i++)  //total value başlangıç değeri 0 .       İ'nin başlangıç değeri 1 .       0++1 den totalValuenin değeri 1 oldu. 
            {                             //total value yeni değeri  1 oldu. İ' yi 1 arttır İ'nin yeni değeri kaç oldu 2 oldu 2<=10 mu ? evet.      1+2 den totalValuenin değeri 3 oldu. 
                totalValue += i;          //total value yeni değeri  3 oldu. İ' yi 1 arttır İ'nin yeni değeri kaç oldu 3 oldu 2<=10 mu ? evet.      3+3 ten totalValuenin değeri 6 oldu.
            }
            Console.WriteLine(totalValue); //böylece 1 den 10a kadar olan sayıları toppladı toplam 55 verdi bize

            //1-20 ARASINDAKİ ÇİFT SAYILARI YAZIP SONRADA BUNLARIN TOPLAMINI YAAZSIN.
            int totalValue = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)  // Eğeri İ'nin 2 ye bölümünden kalan 0 ise ekrana yazdır. ÇIKTI: 2,4,6,8,10,12,14,16,18
                {
                    totalValue += i;  // totalVloenin üzerine İ'yi ekle. Yani Yukarıdaki çıkktıdaki değerleri toplayıp TOPLAMI ekrana yazdırıyor.
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(totalValue);                 //toplam değer olan totalValue yi değerini ekrana yazdırdı.


            //1 İLE 50 ARASINDA 7 YE TAM BÖLÜNEN KAÇ SAYI VAR BULALIM.

            int count = 0;  // ilk değeri 0 olan bir count değeri tanımladım.

            for (int i = 1; i <= 50; i++)
                if (i % 7 == 0)     //sırayla denedi 7 ye kadar 7 sayısı 7ye tam bölündü caont değeri 1 oldu. sonra 14e kadar denedi count değerini 1 arttırdı 2 oldu
                {                       // böyle böyle deneyerek bize  kaçtane 7 ye bölünen sayı var verdi. 
                    count++;            // Her defasında her 7 ye tam bbölünen sayıda count değerini 1 arttırdı.
                }
            Console.WriteLine(count);

            // Bir bakteri her saatin sonunda kendini 2 ye katlayarak sayısını arttırıyor.
            //1 - 2 - 4 - 8 - 16 - 32 - 64 - 128......diye gidiyor.
            //24 saatin sonunda bu ortamda kaç bakteri var.PROGRAMI YAZINIZ. C# EĞİTİM KİTABINDAN ÖRNEK

            int bacterium = 1;
            for (int i = 1; i <= 24; i++)  // Buradaki İ değeri bizim aslında saat değerimizi tutacak. 
            {
                bacterium *= 2;  // burada bakteri sayısını 2 ile çarparak ilerlicem. 
                Console.WriteLine(i + ".Saat Sonunda Oluşan Bakteri Sayısı" + bacterium); // burada her i değeri yani her saatin soınunda kaç bakteri oluşuyor yazdırıyoruz.
            }
            #endregion

            #region WHİLE DÖNGÜSÜ
            //Şartlkar sağlandıkça çalışıyor
            //While(şart)
            //{
            //işlemler
            //}                // yazım şekli bu.

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("MERHABA DÖNGÜLER"); // 10 Defa merhaba döngüler yazmış oldu.
                i++;
            }

            int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {

                    Console.WriteLine(i);
                }
                i++;
            }

            //1 İLE 10 ARASINDAKİ SAYILARIN TOPLAMINI YAZDIRALIM.
            int i = 1;
            int sum = 0;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);



            #endregion

            #region ÖRNEK SINAV SORUSU

            //KLAVYEDEN GİRİLEN 3 BASAMAKLI SAYININ BASAMAKLARI TOPLAMINI VEREN PROGRAMI YAZIN.
            // 456 4+5+6 =15 GİBİ
            Console.Write("Sayıyı Girin: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundred;  // Burada birler onalr yüzler diye basamak değerlerini temsil eden değişkenler tanımladım.
            int sum; // TOPLAM değerimizi tutacak.

            ones = number % 10; // sayının birler basamağını bulmak için 10 a bölümünden kalan sayı aslında birler  basamağıdır. 456/10 kalan 6 birler basamağını yakaladık.
            hundred = number / 100;   // mesela 456 sayısını 100e bölersek 4.56 gelir . ama . int (integer değişkeni) kullandığımız için tamsayı yani 4 sayısını alır.
            tens = (number % 100) / 10; //burada 456 sayısının 100 e bölümünden kalan 56. ama . bana 56 sayısının sadece 5 rakamı lazım içinden 5'i yani 10 lar basamağını versin istiyorum. o yüzden 100e bölümünden kalanı 10 a böldüm.
            Console.WriteLine(ones + "-" + tens +"-" + hundred + "-");  //ÇIKTI=6-5-4 olacak. birler onlar yüzler basamağı.
            sum = ones + tens + hundred;  // bütün basamakları topladım
            Console.WriteLine(sum);       // toplamı ekrana yazdırdım. çıktı:15
            
            #endregion
            Console.Read();
        }
    }
}
