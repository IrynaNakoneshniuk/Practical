using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ScreenDiagonal
{
    public class GetScreendiagonal
    {
        public void Screendiagonal()
        {
            double width = 0;
            double height = 0;
            double diagonal = Math.Sqrt(width * width + height * height);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\root\wmi", @"SELECT * FROM WmiMonitorBasicDisplayParams");
            foreach (ManagementObject obj in searcher.Get())
            {
                width = (byte)obj["MaxHorizontalImageSize"] / 2.54;
                height = (byte)obj["MaxVerticalImageSize"] / 2.54;
                diagonal = Math.Sqrt(width * width + height * height);

            }
            Console.WriteLine("Monitor Size: {0:F1}\"", diagonal);
        }
    }
}
