using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Running
    {
        private Menu _menu;
        public Running()
        {
            _menu = new Menu();
        }
        public void Run()
        {
            CreditCard card = new CreditCard("Iryna",5169306710186667,"31/07/22",10000);
            this._menu.FillListEvenet(card);
            int choise = 0;
            while (true)
            {
                Console.Clear();
                this._menu.PrintMenu();
                Write("Choice a item of menu: ");
                choise = Convert.ToInt32(ReadLine());
                if (choise == 4)
                {
                    return;
                }
                else if (this._menu._sortedEvents[choise - 1] != null)
                {
                    this._menu._sortedEvents[choise - 1]();
                    card.PrintInfo();
                }
                else
                {
                    throw new KeyNotFoundException("Uncorrect Value");
                }
                Thread.Sleep(1500);
            }
        }
    }
}
