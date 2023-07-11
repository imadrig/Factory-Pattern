using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public int NumberOfTires {get; set;}
       public void Drive()
        {
            Console.WriteLine("Your car is being driven.");
        }
    }
}
