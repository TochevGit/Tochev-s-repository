using System;
using System.Globalization;

namespace FuelPriceComparer
{
    class Program
    {
        // 1 US gallon = 3.785411784 liters.
        // Declared here, at class level, so every method in the class can use it.
        // (For an imperial/UK gallon, change this to 4.54609.)
        const double LitersPerGallon = 3.785411784;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Fuel Price Comparer ===");
            Console.WriteLine();

            double pricePerLiter = ReadPositiveNumber("Enter the price per liter: ");
            double pricePerGallon = ReadPositiveNumber("Enter the price per gallon: ");

            // Convert the gallon price to a per-liter price so both are comparable.
            double gallonPriceAsPerLiter = pricePerGallon / LitersPerGallon;

            Console.WriteLine();
            Console.WriteLine("Price per liter:                  " + pricePerLiter.ToString("F3"));
            Console.WriteLine("Price per gallon (as per liter):  " + gallonPriceAsPerLiter.ToString("F3"));
            Console.WriteLine();

            double difference = Math.Abs(pricePerLiter - gallonPriceAsPerLiter);

            if (difference < 0.0005)
            {
                Console.WriteLine("Both prices are equally economical.");
            }
            else if (pricePerLiter < gallonPriceAsPerLiter)
            {
                Console.WriteLine("The most economical fuel price is the price per liter: "
                    + pricePerLiter.ToString("F3") + " per liter.");
                PrintSavings(difference);
            }
            else
            {
                Console.WriteLine("The most economical fuel price is the price per gallon: "
                    + pricePerGallon.ToString("F3") + " per gallon.");
                PrintSavings(difference);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void PrintSavings(double differencePerLiter)
        {
            Console.WriteLine("You save " + differencePerLiter.ToString("F3") + " per liter ("
                + (differencePerLiter * LitersPerGallon).ToString("F3") + " per gallon).");
        }

        static double ReadPositiveNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (input != null)
                {
                    input = input.Trim().Replace(',', '.');

                    double value;
                    if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out value) && value > 0)
                    {
                        return value;
                    }
                }

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}
