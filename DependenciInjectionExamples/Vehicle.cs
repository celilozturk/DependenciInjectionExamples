using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenciInjectionExamples
{
    class Vehicle
    {
        Car car;

        public Vehicle()
        {
            car = new Car();      //Not loosely coupled, Highly coupled. 
        }

        public void Drive()
        {
            car.Accelerate();
            car.Brake();
        }
    }
}
