using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Big Giveaway");
            Console.Write("Chose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            //Using If statement
            /*string message = "";

             if (userValue == "1")
             {
                 message = "You won nothing, better luck next time :(";
             }

             else if (userValue == "2")
             {
                 message = "You won a car :)";
             }

             else if (userValue == "3")
             {
                 message = "You won £50 :)";
             }

             else
             {
                 message = "Invalid Input";
             }
             Console.WriteLine(message);*/


            //Using condition, not good for multiple options
            /*string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}.", message);
            Console.ReadLine();*/


            //Using switch, good for 5+ options and looks nice :)
            /*switch (userValue)
            {
                case "1":
                    Console.WriteLine("You won nothing, better luck next time :(");
                    break;

                case "2":
                    Console.WriteLine("You won a car :)");
                    break;

                case "3":
                    Console.WriteLine("You won £50 :)");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }*/

            Console.ReadLine();
        }
    }
}
