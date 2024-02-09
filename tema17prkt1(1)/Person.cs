using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema17prkt1
{
    class Person
    {
        string name;
        string surname;
        int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        { }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Person(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }
        virtual public void Print()
        {

            WriteLine($"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age}");
        }
    }
}
