using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string FirstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string LastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string City = Console.ReadLine();

            DisplayResult(ReverseString(FirstName), ReverseString(LastName), ReverseString(City));
            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string ReversedFirstName, string ReversedLastName, string ReversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", ReversedFirstName, ReversedLastName, ReversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
