using System.Diagnostics;
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArryInt test = new ArryInt(10);
                test.FillRandom(10);
                Console.WriteLine($"Arr []: ");
                test.Output();
                Console.WriteLine();
                int Creater = test.Greater(2);
                int Less = test.Less(8);
                Console.WriteLine($"Qty values less than 8: {Less}");
                Console.WriteLine($"Qty values greater than 2: {Less}");
                Console.WriteLine($"Even values: ");
                test.ShowEven();
                Console.WriteLine();
                Console.WriteLine($"Odd values: ");
                test.ShowOdd();
                Console.WriteLine();
                Console.WriteLine($"Qty uniq values: {test.CountDistinct().ToString()}");
                Console.WriteLine();
                Console.WriteLine($"Qty equal values (2): {test.EqualToValue(2).ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}



