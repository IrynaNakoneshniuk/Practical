using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Passport
    {
        protected int? Number;
        protected string? Name;
        protected string? SurName;
        protected string? DateBirthday;
        protected string? Adress;
        public Passport(int? number, string? name, string? surName, string? dateBirthday, string? adress)
        {
            Number = number;
            Name = name;
            SurName = surName;
            DateBirthday = dateBirthday;
            Adress = adress;
        }
        
        public int ?number { get; set; }
        public string? name { get; set; }
        public string? surName { get; set; }
        public string? dateBirthday { get; set; }
        public string? adress { get; set; }
        public virtual void PersonalInfo()
        {
            WriteLine($"Name: {this.Name}");
            WriteLine($"SurName: {this.SurName}");
            WriteLine($"Date of Birthday: {this.DateBirthday}");
            WriteLine($"Adress: {this.Adress}");
            WriteLine($"Number of passport: {this.Number}");    
        }
    }
    internal class ForeignPassport : Passport
    {
        private List <Visa> visas = new List<Visa>();
        public ForeignPassport(int? number, string? name, string? surName, string? dateBirthday, string? adress)
            : base(number, name, surName, dateBirthday, adress) { }
        
        public Visa this[int index]
        {
            get
            {
                if (index >= 0 && index < visas.Count)
                {
                    return visas[index];
                }
                else
                {
                   throw new ArgumentOutOfRangeException(); ;
                }
            }
            set
            {
                if (index >= 0 && index < visas.Count)
                {
                    visas[index]=value;
                }
            }
        }
        public void ShowVisas()
        {
           for(int i = 0; i < visas.Count; i++)
            {
                WriteLine(visas[i].ToString());
            }
        }
        public void AddVisas(Visa visa)
        {
              this.visas.Add(visa);
        }
    }
    internal class Visa
    {
        public string? Country;
        public string? Term;
        public string? Type;
        public Visa(string? country, string? term, string? type)
        {
            Country = country;
            Term = term;
            Type = type;
        }
        public override string ToString()
        {
            return $"Type: {this.Type}, Country: {this.Country}, Term: {this.Term}";
        }
    }
}



