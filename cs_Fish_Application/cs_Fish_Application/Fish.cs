using System;
using System.Collections.Generic;
using System.Text;

namespace cs_Fish_Application
{
    public class Fish
    {
        public string fish_type { get; set; }
        public int fish_value { get; set; }

        public string get_type()
        {
            return fish_type;
        }

        public int get_value()
        {
            return fish_value;
        }

        public Fish(string fish_type, int fish_value)
        {
            this.fish_type = fish_type;
            this.fish_value = fish_value;
        }
    }
}
