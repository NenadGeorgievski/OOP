using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Car : IVehiculo
    {
        public int CarTank { get; set; }

        public Car()
        {
            CarTank = 0;
        }
        public void Drive()
        {
            if(CarTank < 1)
            {
                Console.WriteLine("Not driving.");
            } else
            {
                Console.WriteLine("Driving.");
            }
        }

        public bool Refuel(int liters)
        {
            CarTank += liters;
            return true;
        }
    }
}
