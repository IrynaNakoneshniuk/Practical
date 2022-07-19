using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;

namespace H_W._25._07
{
    internal  interface ISwap<T>
    {
        void Swap(T firstV,  T secondV);
    }
    internal class TestArray : ISwap<int>
    {
        public int[] TestArr;
        public int? Length;
        public TestArray(int Length)
        {
            this.Length = Length;
            TestArr = new int[Length];
        }
        public void FillRandom(int Max)
        {
            Random rnd = new Random();
            for (int i = 0; i < TestArr.Length; i++)
            {
                TestArr[i] = rnd.Next(Max);
            }
        }
        public void Output()
        {
            foreach (int i in TestArr)
            {
                Console.Write($" {i}");
            }
        }
        public void Swap(int index1,  int index2)
        {
            int Temp = this.TestArr[index1];
            this.TestArr[index1] = this.TestArr[index2];
            this.TestArr[index2] = Temp;
        }
    }
}

