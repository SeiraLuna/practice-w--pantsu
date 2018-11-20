using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_w__pantsu
{
    public class Pantsu :IWearable
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

        public override string ToString()
        {
            return ($"a size {this.Size} {(this.Style.Last() == 's' ? "pair of" : "")} {this.Color} {this.Material} {this.Style}");
        }

        public void Wear(Waifu name)
        {
            Console.WriteLine($"{name} dons {this.ToString()}.");
        }

        public void Inspect()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Use()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Wear()
        {
            throw new NotImplementedException();
        }
    }
}
