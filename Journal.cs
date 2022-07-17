using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._21._07._22
{
    internal class Journal : IDisposable
    {
        public Journal()
        {
            this._description = null;
            this._name = null;
            this._email = null;
            this._phone = null;
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
        private int ? _qtyEmployee;
        public int ? QtyEmployee { get { return _qtyEmployee; } }
        public string? Name { get { return _name; } set { _name = value; } }
        public string? Phone { get { return _phone; } set { _phone = value; } }
        public string? Description { get { return _description; } set { _description = value; } }
        public string? Email { get { return _email; } set { _email = value; } }
        public string? Since_Year { get { return _since_year; } set { _since_year = value; } }
        public void InputInfo(string? description, string? phone, string? name, string? email, string? since_year, int? qtyEmpl)
        {
            this._description = description;
            this._name = name;
            this._phone = phone;
            this._email = email;
            this._since_year = since_year;
            this._qtyEmployee = qtyEmpl;
        }
        public void ShowInfo()
        {
            WriteLine($"NAME:{this._name}");
            WriteLine($"Discription: {this._description}");
            WriteLine($"Phone: {this._phone}");
            WriteLine($"Email: {this._email}");
            WriteLine($"Since year: {this._since_year}");
            WriteLine($"Qty employee: {this._qtyEmployee}");    
        }
        public static Journal operator +(Journal j, int value)
        {
            j._qtyEmployee += value;
            return j;
        }
        public static Journal operator -(Journal j, int value)
        {
            j._qtyEmployee -= value;
            return j;
        }
        public static bool operator == (Journal j1, Journal j2)
        {
            return j1.Equals(j2);
        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return !(j1==j2);
        }
        public static bool operator < (Journal j1, Journal j2)
        {
            return (j1._qtyEmployee < j2._qtyEmployee);
        }
        public static bool operator >(Journal j1, Journal j2)
        {
            return (j1._qtyEmployee > j2._qtyEmployee);
        }
        public override string ToString()
        {
            return $"NAME:{this._name},Discription: {this._description},Phone: {this._phone},Email: {this._email}" +
                $" Since year: {this._since_year},Qty employee: {this._qtyEmployee}";
        }
        public override bool Equals(object? obj)
        {
            return this.ToString()==obj.ToString();
        }
    }
}
