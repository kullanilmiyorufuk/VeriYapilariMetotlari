using System;
using System.Collections;

namespace HashTableTemelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama
            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazıg");

            //Dolaşma
            foreach (DictionaryEntry yazdirlen in sehirler)
            {
                Console.WriteLine($"{yazdirlen.Key} - {yazdirlen.Value}");

            }
            //Anahtarı alma

            var anahtar = sehirler.Keys;
            foreach (var yazdirlen in anahtar)
            {
                Console.WriteLine(yazdirlen);
            }

            //Degerler

            //Var yerine ICollection yazabiliriz biliyoruz ne oldugunu
            var degerler = sehirler.Values;

            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            //Elemana Erişme.
            Console.WriteLine("\n Elemana Erişme.");
            Console.WriteLine(sehirler[55]);

            //Eleman silme!

            Console.WriteLine("Eleman Silme! Elazigi silelim 23 keyli!");
            sehirler.Remove(23);
            foreach (var item in degerler)
            {
               
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

