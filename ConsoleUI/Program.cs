using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        

        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle//Done
             * The vehicle class shall have three string properties Year, Make, and Model//Done
             * Set the defaults to something generic in the Vehicle class//Done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation//Done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.//Done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle//Done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle//Done
             * Provide the implementations for the abstract methods//Done
             * Only in the Motorcycle class will you override the virtual drive method//Done
            */

            // Create a list of Vehicle called vehicles//Done
            var vehicles = new List<Vehicle>();
            

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes//Done
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var myCar = new Car()
            {
                HasATrunk = true,
                Make = "Chevy",
                Model = "Corvette",
                Year = "2023"
            }; 
            var myBike = new Motorcycle() 
            { 
                HasHandleBars = true,
                Make = "Kawasaki",
                Year = "2010",
                Model = "Ninja"
            };
            Vehicle vehicleOne = new Car()
            {
                Make = "Chevy",
                Model = "Silverado",
                Year = "2023"
            };
            Vehicle vehicleTwo = new Motorcycle() 
            { 
                Make = "Harley",
                Model = "Shovel Head",
                Year = "1992"
            };

            /*
             * Add the 4 vehicles to the list//Done
             * Using a foreach loop iterate over each of the properties//Done
             */
            vehicles.Add(vehicleOne);
            vehicles.Add(vehicleTwo);
            vehicles.Add(myBike);
            vehicles.Add(myCar);
            
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();

            }
            // Call each of the drive methods for one car and one motorcycle//Done


            Console.WriteLine($"Number of vehicles created: {vehicles}");

            #endregion            
            Console.ReadLine();
        }
    }
}
