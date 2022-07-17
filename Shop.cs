using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._21._07._22
{
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
        private double? _area;
        public double ? Area { set => _area = value; }
        public string? Name { get { return _name; } set { _name = value; } }
        public string? Phone { get { return _phone; } set { _phone = value; } }
        public string? Description { get { return _description; } set { _description = value; } }
        public string? Address { get { return _address; } set { _address = value; } }
        public string? Email { get { return _email; } set { _email = value; } }
        public void InputInfo(string? description, string? phone, string? name, string? email, string? address, double ? area)
        {
            this._description = description;
            this._name = name;
            this._phone = phone;
            this._email = email;
            this._address = address;
            this._area = area;  
        }
        public void ShowInfo()
        {
            WriteLine($"NAME:{this._name}");
            WriteLine($"Discription: {this._description}");
            WriteLine($"Phone: {this._phone}");
            WriteLine($"Email: {this._email}");
            WriteLine($"Address: {this._address}");
            WriteLine($"Area: {this._area}");
        }
        public static Shop operator + (Shop s, double value)
        {
            s._area += value;
            return s;
        }
        public static Shop operator -(Shop s, double value)
        {
            s._area -= value;
            return s;
        }
        public static bool operator ==(Shop s1, Shop s2)
        {
            return (s1._area == s2._area);
        }
        public static bool operator !=(Shop s1, Shop s2)
        {
            return !(s1._area == s2._area);
        }
        public static bool operator >(Shop s1, Shop s2)
        {
            return (s1._area > s2._area);
        }
        public static bool operator <(Shop s1, Shop s2)
        {
            return (s1._area < s2._area);
        }
        public override string ToString()
        {
            return $"NAME:{this._name},Discription: {this._description},Phone: {this._phone}," +
                $"Email: {this._email},Address: {this._address}" +
                $"Area: {this._area} ";
        }
        public override bool Equals(object? obj)
        {
            return base.ToString()==obj.ToString();
        }
    }
}
