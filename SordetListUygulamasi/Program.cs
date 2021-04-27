using System;
using System.Collections;

namespace SordetListUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Değişkenler");
            kitapIcerigi.Add(40, "Oparatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "İlişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($" {item.Value,30} {item.Key,25} ");
            }
            Console.ReadKey();
        }
    }
}
