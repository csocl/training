using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_003___operators_and_precedence
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operators such as + or * are handled in a particular order,
             * and the operators are grouped into categories. */

            /* The following example shows that expressions are evaluated
             * in order of their precedence, and multiply has a higher precedence
             * than addition.
             * This will result in 3 * 2 first, then 7 being added last,
             * giving the result of 13. */
            int result = 7 + 3 * 2;
            Console.WriteLine("The answer for result is : " + result);

            /* It is possible to change the order, by forcing the expression
             * to be evaluated first being placed in brackets, as the following
             * example shows. The result will be 20. */
            int result2 = (7 + 3) * 2;
            Console.WriteLine("The answer for result2 is : " + result2);

            /* Some operators look the same but have multiple uses, and these
             * operators will also have their own order of precedence
             * and an associativity.
             * One example of this is the prefix and postfix operator ++.
             * The association between an operator and the object it is applied
             * can be left to right, or right to left, as the following examples show. */

            /* This sets result3 to result2 and then increments result2,
             * which will be 21.
             * The associativity of the prefix ++ operator is right to left,
             * meaning that the value is evaluated first before the operator. */
            int result3 = ++result2;
            Console.WriteLine("The answer for result3 is : " + result3);

            /* This increments result2 then sets result4 to result2
             * after the increment, which will be 21.
             * The associativity of the postfix ++ operator is left to right.
             * Also notice that the assignment operator has an associativity of
             * right to left, meaning whatever is on he right side of the assignment
             * is evaluated first, before it can be assigned to the left side of the
             * assignment operator. */
            int result4 = result2++;
            Console.WriteLine("The answer for result4 is : " + result4);

            // We can then verify that result2 was incremented after setting result4.
            Console.WriteLine("The answer for result2 is : " + result2);

            /*
             * For a list of all the operators, groups and associativity, see:
             * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
             */
        }
    }
}
