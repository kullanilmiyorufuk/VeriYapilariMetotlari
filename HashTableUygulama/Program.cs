using System;
using System.Collections;

namespace HashTableUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Başlık giriniz:");
            string baslik = Console.ReadLine();

            baslik = baslik.ToLower();

            var karakterseti = new Hashtable()

            {
                { 'ç','c'},
                { 'ı','i'},
                { 'ö','o'},
                { 'ü','u'},
                { ' ','-'},
                { '\'','-'},
                { 'ğ','g'},
                { '.','-'},

            };

            foreach (DictionaryEntry item in karakterseti )
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            Console.WriteLine(baslik);
            Console.ReadKey();

        }
    }
}
