using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W._28._07
{
    internal class Oceanarium : IEnumerable
    {
        private IOceanDwellers[] _litsDwellers;
        public Oceanarium(int length)
        {
            _litsDwellers = new IOceanDwellers[length];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public EnumOceanarium GetEnumerator()
        {
            return new EnumOceanarium(_litsDwellers);
        }
    }
    internal class EnumOceanarium : IEnumerator
    {
        public IOceanDwellers[] List;
        public int position = -1;

        public EnumOceanarium(IOceanDwellers[] list)
        {
            List = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < List.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public IOceanDwellers Current
        {
            get
            {
                try
                {
                    return List[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

