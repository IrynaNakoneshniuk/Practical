using static  System.Console;
using  System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Task1()
        {
            int ? digit = 0;
            Write("Input digit between 1 and 100: ");
            digit= Convert.ToInt16(ReadLine());
            if (digit < 1 || digit > 100)
            {
                WriteLine("Error!");
            }
            else if( digit%5 is 0&& digit % 3 is 0)
            {
                WriteLine("Fizz Buzz");
            }
            else if (digit % 5 is 0)
            {
                WriteLine("Buzz");
            }
            else if (digit % 3 is 0)
            {
                WriteLine("Fizz");
            }
            else if(digit % 5 != 0 && digit % 3 != 0)
            {
                WriteLine($"Digit{digit}");
            }
        }
        static void Task2()
        {
            int Digit = 0;
            double Procent = 0;
            Write("Input first digit: ");
            Digit = Convert.ToInt32(ReadLine());
            Write("Input second digit: ");
            Procent = Convert.ToDouble(ReadLine());
            Procent /= 100;
            Write($"Result:{(Procent * Digit)}");
        }

        static void Task3()
        {
            int Digit1=0,Digit2=0, Digit3=0, Digit4=0, Digit5=0;
            WriteLine("Input  digits");
            Write("1 - digit: ");
            Digit1 = Convert.ToInt32(ReadLine());
            Write("2 - digit: ");
            Digit2 = Convert.ToInt32(ReadLine());
            Write("3 - digit: ");
            Digit3 = Convert.ToInt32(ReadLine());
            Write("4 - digit: ");
            Digit4 = Convert.ToInt32(ReadLine());
            Digit5=(Digit1*1000)+(Digit2*100)+(Digit3*10)+Digit4;
            WriteLine($"Result: {Digit5}");
        }
        static void Task4()
        {
            string? Temp = "";
            int Digit2=0, Digit3=0;
            do
            {
                Write("Input six-digit ");
                Temp=Convert.ToString(ReadLine());

            } while (Temp.Length< 6);
            StringBuilder ReversDigit = new StringBuilder(Temp);
            WriteLine("Input position for revers ");
            Write("First position: ");
            Digit2 =Convert.ToInt32(ReadLine())-1;
            Write("Second position: ");
            Digit3 = Convert.ToInt32(ReadLine())-1;
            char Temp2 = ReversDigit[Digit3];
            ReversDigit[Digit3] = ReversDigit[Digit2];
            ReversDigit[Digit2] = Temp2;
            WriteLine(ReversDigit);
        }
        static void Task5()
        {
            string? Date = null;
            WriteLine("Enter the date: ");
            Date=ReadLine();
            DateTime ParsedDate= DateTime.Parse(Date, System.Globalization.CultureInfo.InvariantCulture);
            if(ParsedDate.Month==12|| ParsedDate.Month==1|| ParsedDate.Month == 2)
            {
                Write("Winter ");
            }
            else if(ParsedDate.Month == 3 || ParsedDate.Month == 4 || ParsedDate.Month == 5)
            {
                Write("Spring ");
            }
            else if(ParsedDate.Month == 6 || ParsedDate.Month == 7 || ParsedDate.Month == 8)
            {
                Write("Summer ");
            }
            else if(ParsedDate.Month == 9 || ParsedDate.Month == 10 || ParsedDate.Month == 11)
            {
                Write("Autum ");
            }
            WriteLine(ParsedDate.DayOfWeek.ToString());
        }
        static void Task6()
        {
            int? choise = null;
            int? Digit = null;
            int? Fahrenheit = null;
            int? Celsius = null;
            do
            {
                Clear();
                SetCursorPosition(10, 2);
                WriteLine("Enter the temperature value: ");
                Digit = Convert.ToInt32(ReadLine());
                WriteLine("1- Fahrenheit");
                WriteLine("2- Celsius");
                WriteLine("3-Exit");
                choise = Convert.ToInt32(ReadLine());
                if (choise == 1)
                {
                    Fahrenheit = (Digit * 9) / 5 + 32;
                    WriteLine(Fahrenheit.ToString());
                }
                else if (choise == 2)
                {
                    Celsius = (Digit - 32) * (5 / 9);
                    WriteLine(Celsius.ToString());
                }
                else if (choise == 3)
                {
                    return;
                }
                else
                {
                    WriteLine("Uncorrect value");
                }
                Thread.Sleep(1000);

            } while (true);
        }
        static void Task7()
        {
            int? DigitFirst = null;
            int? DigitSecond = null;
            int Max=0;
            int Min=0;
            Write("Enter first digit: ");
            DigitFirst = Convert.ToInt32(ReadLine());
            Write("Enter second digit: ");
            DigitSecond= Convert.ToInt32(ReadLine());
            Max= Math.Max(((byte)DigitFirst),(byte) DigitSecond);
            Min = Math.Min(((byte)DigitFirst), (byte)DigitSecond);
            for (int i = Min; i <=Max; i++)
            {
                if (i % 2 == 0)
                {
                    Write("{0,-10}",i.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Task7();

        }
    }
}