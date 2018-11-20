using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_w__pantsu
{
    public class PantsuCollection
    {
        public static string[] Owners;
        private static string[] Materials;
        private static string[] Colors;
        private static string[] Styles;
        private static string[] Sizes;
        private static int Counts;
        private static Random rnd = new Random();

        public PantsuCollection()
        {
            Owners = new string[0];
            Materials = new string[0];
            Colors = new string[0];
            Styles = new string[0];
            Sizes = new string[0];
        }

        private static Dictionary<string, string[]> pantsuPendium;

        public static void Catalogue(Pantsu pantsu, PantsuCollection panColle)
        {
            if (pantsuPendium == null)
            {
                pantsuPendium = new Dictionary<string, string[]>();
                pantsuPendium.Add("Owner", Owners);
                pantsuPendium.Add("Materials", Materials);
                pantsuPendium.Add("Colors", Colors);
                pantsuPendium.Add("Styles", Styles);
                pantsuPendium.Add("Sizes", (Sizes));
            }

            Counts++;
            Array.Resize(ref Owners, Counts);
            Owners[Counts - 1] = pantsu.Owner;
            Array.Resize(ref Materials, Counts);
            Materials[Counts - 1] = pantsu.Material;
            Array.Resize(ref Colors, Counts);
            Colors[Counts - 1] = pantsu.Color;
            Array.Resize(ref Styles, Counts);
            Styles[Counts - 1] = pantsu.Style;
            Array.Resize(ref Sizes, Counts);
            Sizes[Counts - 1] = Convert.ToString(pantsu.Size);


            pantsuPendium["Owner"] = Owners;
            pantsuPendium["Materials"] = Materials;
            pantsuPendium["Colors"] = Colors;
            pantsuPendium["Styles"] = Styles;
            pantsuPendium["Sizes"] = Sizes;

        }

        public static void RandomPair()
        {
            int style = rnd.Next(0, Styles.Length);
            Console.WriteLine($"{Owners[rnd.Next(0, Owners.Length)]} is wearing{(Styles[style].Last() == 's' ? "" : " a")} " +
                $"size {Sizes[rnd.Next(0, Sizes.Length)]} {Colors[rnd.Next(0, Colors.Length)]} " +
                $"{Materials[rnd.Next(0, Materials.Length)]} {Styles[style]}.");
        }
    }
}
