using Microsoft.EntityFrameworkCore;
using Proje_2.Models;


#region LoginKontrol
//using (var dbContext = new NORTHWNDContext())
//{
//    Console.WriteLine("..............Kullanıcı Giriş Ekranı...............");
//    Console.WriteLine("Kullanıcı Adınız (Ad.Soyad): ");
//    string ad = Convert.ToString(Console.ReadLine());
//    Console.WriteLine("Şifre(SoyadDoğumtarihi): ");
//    string sad = Convert.ToString(Console.ReadLine());
//    var result = from e in dbContext.Employees
//                 group e by new { e.FirstName, e.LastName, e.BirthDate }
//                 into g
//                 select new
//                 {
//                     Ad = g.Key.FirstName + "." + g.Key.LastName,
//                     Sifre = g.Key.LastName + g.Key.BirthDate
//                 };

//    foreach (var group in result)
//    {

//        if (group.Ad == ad)
//        {
//            //Console.WriteLine(group);
//            Console.WriteLine("Kullanıcı Adı: " + group.Ad + " --- " + "Şifre: " + group.Sifre);
//        }

//    }
//    Console.WriteLine("------Giriş Başarılı------");
//}
#endregion

#region Adres / Tel Güncelleme
//using (var dbContext = new NORTHWNDContext())
//{
//    Employee employee = await dbContext.Employees.FirstOrDefaultAsync(e => e.FirstName == "Andrew");

//    Console.WriteLine("..............Çalışan Bilgi Güncelleme  Ekranı...............");
//    Console.WriteLine("Çalışan Adı:{0} - Soyadı:{1} - Lütfen Adres Ve Telefon Bilgilerinizi Güncelleyiniz", employee.FirstName, employee.LastName);
//    //Console.WriteLine("Çalışan Adı: " + employee.FirstName + "Lütfen Adres Ve Telefon Bilgilerinizi Güncelleyiniz");
//    Console.WriteLine("Mevcut Adres Bilgisi: {0}", employee.Address);
//    Console.WriteLine("Mevcut Telefon Bilgisi: {0}", employee.HomePhone);
//    Console.WriteLine("Yeni Adres: ");
//    string adres = Convert.ToString(Console.ReadLine());
//    Console.WriteLine("Yeni Telefon No: ");
//    string tel = Convert.ToString(Console.ReadLine());

//    employee.Address = adres;
//    employee.HomePhone = tel;
//    await dbContext.SaveChangesAsync();

//    Console.WriteLine("--Yeni Bilgiler--");
//    Console.WriteLine("Adres Bilgisi: {0}", employee.Address);
//    Console.WriteLine("Telefon Bilgisi: {0}", employee.HomePhone);
//    Console.WriteLine("Kaydınız Yenilenmiştir");
//}
#endregion

#region Ürün Bilgileri
//using (var dbContext = new NORTHWNDContext())
//{
//    var query = from p in dbContext.Products
//                select new Product
//                {
//                    ProductId = p.ProductId,
//                    ProductName = p.ProductName,
//                    UnitPrice = p.UnitPrice,
//                    UnitsInStock = p.UnitsInStock,
//                };
//    Console.WriteLine("-------Ürün Bilgileri------------");
//    Console.WriteLine("ID   Name                                      Price         Stock");
//    foreach (var item in query)
//    {

//        Console.WriteLine($"{item.ProductId,-5}" +
//                $"{item.ProductName,-40}" +
//                $" {item.UnitPrice,-15}" +
//                $"{item.UnitsInStock,-15}"
//            );

//    }
//}
#endregion

#region Çalışan Satış Adedi
using (var dbContext = new NORTHWNDContext())
//{
//    var result = dbContext.Employees.Include("Orders").OrderBy(e => e.FirstName);
//    foreach (var employee in result)
//    {

//        Console.WriteLine("Çalışan Ad: {0} - Satış Adedi: {1}", employee.FirstName, employee.Orders.Count);
//    }
//}
#endregion

#region Çalışanların hangi müşteriye hangi ürünü kaçparaya ve kaç adet olarak sattığı listesi
//using (var dbContext = new NORTHWNDContext())
//{
//    var result = from e in dbContext.Employees

//                 join o in dbContext.Orders
//                 on e.EmployeeId equals o.EmployeeId
//                 join od in dbContext.OrderDetails
//                 on o.OrderId equals od.OrderId
//                 //where(e.FirstName=="Andrew")  //sadece andrew için           
//
//                select new { e.FirstName, o.EmployeeId, o.OrderId, o.CustomerId, od.UnitPrice, od.Quantity };
//    Console.WriteLine("ÇalışanAdı--  ÇalışanID--     SiparişID--     Müşteri--      BirimFiyat--   Adet--     ToplamTutar--");
//    foreach (var item in result)
//    {
//        Console.WriteLine($"{item.FirstName,-15}" +
//                $"{item.EmployeeId,-15}" +
//                $" {item.OrderId,-15}" +
//                $" {item.CustomerId,-15}" +
//                $"{item.UnitPrice,-15}" +
//                $"{item.Quantity,-15}" +
//                $"{item.UnitPrice * item.Quantity}"
//            );

//    }

//}
#endregion
Console.ReadKey();
