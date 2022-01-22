using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenciInjectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicleCar = new Vehicle();

            vehicleCar.Drive();

            //Vehicle vehicleBus  ???

        }
    }
}
