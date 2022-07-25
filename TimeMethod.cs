using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Math;

namespace ConsoleApp2
{
    internal class TimeMethod
    {
        public string TimeNow()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
        public string DateNow()
        {
            return DateTime.Now.ToString("yyyy-MM-dd "); 
        }
        public string DayOfWeek()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }

    }
    internal class AreaFigure
    {
        public double AreaTriangle(double Side1,double Side2, double Angel)
        {
            return 0.5*(Side1*Side2)*(Sin(Angel));
        }
        public double AreaRectangle(double Diagonal1, double Diagonal2, double Angel)
        {
            return 0.5 * (Diagonal1 * Diagonal2) * (Sin(Angel));
        }
    }
}
