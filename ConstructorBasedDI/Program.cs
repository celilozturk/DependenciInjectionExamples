using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBasedDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(new Car());
            vehicle.Drive();

            Vehicle vehicle2 = new Vehicle(new Bus());
            vehicle2.Drive();
        }
    }
}
 