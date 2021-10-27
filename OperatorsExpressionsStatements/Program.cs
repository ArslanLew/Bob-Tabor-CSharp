using System;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int x, y, a, b;

            //Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //Mathematical operators

            //Addition operator
            x = 3 + 4;

            //Subtraction operator
            x = 4 - 3;

            //Multiplication operator
            x = 10 * 5;

            //Division operator
            x = 10 / 5;

            //Order of operations using parenthesis
            x = (x + y) * (a - b);

            //Logical operators

            //Equality operator
            if (x == y)
            {

            }

            //Greater than operator
            if (x > y)
            {

            }

            //Less than operator

            if (x < y)
            {

            }

            //Greater or equal to operator
            if (x >= y)
            {

            }

            //Conditional operator

            //Conditional AND operator
            if ((x>y) && (a > b))
            {

            }

            //Conditional OR operator
            if ((x>y) || (a > b))
            {

            }

            //in-line conditional operator
            string message = (x == 1) ? "Car" : "Nothing";
        }
    }
}
