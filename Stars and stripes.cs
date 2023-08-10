using System;

namespace StarsAndStripes
{
    class Program
    {
        static void Main(string[] args)
        { 
            //jeg har prøvet i lang tid nu, men kunne ikke få det til at virke, så det  her var mit bedste.
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            int width = 23;
            int height = 11;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if ((col + row) % 3 == 0)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
