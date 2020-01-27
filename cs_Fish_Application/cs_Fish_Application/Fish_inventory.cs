using System;
using System.Collections.Generic;
using System.Text;


namespace cs_Fish_Application
{
    public class Fish_inventory
    {
        public static List<Fish> inventory = new List<Fish>();

        public void add_fish()
        {
            if (inventory.Count >= 28)
            {
                Console.WriteLine("You can't carry anymore fish.");
                return;
            }

            inventory.Add(Fishes.fish_fetcher());
        }

        public void sell_fish()
        {
            Console.WriteLine("Enter the position of the fish of which you wish to sell: 1-" + inventory.Count);

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                input -= 1;
                inventory.RemoveAt(input);
            }
            catch
            {
                Console.WriteLine("Invalid position.");
            }
        }

        public void fish_caught()
        {
            foreach (Fish fishy in inventory)
            {
                Console.WriteLine(fishy.get_type() + " $" + fishy.get_value());
            }
        }
    }
}
