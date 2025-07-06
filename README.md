# C# Scripts Collection

A collection of useful C# scripts demonstrating various programming concepts and functionalities.

*   [Scripts Overview](#scripts-overview)
*   [Getting Started](#getting-started)
    *   [Prerequisites](#prerequisites)
    *   [Installation](#installation)
*   [Usage](#usage)
*   [Example Outputs](#example-outputs)

## Scripts Overview

This repository contains the following scripts:

### 1. Message Generator (`script.cs`)
A simple script that demonstrates basic console input/output and loop functionality.
- Prompts for a number.
- Validates the input.
- Prints numbered messages the specified number of times.

### 2. Web Scraper (`scrapping.cs`)
A web scraping script for `litoralulromanesc.ro` that:
- Fetches hotel offers from the website.
- Extracts hotel names, locations, prices, and periods.
- Displays the extracted information in a formatted output.
- **Dependency**: `HtmlAgilityPack`

### 3. Time Humanizer (`humanizerScript.cs`)
A script that uses the Humanizer library to display time in a user-friendly format.
- Calculates the time elapsed since .NET 9's release date.
- Converts the `TimeSpan` into a human-readable string (e.g., "6 months ago").
- Demonstrates date manipulation and third-party package usage.
- **Dependency**: `Humanizer`

## Getting Started

Follow these instructions to get the scripts running on your local machine.

### Prerequisites

- .NET SDK (which includes `dotnet-script`)

### Installation

1.  **Clone the repository or download the scripts.**

2.  **Navigate to the script directory:**
    ```bash
    cd /path/to/scripts
    ```

3.  **Install NuGet dependencies:**
    The `scrapping.cs` and `humanizerScript.cs` scripts have package dependencies which are automatically fetched by `dotnet-script` on the first run. No manual installation is needed.

## Usage

You can run the scripts in two ways.

### Option 1: Using `dotnet-script` (Recommended)

This is the standard, cross-platform way to execute the scripts.

```bash
dotnet script script.cs
dotnet script scrapping.cs
dotnet script humanizerScript.cs
```

### Option 2: As Executable Files (Linux/macOS)

The scripts are configured to be directly executable on Unix-like systems.

1.  **Make the scripts executable:**
    ```bash
    chmod +x *.cs
    ```

2.  **Run the scripts:**
    ```bash
    ./script.cs
    ./scrapping.cs
    ./humanizerScript.cs
    ```
> **How does this work?** The scripts use a "shebang" line (`#!/usr/bin/env dotnet-script`) at the top, which tells the system to use the `dotnet-script` interpreter to run the file.

## Example Outputs

### Message Generator (`script.cs`)
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

### Time Humanizer (humanizerScript.cs)
```
.NET 9 was released 6 months ago
```

## Notes

- All scripts are executable and use the .NET SDK
- Some scripts require additional NuGet packages
- The web scraper results may vary based on available offers
- The humanizer script shows relative time based on current date
