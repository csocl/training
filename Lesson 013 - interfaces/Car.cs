using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_013___interfaces
{
    /*
     * Car implements the methods on the Vehicle interface, ensuring that
     * 
     */
    public class Car : Vehicle
    {
        public Car(string model, string manufacturer)
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
