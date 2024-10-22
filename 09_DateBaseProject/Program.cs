using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADO.net   SQL Server Management Studio da taplo yaptık. sorgu yaptık onu burada çağıracağız

            Console.WriteLine("******C# Ürün - Ktegori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek istediğiniz tablo numarasını girin: ");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------");

            // Bizim önce SQL Bağlantısına ihtiyacımız var. 

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-C4VKPFC;initial Catalog=EgitimKampiDB;integrated security=true");    // Sınıflara erişim sağlamak için bir nesne örneği türetmen lazım. Nesne örneği türetme işlemini bununla yaptık.
            // (   Veri Tabanı sunucu adresimiz ; Veri Tabanı ismi  ; güvenlik   )
                                                             // İlk yazdımız SQL connection bir sınıf. 
                                                             // connection bir nesne.
                                                             // Bu satırın altındakilerde properties-nitelik. 
            connection.Open();        //connection ile oluşturduğumuz bağlantıyı açtık.Bağlantımı açtım.
            SqlCommand command = new SqlCommand("select * From TblCategory" , connection);  // Command isminde nesne örnekliyoruz. tblcategory tablomuz hangi veri tabanında olduğunu bildirmek için connection verdik yanına.
            SqlDataAdapter adapter = new SqlDataAdapter(command);                     // C# ile SQL arasındna köprü görevi görecek sınıf. // Adapter adında nesne örneği oluşturduk buda command ile çalışacak.
            DataTable dataTable = new DataTable();   // Data table verilerimi geçici RAM belleğe almamı sağlıcak. 
            adapter.Fill(dataTable);     // sorguyu RAM bellekte göstermek amacıyla yaptım. 

            connection.Close();   // Bağlantıyı kapattık.

            foreach (DataRow row in dataTable.Rows)   // data row data tableden gelen bir sınıf türü 
            {
               foreach (var item in row.ItemArray)    // row dan gelen dizinin itemini yani içeriğini okuyacak.
                {
                    Console.WriteLine(item.ToString());
                }
               Console.WriteLine();
            }

            Console.Read();
        }
    }
}
