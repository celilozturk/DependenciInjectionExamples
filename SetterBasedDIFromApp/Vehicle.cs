using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBasedDI
{
    class Vehicle
    {
        public IVehicle _vehicle { get; set; } 
                                              
        
        public void Drive()
        {
            _vehicle.Accelerate();
            _vehicle.Brake();
        }

    }
}
