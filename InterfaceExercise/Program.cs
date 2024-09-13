using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany-Done

            //Create 3 classes called Car , Truck , & SUV-Done

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.-Done
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company-Done
                 * regardless of vehicle type.
                 * Example: public string CompanyName { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class -Done
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.-Done
                 */

            //Now, create objects of your 3 classes and give their members values.-Done
            //Creatively display and organize their values


            var suv = new SUV
            {
                Wheels = "265/50-22",
                Engine = "i-Force",
                Transmission = "Eight speed automatic",
                DriveShaft = "full-time 4WD",
                CompanyName = "Toyota",
                Location = "Aichi Prefecture, Japan",
                BackDoorConfiguration = "Hinge at Top",
                Model = "4Runner",
                Year = 2025
            };
            var truck = new Truck 
            {
                Wheels = "255 70/17",
                Engine = "6.2L V8",
                Transmission = "10-speed automatic",
                DriveShaft = "2WD",
                CompanyName = "Chevy",
                Location = "Detroit, Michigan",
                Model = "1500 Silverado",
                Year = 2025,
                BedLength = 8
            };
            var car = new Car 
            { 
                Wheels = "R/T 245/55-18",
                Engine = "6.4L HEMI V8 (Scat Pack)",
                Transmission = "8-speed automatic",
                DriveShaft = "RWD",
                CompanyName = "Dodge",
                Location = "Auburn Hills, Michigan",
                Model = "Charger",
                Year = 2024,
                TrunkCapacity = 16.5
            };

            var displayList = new List<IVehicleWithCompany> { suv, truck, car };

            foreach (var vehicle in displayList)
            {
                vehicle.DisplayDetails();
            }
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.-Done
            //Implement the stubbed out method in the derived classes.-Done
            //In the scope of them method, use string interpolation to display property values.-Done
            //In order to also interpolate values from ICompany, research how to extend interfaces.-Done
            
        }
    }
}
