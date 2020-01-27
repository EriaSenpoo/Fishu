using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace cs_Fish_Application
{
    static class Randomizer
    {
        static Random rng = new Random();

        static public int get_random(int min, int max)
        {
            return rng.Next(min, max);
        }
    }
}
