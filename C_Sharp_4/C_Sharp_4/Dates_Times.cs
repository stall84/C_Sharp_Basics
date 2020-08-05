using System;
namespace C_Sharp_4
{
    public class Dates_Times
    {


        public static void DateTimer ()
        {

        

        var now = DateTime.Now;

        Console.WriteLine(now);

            var yesterday = now.AddDays(-1);
            var tomorrow = now.AddDays(1);
            //Console.WriteLine("Yesterday was: " + yesterday);
            //Console.WriteLine("Tomorrow is: " + tomorrow);  
            //Console.WriteLine("Converting to DateString: " + now.ToLongDateString());

            // To convert datetime to string for use with JSON for example use ToString("FORMAT")

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }

        public static void TimeSpanner ()
        {
            // TimeSpan class instantiates new objecs of a time span.. below first example
            // 1hr, 2min, 3secs. 2nd example 1hr 
            var timeSpan1 = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            // Another way is using the static methods off of the TimeSpan Structure/Class
            var timespan3 = TimeSpan.FromHours(1);  // 1 hour (more readable than above)

                // You can also create a timespan by doing (math) on DateTime (Create a span of 50 minutes)
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(50);
            var duration = end - start;
            //Console.WriteLine("Duration of end minus start: " + duration);


            // Properties on TimeSpan:

            Console.WriteLine("Display minutes component: " + timeSpan1.Minutes);
            Console.WriteLine("Display TOTAL minutes component: " + timeSpan1.TotalMinutes);
        }


    }
}
