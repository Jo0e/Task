using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task06
{
    internal class HourlyEmployee :  Employee
    {
        public double HourlyRate { get; set; }

        public HourlyEmployee(string name, int age, string address, string nationality, int salary, string rank
        , string jop, int workingHours, double hourlyRate)
            :base(name, age, address, nationality, salary, rank, jop, workingHours)
        {
            HourlyRate = hourlyRate;
        }

        public override string Display()
        {
            return base.Display() + $", Hourly Rate: {HourlyRate}";
        }
    }
}
