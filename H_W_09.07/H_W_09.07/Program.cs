using System;
using System.Collections;
using System.Threading;
using System.Text;
using System.Globalization;
using System.Runtime;


namespace H_W_09._07
{
    internal class Program
    {
        static void Task1()
        {
            Random rand = new Random();
            int[]? A = new int[5];
            int Max = 0;
            int Min = 0;
            int Sum = 0;
            int SumA = 0;
            int SumB=0;
            Sum = A.Sum();
            Console.WriteLine("Enter value fo arry A[]: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"N-{i} ");
                A[i] = Convert.ToInt32(Console.ReadLine());
                if(A[i] % 2 == 0)
                {
                    SumA += A[i];
                }
            }
            int SizeColmn = 4;
            int SizeRow = 3;
            int[][] B = new int[SizeRow][];
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = new int[SizeColmn]; 
            }
            Console.WriteLine("Arry B[][]: ");
            for (int i = 0; i < B.Length; i++)                                
            {
                for (int j = 0; j < SizeColmn; j++)                                
                {
                    B[i][j] = rand.Next(1,10);
                    Console.Write(B[i][j] + " ");
                    Sum += B[i][j];
                    if (j % 2 != 0)
                    {
                        SumB += B[i][j];
                    }
                }
                Console.WriteLine();
            }
            Array.Sort(A);
            for(int i = A.Length-1; i >=0 ; i--)
            {
                for(int j = 0; j < SizeRow; j++)
                {
                    for(int k = 0; k < SizeColmn; k++)
                    {
                        if (A[i] == B[j][k])
                        {
                            Max = B[j][k];
                             break;
                        }
                    }
                    if (Max > 0)
                    {
                        break;
                    }
                }
                if (Max > 0)
                {
                    break;
                }
            }
            for (int i = 0; i <A.Length; i++)
            {
                for (int j = 0; j < SizeRow; j++)
                {
                    for (int k = 0; k < SizeColmn; k++)
                    {
                        if (A[i] == B[j][k])
                        {
                            Min = B[j][k];
                            break;
                        }
                    }
                    if (Min > 0)
                    {
                        break;
                    }
                }
                if (Min > 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Max: {Max}");
            Console.WriteLine($"Min: {Min}");
            Console.WriteLine($"Total sum: {Sum}");
            Console.WriteLine($"Sum even elemnts in array A: {SumA}");
            Console.WriteLine($"Sum  elemnts in array B: {SumB}");
        }
        static void Task2()
        {
            Random rand = new Random();
            int Size = 5;
            int Sum = 0; int k = 0;
            int[,] Arr = new int[Size, Size];
            int[] Arr2 = new int[Size * Size];
            int Max = Arr2.Max();
            int Min = Arr2.Min();
            int IndexM = Array.IndexOf(Arr2, Max);
            int IndexMin = Array.IndexOf(Arr2, Min);
            int MaxIndex = Math.Max(IndexM, IndexMin);
            int MinIndex = Math.Min(IndexM, IndexMin);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Arr[i, j] = rand.Next(-100, 100);
                    Console.Write("{0,-6}",$"{Arr[i, j]}");
                    Arr2[k] = Arr[i,j];
                    k++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elements between min and max value");
            for (int i = MaxIndex-1; i >MinIndex; i--)
            {
                Console.Write("{0,-6}", $"{Arr2[i]}");
                Sum += Arr2[i];
            }
            Console.Write("{0,-6}", $"Sum {Sum}");
            Thread.Sleep(2000);
        }

        static void Task3()
        {
            Console.WriteLine("Enter string for encryption ");
            string? Temp = Console.ReadLine();
            StringBuilder sb = new StringBuilder(Temp);
            for(int i = 0; i < sb.Length; i++)
            {
                sb[i] =(char)((int)sb[i] + 3);
            }
            Console.WriteLine(sb);
            Console.WriteLine("Decrypt");
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i] = (char)((int)sb[i] -3);
            }
            Console.WriteLine(sb);
        }
        static void Task4()
        {
            Random rnd = new Random();
            int Size = 3;
            int[,] Arr = new int[Size, Size];
            Console.WriteLine("Arr1[][]");
            for (int i = 0; i < Size; i++)
            {
              for(int j = 0; j < Size; j++)
               {
                    Arr[i,j] = rnd.Next(1,10);
                    Console.Write("{0,-6}", $"{Arr[i, j]}");
               }
                Console.WriteLine();
            }
            Console.WriteLine ("Arr2[][]: Multiplication (Arr1[][]*3)");
            int[,] ArrMultip = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    ArrMultip[i, j] = Arr[i,j]*3;
                    Console.Write("{0,-6}", $"{ArrMultip[i, j]}");
                }
                Console.WriteLine();
            }
            int[,] ArrAdd = new int[Size, Size];
            Console.WriteLine("Adding (Arr1[][]+Arr2[][]");
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    ArrAdd[i, j] = Arr[i, j] + ArrMultip[i, j];
                    Console.Write("{0,-6}", $"{ArrAdd[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static void Task5()
        {
            int k = 2;
            int? Result = null;
            string? ArithmeticExpretion = null;
            Console.Write("Enter arithmetic expression: ");
            ArithmeticExpretion=Console.ReadLine();
            string[] subs=ArithmeticExpretion.Split('-', '+');
            int[] ArrayDigit = new int[ArithmeticExpretion.Length+10];
            Result = int.Parse(subs[0]);
            for (int i = 1; i <subs.Length ; i++)
            {
                ArrayDigit[k] = int.Parse(subs[i]);
                k += 2;
            }
            for (int i = 1; i <ArithmeticExpretion.Length; i++)
            {
                if (ArithmeticExpretion[i] == '+')
                {
                    Result += ArrayDigit[i+1];
                }
                else if (ArithmeticExpretion[i] == '-')
                {
                    Result -= ArrayDigit[i+1];
                }
            }
            Console.WriteLine($"Result {Result}");
        }
        static void Task6()
        {
            Console.Write("Enter string: ");
            CultureInfo culture = new CultureInfo("en-US");
            string? Temp = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(Temp);
            stringBuilder[0] = Char.ToUpper(stringBuilder[0], culture);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == '.')
                {
                    i++;
                    while (stringBuilder[i] == ' ')
                    {
                        i++;
                    }
                    stringBuilder[i] = Char.ToUpper(stringBuilder[i], culture);
                }
            }
            Console.Write("New string: ");
            Console.Write(stringBuilder.ToString());
        }

        static void Task7()
        {
            int AmountOfLine = 0;
            StringBuilder stringBuilder = new StringBuilder();
            int CounterPeplace = 0;
            Console.Write("Enter word for replace: ");
            string? WordForReplace = Console.ReadLine();
            Console.Write("Enter amount of line: ");
            AmountOfLine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter text: ");
            for(int i = 0; i < AmountOfLine; i++)
            {
                string? Temp = Console.ReadLine();
                stringBuilder.AppendLine(Temp);
                if (Temp.Contains(WordForReplace))
                {
                    CounterPeplace++;
                }
            }
            stringBuilder.Replace(WordForReplace, "***");
            Console.Write("New text: ");
            Console.Write(stringBuilder.ToString());
            Console.Write($"change statistics: {CounterPeplace}") ;
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