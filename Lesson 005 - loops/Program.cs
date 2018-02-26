using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005___loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * There are 4 types of loops, the for loop, foreach loop, while loop and do while loop,
             * and each loop provides similar, but subtly different features that can be useful.
             *
             * The for loop allows for initialisation, conditional checking per iteration,
             * and an expression after each iteration.
             *
             * The foreach is a shortcut to accessing each element in a container or sequence
             * of values.
             * 
             * The while loop loops while a condition is true, and only executes the code
             * within the loop while the condition is true.
             *
             * The do while loop will always do at least one iteration before checking the
             * condition for exiting the loop.
             */

            string message = "Hello World!";

            int uppercase_count = 0;

            /*
             * Example of a for loop that looks at  each character and increments uppercase_count
             * when an upper case character is identified.
             */
            for (int pos = 0; pos < message.Length; ++pos)
            {
                if (char.IsUpper(message[pos]))
                    ++uppercase_count;
            }

            // Output the number of found upper case characters to the screen, which will be 2.
            Console.WriteLine("Number of upper case characters: " + uppercase_count);


            /*
             * The for loop can also be done a different way,
             * by assigning a value for each element in the array or string.
             * Here the variable c is set for every position in the string.
             */
            uppercase_count = 0;
            foreach (char c in message)
            {
                if (char.IsUpper(c))
                    ++uppercase_count;
            }

            // Output the number of found upper case characters to the screen, which will be 2.
            Console.WriteLine("Number of upper case characters: " + uppercase_count);


            /*
             * Example of a while loop, which keeps looping until a non-alphabetic character
             * is found.
             */
            int pos2 = 0;
            while (pos2 < message.Length)
            {
                if (!char.IsLetterOrDigit(message[pos2]))
                    break; // Any loop can exit early with the break statement.
                ++pos2;
            }

            // Output the position of the first non-alphabetic character to the screen.
            if (pos2 < message.Length)
                Console.WriteLine("Non-alphabetic character found at position " + pos2);
            else
                Console.WriteLine("Non-alphabetic not found");


            /*
                Example of a do while loop, which will always do at least one iteration before
                checking to exit the loop.
                The example will reverse the characters in the message string.
            */

            string reversed_message = "";
            do
            {
                reversed_message += message[message.Length - 1];
                message = message.Remove(message.Length - 1);
            }
            while (message.Length > 0);

            // Output the reversed message to the screen.
            Console.WriteLine("The message reversed is " + reversed_message);
        }
    }
}
