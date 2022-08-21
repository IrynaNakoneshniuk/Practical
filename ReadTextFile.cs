using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    internal class ReadTextFile
    {
        public string? Text { get; set; }
        public string? FileName { get; set; }
        public string? ReadFile(FileInfo fileInfo)
        {
            if (File.Exists(fileInfo.ToString()))
            {
                using (FileStream fs = fileInfo.OpenRead())
                {
                    byte[] readBytes = new byte[(int)fs.Length];
                    fs.Read(readBytes, 0, readBytes.Length);
                    return Encoding.Default.GetString(readBytes);
                    fs.Close();
                }
            }
            else
            {
                throw new FileNotFoundException("File not exists");
            }
            
        }
    }
}
