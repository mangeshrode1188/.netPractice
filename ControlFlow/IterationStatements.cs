using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.ControlFlow
{
    //For  + ForEarch + While
     class IterationStatements
    {

        public void TryRunFor() { 
        
            int[] ints = new int[10] {1,2,3,4,5,6,7,8,9,10};
            
            for (int i = 0; i <= ints.Length; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even Numver" +i);
                else
                    Console.WriteLine("Odd");
            }

            for (int i = 50; i >= 10; i--)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even Numver" + i);
                else
                    Console.WriteLine("Odd");

               
            }
        }

        public void TryRunForEach()
        {
            var name = "Mangesh Rode";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name) {
                Console.WriteLine(character);
            }


            var numbers = new int[10] {1,2,3,4,5,6,7,8,9,10 };
            foreach (var number in numbers)
            {
               
                Console.WriteLine(number);

            }

        }

        public void TryRunForDoWhile()
        {

            while (true) {
                Console.Write("TypeYourName");

                var input= Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(input);
                    continue;
                }
                break;

            }

        }

    }
}
