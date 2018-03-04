using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_011___class_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Here we can create a Car object, and the object will be created,
             * firstly by constructing the base Vehicle object by calling the Vehicle constructor,
             * and then the Vehicle is constructed, the Car part of the object will be constructed.
            */
            Car fordFocus = new Car("Focus", "Ford", false);
            string hand = fordFocus.LeftHandDrive() ? "left" : "right";
            Console.WriteLine("Model " + fordFocus.GetModel() +
                              " and make " + fordFocus.GetManufacturer() +
                              " is " + hand + " drive");

            /*
             * We can also create a Car object and assign this to a Vehicle,
             * although only the methods on the Vehicle object will be accessible.
             */
            Vehicle hondaAccord = new Car("Accord", "Honda", true);
            Console.WriteLine("Model " + hondaAccord.GetModel() +
                              " and make " + hondaAccord.GetManufacturer());

            /*
             * It's also possible to convert the Vehicle object into a Car object,
             * which then allows us to use the methods on the Car object.
             */
            Car hondaAccordCar = (Car)hondaAccord;
            hand = hondaAccordCar.LeftHandDrive() ? "left" : "right";
            Console.WriteLine("Model " + hondaAccord.GetModel() +
                              " and make " + hondaAccord.GetManufacturer() +
                              " is " + hand + " drive");

            /*
             * When you create an object of the base class type, it's not
             * possible to convert it to some other class that is inherited from
             * the base class, if the object was not created using the inherited class.
             * 
             * So it's not possible to convert nissanMicra to a Car object, as it is not
             * created as a Car object.
             */
            Vehicle nissanMicra = new Vehicle("Micra", "Nissan");
            string vehicleType = nissanMicra.GetType().Name;

            /*
             *It's possible to get the type of the object as a string, and compare it.
             * This demonstrates that the object is a Vehicle, and it won't be possible
             * to use it as a car, without causing your software to fail.
             */
            if (vehicleType == "Car")
            {
                Car nissanMicraCar = (Car)nissanMicra;
                hand = nissanMicraCar.LeftHandDrive() ? "left" : "right";
                Console.WriteLine("Model " + nissanMicraCar.GetModel() +
                                  " and make " + nissanMicraCar.GetManufacturer() +
                                  " is " + hand + " drive");
            }
            else
            {
                Console.WriteLine("Model " + nissanMicra.GetModel() +
                                  " and make " + nissanMicra.GetManufacturer());
            }
        }
    }
}
