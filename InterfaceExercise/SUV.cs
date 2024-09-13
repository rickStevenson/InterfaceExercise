using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicleWithCompany
    {
        public string Wheels { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string DriveShaft { get; set; }

        public string CompanyName { get; set; }
        public string Location { get; set; }


        public string BackDoorConfiguration { get; set; }
        public string Model {  get; set; }
        public int Year { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This is a {Year} {CompanyName} {Model} out of {Location}. It is a {DriveShaft} engine with" +
                $" a {Engine} and a {Transmission} transmission. The wheel size is {Wheels}. " +
                $"The back door has the {BackDoorConfiguration}");
        }


    }
}
