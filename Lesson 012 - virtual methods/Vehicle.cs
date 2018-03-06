using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_012___virtual_methods
{
    public class Vehicle
    {
        public virtual string GetModel()
        {
            return "Unknown";
        }

        public virtual string GetManufacturer()
        {
            return "Unknown";
        }
    }
}
