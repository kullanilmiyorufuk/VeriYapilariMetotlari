using System;
using System.Collections.Generic;

namespace QueueUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };


            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();


            foreach (char items in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{items,-5} kuyruğa eklensinmi ? [e/h] ");
                secim =   Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(items);
                    Console.WriteLine($"\n {items,-5} Kuyruğa eklendi");
                    Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.Write("Kuyruktan elemanların kaldırılması için ESC tuşuna basınız. ");
            secim = Console.ReadKey();
            Console.WriteLine();

            if (secim.Key==ConsoleKey.Escape)
            {
               
            


            while (kuyruk.Count>0)
            {
                Console.WriteLine();
                Console.WriteLine($"{kuyruk.Peek()} kuyruktan çıkartılıyor.");
                Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı");
                Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
            }
            Console.WriteLine("\n Kuyruktan Çıkarma işlemi tamamlandı.");
            Console.ReadKey();
            }

        }

        private static void KuyrukTemelleriOrnek()
        {
            // Queue Tanımlama (ilk giren ilk çıkar)

            var karakterKuyrugu = new Queue<char>();

            //Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman Sayisi : {karakterKuyrugu.Count}");

            //Diziye atama
            var dizi = karakterKuyrugu.ToArray();

            //Çıkarma
            Console.WriteLine($"Kuyrugun Başındaki eleman : {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} Kuyruktan çıkartıldı! ");
            Console.WriteLine($"Eleman Sayisi : {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyrugun Başındaki eleman : {karakterKuyrugu.Peek()}");



            Console.ReadKey();
        }
    }
}
