using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_009___construction_and_destruction
{
    public class Person
    {
        /*
         * When the method has the same name as the class, it becomes a function
         * that is called at the time of constructing the class object.
         * A constructor without arguments is known as a default constructor.
         */
        public Person()
        {
            Name = "";
            Age = 0;
        }

        /*
         * It is also possible to define multiple constructors, which is also
         * known as overloading.
         */
        public Person(string name, uint age)
        {
            Name = name;
            Age = age;
        }

        // When objects are destroyed, any destructor will be called.
        ~Person()
        {
            string name;
            if (Name.Length > 0)
                name = Name;
            else
                name = "<not set>";

            // We can output a message to prove the destructor is executed.
            Console.WriteLine("Person " + name + " is being destroyed");
        }

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
