#!/home/adavidoaiei/dotnet/dotnet run

#:package HtmlAgilityPack@1.12.1

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;


var httpClient = new HttpClient();
var html = await httpClient.GetStringAsync("https://www.litoralulromanesc.ro/oferte_litoral.htm");

var htmlDocument = new HtmlDocument();
htmlDocument.LoadHtml(html);

// Select all hotel offer containers
var offerNodes = htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'hotel_box')]");

if (offerNodes != null)
{
    foreach (var offerNode in offerNodes)
    {
        // Extract hotel name
        var hotelName = offerNode.SelectSingleNode(".//div[@class='hotel_name']")?.InnerText.Trim();
        
        // Extract location
        var location = offerNode.SelectSingleNode(".//div[@class='statiune']")?.InnerText.Trim();
        
        // Extract price
        var price = offerNode.SelectSingleNode(".//div[contains(@class, 'pret')]")?.InnerText.Trim();
        
        // Extract period
        var period = offerNode.SelectSingleNode(".//div[@class='perioada']")?.InnerText.Trim();

        if (!string.IsNullOrEmpty(hotelName))
        {
            Console.WriteLine("\nHotel Found:");
            Console.WriteLine($"Name: {hotelName}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Period: {period}");
            Console.WriteLine("------------------------");
        }
    }
}
else
{
    Console.WriteLine("No offers found. The website structure might have changed.");
}
