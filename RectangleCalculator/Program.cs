using System;
using System.Globalization;

namespace RectangleCalculator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Rectangle Calculator ===");

            double height = ReadPositiveNumber("Enter the height of the rectangle: ");
            double width = ReadPositiveNumber("Enter the width of the rectangle: ");

            double area = CalculateArea(height, width);
            double perimeter = CalculatePerimeter(height, width);

            PrintResults(height, width, area, perimeter);
        }

        // Asks the user for a number until a valid positive value is entered.
        public static double ReadPositiveNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (input == null)
                {
                    throw new InvalidOperationException("No input available.");
                }

                input = input.Trim().Replace(',', '.');

                if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double value)
                    && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        // Area = height * width
        public static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        // Perimeter = 2 * (height + width)
        public static double CalculatePerimeter(double height, double width)
        {
            return 2 * (height + width);
        }

        public static void PrintResults(double height, double width, double area, double perimeter)
        {
            Console.WriteLine();
            Console.WriteLine($"Rectangle: height = {height:0.##}, width = {width:0.##}");
            Console.WriteLine($"Area: {area:0.##}");
            Console.WriteLine($"Perimeter: {perimeter:0.##}");
        }
    }
}
