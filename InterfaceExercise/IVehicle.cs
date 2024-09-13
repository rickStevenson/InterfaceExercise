using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        string Wheels { get; set; }
        string Engine { get; set; }
        string Transmission { get; set; }
        string DriveShaft  { get; set; }

        void DisplayDetails();

    }
}
