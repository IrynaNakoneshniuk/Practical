using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.GC;

namespace H_W1_11._07
{
    internal class WebSite
    {
        public WebSite()
        {
            this._description = null;
            this._url = null;
            this._ip = null;
            this._name = null;
        }
        private string? _url;
        public string? Url { get { return _url; } set { _url = value; } }
        private string? _name;
        public string? Name { get { return _name; } set { _name = value; } }
        private string? _description;
        public string? Description { get { return _description; } set { _description = value; } }
        private string? _ip;
        public string? Ip { get { return _ip; } set { _ip = value; } }
        public void InputInfo(string? description, string? ip, string? name, string? url)
        {
            this._description = description;
            this._ip = ip;
            this._name=name;
            this._url=url;
        }
        public void ShowInfo()
        {
            WriteLine($"NAME:{this._name}");
            WriteLine($"Discription: {this._description}");
            WriteLine($"Url: {this._url}");
            WriteLine($"IP: {this._ip}");
        }
    }
    internal class Shop : IDisposable
    {
        public Shop()
        {
            this._description = null;
            this._name = null;
        }
        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }
        private void Cleaning(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    WriteLine("Cleaning up managed resurs");
                }
                WriteLine("cleaning up unmanaged resources");
            }
            isDisposed = true;
        }
        private bool isDisposed = false;
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
            WriteLine($"Phone: {this._phone}");
            WriteLine($"Email: {this._email}");
            WriteLine($"Address: {this._address}");
        }
    }
}
internal class Journal : IDisposable
{
    public Journal()
    {
        this._description = null;
        this._name = null;
        this._email = null;
        this._phone=null;
        this._since_year = null; 
    }
    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }
    private void Cleaning(bool disposing)
    {
        if (!isDisposed)
        {
            if (disposing)
            {
                WriteLine("Cleaning up managed resurs");
            }
            WriteLine("cleaning up unmanaged resources");
        }
        isDisposed = true;
    }
    private bool isDisposed = false;
    private string? _email;
    private string? _name;
    private string? _phone;
    private string? _description;
    private string? _since_year;
    public string? Name { get { return _name; } set { _name = value; } }
    public string? Phone { get { return _phone; } set { _phone = value; } }
    public string? Description { get { return _description; } set { _description = value; } }
    public string? Email { get { return _email; } set { _email = value; } }
    public string ? Since_Year { get { return _since_year; } set { _since_year = value; } }
    public void InputInfo(string? description, string? phone, string? name, string? email, string? since_year)
    {
        this._description = description;
        this._name = name;
        this._phone = phone;
        this._email = email;
        this._since_year = since_year;
    }
    public void ShowInfo()
    {
        WriteLine($"NAME:{this._name}");
        WriteLine($"Discription: {this._description}");
        WriteLine($"Phone: {this._phone}");
        WriteLine($"Email: {this._email}");
        WriteLine($"Since year: {this._since_year}");
    }
}

