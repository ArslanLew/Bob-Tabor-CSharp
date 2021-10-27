using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadKey(true);
            */

            Console.Write("Type your first name: ");
            string FirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string LastName = Console.ReadLine();

            //Console.WriteLine("Hello, " + FirstName + " " + LastName+ ".");
            Console.WriteLine("Hello, {0} {1}.", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
