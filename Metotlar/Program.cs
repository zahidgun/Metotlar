using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.Id = 5221564;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Id = 5221565;

           // Product[] products = new Product[] {product1, product2 };
           // foreach (Product product in products)
           // {
               // Console.WriteLine(product.Adi);
               // Console.WriteLine(product.Fiyati);
               // Console.WriteLine(product.Aciklama);
               // Console.WriteLine(product.Id);
               // Console.WriteLine("-------------------");
           // }

            Console.WriteLine("---------------METOTLAR-----------------");

            //instance - örnek
            //encapsulation

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(product2);
            sepetMenager.Ekle(product1);




        }
    }
}




// Metotar tekrar tekrar kulnılan kod satırları için kulanılır.
// Dont repeat yourself - DRY
// Clean Code = Temiz kod
// Best Practice = Doğru uygulama teknikleri.
// Type-safe = Veri güvenliği.