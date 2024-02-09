using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema17prkt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Артём", "Мутаф", 17);
            Student student = new Student("Артём", "Мутаф", 17, 2);
            student.Print();
            Employee employee = new Employee("Артём", "Мутаф", 17, "Microsoft", "Programmier");
            employee.Print();
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Артём","Мутаф",17));
            persons.Add(new Employee("Артём", "Мутаф", 17, "Microsoft", "Programmier"));
            persons.Add(new Student("Артём", "Мутаф", 17,2));
            foreach(var sigma in persons)
            {
                sigma.Print();
            }

            ReadKey();
        }
    }
}
