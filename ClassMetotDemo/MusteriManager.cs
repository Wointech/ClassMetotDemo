using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine($"{musteri.FirstName} {musteri.LastName} bankaya eklenmiştir");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine($"{musteri.FirstName} {musteri.LastName} bankadan silinmiştir");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine($"ADI: {musteri.FirstName}\nSOYADI: {musteri.LastName}\nYAŞ: {musteri.Age}\nDOĞUM YERİ: {musteri.City}\nTC NO: {musteri.AccountNumber}");
        }


    }
}
