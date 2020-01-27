using System;
using System.Collections.Generic;
using System.Text;

namespace cs_Fish_Application
{
    static class Fishes
    {
        static public Fish fish_fetcher()
        {
            return fishes[Randomizer.get_random(0, fishes.Length)];
        }

        static Fish[] fishes =
        {
            new Fish("Shrimp", 32),
            new Fish("Sardine", 31),
            new Fish("Herring", 54),
            new Fish("Anchovies", 89),
            new Fish("Mackarel", 25),
            new Fish("Trout", 20),
            new Fish("Cod", 95),
            new Fish("Pike", 64),
            new Fish("Slimy eel", 314),
            new Fish("Salmon", 42),
            new Fish("Tuna", 46),
            new Fish("Rainbow fish", 249),
            new Fish("Cave eel", 601),
            new Fish("Lobster", 219),
            new Fish("Bluegill", 60),
            new Fish("Bass", 563),
            new Fish("Leaping trout", 7),
            new Fish("Swordfish", 353),
            new Fish("Common tench", 94),
            new Fish("Leaping salmon", 3),
            new Fish("Monkfish", 333),
            new Fish("Karambwan", 529),
            new Fish("Leaping sturgeon", 69),
            new Fish("Mottled eel", 94),
            new Fish("Shark", 974),
            new Fish("Seaturtle", 1040),
            new Fish("Manta ray", 1303),
            new Fish("Anglerfish", 1866),
            new Fish("Dark crab", 1368),
            new Fish("Greater siren", 61),
        };
    }
}
