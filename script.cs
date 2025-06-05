#! /home/adavidoaiei/dotnet/dotnet run

Console.Write("Enter a number: ");
int count;

// Validate input to ensure it's a valid integer
while (!int.TryParse(Console.ReadLine(), out count))
{
    Console.Write("Please enter a valid number: ");
}

// Print message 'count' number of times
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"This is message #{i + 1}");
}