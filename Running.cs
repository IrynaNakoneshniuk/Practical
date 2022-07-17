using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._21._07._22
{
    internal class Running
    {
        public Menu menu;
        public char? Choise;
        public Running()
        {
            menu = new Menu();
            Choise = null;
        }
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                menu.PrintList();
                menu.PrintMenu();
                try
                {
                    Write("To do choise: ");
                    Choise = Convert.ToChar(ReadLine());
                    if (Choise == '1')
                    {
                        menu.MenuItem1();
                    }
                    else if (Choise == '2')
                    {
                        menu.MenuItem2();
                    }
                    else if (Choise == '3')
                    {
                        menu.MenuItem3();
                    }
                    else if (Choise == '4')
                    {
                        return;
                    }
                    else
                    {
                        WriteLine("Uncorrect value");
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message.ToString());
                }
            }
        }
    
    }
}
