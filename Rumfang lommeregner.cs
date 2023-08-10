using System;

namespace Rumfang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast længden af kassen: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast bredden af kassen: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast højden af kassen: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = length * width * height;

            Console.WriteLine("Rumfanget af kassen er: " + volume);
            Console.ReadKey();
        }
    }
}
