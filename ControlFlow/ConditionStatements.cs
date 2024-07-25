using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.ControlFlow
{
    partial class ConditionStatements
    {

        public void dryRunif2(int hour) {
        
            bool isGoldMmber=true;

            float price = (isGoldMmber) ? 19.95f : 29.95f;


            Console.WriteLine(price);

        }

        public void dryRunCase(Season season)
        {
                      

            switch (season)
            {

                case Season.Winter:
                    Console.WriteLine("Very Cold ");
                    break;

                case Season.Summer:
                    Console.WriteLine("Very hot ");
                    break;

                case Season.Fall:
                    Console.WriteLine("Very watery ");
                    break;

                 default:
                    Console.WriteLine("No Such Reason");
                    break;  

            }
        }



            public void dryRunif(int hour)
        {
            Console.WriteLine("User passed: "+hour);

            if (hour >   0 && hour < 12) {
                Console.WriteLine("Good Morning");
            }else if (hour >= 12 && hour < 18) {

                Console.WriteLine("good Afternoon");
            }
            else {
                Console.WriteLine("Good night");
                    
              }

        }

    }
}
