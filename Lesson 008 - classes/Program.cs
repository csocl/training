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
            /* Any class is a reference type, and must be constructed using the new keyword.
             * C# manages reference types, and any memory allocated for a class will be
             * freed by the built in garbage collector.
             * It's not important for now to understand how the garbage collector works,
             * only that it knows when an new object is no longer used and that it will
             * free the object from memory.
             */
            Person person = new Person();

            // Once the person object has been created, the methods on the person object
            // can be used to set the state of the data for the person object.
            person.SetName("Fred");
            person.SetAge(22);

            // We can extract the values from the person object by calling the functions
            // that return the values.
            string Name = person.GetName();
            uint Age = person.GetAge();

            // To prove this is set as expected, we can get the values out of the person
            // object and display them to the screen.
            Console.WriteLine(Name + " is " + Age + " years old");
        }
    }
}
