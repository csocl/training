using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_004___conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            // Read the age from the user input.
            int age = 0;
            Console.WriteLine("Enter your age (in years): ");
            line = Console.ReadLine();
            age = int.Parse(line);

            /*
             * This simplest form of conditional checking is the use of if and else.
             * It is possible to just use the if statement, or combine if with one of more
             * if else statements and single else statement at the end.
             *
             * It is possible to compare if a value is less than another by using <,
             * less than or equal too by using <=, greater than a value with >,
             * greater or equal with >=, if two values are the same with ==
             * and if they are not equal by using !=
            */

            if (age >= 60)
                Console.WriteLine("No comment!");
            else if (age >= 50)
                Console.WriteLine("50's is the new 40!");
            else if (age >= 40)
                Console.WriteLine("40's is the new 30!");
            else
                Console.WriteLine("Spring chicken!");

            // Here are some fun examples of < <= > >= == and !=
            if (age < 16)
            {
                if (age != 0)
                    Console.WriteLine("Not working yet!");
                else
                    Console.WriteLine("Welcome to the World!");
            }
            else if (age > 77)
            {
                Console.WriteLine("You might have made retirement!");
                if (age == 100)
                    Console.WriteLine("Where's my royal letter?");
            }


            /*
             * The switch statement is generated more efficient executable code than using if else,
             * but might not be as flexible.
             * When the range is not extreme, such as having a limited set of values then a
             * switch statement might be better.
            */

            // Read the number of vehicles from the user input.
            int vehicles = 0;
            Console.WriteLine("Enter number of vehicles: ");
            line = Console.ReadLine();
            vehicles = int.Parse(line);

            switch (vehicles)
            {
                case 0:
                    Console.WriteLine("Well that's very environmentally considerate.");
                    break;
                case 1:
                    Console.WriteLine("That's reasonable.");
                    break;
                case 2:
                    Console.WriteLine("Whoa!");
                    break;
                case 3:
                    Console.WriteLine("No comment!");
                    break;
                default: // Anything larger is beyond our comprehension.
                    Console.WriteLine("I can't count that high!");
                    break;
            }
        }
    }
}
