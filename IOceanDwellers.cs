using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._28._07
{
    internal interface IOceanDwellers
    {
        string ?Name { get; set; }
        void InfoOceanDwellers();
    }
    internal class Dolphin : IOceanDwellers
    {
        public Dolphin(string? name)
        {
            Name = name;
        }

        public string? Name { get ; set ; }

        public void InfoOceanDwellers()
        {
            WriteLine($"{this.Name} : small gregarious toothed whale " +
                $"that typically has a beaklike snout and a curved fin on the back");
        }
    }
    internal class Shark : IOceanDwellers
    {
        public string? Name { get; set; }
        public Shark(string? name)
        {
            Name = name;
        }
        public void InfoOceanDwellers()
        {
            WriteLine($"{this.Name} :is a fish characterized by a cartilaginous skeleton, " +
                $"five to seven gill slits on the sides of the head");
        }
    }
    internal class Turtle : IOceanDwellers
    {
        public string? Name { get; set; }
        public Turtle(string? name)
        {
            Name = name;
        }
        public void InfoOceanDwellers()
        {
            WriteLine($"{this.Name} :is a slow-moving reptile, " +
                $"enclosed in a scaly or leathery domed shell into which it can retract its head and thick legs");
        }
    }

}
