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
        /*
         * When defining a method for a class, you can specify the method name,
         * the return type which is left of the method name, and any parameters
         * which are within the brackets following the method name.
         * Methods also known as functions, can access data within the class,
         * such as Name or Age.
         * 
         * There are keywords like public and private that allow us to define
         * what the user of our class can see.
         * 
         * When something is marked as private then only the class can see those
         * functions or variables.
         * 
         * When something is marked as public, the class can see those functions
         * and variables, but so can the user of the class.
         */
        public string GetName()
        {
            /*
             * To return a value to the user of our class object,
             * we use the keyword return followed by the name of the variable
             * that will be returned.
             */
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

        /*
         * When defining a variable within a class,
         * you just need to provide the type and the name of the variable.
         * We can see the type for variable Name is string.
         */
        private string Name;
        private uint Age;
    }
}
