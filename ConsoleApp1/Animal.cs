using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal abstract class Animal
    {
        protected string? Name;
        protected string? Kind;
        public Animal(string? name, string? kind)
        {
            Name = name;
            Kind = kind;
        }
        public string ? name { get; set; }  
        public string ? kind { get; set; }  
        public abstract void AnimalDescription();
        public void ShowInfo()
        {
            WriteLine($"Name: {this.Name}, Kind: {this.Kind}");
        }
    }
    internal class Tiger : Animal
    {
        public Tiger(string? name, string? kind) : base(name, kind){}

        public override void AnimalDescription()
        {
            WriteLine("Very large solitary cat with a yellow-brown coat striped with black");
        }
    }
    internal class Crocodile : Animal
    {
        public Crocodile(string? name, string? kind) : base(name, kind) { }

        public override void AnimalDescription()
        {
            WriteLine("Large predatory semiaquatic reptile with long jaws, long tail, short legs, and a horny textured skin");
        }
    }
    internal class Kangaroo : Animal
    {
        public Kangaroo(string? name, string? kind) : base(name, kind) { }

        public override void AnimalDescription()
        {
            WriteLine("large plant-eating marsupial with a long powerful tail");
        }
    }
}
