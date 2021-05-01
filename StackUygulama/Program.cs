using System;
using System.Collections.Generic;

namespace StackUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen bir sayi giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi>0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"{s} x {Math.Pow(10,n-i)} = {s*Math.Pow(10,n-i)}");
                i++;
            }

            Console.ReadKey();

        }

        private static void KarakterYiginOrnegi()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()}  Yigina Eklendi.");
                Console.WriteLine($"Yigindaki eleman sayisi : {karakterYigini.Count}");
            }
            //Ek bilgi
            var dizi = karakterYigini.ToArray();
            Console.WriteLine("Yigindan Çıkarma işlemi için bir tuşa basınız");

            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yigindan çıkartıldı.");
                Console.WriteLine($"Yigindaki eleman sayisi : {karakterYigini.Count}");
            }

            Console.ReadKey();
        }

        private static void YiginOrnegi()
        {
            //Stack tanımlama
            var karakterYigini = new Stack<char>();

            //Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            // Çıkarma
            Console.WriteLine(karakterYigini.Pop() + "  Yigindan Çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + "  Yigindan Çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + "  Yigindan Çıkartıldı");
        }
    }
}
