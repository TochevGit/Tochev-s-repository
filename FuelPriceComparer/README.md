# Fuel Price Comparer

A C# console program that asks for two fuel prices — a price per **liter** and a
price per **gallon** — and tells you which one is more economical.

The gallon price is converted to a per-liter price (1 US gallon = 3.785411784 L)
so the two can be compared directly.

## Run

```bash
cd FuelPriceComparer
dotnet run
```

## Example

```
=== Fuel Price Comparer ===

Enter the price per liter: 1.50
Enter the price per gallon: 5.40

Price per liter:                  1.500
Price per gallon (as per liter):  1.427

The most economical fuel price is the price per gallon: 5.400 per gallon.
You save 0.073 per liter (0.278 per gallon).
```
