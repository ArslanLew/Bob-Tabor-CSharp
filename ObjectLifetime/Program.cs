using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            //Car.MyMethod();
            /*
            /myCar.Make = "Citroen";
            myCar.Model = "C3";
            myCar.Year = 2003;
            myCar.Colour = "Black";

            Car myThirdCar = new Car("Vauxhall", "Mokka", 2016, "White");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Colour);

            myOtherCar.Model = "Cactus";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);

            */

            Console.ReadKey(true);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public Car()
        {
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }

       /* public static void MyMethod()
        {
            Console.WriteLine("Called the static method");
            Console.WriteLine(Make);
        }*/
    }
}
