using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace XMLReadSave
{
    [Serializable]
    internal class Order
    {
        public List<Product> products;
        public DateTime DateOrder { get; set; }
        public int OrderID { get; set; }
        public double Sum { get; set; }
        public Order()
        {
            this.products=new List<Product>();
        }
        public void Add(Product prod)
        {
            products.Add(prod);
        }
        public override string ToString()
        {
            string? order = null;
            foreach(Product prod in products)
            {
                order+=prod.ToString();
            }
            return order;
        }
    }
}
