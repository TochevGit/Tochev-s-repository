using System.Globalization;

namespace FuelPriceComparer;

public static class Program
{
    // 1 US gallon = 3.785411784 liters
    private const double LitersPerGallon = 3.785411784;

    public static void Main()
    {
        Console.WriteLine("=== Fuel Price Comparer ===");
        Console.WriteLine();

        double pricePerLiter = ReadPositiveNumber("Enter the price per liter: ");
        double pricePerGallon = ReadPositiveNumber("Enter the price per gallon: ");

        // Convert the gallon price to a per-liter price so both are comparable.
        double gallonPriceAsPerLiter = pricePerGallon / LitersPerGallon;

        Console.WriteLine();
        Console.WriteLine($"Price per liter:                  {pricePerLiter:F3}");
        Console.WriteLine($"Price per gallon (as per liter):  {gallonPriceAsPerLiter:F3}");
        Console.WriteLine();

        const double tolerance = 0.0005;
        double difference = Math.Abs(pricePerLiter - gallonPriceAsPerLiter);

        if (difference < tolerance)
        {
            Console.WriteLine("Both prices are equally economical.");
        }
        else if (pricePerLiter < gallonPriceAsPerLiter)
        {
            Console.WriteLine($"The most economical fuel price is the price per liter: {pricePerLiter:F3} per liter.");
            Console.WriteLine($"You save {difference:F3} per liter ({difference * LitersPerGallon:F3} per gallon).");
        }
        else
        {
            Console.WriteLine($"The most economical fuel price is the price per gallon: {pricePerGallon:F3} per gallon.");
            Console.WriteLine($"You save {difference:F3} per liter ({difference * LitersPerGallon:F3} per gallon).");
        }
    }

    private static double ReadPositiveNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (input is null)
            {
                throw new InvalidOperationException("No input available.");
            }

            input = input.Trim().Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double value) && value > 0)
            {
                return value;
            }

            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}
