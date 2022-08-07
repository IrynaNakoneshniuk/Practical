using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W._28._07
{
    internal class Cafe: IEnumerable
    {
        private IEmployee[] _employee;
        public Cafe(int length)
        {
            _employee = new IEmployee[length];
        }
        public IEnumerator GetEnumerator()
        {
            return _employee.GetEnumerator();
        }
    }
}
