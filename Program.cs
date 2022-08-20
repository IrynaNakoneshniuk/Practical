using System.Linq;
using static System.Console;
namespace linq
{
    internal class Program
    {
        static void Task1()
        {
            try
            {
                int[] arrTest = new int[] { 1, 2, -7, -9, 3, 0, 8, -2, -1, 8 };
                var query = from i in arrTest group i by i < 0 into res select res;
                var pos = query.AsEnumerable().Where(i => i.Key == false).First().First();
                var neg = query.AsEnumerable().Where(i => i.Key == true).Last().Last();
                Console.WriteLine("The array: ");
                foreach (var item in query)
                {
                    foreach (var elem in item)
                    {
                        Console.Write($"{elem}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(pos);
                Console.WriteLine(neg);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task2()
        {
            try
            {
                int[] A = new int[] { 12, 45, 32, 43, 67, 62, 72 };
                int D = 2;
                IEnumerable<int> query = from i in A
                                         where i % 10 == D && i > 0
                                         select i;
                Console.WriteLine("First element in sequense: ");
                Console.WriteLine(query.First());
            }catch(InvalidOperationException ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task3()
        {
            try
            {
                string[] A = { "4ll the world's a stage," ,
               "4 all the men and women merely players;," +
               "They have their exits and their entrances,",
                "And one man in his time plays many parts,",
                 "His acts being seven ages…"};
                int L = 24;
                IEnumerable<string>? query = from i in A
                                             where i.Length == L
                                             where Char.IsDigit(i[0]) == true
                                             select i;
                string? Str = "Not found";
                string? Temp = query.Last() ?? Str;
                Console.WriteLine(Temp);
            }catch(InvalidOperationException ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task4()
        {
            int[] Arr = new int[] { 23, -12, 67, 34, 67, 23, 54, 89, -37, -67, 89 };
            IEnumerable<int>? query = from i in Arr.Select(i => i % 10).Where(i => i > 0).Distinct()
                                      select i;
            foreach(int i in query)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }
    }
}