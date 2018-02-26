using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_006___value_types_and_reference_types
{
    public struct StructValueType
    {
        public char ch;
        public int i;
    }

    public class ClassReferenceType
    {
        public char ch;
        public int i;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# variables are either a value type or a reference type.
             * This means that a value type variable holds the actual values,
             * where as a reference types only store a reference to the object 
             * 
             * When assigning a value for a value type, the value is copied,
             * whereas assigning a reference variable to another variable only
             * changes the reference to the object.
             * 
             * When comparing value types, the stored value is compared,
             * whereas a reference type compares the reference of the objects,
             * not the values within the objects.
             * The only exception to this rule is the string which although
             * is a reference type, the stored values are compared.
             * 
             * When a value type is changed, it won't affect any other variable
             * that it was copied from.
             * 
             * When a reference types data is changed, the reference that was
             * copied will also change.
             */

            /*
             * Here is an example of a struct behaves (as a value type).
             */
            StructValueType stvt1;
            stvt1.ch = 'A';
            stvt1.i = 55;

            StructValueType stvt2;
            stvt2.ch = 'B';
            stvt2.i = 77;

            // stvt1 is set to 'A' and 55 and stvt2 is set to 'B' and 77.
            Console.WriteLine("stvt1 : " + stvt1.ch + " " + stvt1.i);
            Console.WriteLine("stvt2 : " + stvt2.ch + " " + stvt2.i);

            stvt1 = stvt2;

            // stvt1 and stvt2 are both set to 'B' and 77.
            Console.WriteLine("stvt1 : " + stvt1.ch + " " + stvt1.i);
            Console.WriteLine("stvt2 : " + stvt2.ch + " " + stvt2.i);

            stvt1.ch = 'A';
            stvt1.i = 55;

            // stvt1 is set to 'A' and 55 and stvt2 is set to 'B' and 77.
            Console.WriteLine("stvt1 : " + stvt1.ch + " " + stvt1.i);
            Console.WriteLine("stvt2 : " + stvt2.ch + " " + stvt2.i);

            // These value types will be independent of each other.
            int i1 = 33;
            int i2 = 44;
            Console.WriteLine("i1 = " + i1 + " and i2 = " + i2);

            i1 = 55;

            // i1 is now 55 and i2 remains as 44.
            Console.WriteLine("i1 = " + i1 + " and i2 = " + i2);


            /*
             * Here is an example of a class behaves (as a reference type).
             */

            // Both classes have references to their own objects.
            ClassReferenceType crt1 = new ClassReferenceType();
            ClassReferenceType crt2 = new ClassReferenceType();
            crt1.ch = 'A';
            crt1.i = 55;
            crt2.ch = 'B';
            crt2.i = 77;

            // crt1 is set to 'A' and 55 and crt2 is set to 'B' and 77.
            Console.WriteLine("crt1 : " + crt1.ch + " " + crt1.i);
            Console.WriteLine("crt2 : " + crt2.ch + " " + crt2.i);

            // crt1 now references crt2, and both would have the same values for ch and i.
            crt1 = crt2;

            crt1.ch = 'C';
            crt1.i = 99;

            // crt1 and crt2 are set to 'C' and 99.
            Console.WriteLine("crt1 : " + crt1.ch + " " + crt1.i);
            Console.WriteLine("crt2 : " + crt2.ch + " " + crt2.i);


            /*
             * Although strings are reference types, they behave in a similar way
             * to value types, so they compare the contents,
             * but they are also immutable.
             * This means they cannot be changed, but instead are replaced with
             * new objects each time they are set.
             */
            // These two strings start as independent values.
            string str1 = "Hello";
            string str2 = "Goodbye";
            Console.WriteLine(str1 + " " + str2);

            // Because strings are a special type that is immutable, str2 is
            // changed to take a copy of the characters from str1.
            str2 = str1;

            // Output "[Hello] [Hello]"
            Console.WriteLine("[" + str1 + "] [" + str2 + "]");

            str2 = "Something";

            // Output "[Hello] [Something]"
            Console.WriteLine("[" + str1 + "] [" + str2 + "]");

            // Reference types can be null, meaning they don't reference an object.
            str2 = null;

            // Output [hello] []
            Console.WriteLine("[" + str1 + "] [" + str2 + "]");
        }
    }
}
