using static System.Console;
using System.Threading;
using System.Collections;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.GC;
namespace H_W1_11._07
{
    internal class Program
    {
        static void Task1()
        {
            Console.Write("Enter symbol for drawing square: ");
            char symbol = Convert.ToChar(ReadLine());
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
            try
            {
                DrawingSquare(symbol);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task2()
        {
            string? Digit = null;
            Write("Enter digit: ");
            Digit = ReadLine();
            static bool IsPalindrom(string? Digit)
            {
                for (int i = 0; i <= Digit.Length / 2; i++)
                {
                    if (Digit[i] != Digit[Digit.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            try
            {
                if (IsPalindrom(Digit))
                {
                    WriteLine("Palindrom!");
                }
                else
                {
                    WriteLine("Not a palindrome!");
                };
            }
            catch(IndexOutOfRangeException exOut)
            {
                WriteLine(exOut.Message.ToString());
            }
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
            WriteLine();
            WriteLine("Filter Array[]: ");
            foreach (int i in FiltrArray)
            {
                Write("{0} ", i);
            }
            WriteLine();
            static void Filter(int[] OriginArray, int[] FiltrArray)
            {
                int CountOfChange = 0;
                for (int i = 0; i < FiltrArray.Length; i++)
                {
                    for (int j = 0; j < OriginArray.Length; j++)
                    {
                        if (OriginArray[j] == FiltrArray[i])
                        {
                            Array.Clear(OriginArray, j, 1);
                            CountOfChange++;
                        }
                    }
                }
                Array.Resize<int>(ref OriginArray, (OriginArray.Length - CountOfChange));
            }
                try
                {
                    Filter(OriginArray, FiltrArray);
                    WriteLine("Result: ");
                     foreach (int i in OriginArray)
                     {
                         Write("{0} ", i);
                     }
                }
                catch (IndexOutOfRangeException exOverflow)
                {
                    WriteLine(exOverflow.ToString());
                }
        }
        static void Task4()
        {
            try
            {
                WebSite website = new WebSite();
                website.InputInfo("For sale", "22.21.1.2", "website", "https://****.in.ua");
                website.ShowInfo();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task5()
        {
            try
            {
                Journal journal = new Journal();
                journal.InputInfo("Economics", "+38096****", "Name journal", "journal@gmail.com", "1990");
                journal.ShowInfo();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
            finally
            {
                WriteLine($"Finally");
            }
        }
        static void Task6()
        {
            Shop shop = new Shop();
            try
            {
                shop.InputInfo("Product", "****", "***", "shop@email.com", "Vinnytsia, str  Street");
                if (shop.Phone == null)
                {
                    throw new ArgumentNullException(paramName: nameof(shop.Phone), message: "parameter can't be null.");
                }
                shop.ShowInfo();
                WriteLine($"Use memmory-> {GC.GetTotalMemory(false)}");
            }
            catch (Exception ex)
            {
                WriteLine($"Exeption-> {ex.Message}");
            }
            finally
            {
                shop.Dispose();
            }
        }
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
        }
    };
}

    





    
