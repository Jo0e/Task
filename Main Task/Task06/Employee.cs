using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    internal class Employee :Person
    {
        public Employee(string name, int age, string address, string nationality, int salary, string rank
            , string jop, int workingHours) : base(name, age, address, nationality)
        {
            Salary = salary;
            Rank = rank;
            Jop = jop;
            WorkingHours = workingHours;
        }

        public int Salary { get; set; }
        public string Rank { get; set; }
        public string Jop { get; set; }
        public int WorkingHours { get; set; }

        public virtual new string Display()
        {
            return base.Display() + $", Salary: {Salary}, Rank: {Rank}, Job: {Jop} \r\n, Working Hours: {WorkingHours}";
        }

    }
}
