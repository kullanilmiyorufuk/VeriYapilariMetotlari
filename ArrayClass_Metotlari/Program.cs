using System;
using System.Collections;

namespace ArrayClass_Metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Dizi Tanimlama
            int[] sayilar = new int[] { 5, 3, 8, 10, 2 };
            var numbers = Array.CreateInstance(typeof(int), 5); // 5 Size belirtiyor.
            var arr = new ArrayList(sayilar);

            //Sıralama işlemler.
            Array.Sort(sayilar);
            Array.Sort(numbers);
            arr.Sort();
            sayilar.CopyTo(numbers, 0);

            //Array.Clear(sayilar, 0, 2);   // 0. index'den 2 elemente kadar silecek.
            //Console.WriteLine(Array.IndexOf(sayilar, 55)); // Arraydaki 55'in kaçıncı indexde oldugunu verecek.

            //Dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = " + $"{sayilar[i],3} - " + $"numbers[{i}] = " + $"{numbers.GetValue(i),5} "
                    + $"      arr[{i}] = " + $"{arr[i]}");
            }

            Console.ReadKey();
        }

    }
}
