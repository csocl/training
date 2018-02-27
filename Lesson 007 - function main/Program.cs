using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_007___function_main
{
    class Program
    {
        /*
         * Function Main can either have a void or an int return type.
         * When function Main returns an int type, this value is returned
         * to the shell or command prompt, and non-zero return values
         * represent error conditions.
         * The arguments passed in at the command prompt are massed into
         * function Main as the args string array.
         * These values can be indexed starting from 0, to args.Length - 1.
         *
         * Also note that function Main must not be public, so this is
         * defined as private by default.
         */
        static int Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (string s in args)
                    Console.WriteLine("arg : " + s);
            }
            else
                Console.WriteLine("No arguments");

            // Return of 0 means success for the command prompt.
            return 0;
        }
    }
}
