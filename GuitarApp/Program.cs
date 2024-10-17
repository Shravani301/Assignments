using GuitarApp.CustomEnums;
using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(
                Builder.FENDER, "Stratocaster", GuitarType.ELECTRIC, 6, Wood.ALDER, Wood.ALDER
            );

            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

            HandleSearchResults(matchingGuitars);

            
        }

        private static void HandleSearchResults(List<Guitar> guitars)
        {
            if (guitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach (Guitar guitar in guitars)
                {
                    DisplayGuitarDetails(guitar);
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }
            private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar(
                "11277", 1499.95, new GuitarSpec(
                    Builder.FENDER, "Stratocaster", GuitarType.ELECTRIC, 6, Wood.ALDER, Wood.ALDER
                )
            );

            inventory.AddGuitar(
                "V95693", 1549.95, new GuitarSpec(
                    Builder.FENDER, "Stratocaster", GuitarType.ELECTRIC, 6, Wood.ALDER, Wood.ALDER
                )
            );
        }

        private static void DisplayGuitarDetails(Guitar guitar)
        {
            GuitarSpec spec = guitar.Spec;
            Console.WriteLine($"We have a {spec.Builder} {spec.Model} {spec.Type.ToString().ToLower()} guitar:\n" +
                $"{spec.BackWood} back and sides, {spec.TopWood} top.\n" +
                $"You can have it for only ${guitar.Price}\n");
            
        }
    }
    
}
