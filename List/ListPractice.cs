using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.List
{
    internal class ListPractice
    {

        public void tryList()
        {
            var numbers = new List<int>();  

            numbers.Add(0); 
            numbers.Add(1); 
                numbers.Add(2);
            numbers.Add(3); 
            numbers.Add(4); 
            numbers.Add(5); 
            numbers.Add(6); 
            numbers.Add(7); 
            numbers.Add(8); 
                numbers.Add(9);
            numbers.Add(10);

            Console.WriteLine(numbers);

            foreach (var number in numbers) {

                Console.WriteLine(number);
            }
        }
            public void tryArray()
        {


            var numbers = new [] { 55, 2, 22, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("length"+numbers.Length);

            //Indixof

      var index=      Array.IndexOf(numbers, 3);
            Console.WriteLine(index);


            //Clear

            Array.Clear(numbers,3,2);
            Console.WriteLine("------------------");
            foreach (var number in numbers)
                Console.WriteLine(number);


            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            //Copy
            int []  numvercopy = new int[3];

            Array.Copy(numbers, numvercopy, 3);
            foreach (var number in numvercopy)
                Console.WriteLine(number);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            //Sort
            var numberssort = new[] { 22,44, 100,10,55, 2, 22, 4, 5, 6, 7, 8, 9 };
            Array.Sort(numberssort);
            foreach (var number in numberssort)
                Console.WriteLine(number);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            //reverse
            var revrse = new[] { 22, 44, 100, 10, 55, 2, 22, 4, 5, 6, 7, 8, 9 };
            Array.Reverse(revrse);


            foreach (var number in revrse)
                Console.WriteLine(number);

        }
    }
}
