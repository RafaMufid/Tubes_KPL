using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Libraries.Validation
{
    public static class ValidateString
    {
        public static string GetValidatedString(string fieldInput)
        {
            string input;
            do
            {
                Console.Write($">> Enter {fieldInput}: ");
                input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($">!!!> {fieldInput} cannot be empty. Please try again.");
                    continue;
                }

                if (input.Any(char.IsDigit))
                {
                    Console.WriteLine($">!!!> {fieldInput} cannot contain numbers. Please enter letters only.");
                    continue;
                }

                if (input.Any(ch => !char.IsLetter(ch) && ch != ' '))
                {
                    Console.WriteLine($">!!!> {fieldInput} can only contain letters and spaces. Please remove any special characters.");
                    continue;
                }

                if (input.Length > 50)
                {
                    Console.WriteLine($">!!!> {fieldInput} cannot be longer than 50 characters. Please shorten it.");
                    continue;
                }

                break; // Input valid, keluar dari loop
            } while (true);

            return input;
        }
    }
}
