using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Random;

namespace ConsoleApp2
{
    internal class ArrayIntcs
    {
        private int[] array;
        private int length;
        public ArrayIntcs(int length)
        {
            this.array = new int[length] ;
            this.length = length;
        }
        public void Print()
        {
            foreach(int i in this.array)
            {
                Console.Write($" {i}");
            }
        }
        public void Fill()
        {
            Random rnd = new Random();
            for(int i = 0; i < this.length; i++)
            {
                this.array[i] = rnd.Next(50);
            }
        }
        public void EvenValue(int[] array1)
        {
            int j = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] % 2 == 0)
                {
                    array1[i] = this.array[i];
                    j++;
                }
            }
        }
        public void OddValue(int[] array1)
        {
            int j = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] % 2 != 0)
                {
                    array1[i] = this.array[i];
                    j++;
                }
            }
        }
        public void PrimeDigit(int[] array2)
        {
            int j = 0;
            for (int i = 0; i <this.array.Length; i++)
            {
                bool IsPrime = true;
                for (int j2 = 2; j2 < this.array[i]; j2++)
                {
                    if (this.array[i] % j2 == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime)
                {
                    array2[j] = this.array[i];
                    j++;
                }
            }
        }
        public void FibanacсiDigit(int[] array2)
        {
            array2[0] = 0;
            array2[1] = 1;
            for (int i = 2; i <this.array.Length; i++)
            {
                array2[i] = this.array[i - 2] + array2[i - 1];
            }
        }
    }
}
