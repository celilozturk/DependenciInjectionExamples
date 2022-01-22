using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConstructorBasedDI;

namespace SetterBasedDIFromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle vehicleCar = new Vehicle(); //Created an object Vehicle Class.
            vehicleCar._vehicle = new Car();  //Vehicle type setted as a car.
            vehicleCar.Drive();

            Vehicle vehicleBus = new Vehicle();
            vehicleBus._vehicle = new Bus();
            vehicleBus.Drive();
        }
    }
}
