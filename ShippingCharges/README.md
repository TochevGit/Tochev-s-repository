# Shipping Charge Calculator

A C# console application that calculates shipping charges based on the number of
items purchased. The charge per item goes down as the number of items goes up.

| Items purchased | Charge per item |
|-----------------|-----------------|
| 1 – 3           | $3.50           |
| 4 – 6           | $2.95           |
| 7 – 10          | $2.55           |
| 11 or more      | $2.15           |

## Run

```bash
cd ShippingCharges
dotnet run
```

## Example

```
Enter the number of items purchased: 8

Number of items:     8
Charge per item:     $2.55
Total shipping cost: $20.40
```
