using System;

namespace BirthdayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast fødselsdato (ddMMyyyy): ");
            string input = Console.ReadLine();

            DateTime birthday = DateTime.ParseExact(input, "ddMMyyyy", null);
            DateTime now = DateTime.Now;

            TimeSpan difference = now - birthday;

            int years = (int)Math.Floor(difference.TotalDays / 365.2425);
            birthday = birthday.AddYears(years);
            difference = now - birthday;

            int days = (int)Math.Floor(difference.TotalDays);

            Console.WriteLine("Du er " + years + " år og " + days + " dage gammel");
            Console.ReadKey();
        }
    }
}
