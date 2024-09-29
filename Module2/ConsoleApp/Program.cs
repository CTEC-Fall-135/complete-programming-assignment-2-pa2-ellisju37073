using System;

class Program
{
    static void Main()
    {
        // Task2 Part 1
        #region Task2 Part 1
        // Declare an int variable and set it to the max value
        int maxValue = int.MaxValue;

        // Print the value both as a normal int and in its Hex format
        Console.WriteLine($"Int Max Value: {maxValue}");
        Console.WriteLine($"Int Max Value (Hex): {maxValue:X}");

        // Increment the variable by one (causing overflow)
        maxValue++;
        Console.WriteLine($"\nAfter Incrementing by 1:");
        Console.WriteLine($"Int Value: {maxValue}");
        Console.WriteLine($"Int Value (Hex): {maxValue:X}");

        // Set the variable to 0 and print its value
        maxValue = 0;
        Console.WriteLine($"\nSet to 0:");
        Console.WriteLine($"Int Value: {maxValue}");
        Console.WriteLine($"Int Value (Hex): {maxValue:X}");

        // Decrement the variable by one (causing underflow)
        maxValue--;
        Console.WriteLine($"\nAfter Decrementing by 1:");
        Console.WriteLine($"Int Value: {maxValue}");
        Console.WriteLine($"Int Value (Hex): {maxValue:X}");
        #endregion

        // Casting Section
        #region Casting
        // Assign the max value to your int variable
        int intValue = int.MaxValue;

        // Declare a short variable and initialize its value to the int variable using casting
        short shortValue = (short)intValue;

        // Print the int variable as a number and in the hexadecimal format
        Console.WriteLine($"\nCasting Section:");
        Console.WriteLine($"Int Max Value: {intValue}");
        Console.WriteLine($"Int Max Value (Hex): {intValue:X}");

        // Print the short variable as a number and in the hexadecimal format
        Console.WriteLine($"Short Value after casting: {shortValue}");
        Console.WriteLine($"Short Value (Hex): {shortValue:X}");
        #endregion

        // Task 3: Arrays and Loops
        #region Loops
        // Declare an array of ints of size 5
        int[] numbers = new int[5];

        // Use a for loop to initialize the values in the range of 1 to 5
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        // Use a foreach loop to print the array values on a single line
        Console.WriteLine("\nArray values:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        #endregion

        // Task 3 Bonus: Multiplication Table
        #region Loop bonus
        Console.WriteLine("\nMultiplication Table (1 to 5):");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
        #endregion

        // Task 4: Printer Troubleshooter Program
        #region Printer troubleshooter
        string condition = "";

        // Ask the first question
        Console.WriteLine("\nIs the printer on? (Y/N)");
        string answer1 = Console.ReadLine();
        condition += answer1.ToUpper() == "Y" ? "Y" : "N";

        // Ask the second question
        Console.WriteLine("Does the printer have paper? (Y/N)");
        string answer2 = Console.ReadLine();
        condition += answer2.ToUpper() == "Y" ? "Y" : "N";

        // Ask the third question
        Console.WriteLine("Is there a paper jam? (Y/N)");
        string answer3 = Console.ReadLine();
        condition += answer3.ToUpper() == "Y" ? "Y" : "N";

        // Print the condition variable (for testing)
        // Console.WriteLine($"\nCondition String: {condition}"); // Uncomment to test

        // Switch statement with troubleshooting steps
        switch (condition)
        {
            case "YYY":
                Console.WriteLine("No problems detected.");
                break;
            case "YYN":
                Console.WriteLine("Check for other issues. Printer seems fine.");
                break;
            case "YNY":
                Console.WriteLine("Check for a paper jam.");
                break;
            case "YNN":
                Console.WriteLine("Load paper into the printer.");
                break;
            case "NYY":
                Console.WriteLine("Turn on the printer.");
                break;
            case "NYN":
                Console.WriteLine("Turn on the printer and load paper.");
                break;
            case "NNY":
                Console.WriteLine("Turn on the printer and check for a paper jam.");
                break;
            case "NNN":
                Console.WriteLine("Turn on the printer and load paper.");
                break;
            default:
                Console.WriteLine("Invalid input. Please answer with 'Y' or 'N'.");
                break;
        }
        #endregion
    }
}
