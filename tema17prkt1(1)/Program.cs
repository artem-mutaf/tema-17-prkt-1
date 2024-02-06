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
            //Задание 1
            Person person = new Person("Артём", "Мутаф", 17);
            Student student = new Student("Артём", "Мутаф", 17, 2);
            student.Print();
            Employee employee = new Employee("Артём", "Мутаф", 17,"Microsoft","Programmier");
            employee.Print();
            
            Console.ReadKey();
        }
    }
}
