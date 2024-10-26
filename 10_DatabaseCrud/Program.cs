using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud-->  4 temel veri tabanı işlemi olarak geçiyor . CREATE --- Read -- Update -- Delete

            

            Console.WriteLine("**********Menü Sipariş İşlem Paneli**********");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------");
            #region KATEGORİ EKLEME
            Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            // Biz yenibir kategori ismi eklemek istiyoruz. Bunu C# üzerinden ekleyeceğiz. SQL üzerinden de eklenebiliir ama biz buradan ekleyeceğiz.

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-C4VKPFC;initial catalog=EgitimKampiDB;integrated security=true");
            // Data source SQL içindeki connect kısmındaki SERVER NAME
            // İnitial catalog bizim veri tabanımızın ismini tutuyordu. 
            // Harf kaçırmamaya çıalış dikkat et!!!!!!
            // bağlantımızı oluşturduk böylece. 

            connection.Open();  // Bağlantımızı açtık. Daha sonra bir veri eklemek için sorgu açıyoruz. 
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)", connection);  // Sorgu açtık sqlcommand ile. İnsert into --> sqlde içine ekleme için yazıln komut.
                                                                                                                    // Vlaues @p1--> sen bu değerleri parametre 1'den al dedik.
                                                                                                                    // connetion ile bu veri tabanının neredeki bağlantı ile ilişkilendiriliyor onu yazdık. Yani connectiondaki 25. satırdaki bağlantı ile ilişkilendirdik.
            command.Parameters.AddWithValue("@p1", categoryName);   // Ben sana @p1 diye bir şey yolaldım bu 32. satırdaki @p1 olacak. @ sembolü SQL de değişken tanımlamada kullanılan bir sembol. 
            command.ExecuteNonQuery();   // executery --> Koşulsuz herhhangi bir istisma olmadan. şekilde sorguyu çalıştır diyoruz. 
            connection.Close();

            Console.Write("Ktegori Bşarıyla Eklendi.");   // SQL açıp bakıyorsun sağ tuş excecuteSQL diyoruz ve kahvaltı eklenmiş oluyor. 
            #endregion

            #region ÜRÜN EKLEME İŞLEMİ
            string productName;             // string ver itipinde ürün adı değişkkeni
            decimal producPrice;        // decimal ondalıklı değişken türünde fiyat ekledik.
            //bool pruductStatus;             // bool türünde true false çalıştıran productstatus tanımladık.

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            producPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-C4VKPFC;initial catalog=EgitimKampiDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct(productName,ProductPrice,ProductStatus) values(@productName,@productPrice,@productStatus)", connection); // (@p1,@p2,@p3) şeklindede yazabilirdik. 
            // BU KEZ BİRDEN FAZLA PARAMETREMİZ VAR BUNU TANIMLAMAMIZ GEREKİYOR.
            command.Parameters.AddWithValue("productName", productName);
            command.Parameters.AddWithValue("productPrice", producPrice);
            command.Parameters.AddWithValue("productStatus", true);
            command.ExecuteNonQuery();  // Değişikleri kaydet ve veritabanına yansıt anlamına genelen bu kodu yazdık.
            connection.Close();
            Console.Write("ÜRÜN EKLEMESİ BAŞARILI:");  // Yazdığımız ürünler Et Döner VE Makarna SQL tablomuza eklendi.
            #endregion

            #region ÜRÜN LİSTELEME İŞLEMİ
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-C4VKPFC;initial catalog=EgitimKampiDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblProduct", connection); // Sonuna yine bağlantımla ilişkilendirdim.
            SqlDataAdapter adapter = new SqlDataAdapter(command);           // SQL den  veri çekerken köprü görevi gören komutumuz sqldataadapter. sql den verileri C# a çekecek köprü görevi görüyor.
            DataTable dataTable = new DataTable(); // Memory RAM  hafızada bir data table (bir alan)tutmaya yarıyor.
            adapter.Fill(dataTable); // İçini dolduruyoruz. adapter table den gelen değerle.

            foreach (DataRow row in dataTable.Rows)  // Burada taobolnun satırına komple girdik. Birde satırın sütünlarına tek tek girmemiz lazım aynı satırın sütünlarına. yeni bir foreach yzacaksın.
            {
                foreach (var item in row.ItemArray)  // İlgili satırın sürtünlarına gittik.
                {
                    Console.Write(item.ToString() + " "); // item ı string olarak yazdırdık.
                }
                Console.WriteLine(); // boşluk bıraktık.
            }

            connection.Close();

            #endregion

            #region ÜRÜN SİLME İŞLEMİ 
            Console.Write("Silinecek Ürün İD: ");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-C4VKPFC;initial catalog=EgitimKampiDB;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Delete  From TblProduct Where ProductId=@ProductId", connection); // Sonuna yine bağlantımla ilişkilendirdim.
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();   // değişiklikleri veritabanından yansıttık.

            connection.Close();
            Console.WriteLine("SİLME İŞLEMİ YAPILDI.");

            #endregion

            #region GÜNCELLEME İŞLEMİ

            Console.Write("Güncellenecek Ürün İD: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-C4VKPFC;initial catalog=EgitimKampiDB;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set  ProductName=@ProductName,ProductPrice=@ProductPrice Where ProductId=@ProductId", connection); // Sonuna yine bağlantımla ilişkilendirdim 
                                                                                                                      // where ile şartı yazmalısın yoksa bütün tabloyu günceller. 
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();   // değişiklikleri veritabanından yansıttık.

            connection.Close();
            Console.WriteLine("GÜNCELLEME İŞLEMİ YAPILDI.");


            #endregion

            Console.Read();
        }
    }
}
