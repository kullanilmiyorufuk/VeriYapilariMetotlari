using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace lComparable_Implement
{

    public class Sehir:IComparable<Sehir>
    {
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }
        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdi,-15}";
        }
        public int CompareTo([AllowNull] Sehir other)
        {
            if (this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if(this.PlakaNo==other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
    }
   public class Program
    {
        static void Main(string[] args)
        {

            //List
            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort();
            sayilar.ForEach(turet => Console.WriteLine(turet));

            //Sehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"), 
                new Sehir(34,"İstanbul"), 
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazig"),
                new Sehir(44,"Malatya")
            };
            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort();
            sehirler.ForEach(turet => Console.WriteLine(turet));
            Console.ReadKey();
        }
    }
}
