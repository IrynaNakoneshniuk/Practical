using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

using static System.Console;

namespace XMLReadSave
{
    internal class XMLSaveOrder
    {
        public void Save(string Path,Order order)
        {
            try
            {
                XmlTextWriter textWriter = new XmlTextWriter(Path, Encoding.Unicode);
                textWriter.Formatting = Formatting.Indented;
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("order");
                textWriter.WriteStartElement("order");
                foreach (Product item in order.products)
                {
                    textWriter.WriteElementString("name", item.Name);
                    textWriter.WriteElementString("price", XmlConvert.ToString(item.Price.Value));
                    textWriter.WriteElementString("type", item.Type);
                }
                textWriter.WriteEndElement();
                textWriter.WriteEndElement();
                textWriter.Close();
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message.ToString());   
            }
        }
    }
    
    internal class ReadXML
    {
        public void ReadXMLOrder(string Path)
        {
            XmlTextReader xmlTextReader = new XmlTextReader(Path);
            xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
            while (xmlTextReader.Read())
            {
                WriteLine($"{xmlTextReader.Value.ToString()}");
                if (xmlTextReader.AttributeCount > 0)
                {
                    while (xmlTextReader.MoveToNextAttribute())
                    {
                        WriteLine($"{xmlTextReader.Value.ToString()}");
                    }
                }
            }
        }
    }
}
