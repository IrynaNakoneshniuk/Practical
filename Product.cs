using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace XMLReadSave
{
    [Serializable]
    internal class Product
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double ?Price { get; set; }
        public string ? Type { get; set; }
        public Product(string? name, string? description, double? price, string? type)
        {
            Name = name;
            Description = description;
            Price = price;
            Type = type;
        }
        public Product()
        {
            Name = null;
            Description = null;
            Price = null;
            Type = null;
        }
        public override string ToString()
        {
            return $"Name: {Name},Description: {Description}, Price: {Price}, Type: {Type}";
        }
    }
}
