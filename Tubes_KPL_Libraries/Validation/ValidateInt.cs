using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Libraries.Validation
{
    public static class ValidateInt
    {
        public static int GetPositiveIntegerInput(string fieldInput)
        {
            int value;
            do
            {
                Console.Write($">> Enter {fieldInput}: ");
                var input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($">!!!> {fieldInput} cannot be empty. Please enter a number.");
                }

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine($">!!!> {fieldInput} must be a number. Please try again.");
                    continue;
                }

                if (value <= 0)
                {
                    Console.WriteLine($">!!!> {fieldInput} must be a positive number. Please try again.");
                }
            } while (value <= 0);

            return value;
        }
    }
}
