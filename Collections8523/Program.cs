using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections8523
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            string[] isimler = new string[3];
            isimler[0] = "Çağıl";
            isimler[1] = "Leo";
            isimler[2] = "Angel";
            //isimler[3] = "Muhittin";
            isimler = new string[4];
            isimler[0] = "Çağıl";
            isimler[1] = "Leo";
            isimler[2] = "Angel";
            isimler[3] = "Muhittin";
            #endregion

            #region ArrayList
            ArrayList isimlerListesi = new ArrayList(); // System.Collections.ArrayList
            isimlerListesi.Add("Çağıl");
            isimlerListesi.Add("Leo");
            isimlerListesi.Add("Angel");
            foreach(object isim in isimlerListesi)
            {
                Console.WriteLine(isim);
            }
            isimlerListesi.Add("Muhittin");
            foreach(object isim in isimlerListesi)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine(isimlerListesi[3]); // Muhittin
            isimlerListesi.Add(1);
            isimlerListesi.Add('A');
            isimlerListesi.Add(true);
            foreach(object isim in isimlerListesi)
            {
                Console.WriteLine(isim);
            }

            // type safe generic koleksiyonlar
            List<string> sehirListesi = new List<string>()
            {
                "İstanbul"
            };
            sehirListesi.Add("Ankara");
            sehirListesi.Add("İzmir");
            foreach(var sehir in sehirListesi)
            {
                Console.WriteLine(sehir);
            }

            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir()
                {
                    Plaka=6,
                    Adi="Ankara"
                },
                new Sehir()
                {
                    Plaka=34,
                    Adi="İstanbul"
                }
            };
            Sehir yeniSehir = new Sehir()
            {
                Plaka = 35,
                Adi = "İzmir"
            };
            Console.WriteLine(yeniSehir);
            foreach(var s in sehirler)
            {
                Console.WriteLine("Plaka: " + s.Plaka + " Adı: " + s.Adi);
            }
            #endregion

            #region Collection Methods
            int count = sehirler.Count; // 3
            for(int i=0; i<sehirler.Count; i++)
            {
                Console.WriteLine("Plaka: " + sehirler[i].Plaka + " Adı: " + sehirler[i].Adi);
            }
            Sehir[] yeniSehirler = new Sehir[2]
            {
                new Sehir()
                {
                    Plaka = 7,
                    Adi = "Antalya"
                },
                new Sehir()
                {
                    Plaka = 1,
                    Adi = "Adana"
                }
            };
            sehirler.AddRange(yeniSehirler);
            foreach(var s in sehirler)
            {
                Console.WriteLine("Plaka: " + s.Plaka + " Adı: " + s.Adi);
            }

            IEnumerable<string> names1 = new List<string>()
            {
                "Max",
                "Charlize",
                "Robert",
                "Jasmine"
            };
            ICollection<string> names2 = new List<string>()
            {
                "Max",
                "Charlize",
                "Robert",
                "Jasmine"
            };
            //names1.Sort();
            //names2.Sort();
            List<string> names3 = new List<string>()
            {
                "Veli",
                "Ali"
            };
            names3.Sort();
            foreach(var name in names3)
            {
                Console.WriteLine(name); // Ali, Veli
            }
            Console.WriteLine(names2.Contains("Max")); // True
            Console.WriteLine(names2.Contains("max")); // False
            Console.WriteLine(names2.Contains("Micahel")); // False
            Console.WriteLine(sehirler.Contains(new Sehir() { Plaka = 6, Adi = "Ankara" })); // False
            var sehirAnkara = sehirler[0]; // ankara
            Console.WriteLine(sehirler.Contains(sehirAnkara)); // True
            
            #endregion
            
            Console.ReadLine();
        }
    }
    class Sehir
    {
        public int Plaka { get; set; }
        public string Adi { get; set; }
    }
}
