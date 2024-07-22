using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{
    public class ArraysDemo
    {

      public   static void TryArrays()
        {
            var numbers =new int[3];
            numbers[0] = 1;
            numbers[1] = 2;


            
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            var flagsArray=new bool[3];
            flagsArray[0] = true;
            Console.WriteLine(flagsArray[0]);
            Console.WriteLine(flagsArray[1]);
            Console.WriteLine(flagsArray[2]);


            var strArray =new string[3] { "ram","shyam","ghanshyam"};

            Console.WriteLine(strArray[0]);
            Console.WriteLine(strArray[1]);

            Console.WriteLine(strArray[2]);




        }
    }
}
