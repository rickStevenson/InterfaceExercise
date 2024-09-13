using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicleWithCompany
    {
        public string Wheels { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string DriveShaft { get; set; }

        public string CompanyName { get; set; }
        public string Location { get; set; }

        public double BedLength { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This is a {Year} {CompanyName} {Model} out of {Location}. It is a {DriveShaft} with" +
                $" a {Engine} engine and a {Transmission} transmission. The wheel size is {Wheels}. " +
                $"The bed length is {BedLength}");
        }

    }
}
