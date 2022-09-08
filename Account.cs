using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
    
    public class Account
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string ? LastName { get; set; }
        public string? Created { get; set; }
        public static int ? NumberID { get; set; }
        public static int numberID;
        public string ? Password { get; set; }
        public Account(string? name, string? surname, string? lastName)
        {
            Name = name;
            Surname = surname;
            LastName = lastName;
            Created = DateTime.Now.ToString();
            numberID++;
        }
        public Account()
        {
            Name = null;
            Surname = null;
            LastName = null;
            Created = DateTime.Now.ToString();
            numberID++;
        }       
        public virtual void CreatedAccount() { }
       
        public override string ToString()
        {
            return $"{LastName},  {Name} ,{Surname} " +
                $" \nID: {numberID}, :Created:  {Created}";
        }
    }
}
