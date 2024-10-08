using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ALT ALTA 10 TANE YILDIZ OLUŞTURMA 

            //YILDIIZLARLA ŞEKİL ÇİZDİRME 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");   //Alt alta 10 tane yıldız yazmış oldu
            //}
            #endregion

            #region HER SATIRDA 10 AR TANE YAN YANA VE ALT ALTA YILDIZ.
            ////YILDIIZLARLA ŞEKİL ÇİZDİRME 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*********");   //Alt alta 10 tane yıldız yazmış oldu. her satırda 10 yıldz olan 10 satırda 10ar tane yıldzılı ekrana yazdırdı.
            //}
            #endregion

            #region DİK ÜÇGEN 
            ////1.SATIRDA 1 2.SATIRDA2 3.SATIRDA3 5. SATIRDA 5 TANE YILDIZ OLACAK.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++) // İ'nin ilk değeri 1 . aşağı geldi j değerini i ye kadar yazdırdı.ilk satırda 1 yıldız oldu.
            //    {                            // İ'nin yeni değeri 2 aşşağı indi. j değerini 2 ye kadar yazdı yyani 2 tane yıldız yazdı bunu taa 5 satısına kadar yaptı. 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region TERS DİK ÜÇGEN
            //1.SATIRDA 5         2.SATIRDA 4       3.SATIRDA3    5. SATIRDA 1 TANE YILDIZ OLACAK.
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++) // İ'nin ilk değeri 5 . aşağı geldi j değerini i=5 e kadar yazdırdı.ilk satırda 5 yıldız oldu.
            //    {                            // İ'nin yeni değeri 4 aşşağı indi. j değerini 4 ye kadar yazdı yyani 4 tane yıldız yazdı bunu taa 5 satısına kadar yaptı. 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region DİK VE TERS DİK ÜÇGEN ALT ALTA
            //                                  //1.SATIRDA 1         2.SATIRDA 2       3.SATIRDA3    5. SATIRDA 5 TANE YILDIZ OLACAK.
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++) // İ'nin ilk değeri 1 . aşağı geldi j değerini i e kadar yazdırdı.ilk satırda 5 yıldız oldu.
            //    {                            // İ'nin yeni değeri 2 aşşağı indi. j değerini 2 ye kadar yazdı yyani 4 tane yıldız yazdı bunu taa 5 satısına kadar yaptı. 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //                                  //1.SATIRDA 4         2.SATIRDA 3       3.SATIRDA2    4. SATIRDA 1 TANE YILDIZ OLACAK.
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++) // K'nin ilk değeri 4 . aşağı geldi m değerini i e kadar yazdırdı.ilk satırda 4 yıldız oldu.
            //    {                            // K'nin yeni değeri 3 aşşağı indi. m değerini 3 ye kadar yazdı yyani 3 tane yıldız yazdı bunu taa 4. satıra kadar yaptı. 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region BAKLAVA DİLİMİ
            //// ÜST KISIM 

            //int n = 5;   // BAKLAMANIN KAÇ SATIRDAN OLUŞACAĞINI BİLDİRMEK İÇİN N ADINDA BİR DEĞİŞKEN TANIMLADIK 

            //for (int i = 1; i <= n; i++)     //İ=1 DEN BAŞAYIP İ DEĞERİ TEK TEK ARTTI
            //{
            //    for (int j = n-1; j>0; j--) //BUADA J DEĞERİ 4 TEN BAŞLAYIP TEKER TEKER AZALACAK 
            //    {                             
            //        Console.Write(" ");     // BUNUN YAPTIĞI ŞEY SOL TARAFTAN BOŞLUK BIRAKMAK 4 BOOŞLUK BIIRAKTI
            //    }

            //    for (int k = 1; k <= 2*i-1; k++) //BURADA İSE K DEĞİŞKENİ İLE KAÇ ADET YILDIZ YAZACAĞINI BELİRLERDİK. BURADA 1 3 5 7 9 DİYE GİDİYOR YILDIZ SAYISI. FORMUL BUNU DİYOR
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //// ALT KISIM
            //for (int i = n-1; i >= 1; i--)  //N-1 DEN BAŞLATTIK ÇÜNKÜ İKİ TANE AYNI SAYIDA YILDIZ YAZMASIN TAM DÜZGÜN BİR KKÖŞE OLUŞSUN DİYE.
            //{
            //    for (int j = n - 1; j > 0; j--) 
            //    {
            //        Console.Write(" ");   
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++) //YUKARIDAKİ ŞLEMİN TERSİNİ AZALARAK YAZDI.
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region PİRAMİT 
            // ÜST KISIM 

            //int n = 5;   

            //for (int i = 1; i <= n; i++)     
            //{
            //    for (int j = n-i; j>0; j--)  //J DEĞİŞKENİM N-İ DEN BAŞŞLIYOR. İ BAŞTA 5 . N DEĞERİ BAŞTA 1. SOLDAN 4 KARAKTER BOŞLUK BIRAKTI. 
            //    {                             
            //        Console.Write(" ");   
            //    }

            //    for (int k = 1; k <= 2*i-1; k++) //K 1 DEN BAŞLADI İ NİN DEĞERİ 1. 2*2-1=1 YANİ BİR YILDIZ KOYDU. SONRA BAŞA DÖNÜP TEKRAK İ DEĞERİ BU SEFER 2 OLARAK BAŞLAYIP 3 BOŞLUK BIRAKIP DEVAM EDECEK
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  TERS PİRAMİT 
            // ÜST KISIM 

            int n = 5;

            for (int i = 5; i >= 1; i--)
            {
                //BOŞLUKLAR
                for (int j = n - i; j > 0; j--)  //J DEĞİŞKENİM N-İ DEN BAŞŞLIYOR. İ BAŞTA 5 . N DEĞERİ BAŞTA 5. SOLDAN  BOŞLUK BIRAKMADI.
                {
                    Console.Write(" ");
                }

                // YILDIZLAR
                for (int k = 1; k <= 2 * i - 1; k++) //K 1 DEN BAŞLADI İ NİN DEĞERİ 1. 2*2-1=1 YANİ BİR YILDIZ KOYDU. SONRA BAŞA DÖNÜP TEKRAK İ DEĞERİ BU SEFER 2 OLARAK BAŞLAYIP 3 BOŞLUK BIRAKIP DEVAM EDECEK
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
