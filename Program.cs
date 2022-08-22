using System.IO;
using System.Text;
using static System.Console;

namespace H_W_27_08
{
    internal class Program
    {
        static void Task1_2()
        {
            try
            {
                string[] fileEntries = Directory.GetFiles(@"C:\Users\ZbooK\source\repos\H_W_27_08","*.txt",
                    SearchOption.AllDirectories);
                Console.WriteLine("All txt file: ");
                foreach (string file in fileEntries)
                {
                    Console.WriteLine(file);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        static void Task3_4_5()
        {
            try
            {
                WriteLine("Input path in file: ");
                string? Path = ReadLine();
                WriteLine("Input mask of file: ");
                string ?Mask=ReadLine();
                var dir = new DirectoryInfo(Path);
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    foreach (FileInfo file in subDir.GetFiles(Mask))
                    {
                        file.Delete();
                    }
                    subDir.Delete(true);
                }
                FileInfo[] fileL = dir.GetFiles(Mask);
               foreach(FileInfo file in fileL)
                {
                    file.Delete();
                }

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        static void Task6()
        {
            try
            {
                WriteLine("Input path in file: ");

                string? Path = ReadLine();
                var dir = new DirectoryInfo(Path);
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    foreach (FileInfo file in subDir.GetFiles("*.*"))
                    {
                        WriteLine(file.FullName);
                    }
                    WriteLine(subDir.FullName);
                }
                FileInfo[] fileL = dir.GetFiles("*.*");
                foreach (FileInfo file in fileL)
                {
                    WriteLine(file.FullName);
                }
            }  
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        static void Main(string[] args)
        {
            //Task3_4_5();
            //Task1_2();
            Task6();
        }
    }
}