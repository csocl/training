using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_010___static_classes
{
    /*
     * Classes declared as static can be used without having
     * a variable declared for the class type.
     * These classes don't take up memory, and the methods can
     * be used by just specifying the class name, full stop and method name.
     * e.g.
     * *   int count = StringUtility.CountChars("2a .");
     *     // count will be 1.
     */
    static public class StringUtility
    {
        public enum SeparateOptions
        {
            Digits,
            Letters,
            WhiteSpace,
            Punctuation
        };

        // Count the number of characters matching the option.
        public static int CountChars(string str, SeparateOptions option)
        {
            string found, notFound;
            Separate(str, out found, out notFound, option);
            return found.Length;
        }

        // Separate characters from a string into two strings.
        public static void Separate(string str, out string found, out string notFound, SeparateOptions option)
        {
            found = "";
            notFound = "";

            foreach(char ch in str)
            {
                switch (option)
                {
                    case SeparateOptions.Digits:
                        if (char.IsDigit(ch))
                            found += ch;
                        else
                            notFound += ch;
                        break;
                    case SeparateOptions.Letters:
                        if (char.IsLower(ch) || char.IsUpper(ch))
                            found += ch;
                        else
                            notFound += ch;
                        break;
                    case SeparateOptions.Punctuation:
                        if (char.IsPunctuation(ch))
                            found += ch;
                        else
                            notFound += ch;
                        break;
                    case SeparateOptions.WhiteSpace:
                        if (char.IsWhiteSpace(ch))
                            found += ch;
                        else
                            notFound += ch;
                        break;
                }
            }
        }
    }
}
