using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema17prkt1
{
    class Student:Person
    {
        DateTime rod;
        int curs;
        public DateTime Rod
        {
            get { return rod; }
            set { rod = value; }
        }
        public int Curs
        {
            get { return curs; }
            set { curs = value; }
        }
        public Student() { }


        public Student(string name, string surname, int age, int curs,DateTime rod) : base(name, surname, age)
        { 
        this.curs = curs; 
        this.rod=rod;
        }

        public override void Print()
        {
            base.Print();
            Write($"Дата рождения:{rod.ToShortDateString())}\nКурс: {curs}\n");
        }
    }
}
