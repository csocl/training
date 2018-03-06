using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_012___virtual_methods
{
    public class Car : Vehicle
    {
        public Car(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public override string GetModel()
        {
            return Model;
        }

        public override string GetManufacturer()
        {
            return Manufacturer;
        }

        private string Model;
        private string Manufacturer;
    }
}
