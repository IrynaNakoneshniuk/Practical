using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltiesAccounting
{
    internal class ManageSystem
    {
        public ListTemplates<User> Users;
        public ListTemplates<ExecutiveAgency> ExecutiveAgency;
        public ListTemplates<Chek> Chek;
        public string PathUsers;
        public string PathExecutiveAgency;
        public string PathChek;
        public ManageSystem()
        {
            PathUsers = @"C:\Users\ZbooK\source\repos\PenaltiesAccounting\AccountUser.xml";
            PathExecutiveAgency = @"C:\Users\ZbooK\source\repos\PenaltiesAccounting\AccountAgency.xml";
            PathChek = @"C:\Users\ZbooK\source\repos\PenaltiesAccounting\Chek.xml";
            Users = new ListTemplates<User>(PathUsers);
            ExecutiveAgency = new ListTemplates<ExecutiveAgency>(PathExecutiveAgency);
            Chek=new ListTemplates<Chek>(PathChek);

        }
        public void CreateNewAccount()
        {

        }
        public void LoginInExistAccount()
        {

        }

    }
}
