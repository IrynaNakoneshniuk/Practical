using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W._28._07
{
    internal class TeamFootball:IEnumerable
    {
        private IPlayer[] _team;
        public TeamFootball(int length)
        {
            _team=new IPlayer[length];
        }

        public IEnumerator GetEnumerator()
        {
            return _team.GetEnumerator();
        }
    }
}
