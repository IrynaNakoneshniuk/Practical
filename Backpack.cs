using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._12._08
{
    
    internal class Backpack
    {
        public double? Volume { get; set; }
        public string? Color { get; set; }
        public double ?Weight { get; set; }
        public string ?Fabric { get; set; }
        public double ?Size { get; set; }
        public double? CurentSize { get; set; }
        public List<Object> ContentBackpack { get; set; }
        public Backpack(double? volume, string? color, double? weight, string? fabric, double? size)
        {
            Volume = volume;
            Color = color;
            Weight = weight;
            Fabric = fabric;
            Size = size;
            ContentBackpack = new List<Object>();
            CurentSize = 0;
        }
        public void ShowContentOfBag()
        {
            foreach(Object item in ContentBackpack)
            {
                WriteLine(item.ToString());
            }
        }
    }
}
