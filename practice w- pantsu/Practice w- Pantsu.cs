//Structure #2 --  Practice w/ pantsu
using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_w__pantsu
{
    class Program
    {
        static void Main()
        {
            Pantsu Gabriel = new Pantsu(nameof(Gabriel), "silk", "golden", "thong", 3);
            Pantsu Ariel = new Pantsu(nameof(Ariel), "latex", "indigo", "boyshorts", 4);
            Pantsu Jezzabelle = new Pantsu(nameof(Jezzabelle), "cotton", "rainbow-striped", "bikini", 2);

            PantsuCollection myPantsu = new PantsuCollection() { };

            Pantsu.Collect(Gabriel, myPantsu);
            Pantsu.Collect(Ariel, myPantsu);
            Pantsu.Collect(Jezzabelle, myPantsu);

            Pantsu.DisplayPantsu();

            Console.WriteLine();

            for (var i = 0; i < 10; i++)
            {
                PantsuCollection.RandomPair();
            }

            Console.ReadKey();
        }

        /*
        public struct Pantsu
        {
            public string Owner;
            public string Material;
            public string Color;
            public string Style;
            public int Size;

            public Pantsu(string owner, string material, string color, string style, int size)
            {
                Owner = owner;
                Material = material;
                Color = color;
                Style = style;
                Size = size;
            }

            private static List<Pantsu> pantsuList;

            public static void Collect(Pantsu pantsu, PantsuCollection panColle)
            {
                if (pantsuList == null)
                {
                    pantsuList = new List<Pantsu>();
                }
                pantsuList.Add(pantsu);

                PantsuCollection.Catalogue(pantsu, panColle);
            }

            public static void DisplayPantsu()
            {
                foreach (Pantsu p in pantsuList)
                {
                    Console.WriteLine($"{p.Owner} is wearing{(p.Style.Last() == 's' ? "" : " a")} size {p.Size} {p.Color} {p.Material} {p.Style}.");
                }
            }

        }
        */
        
    }
}