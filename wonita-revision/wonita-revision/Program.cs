using System;
using System.Collections;
using System.Net;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args){


            Car car1 = new Car();
            car1.Make = "oldsmobile";
            car1.Model = "Cutlas supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "sm supreme";
            car2.VIN = "K2";

            Book b1 = new Book();
            b1.Author = "Wonita February";
            b1.Title = "wonders of the world";
            b1.IBSN = "123-4456-0000";


            //ArrayList are dynamically sized, cool feature sorting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }


            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //  myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            Dictionary<string, Car> mydictionary = new Dictionary<string, Car>();
            mydictionary.Add(car1.VIN, car1);
            mydictionary.Add(car2.VIN, car2);

            Console.WriteLine(mydictionary["K2"].Make);

            string[] names = { "kate", "Bob", "Eve", "Steve" };
            Console.ReadLine();

            //Car car1 = new Car() { Make = "BMW", Model = "750", VIN = "C3" };

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
            public string IBSN { get; set; }
            public string Author { get; set; }
        }
    }
}
           
        