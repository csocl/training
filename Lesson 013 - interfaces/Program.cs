using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_013___interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This example shows how to create an object derived from
             * an interface, and the derived class must have implemented all
             * methods for this to be valid.
             */
            Vehicle car = new Car("Accord", "Honda");
            Console.WriteLine("Model " + car.GetModel() +
                              " and make " + car.GetManufacturer());
        }
    }
}
