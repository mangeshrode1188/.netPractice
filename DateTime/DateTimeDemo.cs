using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.DateTimeDemo2
{
    public  class DateTimeDemo
    {

  public void tryDateTime()
        {
            Console.WriteLine("DateTime ===============================================");
            var dateTime = new DateTime(2015, 1, 1);

            var now =DateTime.Now;

            var today =DateTime.Today;
            Console.WriteLine("Hour"+ now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.DayOfYear);


            Console.WriteLine("Month: " +now.Month);


            now.AddDays(10);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HHH:mm"));


            Console.WriteLine("----------------------------------------------");

            var timespan = new TimeSpan(1,2,4);
            
            var timeSpan2 = new TimeSpan(1,0,0);
            var timeSpan3=  TimeSpan.FromHours(1);



            var start = DateTime.Now;
            var end =DateTime.Now.AddMinutes(10);


            var duration = end - start;

            Console.WriteLine("Duration : "+duration);


            //Console.WriteLine(timespan.ToString());

            


        }
    }
}
