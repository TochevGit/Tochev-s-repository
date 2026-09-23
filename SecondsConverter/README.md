# Seconds Converter

A C# console application that asks for a number of total seconds and
converts it to hours, minutes and seconds.

Methods:

- `GetTotalSeconds` - asks the user for the total seconds and returns it
- `CalculateHours` - returns totalSeconds / 3600
- `CalculateMinutes` - returns totalSeconds % 3600 / 60
- `CalculateSeconds` - returns totalSeconds % 60
- `DisplayResults` - clears the screen and prints a summary table
