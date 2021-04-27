using System;
using System.Collections;

namespace SortedListTemelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList()
            {
                {1,"Bir"},{2,"iki"},{3,"üç"},{8,"sekiz"},{5,"beş"},{6,"altı"}
            };


            list.Add(4, "dört");
            list.Add(7, "yedi");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - { item.Value}");
            }
            Console.WriteLine("Listedeki Eleman sayisi {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin kapasitesi {0}", list.Capacity);

            //Spesific Erişim.  /KEY/
            Console.WriteLine(list[4]);

            //index
            Console.WriteLine(list.GetByIndex(0));
            //Get- >Key
            Console.WriteLine(list.GetKey(0));
            //Liste sonundaki elemanın değeri
            Console.WriteLine(list.GetByIndex(list.Count-1));

            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar:");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - { item.Value}");
            }
            Console.ReadKey();

        }
    }
}
