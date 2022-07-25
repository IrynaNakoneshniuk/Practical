using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    public delegate void CardDelegat();
    internal class Menu
    {
        public SortedList<int, CardDelegat> _sortedEvents =
            new SortedList<int, CardDelegat>();
        public event CardDelegat eventCard
        {
            add
            {
                for(int key=0; ;)
                {
                    if (!_sortedEvents.ContainsKey(key))
                    {
                        _sortedEvents.Add(key, value);
                        break;
                    }
                    key++;
                }
            }
            remove
            {
                _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
            }
        }
       public void FillListEvenet(CreditCard _creditCard)
       {
            eventCard+=_creditCard.WithdrawFunds;
            eventCard+=_creditCard.СrediFunds;
            eventCard += _creditCard.ChangePin;
       }
        public void PrintMenu()
        {
            WriteLine("1-Withdraw funds");
            WriteLine("2-Сredit funds");
            WriteLine("3-Change Pin");
            WriteLine("4-Exit");
        }
    }
}
