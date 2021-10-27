using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            //Console.WriteLine(myDate.ToString());
            //Console.WriteLine(myDate.ToShortDateString());
            //Console.WriteLine(myDate.ToShortTimeString());
            //Console.WriteLine(myDate.ToLongDateString());
            //Console.WriteLine(myDate.ToLongTimeString());

            //Console.WriteLine(myDate.AddDays(1095).ToLongDateString());
            //Console.WriteLine(myDate.AddHours(23).ToLongTimeString());
            //Console.WriteLine(myDate.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myDate.Month);

            /*DateTime Birthday = new DateTime(2004, 9, 27);
            Console.WriteLine(Birthday.ToShortDateString());*/

            DateTime Birthday = DateTime.Parse("27/9/2004");
            TimeSpan Age = DateTime.Now.Subtract(Birthday);

            Console.WriteLine("Age in days: {0}. Age in hours: {1}. Age in minutes: {2}. Age in seconds: {3}.", Age.TotalDays, Age.TotalHours, Age.TotalMinutes, Age.TotalSeconds);
            Console.ReadLine();
        }
    }
}
