using System;

namespace RectangleCalculator
{
    internal class Program
    {
        static void ReadInput(out double height, out double width)
        {
            string inValue;

            Console.Write("Enter the height: ");
            inValue = Console.ReadLine();
            height = double.Parse(inValue);

            Console.Write("Enter the width: ");
            inValue = Console.ReadLine();
            width = double.Parse(inValue);
        }

        static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        static double CalculatePerimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }

        static void DisplayResults(double area, double perimeter)
        {
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The perimeter is: " + perimeter);
        }

        static void Main(string[] args)
        {
            double height;
            double width;
            double area;
            double perimeter;

            ReadInput(out height, out width);

            area = CalculateArea(height, width);
            perimeter = CalculatePerimeter(height, width);

            DisplayResults(area, perimeter);

            Console.ReadKey();
        }
    }
}
