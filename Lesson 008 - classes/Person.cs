using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_008___classes
{
    /*
     * Classes allow methods and data to be brought together into a logical unit.
     * This is known as encapsulation, and allows us to safeguard how the data is
     * modified through the methods of the class.
     * By hiding the data and only accessing them through the methods,
     * we can control the state of our data, and ensure they remain coherent together.
     */
    public class Person
    {
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public uint GetAge()
        {
            return Age;
        }

        public void SetAge(uint age)
        {
            Age = age;
        }

        private string Name;
        private uint Age;
    }
}
