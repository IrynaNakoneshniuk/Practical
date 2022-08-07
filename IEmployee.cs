using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace H_W._28._07
{
    internal interface IEmployee
    {
        string? Name { get; set; }
        int? Age { get; set; }
        int? YearsExperience { get; set; }
        float? Salary { get; set; }
        string? Activity { get; set; }
        void ShowEmployeeInfo();
    }
    internal class Waiter : IEmployee
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int? YearsExperience { get; set; }
        public float? Salary { get; set; }
        public string? Activity { get; set; }
        public Waiter(string? name, int? age, int? yearsExperience, float? salary, string? activity)
        {
            Name = name;
            Age = age;
            YearsExperience = yearsExperience;
            Salary = salary;
            Activity = activity;
        }
        public Waiter()
        {
            Name = null;
            Age = null;
            YearsExperience = null;
            Salary = null;
            Activity = null;
        }
        public void ShowEmployeeInfo()
        {
            WriteLine($"Name: {Name}, Age: {Age},Experience: {YearsExperience},Activity: {Activity},Salary: {Salary}");
        }
    }
    internal class Cashier: Waiter
    {
        public Cashier(string? name, int? age, int? yearsExperience, float? salary, string? activity)
        {
            Name = name;
            Age = age;
            YearsExperience = yearsExperience;
            Salary = salary;
            Activity = activity;
        }
    }
    internal class Manager : Waiter
    {
        public Manager(string? name, int? age, int? yearsExperience, float? salary, string? activity)
        {
            Name = name;
            Age = age;
            YearsExperience = yearsExperience;
            Salary = salary;
            Activity = activity;
        }
    }
}
