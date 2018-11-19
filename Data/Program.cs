using System;
using System.Collections.Generic;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blu", "A4"),
                new BMW(250, "red", "M3")
            };

            // showcases virtual and override
            Console.WriteLine("Using an override function:");
            foreach(var car in cars)
            {
                car.Repair();
            }

            // difference between base type and inherited type without overloading
            Console.WriteLine("\nUsing base type declaration:");
            Car bmwZ3 = new BMW(200, "blk", "Z3");
            Car audiA3 = new Audi(100, "grn", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();
            bmwZ3.Repair();

            audiA3.SetCarIDInfo(1201, "Jake Farm");
            audiA3.GetCarIDInfo();

            Console.WriteLine("\nUsing inherited type declaration:");
            BMW bmwM5 = new BMW(330, "wht", "M5");
            bmwM5.ShowDetails();
            bmwM5.Repair();

            // using parent function to hide children details
            Console.WriteLine("\nUsing parent casting:");
            Car carA = (Car)bmwM5;
            carA.ShowDetails(); // this works as parent since virtual
            carA.Repair();      // this works as child since no override on Repair function

            Console.WriteLine("\nUsing grandchildren:");
            M3 newM3 = new M3(260, "red", "M3 Titanium");
            newM3.Repair();

            Console.ReadKey();
        }
    }
}
