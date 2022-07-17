using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

using static System.Console;
namespace ConsoleApp1
{
    internal abstract class Figure
    {
        protected string? Title;
        protected double? Side_1;
        protected double? Side_2;
        public Figure(string? title, double? side_1, double? side_2)
        {
            Title = title;
            Side_1 = side_1;
            Side_2 = side_2;
        }
        public abstract double ?Area();
        public void ShowInfo()
        {
            WriteLine($"{this.Title}, Area:  {this.Area().ToString()}");
        }
    }
    internal class Rectangl : Figure
    {
        public Rectangl(string? title, double? side_1, double? side_2) : base(title, side_1, side_2){}

        public override double? Area()
        {
            return (this.Side_1 * this.Side_2);
        }
    }
    internal class Circule: Figure
    {
        public Circule(string? title, double? side_1) : base(title, side_1,0) { }

        public override double? Area()
        {
            return (this.Side_1 * this.Side_1) * PI;
        }
    }
    internal class Rigth_Triangle: Figure
    {
        public Rigth_Triangle(string? title, double? side_1, double? side_2) : base(title, side_1, side_2= side_1) { }

        public override double? Area()
        {
            return (this.Side_1 * this.Side_2) * 0.5;
        }
    }
    internal class Trapeze : Figure
    {
        private double? _h;
        public double? H { get { return this._h; } set { this._h = value; } }
        public Trapeze(string? title, double? side_1, double? side_2,double ?H) : base(title, side_1, side_2) {
            this._h = H;
        }
        public override double? Area()
        {
            return (this.Side_1 +this.Side_2) * (this._h*this._h);
        }
    }
}
