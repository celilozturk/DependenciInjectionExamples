using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBasedDI
{
    class Vehicle
    {
        private IVehicle _vehicle; //Vehicle Type does not matter. Object just have to implement IVehicle interface. implemented object in this interface uses here

        public Vehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Accelerate();
            _vehicle.Brake();
        }

    }
}
