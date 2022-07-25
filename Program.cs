using static System.Console;
using static System.Random;
using System.Linq;
using static System.Math;
namespace ConsoleApp2
{
    internal class Program
    {
        public delegate void ArrayDelegat<T>(T[] array1);
        public delegate string F();
        public delegate T AreaDelegat<T>(T parametr1, T parametr2, T parametr3);
        static void PrintArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Write($" {arr[i]}");
            }
        }
        static void Task1()
        {
            try
            {
                int[] Result = new int[10];
                ArrayIntcs array = new ArrayIntcs(10);
                array.Fill();
                array.Print();
                WriteLine();
                ArrayDelegat<int> arrayDelgat = array.FibanacсiDigit;
                arrayDelgat += array.PrimeDigit;
                arrayDelgat += array.EvenValue;
                arrayDelgat +=array.OddValue;
                arrayDelgat(Result);
                foreach(ArrayDelegat<int> item in arrayDelgat.GetInvocationList())
                {
                    item(Result);
                    PrintArr(Result);
                    WriteLine();
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());   
            }
        }
        static void Task2()
        {
            try
            {
                TimeMethod timeMethod = new TimeMethod();
                Func<string> timeFunc = timeMethod.DateNow;
                timeFunc += timeMethod.TimeNow;
                timeFunc += timeMethod.DayOfWeek;
                foreach (Func<string> item in timeFunc.GetInvocationList())
                {
                    WriteLine(item());
                }
                AreaFigure area = new AreaFigure();
                AreaDelegat<double> areaFigure = area.AreaTriangle;
                WriteLine($"Area of Triangle: {areaFigure(2.2, 3.3, 45)}");
                areaFigure = area.AreaRectangle;
                WriteLine($"Area of Rectangle: {areaFigure(8.2, 7.3, 45)}");
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task3()
        {
            try
            {
               Running run =new Running();
                run.Run();
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();

        }
    }
}