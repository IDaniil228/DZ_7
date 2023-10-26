using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8_1_
{
    internal class Task
    {
        string name;
        string department;
        Employees from;
        Employees to;


        public string GetToName
        {
            get { return to.Name; }
        }
        public string GetFromName
        {
            get { return from.Name; }
        }
        public string Name
        {
            get { return name; }
        }
        public Employees GetTo
        {
            get { return to; }
        }
        public Employees GetFrom
        {
            get { return  from; }
        }

        public Task(string name, string department, Employees from, Employees to)
        { 
            this.name = name;
            this.department = department;
            this.from = from;
            this.to = to;
        }
        public bool IsBoss(Employees from, Employees to)
        {
            if (to.GetBoss == from || to.GetSecondBoss == from)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
