using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using static System.Console;
namespace XMLReadSave
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Product product1 = new Product("Product 1","For healthy",789.09, "Groceries");
            Product product2 = new Product("Product 2", "For healthy", 800, "Groceries");
            Order order = new Order();
            Order order2 = new Order();
            order.Add(product2);
            order.Add(product1);
            XMLSaveOrder xMLSaveOrder = new XMLSaveOrder();
            xMLSaveOrder.Save(@"C:\Users\ZbooK\source\repos\XMLReadSave\Myfile2.xml", order);
            ReadXML readXML = new ReadXML();
            readXML.ReadXMLOrder(@"C:\Users\ZbooK\source\repos\XMLReadSave\Myfile2.xml");



        }
    }
}