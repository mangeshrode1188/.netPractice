using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        string firstName = "";
        string lastName = "";


        public Employee() { }
        public void Introduce()
        {
            Console.WriteLine(firstName + lastName);
        }

        public Employee(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;

        }
    }

}

