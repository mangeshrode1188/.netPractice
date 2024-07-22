using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringsDemo
    {
        public static void TryStrings() {


            string firstmame = "Michael";
            string lastname = "Jackson";
            string fullname = "Michaeal" + "jackson";

            string newFullName= string.Format("{0}{1}",firstmame, lastname);
            Console.WriteLine(newFullName);
            Console.WriteLine("----------------------");

            var strArray = new string[3] { "ram", "shyam", "ghanshyam" };

            string tryjoin = string.Join("\\", strArray);

            Console.WriteLine(tryjoin);
            string tryjoin1 = string.Join("\n", strArray);
            Console.WriteLine(tryjoin1);    

            string tryjoin2 = string.Join("\t", strArray);
              Console.WriteLine(tryjoin2);

            //Verbatim String

            string path = @"c:\Program Files\Apache software\demo";

            Console.WriteLine(path);
            Console.WriteLine("---------------------------------------------------------------------");


            var employeeFirstName = "MAngesh";
            var employeeLastName = "Rode";
            String employeeAddress = "SB Road";

            var myfullNAme = string.Format("My name is {0}{1}",employeeFirstName,employeeLastName);
            Console.WriteLine(myfullNAme);

            var names = new string[] { "Johny", "yes", "papa" };
            Console.WriteLine(string.Join(",",names));






        }
    }
}
