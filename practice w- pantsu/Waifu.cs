using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_w__pantsu
{
    public class Waifu 
    {
        string Name;
        double Height;
        double Weight;
        double Bust;
        double Waist;
        double Hips;

        string HairColor;
        string EyeColor;

        double ShoeSize;
        double CupSize;

        public Waifu()
        {
            Dictionary <string, IItem> Inventory = InitializeInventory();

        }

        private Dictionary<string, IItem> InitializeInventory()
        {
            Dictionary<string, IItem> Inventory = new Dictionary<string, IItem>() { };

            Inventory.Add("Head", null);
            Inventory.Add("Ear1", null);
            Inventory.Add("Ear2", null);
            Inventory.Add("Eyes", null);
            Inventory.Add("Face", null);
            Inventory.Add("Neck", null);
            Inventory.Add("Shoulders", null);
            Inventory.Add("Chest", null);
            Inventory.Add("Back", null);
            Inventory.Add("Waist", null);
            Inventory.Add("Legs", null);
            Inventory.Add("Ankles", null);
            Inventory.Add("Feet", null);
            Inventory.Add("Arms", null);
            Inventory.Add("Wrists", null);
            Inventory.Add("Hands", null);
            Inventory.Add("Fingers", null);

            return Inventory;
        }


    }
}
