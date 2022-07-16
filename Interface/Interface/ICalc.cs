using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);

    }
    internal interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    internal interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
