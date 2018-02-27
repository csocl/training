using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_008___classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Any class is a reference type, and must be constructed using the new keyword.
            Person person = new Person();

            // Once the person object has been created, the methods on the person object
            // can be used to set the state of the data for the person object.
            person.SetName("Fred");
            person.SetAge(22);

            // To prove this is set as expected, we can get the values out of the person
            // object and display them to the screen.
            Console.WriteLine(person.GetName() + " is " + person.GetAge() + " years old");
        }
    }
}
