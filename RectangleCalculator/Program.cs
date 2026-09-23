using System;

namespace RectangleCalculator
{
    internal class Program
    {
        static double GetSize(string name)
        {
            string inValue;

            Console.Write("Enter the " + name + ": ");
            inValue = Console.ReadLine();
            return double.Parse(inValue);
        }

        static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        static double CalculatePerimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }

        static void DisplayResults(double height, double width,
            double area, double perimeter)
        {
            Console.Clear();
            Console.WriteLine("Summary of Rectangle Measurements\n");
            Console.WriteLine("{0, -12} {1,8:N1}", "Height", height);
            Console.WriteLine("{0, -12} {1,8:N1}", "Width", width);
            Console.WriteLine("{0, -12} {1,8:N1}", "Area", area);
            Console.WriteLine("{0, -12} {1,8:N1}", "Perimeter", perimeter);
        }

        static void Main(string[] args)
        {
            double height, width, area, perimeter;

            height = GetSize("height");
            width = GetSize("width");

            area = CalculateArea(height, width);
            perimeter = CalculatePerimeter(height, width);

            DisplayResults(height, width, area, perimeter);

            Console.ReadKey();
        }
    }
}
