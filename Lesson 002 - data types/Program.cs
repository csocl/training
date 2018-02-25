using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_002___data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // The following lines of code show primitive data types built into the C# language.
            // Data types describe the properties of a variable, including the amount of memory used
            // and what type of information is stored, i.e. integer, floating point number, etc.

            bool is_primitive = true;
            Console.WriteLine("is_primitive is : " + is_primitive);

            // These are the in-built 8 bit types, with byte being unsigned (meaning positive only values),
            // and sbyte being signed (meaning negative or positive values).
            byte ASCII_A = 65;
            sbyte ASCII_a = 97;
            Console.WriteLine("ASCII A value is : " + ASCII_A + " or char : " + (char)ASCII_A);
            Console.WriteLine("ASCII a value is : " + ASCII_a + " or char : " + (char)ASCII_a);

            // Characters are stored as 16-bit Unicode, and can be set if various ways.
            // The ways to set a character are as a literal in single quotes, i.e. 'A',
            // or as a hex value, i.e. \\0x0041, or you can use a (char) cast like the example
            // above, or you can specify a Unicode value using a hex value, i.e. '\u0041'.
            char letter_A = '\u0041';
            Console.WriteLine("letter A numeric value is : " + (ushort)letter_A);

            // Integer values store whole numbers, and can be signed or unsigned.
            // short and ushort can store 16-bit values (Int16 is the equivalent type).
            short s = -32000;
            Console.WriteLine("s value is : " + s);

            // (UInt16 is the equivalent type)
            ushort us = 32000;
            Console.WriteLine("us value is : " + us);

            // int and uint can store 32-bit values (Int32 is the equivalent type).
            int i = -99000;
            Console.WriteLine("i value is : " + i);

            // (UInt32 is the equivalent type).
            uint ui = 99000;
            Console.WriteLine("ui value is : " + ui);

            // long and ulong can store 64-bit values (Int64 is the equivalent type).
            long l = -200000000;
            Console.WriteLine("l value is : " + l);

            // (UInt64 is the equivalent type).
            ulong ul = 200000000;
            Console.WriteLine("ul value is : " + ul);

            // float is a floating point data type that holds 32-bits and has an approximate range of -3.4E+38 to +3.4E+38.
            float f = 3.14F;
            Console.WriteLine("f value is : " + f);

            double d = 3.14D;
            Console.WriteLine("d value is : " + d);

            decimal m = 3.14m;
            Console.WriteLine("m value is : " + m);

            // C# also natively supports Unicode strings.
            string name = "Fred";
            Console.WriteLine("name is : " + name);
        }
    }
}
