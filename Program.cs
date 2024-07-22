using ConsoleApp1;
using ConsoleApp1.Arrays;
using ConsoleApp1.Math;
using System;
namespace CSharpBasics
{

    public class Program
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(1.2, 3.4);

            Console.WriteLine(result);

            var subResult = calculator.Substract(10.22,34.44);
            Console.WriteLine(subResult);

            var multipleResult = calculator.Multiply(38 , 22);
            Console.WriteLine(multipleResult);  


         

            ArraysDemo.TryArrays();

            StringsDemo.TryStrings();

            var method = ShippingMethod.RegisteredMail;


            Console.WriteLine((int)ShippingMethod.RegularMail);

            var methodID = 12;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
          var finalMethod= (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName); 
            Console.WriteLine(methodName);



        }
    }


}