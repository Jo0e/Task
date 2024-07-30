using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    internal class Student : Person
    {
        public Student(string name, int age, string address, string nationality,string studyLevel
            , string specialization, double gpa) : base( name ,age,address,nationality)
        {
            StudyLevel = studyLevel;
            Specialization = specialization;
            GPA = gpa;
        }

        public string StudyLevel {  get; set; }
        public string Specialization { get; set; }
        public double GPA { get; set; }

        public new string Display()
        {
            return base.Display() + $", Study Level: {StudyLevel}\r\n, Specialization: {Specialization}, GPA: {GPA}";
        }
    }
}
