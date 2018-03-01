using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_010___static_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string found, notFound;
            string str = "ABC123, def456.";

            Console.WriteLine("Separate [" + str + "]");

            /*
             * As this is a static class, there is no need to have a variable for StringUtility.
             * Methods are called directly on the static class.
             */
            StringUtility.Separate(str, out found, out notFound, StringUtility.SeparateOptions.Digits);
            int count = StringUtility.CountChars(str, StringUtility.SeparateOptions.Digits);
            Console.WriteLine("digits [" + found + "] other [" + notFound + "] count = " + count);

            StringUtility.Separate(str, out found, out notFound, StringUtility.SeparateOptions.Letters);
            count = StringUtility.CountChars(str, StringUtility.SeparateOptions.Letters);
            Console.WriteLine("letters [" + found + "] other [" + notFound + "] count = " + count);

            StringUtility.Separate(str, out found, out notFound, StringUtility.SeparateOptions.Punctuation);
            count = StringUtility.CountChars(str, StringUtility.SeparateOptions.Punctuation);
            Console.WriteLine("punctuation [" + found + "] other [" + notFound + "] count = " + count);

            StringUtility.Separate(str, out found, out notFound, StringUtility.SeparateOptions.WhiteSpace);
            count = StringUtility.CountChars(str, StringUtility.SeparateOptions.WhiteSpace);
            Console.WriteLine("whitespace [" + found + "], other [" + notFound + "] count = " + count);
        }
    }
}
