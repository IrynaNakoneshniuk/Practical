using System.IO;
using System.Text;
using static System.Console;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Task1()
        {
            try
            {
                string? PathFibanacci = @"C:\Users\ZbooK\source\repos\ConsoleApp4";
                string? NameFibanacci = "fibanacci.txt";
                string ?PathPrimeDigit = @"C:\Users\ZbooK\source\repos\ConsoleApp4";
                string? NamePrime = "prime.txt";
                ArrInt arrInt = new ArrInt(100);
                arrInt.FillRandom(100);
                WritingInFille writingInFilleFibanacci = new WritingInFille(PathFibanacci, NameFibanacci);
                writingInFilleFibanacci.CreateFile();
                RangeElement rangeElement = new RangeElement();
                string? FibanacciNumbers = arrInt.ConvertArrInString(rangeElement.ReturnFibanacciArr(arrInt.TestArr));
                writingInFilleFibanacci.Writing(FibanacciNumbers);
                WritingInFille writingInFillePrime = new WritingInFille(PathPrimeDigit, NamePrime);
                writingInFillePrime.CreateFile();
                string?PrimeNumbers= arrInt.ConvertArrInString(rangeElement.ReturnPrimeArr(arrInt.TestArr));
                writingInFillePrime.Writing(PrimeNumbers);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task2()
        {
            try
            {
               string Path = @"C:\Users\ZbooK\source\repos\ConsoleApp4";
                string NameFile = "myFile.txt";
               FileInfo fileInfo = new FileInfo((Path+ "/" + NameFile));
               WritingInFille writingInFille = new WritingInFille(Path, NameFile);
                ReadTextFile readTextFile= new ReadTextFile();
               StringBuilder sb = new StringBuilder();
               string? forReplace = null; 
               string ? toReplace = null;
                WriteLine("Current text: ");
                WriteLine(readTextFile.ReadFile(fileInfo));
                WriteLine("Enter a word for replace: ");
               forReplace = ReadLine();
               WriteLine("Enter a new word : ");
               toReplace= ReadLine();
                WriteLine(sb.ToString());
               sb.Append(readTextFile.ReadFile(fileInfo));
               sb.Replace(forReplace, toReplace);
               writingInFille.Writing(sb.ToString());
                WriteLine();
                WriteLine("After replacing: ");
                WriteLine(sb);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static  void Task3()
        {
            try
            {
                WriteLine("Enter a path to the file: ");
                string? Path = ReadLine();
                WriteLine("Enter a name of file: ");
                string? NameFile = ReadLine();
                WriteLine("Enter a text: ");
                string? Text = ReadLine();
                StringBuilder sb = new StringBuilder();
                FileInfo fileInfo = new FileInfo((Path + "/" + NameFile));
                ReadTextFile readTextFile = new ReadTextFile();
                string[] ?strings = Text.Split();
                sb.Append(readTextFile.ReadFile(fileInfo));
                for(int i = 0; i < strings.Length; i++)
                {
                    sb.Replace(strings[i], "***");
                }
                WritingInFille writingInFille = new WritingInFille(Path, NameFile);
                writingInFille.Writing(sb.ToString());
                WriteLine();
                WriteLine("After replacing: ");
                WriteLine(sb);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task4()
        {
            try
            {
                WriteLine("Enter a path to the file: ");
                string? Path = ReadLine();
                string? newFile = "myFile2.txt";
                WriteLine("Enter a name of file: ");
                string? NameFile = ReadLine();
                FileInfo fileInfo2 = new FileInfo((Path + "/" + newFile));
                FileInfo fileInfo = new FileInfo((Path + "/" + NameFile));
                ReadTextFile readTextFile = new ReadTextFile();
                WritingInFille writingInFille = new WritingInFille(Path, newFile);
                StringBuilder sb = new StringBuilder();
                sb.Append(readTextFile.ReadFile(fileInfo));
                char[]? text = sb.ToString().ToCharArray();
                Array.Reverse(text);
                string reversString = new string (text);
                WriteLine(reversString.ToString());
                writingInFille.Writing(reversString);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
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