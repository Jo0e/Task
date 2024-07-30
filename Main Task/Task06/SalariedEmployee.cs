using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name, int age, string address, string nationality, int salary, string rank
        , string jop, int workingHours, double bonus, double dedications)
            : base(name, age, address, nationality, salary, rank, jop, workingHours)
        {
            Bonus = bonus;
            Dedications = dedications;
        }

        public double Bonus { get; set; }
        public double Dedications { get; set; }

        public override string Display()
        {
            return base.Display() + $", Bonus: {Bonus}, Deductions: {Dedications}";
        }
    }
}
