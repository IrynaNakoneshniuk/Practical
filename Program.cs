using static System.Console;
using System.Threading;
namespace H_W._21._07._22
    
{
    internal class Program
    {
       static void Task1()
        {
            try
            {
                Journal journal1=new Journal();
                Journal journal2=new Journal();
                journal1.InputInfo("For sale", "+432***", "Journal1","journal@gmail.com", "1990", 50);
                journal2.InputInfo("For sale", "+432***", "Journal1", "journal@gmail.com", "1990", 50);
                journal1.ShowInfo();
                journal1 = journal1 -20;
                journal2 = journal2 - 20;
                journal1.ShowInfo();
                if (journal1 == journal2)
                {
                    WriteLine("Objects is equal");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task2()
        {
            try
            {
                Shop shop1 = new Shop();
                Shop shop2 = new Shop();
                shop1.InputInfo("Product", "+0432***", "Shop Name", "shop@email.ua", "str Sreet 1", 100.3);
                shop2.InputInfo("Product", "+0432***", "Shop Name", "shop@email.ua", "str Sreet 1", 100.3);
                shop1.ShowInfo();
                shop1 += 20;
                shop2 += 20;
                shop1.ShowInfo();
                if(shop2 == shop1)
                {
                    WriteLine("Objects is equal");
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message.ToString());
            }
        }
        static void Task3()
        {
           Running running= new Running();
            running.Run();
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }
    }
}