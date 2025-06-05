#! /home/adavidoaiei/dotnet/dotnet run

Console.Write("Enter a number: ");
var count = Int32.Parse(Console.ReadLine());

// Print message 'count' number of times
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Hello from a C# script!");
}