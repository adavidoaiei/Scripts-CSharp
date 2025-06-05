# Message Generator Script

A simple C# script that demonstrates basic console input/output and loop functionality.

## Description

This script:
1. Prompts the user to enter a number
2. Validates the input to ensure it's a valid integer
3. Prints numbered messages to the console the specified number of times

## Requirements

- .NET SDK 10 Preview

## Usage

1. Navigate to the script directory:
   ```bash
   cd Scripts-CSharp
   ```

2. Run the script:
   ```bash
   ./script.cs
   ```

3. When prompted, enter a positive integer
   - The script will validate your input
   - If you enter invalid input, it will keep asking until you provide a valid number

## Example Output

```
Enter a number: 3
This is message #1
This is message #2
This is message #3
```

## Notes

- The script uses input validation to ensure only valid integers are accepted
- Each message is numbered sequentially starting from 1
