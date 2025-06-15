using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL_Libraries.Validation
{
    public static class ValidateInt
    {
        public static string ValidateGUIPositiveInteger(string input, string fieldName, out int parsedValue)
        {
            parsedValue = 0; // Initialize out parameter

            if (string.IsNullOrWhiteSpace(input))
            {
                return $"{fieldName} cannot be empty. Please enter a number.";
            }

            if (!int.TryParse(input, out parsedValue))
            {
                return $"{fieldName} must be a number. Please try again.";
            }

            if (parsedValue <= 0)
            {
                return $"{fieldName} must be a positive number. Please try again.";
            }

            return null; // Input is valid
        }

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
