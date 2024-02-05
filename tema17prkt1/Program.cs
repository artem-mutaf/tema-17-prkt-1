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
            Person person = new Person("Артём","Мутаф",17);
            person.Print();
            Employee employee = new Employee("Microsoft","Programmier");
            employee.Print();
            Console.ReadKey();



        }
    }
}
