# C# Scripts Collection

A collection of useful C# scripts demonstrating various programming concepts and functionalities.

## Scripts Overview

### 1. Message Generator (script.cs)
A simple script that demonstrates basic console input/output and loop functionality.
- Prompts for a number input
- Validates the input
- Prints numbered messages the specified number of times

### 2. Web Scraper (scrapping.cs)
A web scraping script for litoralulromanesc.ro that:
- Fetches hotel offers
- Extracts hotel names, locations, prices, and periods
- Displays the information in a formatted output

### 3. Time Humanizer (humanizerScript.cs)
A script using the Humanizer library that:
- Calculates time since .NET 9's release
- Converts the timespan into human-readable format
- Demonstrates date manipulation and formatting

## Requirements

- .NET SDK
- HtmlAgilityPack (for scrapping.cs)
- Humanizer package (for humanizer.cs)

## Usage

1. Navigate to the scripts directory:
   ```bash
   cd /path/to/Scripts
   ```

2. Make scripts executable:
   ```bash
   chmod +x *.cs
   ```

3. Run any script:
   ```bash
   ./script.cs    # Run message generator
   ./scrapping.cs # Run web scraper
   ./humanizer.cs # Run time humanizer
   ```

## Example Outputs

### Message Generator (script.cs)
```
Enter a number: 3
This is message #1
This is message #2
This is message #3
```

### Web Scraper (scrapping.cs)
```
Hotel Found:
Name: Example Hotel
Location: Mamaia
Price: 299 RON
Period: 01.07-08.07
------------------------
```

### Time Humanizer (humanizer.cs)
```
.NET 9 was released 6 months ago
```

## Notes

- All scripts are executable and use the .NET SDK
- Some scripts require additional NuGet packages
- The web scraper results may vary based on available offers
- The humanizer script shows relative time based on current date
