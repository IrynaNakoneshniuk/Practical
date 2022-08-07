using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._28._07
{
    internal interface IPlayer
    {
        string? Name { get; set; }
        int ?Age { get; set; }
        int? YearsExperience { get; set; }
        float? Salary { get; set; }
        string? Activity { get; set; }
        void ShowPlayerInfo();
    }
    internal class Goalkeeper : IPlayer
    {
        public string ?Name { get; set; }
        public int  ?Age { get; set; }
        public int ?YearsExperience { get; set; }
        public float? Salary { get; set; }
        public string ?Activity { get; set; }
        public Goalkeeper(string? name,int? age, int? yearsExperience, float? salary, string? activity)
        {
            Name = name;
            Age = age;
            YearsExperience = yearsExperience;
            Salary = salary;
            Activity = activity;
        }
        public Goalkeeper()
        {
            Name = null;
            Age = null;
            YearsExperience = null;
            Salary = null;
            Activity = null;
        }
        public void ShowPlayerInfo()
        {
            WriteLine($"Name: {Name}, Age: {Age},Experience: {YearsExperience},Activity: {Activity},Salary: {Salary}");
        }
    }
    internal class CenterForward : IPlayer
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int ?YearsExperience { get; set; }
        public float? Salary { get; set; }
        public string? Activity { get; set; }
        public CenterForward(string? name, int? age, int? yearsExperience, float? salary, string? activity)
        {
            Name = name;
            Age = age;
            YearsExperience = yearsExperience;
            Salary = salary;
            Activity = activity;
        }
        public CenterForward()
        {
            Name = null;
            Age = null;
            YearsExperience = null;
            Salary = null;
            Activity = null;
        }
        public void ShowPlayerInfo()
        {
            WriteLine($"Name: {Name}, Age: {Age},Experience: {YearsExperience},Activity: {Activity},Salary: {Salary}");
        }
    }
    internal class Attacker : IPlayer
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int ?YearsExperience { get; set; }
        public float? Salary { get; set; }
        public string? Activity { get; set; }
        public Attacker(string? name, int? age, int? yearsExperience, float? salary, string? activity)
        {
            Name = name;
            Age = age;
            YearsExperience = yearsExperience;
            Salary = salary;
            Activity = activity;
        }
        public Attacker()
        {
            Name = null;
            Age = null;
            YearsExperience = null;
            Salary = null;
            Activity = null;
        }
        public void ShowPlayerInfo()
        {
            WriteLine($"Name: {Name}, Age: {Age},Experience: {YearsExperience},Activity: {Activity},Salary: {Salary}");
        }
    }
}
