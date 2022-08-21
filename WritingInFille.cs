using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using static System.Console;

namespace ConsoleApp4
{
    internal class WritingInFille
    {
        public string? FullPath { get; set; }
        public string? FileName { get; set; }
        public WritingInFille(string? fullPath, string? fileName)
        {
            FullPath = fullPath;
            FileName = fileName;
        }
        public void Writing(string ? Str)
        {
            using (FileStream fFibanacci = new FileStream((@FullPath +"/"+ FileName),
                    FileMode.OpenOrCreate, FileAccess.Write,FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(fFibanacci,
                    Encoding.UTF32))
                {
                    if (File.Exists(@FullPath + "/" + FileName))
                    {
                        sw.Write(Str);
                    }
                    else
                    {
                        throw new FileNotFoundException("File not exist");
                    }
                }
                fFibanacci.Close();
            }
        }
        public void CreateFile()
        {
            using (FileStream fFibanacci = new FileStream((@FullPath + "/" + FileName),
                     FileMode.Create, FileAccess.Write)) ;
        }
    }
}
