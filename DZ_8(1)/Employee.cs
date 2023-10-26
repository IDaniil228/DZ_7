using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8_1_
{
    internal class Employees
    {
        private string name;
        private string department;
        private Employees boss;
        private Employees second_boss;

        public string Name
        {
            get { return name; } 
        }
        public Employees GetBoss
        {
            get { return boss; }
        }
        public Employees GetSecondBoss
        {
            get { return second_boss; }
        }
        public Employees(string name)
        {
            this.name = name;
        }
        public Employees(string name, string department, Employees boss)
        {
            this.name = name;
            this.department = department;
            this.boss = boss;
        }
        public Employees(string name, string department, Employees boss, Employees second_boss)
        {
            this.second_boss = second_boss;
            this.name = name;
            this.department = department;
            this.boss = boss;
        
        }
    }
}
