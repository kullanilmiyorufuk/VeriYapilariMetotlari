using System;
using System.Collections.Generic;

namespace DictionaryUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsöz",7500) },
                {120, new Personel("Ahmet","Can",9000) }
            };
            personelListesi.Add(100,new Personel("Zeynep","Coşkun",5000));

            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }



            Console.ReadKey();


        }

        private static void UygulamaOrnek()
        {
            //Tanımlama
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },{424,"Elazığ"},{466,"Art"}
            };

            //Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            //Erişme
            telefonKodlari[466] = "Artvin";

            //ContainKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkaranın kod bilgisi tanımlı değil");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");
            }

            // ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya kod bilgisi Tanımlı değil");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");
            }

            telefonKodlari.Remove(322);

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
