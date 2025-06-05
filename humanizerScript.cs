#!/home/adavidoaiei/dotnet/dotnet run

#:package Humanizer@2.14.1

using Humanizer;

var dotNet9Released = DateTimeOffset.Parse("2024-12-03");
var timeSince = DateTimeOffset.Now - dotNet9Released;

Console.WriteLine($".NET 9 was released {timeSince.Humanize()} ago");