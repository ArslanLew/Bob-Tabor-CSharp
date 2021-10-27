using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.VIN = "A1";
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.VIN = "B2";
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft book";
            book1.ISBN = "0-000-00000-0";
            */
            /*
            //Array Lists are dynamically sized,
            //features such as sorting and removing.
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /* //List <T>
             List<Car> CarList = new List<Car>();
             CarList.Add(car1);
             CarList.Add(car2);
             //CarList.Add(book1);
             foreach (Car car in CarList)
             {
                 Console.WriteLine(car.Model);
             }
             */

            /*
            //Dictionary<TKey, TValue>
            Dictionary<string, Car> carDictionary = new Dictionary<string, Car>();
            carDictionary.Add(car1.VIN, car1);
            carDictionary.Add(car2.VIN, car2);
            Console.WriteLine(carDictionary[car1.VIN].Model);
            */

            //Object initialiser
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            //Collection initialiser
            List<Car> carList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5"},
                new Car { Make = "Nissan", Model = "Altima", VIN = "F6"}
            };

            foreach (Car car in carList)
            {
                Console.WriteLine(car.Make);
            }
            Console.WriteLine(carList[0].Make);
            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
