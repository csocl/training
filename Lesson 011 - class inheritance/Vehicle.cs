using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_011___class_inheritance
{
    /*
     * Vehicle is defined as a generic class that can be used for any type of vehicle.
     * A car, motorbike, boat, etc could inherit these methods and data, and then
     * extend the Vehicle class.
     */
    public class Vehicle
    {
        public Vehicle(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public string GetModel()
        {
            return Model;
        }

        public string GetManufacturer()
        {
            return Manufacturer;
        }

        private string Model;
        private string Manufacturer;
    }
}
