using System;
using System.Collections.Generic;

namespace SortedSetUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedSet Küme işlemleri
            var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var B = new SortedSet<int>() { 1, 2, 5, 6 };
            Console.WriteLine();
            Console.WriteLine("A kümesi"); ;

            #region yazdirma
            foreach (var s in A)
            {
                Console.WriteLine($"{s,5}");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("B kümesi"); ;

            foreach (var s in B)
            {
                Console.WriteLine($"{s,5}");
            }

            #endregion
            //Union
            A.UnionWith(B);

            Console.WriteLine("A ve B kümesi Birleşimi");
            foreach (int s in A)
            {
                Console.WriteLine($"{s,5}");
            }


            Console.WriteLine("Sadece A'da olan elemanlar");
            A.ExceptWith(B);
    
            foreach (var s in A)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Kesişim Dışındaki Elemanlar");
            A.SymmetricExceptWith(B);
            foreach (var item in A)
            {
                Console.WriteLine($"{item,-5}");
            }



            Console.ReadKey();

        }
       
        


        private static void SortedSetUygulamasi2()
        {
            var sayilar = new List<int>();
            var rnd = new Random();
            Console.WriteLine();

            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(rnd.Next(5, 15));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            //Listedeki benzersiz elemanları bumak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);
            Console.WriteLine("\nBenzersiz sayilarin Listesi\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.WriteLine($"{sayi,-3}");
            }
            Console.WriteLine("\nBenzersiz {0} sayi var.", benzersizSayiListesi.Count);

            Console.ReadKey();
        }

        private static void SortedSetUygulamasi()
        {
            //Tanımlama
            var list = new SortedSet<string>();

            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi.");
            }

            else
            {
                Console.WriteLine("Ekleme Başarısız.");
            }
            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme Başarısız.");

            list.Add("Şule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            list.Remove("Şule");
            list.RemoveWhere(deger => deger.StartsWith("F"));

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Eleman Sayisi : {0} ", list.Count);

            Console.ReadKey();
        }
    }
}
