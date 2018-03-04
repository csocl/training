using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_011___class_inheritance
{
    public class Car : Vehicle
    {
        /*
         * The generic Vehicle class can be extended to add additional methods and data
         * that is only meaningful for the extended system, such as the Car class here.
         * Because a car has a model and manufacturer, the Vehicle class can be used
         * to share the methods and data by inheriting the class, and then add
         * specific methods and data for a car.
         */
        public Car(string model, string manufacturer, bool isLeftHandDrive) : base(model, manufacturer)
        {
            IsLeftHandDrive = isLeftHandDrive;
        }

        /*
         * A motorbike won't have left or right hand drive, so this would not want
         * to be part of the generic class Vehicle.
         * It's useful to only model methods and data in generic base classes that have
         * meaning for those classes that wish to inherit from them.
         * If we didn't use the suggest approach, then Vehicle could have had LeftHandDrive
         * method, but this would be meaningless to use on a Motorbike class.
         */
        public bool LeftHandDrive()
        {
            return IsLeftHandDrive;
        }

        private bool IsLeftHandDrive;
    }
}
