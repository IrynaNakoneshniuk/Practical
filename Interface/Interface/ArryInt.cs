using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;

namespace Interface
{
    internal class ArryInt : ICalc, IOutput2, ICalc2
    {
        public int[] TestArr;
        public int? Length;
        public ArryInt(int Length)
        {
            this.Length = Length;
            TestArr = new int[Length];
        }
        public int Greater(int valueToCompare)
        {
            int CounterGreaterValue = 0;
            for(int i = 0; i < TestArr.Length; i++)
            {
                if(TestArr[i] > valueToCompare)
                {
                    CounterGreaterValue++;
                }
            }
            return CounterGreaterValue;
        }
        public int Less(int valueToCompare)
        {
            int CounterLessValue = 0;
            for (int i = 0; i < TestArr.Length; i++)
            {
                if (TestArr[i] < valueToCompare)
                {
                    CounterLessValue++;
                }
            }
            return CounterLessValue;
        }
        public void FillRandom(int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < TestArr.Length; i++)
            {
                TestArr[i]=rnd.Next(Max);
            }
        }
        public void  Output()
        {
            foreach(int i in TestArr)
            {
                Console.Write($" {i}");
            }
        }

        public void ShowEven()
        {
            foreach (int i in TestArr)
            {
                if(i % 2 == 0)
                {
                    Console.Write($" {i}");
                }
            }
        }
        public void ShowOdd()
        {
            foreach (int i in TestArr)
            {
                if (i % 2 != 0)
                {
                    Console.Write($" {i}");
                }
            }
        }
        public int CountDistinct()
        {
            int Count = 0;
            for(int i = 0; i < TestArr.Length; i++)
            {
                bool Distinct = true;
                for (int j = 0; j < TestArr.Length; j++)
                {
                    if(TestArr[i] == TestArr[j]&&i!=j)
                    {
                        Distinct = false;
                    }
                }
                if(Distinct)
                {
                    Count++;
                }
            }
            return Count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int j = 0; j < TestArr.Length; j++)
            {
                if (TestArr[j] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
