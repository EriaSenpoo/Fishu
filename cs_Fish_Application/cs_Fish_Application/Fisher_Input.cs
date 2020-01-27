using System;
using System.Collections.Generic;
using System.Text;

namespace cs_Fish_Application
{
    class Fisher_Input
    {
        Fish_inventory inv = new Fish_inventory();

        public void console_text()
        {
            Console.WriteLine("0. Quit.");
            Console.WriteLine("1. Start fishing.");
            Console.WriteLine("2. Check inventory.");
            if (Fish_inventory.inventory.Count > 0)
            {
                Console.WriteLine("3. Fishing technique.");
            }
            else
            {
                Console.WriteLine("3. Fishing technique.\n");
            }
        }

        public void start()
        {
            console_text();
            bool quit = false;
            while (quit == false)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                
                Console.Clear();
                console_text();

                if (Fish_inventory.inventory.Count > 0)
                {
                    Console.WriteLine("4. Sell fish.\n");
                }
                if (input.Key == ConsoleKey.D0)
                {
                    quit = true;
                }

                if (input.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("You caught a fish!");
                    inv.add_fish();
                }

                if (input.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Fish in inventory:");
                    inv.fish_caught();
                }

                if (input.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Fishing techniques are coming in a future update! :^)");
                }

                if (Fish_inventory.inventory.Count > 0)
                {
                    if (input.Key == ConsoleKey.D4)
                    {
                        inv.sell_fish();
                    }
                }
            }
        }
    }
}
