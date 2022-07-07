using static System.Console;
using System.Threading;
using System.Collections;

namespace H_W1_11._07
{
    internal class Program
    {
        static void Task1()
        {
            Console.Write("Enter symbol for drawing square: ");
            char symbol =Convert.ToChar (ReadLine());
            static void DrawingSquare(char symbol)
            {
                int MaxSideSize = 11;
                for (int i = 3; i < MaxSideSize; i++)
                {
                    Console.SetCursorPosition(i, 3);
                    Console.Write(symbol);
                    Console.SetCursorPosition(3, i);
                    Console.Write(symbol);
                    Console.SetCursorPosition(i, MaxSideSize - 1);
                    Console.Write(symbol);
                    Console.SetCursorPosition(MaxSideSize - 1, i);
                    Console.Write(symbol);
                    Thread.Sleep(1000);
                }
            }
            DrawingSquare(symbol);
        }
        static void Task2()
        {
            int ?Digit = 0;
            Write("Enter digit: ");
            Digit= Convert.ToInt32(ReadLine());
            static  bool IsPalindrom(int? digit)
            {
                string? Digit= digit.ToString();
                for(int i = 0; i <= Digit.Length / 2; i++)
                {
                    if(Digit[i] != Digit[Digit.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (IsPalindrom(Digit))
            {
                WriteLine("Palindrom!");
            }
            else
            {
                WriteLine("Not a palindrome!");
            };
        }
        static void Task3()
        {
           
            int[] OriginArray = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] FiltrArray = new int[3] { 2, 3, 4 };
            WriteLine("Origin Array[]: ");
            foreach (int i in OriginArray)
            {
                Write("{0} ", i);
            }
            WriteLine("Filter Array[]: ");
            foreach (int i in FiltrArray)
            {
                Write("{0} ", i);
            }
            static void Filter(int[] OriginArray, int[]FiltrArray)
            {
                int CountOfChange = 0;
                for (int i = 0; i < FiltrArray.Length; i++)
                {
                    for(int j = 0; j < OriginArray.Length; j++)
                    {
                        if(OriginArray[j] == FiltrArray[i])
                        {
                            Array.Clear (OriginArray, j,1);
                            CountOfChange++;
                        }
                    }
                }
                Array.Resize<int>(ref OriginArray, (OriginArray.Length - CountOfChange));
            }
            Filter(OriginArray, FiltrArray);
            WriteLine("Result: ");
            foreach (int i in OriginArray)
            {
                Write("{0} ", i);
            }
        }
        static void Task4()
        {
            WebSite website = new WebSite();
            website.InputInfo("For sale", "22.21.1.2","website", "https://****.in.ua");
            website.ShowInfo();
        }
        static void Task5()
        {
            Journal journal = new Journal();
            journal.InputInfo("Economics", "+38096****", "Name journal", "journal@gmail.com", "1990");
            journal.ShowInfo();
        }
        static void Task6()
        {
            Shop shop = new Shop();
            shop.InputInfo("Product","+0432***","***","shop@email.com","Vinnytsia, str  Street");
            shop.ShowInfo();
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
        }
    }
}