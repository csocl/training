using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_012___virtual_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Virtual methods can be overridden to change the behavior of base classes.
             * Creating a Car object demonstrates that the methods on Car are called,
             * which you would always expect.
             */
            Car fordFocus = new Car("Focus", "Ford");
            Console.WriteLine("Model " + fordFocus.GetModel() +
                              " and make " + fordFocus.GetManufacturer());

            /*
             * When a Car object is created and assigned to a Vehicle object,
             * it's possible to see that although the methods on the Vehicle object
             * are used, the Car methods are actually executed.
             */
            Vehicle hondaAccord = new Car("Accord", "Honda");
            Console.WriteLine("Model " + hondaAccord.GetModel() +
                              " and make " + hondaAccord.GetManufacturer());

            /*
             * If the Vehicle object was set from the Vehicle class, we can see
             * that the Vehicle methods will be called.
             */
            Vehicle vehicle = new Vehicle();
            Console.WriteLine("Model " + vehicle.GetModel() +
                              " and make " + vehicle.GetManufacturer());
        }
    }
}
