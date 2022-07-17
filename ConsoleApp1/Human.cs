using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal abstract class Human
    {
        protected string ? Name;
        protected int? Age;
        protected string? SurName;
        protected string? Activity;
        public Human()
        {
            this.SurName = null;
            this.Activity = null;
            this.Age = null;
            this.Name = null;
        }
        public string ?name { get; set; }
        public int ?age { get; set; }
        protected string? activity { get; set; }
        public string? surname { get; set; }
        public void InputInfo(string? name, int? age, string? activity, string? surname)
        {
            this.Age=age;
            this.Activity=activity;
            this.Name = name;
            this.SurName=surname;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}, Surname:{this.SurName}, Activity: {this.Activity}" ;
        }
        public abstract void  DiscriptionActivity();
    }
    internal class Builder : Human
    {
        public override void DiscriptionActivity()
        {
            WriteLine("Сonstructs something by putting parts or material together over a period of time.");
        }
    }
    internal class Pilot : Human
    {
        public override void DiscriptionActivity()
        {
            WriteLine("Operates the flying controls of an aircraft a strike by local airline pilots");
        }
    }
    internal class Salior : Human
    {
        public override void DiscriptionActivity()
        {
            WriteLine("work as a member of the crew of a commercial or naval ship or boat");
        }
    }

}
