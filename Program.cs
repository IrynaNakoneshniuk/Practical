using static System.Console;
using static System.Random;

namespace H_W._25._07
{
    internal class Program
    {
        static void Task1()
        {
            try
            {
                TestArray array = new TestArray(5);
                array.FillRandom(10);
                array.Output();
                WriteLine();
                WriteLine("--------Array after swap first and last position--------");
                array.Swap(1, 4);
                array.Output();
            }catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());   
            }
        }
        static void Task2()
        {
            try
            {
                Write("Queue: ");
                Random random = new Random();
                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < 5; i++)
                {
                    queue.Push(i, i);
                }
                queue.Print();
                WriteLine();
                WriteLine($"Peek: {queue.Peek()}");
                queue.Pop();
                queue.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task3()
        {
            try
            {
                Write("Queue: ");
                Random random = new Random();
                QueueRing <int> queue = new QueueRing<int>(5);
                for(int i = 0; i < 5; i++)
                {
                    queue.Push(i);
                }
                queue.Print();
                queue.Move();
                WriteLine("Queue after moving: ");
                queue.Print();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
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