using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class CreditCard
    {
        public string? Name { get; set; }
        public long? NumberCard { get; set; }
        public DateTime ExpireDate { get; set; }
        public float ? CreditLimit { get; set; }
        public float ? BankBalance { get; set; }
        public int Pin { get; set; }
        public CreditCard(string ?name, long? NumberCard,string expiryDate, float? CreditLimit)
        {
            this.NumberCard = NumberCard;
            this.ExpireDate =Convert.ToDateTime(expiryDate);
            this.CreditLimit = CreditLimit;
            this.Name = name;
            this.BankBalance= CreditLimit;
        }
       public void WithdrawFunds()
       {
            float sum = 0;
            Write("Enter sum for withdraw funds:  ");
            sum = (float)Convert.ToDouble(ReadLine());
            if (IsUseCreditLimit())
            {
                WriteLine("Using a credit funds");
            }
            this.BankBalance-=sum;
       }
        public bool IsUseCreditLimit()
        {
            return this.CreditLimit == this.BankBalance;
        }
        public void СrediFunds()
        {
            Write("Enter the amount to top up:  ");
            float sum = (float)Convert.ToDouble(ReadLine());
            this.BankBalance += sum;
        }
        public void ChangePin()
        {
            Write($"Enter new pin: ");
            int newPin=Convert.ToInt32(ReadLine());
            this.Pin = newPin;
        }
        public void PrintInfo()
        {
            WriteLine($"Card {this.NumberCard}, Name: {this.Name}, Bank balance: {this.BankBalance}");
        }
    }
}
