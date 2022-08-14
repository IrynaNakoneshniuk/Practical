using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using static System.Console;
using System.Drawing;

namespace H_W._12._08
{
    public delegate String AnonimDelegatGetRGB(Color c);
    internal class ShowRgb
    {
        public event AnonimDelegatGetRGB ? eventGetRgb;
        public String  GetRgb(Color c)
        {
            if(eventGetRgb != null)
            {
               return eventGetRgb(c);
            }
            throw new NullReferenceException();
        }
    }
}
