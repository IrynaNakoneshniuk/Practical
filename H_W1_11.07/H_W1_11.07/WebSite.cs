using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace H_W1_11._07
{
    internal class WebSite
    {
       public WebSite()
        {
            this._description = null;
            this._url = null;
            this._ip = null;
            this._name=null;
        }
        private string? _url;
        public string? Url { get { return _url; } set { _url = value; } }
        private string? _name;
        public string? Name { get { return _name; } set { _name = value; } }
        private string? _description;
        public string? Description { get { return _description; } set { _description = value; } }
        private string? _ip;
        public string? Ip { get { return _ip; } set { _ip = value; } }
        public void InputInfo(string? description,string ? ip,string? name,string ?url)
        {
            this._description = description;
            this._ip = ip;
            this._name = name;
            this._url = url;
        }
        public void ShowInfo()
        {
            WriteLine($"URL: {this._url}");
            WriteLine($"IP: {this._ip}");
            WriteLine($"NAME:{this._name}");
            WriteLine($"Discription: {this._description}");
        }
    }
    internal class Journal
    {
        public Journal()
        {
            this._description = null;
            this._since_years = null;
            this._name = null;
            this._email = null;
            this._phone = null;
        }
        private string? _since_years;
        private string? _email;
        private string? _name;
        private string? _phone;
        private string? _description;
        public string? Name { get { return _name; } set { _name = value; } }
        public string? Phone { get { return _phone; } set { _phone = value; } }
       
        public string? Description { get { return _description; } set { _description = value; } }
        public string? Since_years { get { return _since_years; } set { _since_years = value; } }
        public string? Email { get { return _email; } set { _email = value; } } 
        public void InputInfo(string? description, string? phone, string? name, string? email,string ? since_years)
        {
            this._description = description;
            this._name = name;
            this._phone = phone;
            this._email = email;
            this._since_years = since_years;
        }
        public void ShowInfo()
        {
            WriteLine($"NAME:{this._name}");
            WriteLine($"Discription: {this._description}");
            WriteLine($"Phone: {this.Phone}");
            WriteLine($"Email: {this.Email}");
            WriteLine($"Since year: {this.Since_years}");   
        }
    }
    internal class Shop
    {
        public Shop()
        {
            this._description = null;
            this._name = null;
        }
        private string? _address;
        private string? _email;
        private string? _name;
        private string? _phone;
        private string? _description;
        public string? Name { get { return _name; } set { _name = value; } }
        public string? Phone { get { return _phone; } set { _phone = value; } }

        public string? Description { get { return _description; } set { _description = value; } }
        public string? Address { get { return _address; } set { _address = value; } }
        public string? Email { get { return _email; } set { _email = value; } }
        public void InputInfo(string? description, string? phone, string? name, string? email, string? address)
        {
            this._description = description;
            this._name = name;
            this._phone = phone;
            this._email = email;
            this._address = address;
        }
        public void ShowInfo()
        {
            WriteLine($"NAME:{this._name}");
            WriteLine($"Discription: {this._description}");
            WriteLine($"Phone: {this.Phone}");
            WriteLine($"Email: {this.Email}");
            WriteLine($"Address: {this._address}");
        }
    }
}
