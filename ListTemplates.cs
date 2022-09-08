using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml;
using System.Xml.Serialization;


namespace PenaltiesAccounting
{
    using SaveInXML;
    internal class ListTemplates<T>
    {
        public List<T>? accounts;
        public string XMLFilePath;
        public ListTemplates(string XMLFilePath)
        {
            this.XMLFilePath = XMLFilePath;
            accounts = new List<T>();
        }
        public void AddAccount(T account)
        {
            accounts.Add(account);

        }
        public void SaveInFileXml()
        {
            try
            {
                SerializerXML.SerializeObject<List<T>>(XMLFilePath, accounts);
            }
            catch (IOException ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        public List<T> LoadListFromFile()
        {
            List<T> list = new List<T>();
            try
            {
                list = SerializerXML.DeSerializeObject < T >> (XMLFilePath);
            }
            catch (IOException ex)
            {
                WriteLine(ex.Message.ToString());
            }
            return list;
        }
    }
}
