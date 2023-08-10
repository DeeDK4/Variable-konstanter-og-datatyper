using Microsoft.VisualBasic;
using System;

namespace VariableOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;

            // Opgave b
            // you need to use a decimal variable (double) to store the result of "width * length" because it's a decimal value, and integer variables can't hold it.
            int area = (int)(width * length);

            // Opgave c
            // In task c, no type conversion is needed as "width * length" is already of type double, and you direcly assing the result to a double varuable "d".
            double d = width * length;

            Console.WriteLine(length * width);
            Console.WriteLine(area);
            Console.WriteLine(d);
        }
    }
}