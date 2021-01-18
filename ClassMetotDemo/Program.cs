using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri = new Musteri
            {
                FirstName = "Ömer",
                LastName = "Yıldırım",
                Age = 25,
                City = "Van",
                AccountNumber = 12114546

            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri);
            Console.WriteLine();
            musteriManager.List(musteri);
            Console.WriteLine();
            musteriManager.Delete(musteri);

        }
    }
}
