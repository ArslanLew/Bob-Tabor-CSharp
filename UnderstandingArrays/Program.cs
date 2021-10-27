using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.WriteLine("Array length: " + numbers.Length);*/

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            /*for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }*/

            /*foreach  (string name in names)
            {
                Console.WriteLine(name);
            }*/

            string test = "String to reverse";
            char[] charArray = test.ToCharArray();
            Array.Reverse(charArray);

            foreach (char testChar in charArray)
            {
                Console.Write(testChar);
            }

            Console.ReadLine();
        }
    }
}
