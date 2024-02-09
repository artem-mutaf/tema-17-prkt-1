using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema17prkt1
{
    class Employee:Person
    {
        string company;
        string job;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public Employee() { }
        public Employee(string name, string surname, int age, string company, string job) : base(name, surname, age)
        { this.job = job; this.company = company; }

        virtual public new void Print()
        {

            WriteLine($"Компания: {company}\nРабота: {job}");
        }
    }
}
