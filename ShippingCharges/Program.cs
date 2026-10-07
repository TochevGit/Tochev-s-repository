using System;
using System.Globalization;

namespace ShippingCharges
{
    class Program
    {
        // Shipping charge per item - the more items, the cheaper each one ships.
        //   1 - 3 items   : $3.50 per item
        //   4 - 6 items   : $2.95 per item
        //   7 - 10 items  : $2.55 per item
        //   11 or more    : $2.15 per item
        const double RateUpTo3 = 3.50;
        const double RateUpTo6 = 2.95;
        const double RateUpTo10 = 2.55;
        const double RateOver10 = 2.15;

        // Used so the "$" sign and decimal point look the same on every computer.
        static readonly CultureInfo Money = CultureInfo.GetCultureInfo("en-US");

        static void Main(string[] args)
        {
            Console.WriteLine("=== Shipping Charge Calculator ===");
            Console.WriteLine();
            Console.WriteLine("Shipping rates:");
            Console.WriteLine("  1 - 3 items   " + RateUpTo3.ToString("C", Money) + " per item");
            Console.WriteLine("  4 - 6 items   " + RateUpTo6.ToString("C", Money) + " per item");
            Console.WriteLine("  7 - 10 items  " + RateUpTo10.ToString("C", Money) + " per item");
            Console.WriteLine("  11 or more    " + RateOver10.ToString("C", Money) + " per item");
            Console.WriteLine();

            int numberOfItems = ReadNumberOfItems("Enter the number of items purchased: ");

            double ratePerItem = GetRatePerItem(numberOfItems);
            double shippingCharge = numberOfItems * ratePerItem;

            Console.WriteLine();
            Console.WriteLine("Number of items:     " + numberOfItems);
            Console.WriteLine("Charge per item:     " + ratePerItem.ToString("C", Money));
            Console.WriteLine("Total shipping cost: " + shippingCharge.ToString("C", Money));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double GetRatePerItem(int numberOfItems)
        {
            if (numberOfItems <= 3)
            {
                return RateUpTo3;
            }
            else if (numberOfItems <= 6)
            {
                return RateUpTo6;
            }
            else if (numberOfItems <= 10)
            {
                return RateUpTo10;
            }
            else
            {
                return RateOver10;
            }
        }

        static int ReadNumberOfItems(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                int value;
                if (input != null && int.TryParse(input.Trim(), out value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a whole number greater than 0.");
            }
        }
    }
}
