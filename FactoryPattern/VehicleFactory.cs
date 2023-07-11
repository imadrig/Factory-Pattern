using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numberOfTires)
        {
            switch (numberOfTires)
            {
                case "2":
                    return new Motorcycle();

                case "4":
                    return new Car();

                default:
                    Console.WriteLine("Your vehicle is not a motorcycle or car. The vehicle will not be driven.");
                   
                    break;
            }
            return null;
        }
    }
}
