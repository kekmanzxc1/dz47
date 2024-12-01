using System;
//Завдання 1
class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("1 Decimal to Binary");
        Console.WriteLine("2 Binary to Decimal");
        Console.Write("Select the option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (choice == "1")
        {
            if (int.TryParse(input, out int decimalNumber))
            {
                Console.WriteLine($"Binary : {Convert.ToString(decimalNumber, 2)}");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        else if (choice == "2")
        {
            try
            {
                int decimalNumber = Convert.ToInt32(input, 2);
                Console.WriteLine($"Decimal : {decimalNumber}");
            }
            catch
            {
                Console.WriteLine("Incorrect input");
            }
        }
        else
        {
            Console.WriteLine("Wrong choice");
        }
    }
}

// Завдання 2
/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number in words from 0 до 9:");
        string input = Console.ReadLine()?.ToLower();

        int? result = WordToDigit(input);

        if (result != null)
        {
            Console.WriteLine($"Number: {result}");
        }
        else
        {
            Console.WriteLine("Incorrect entry");
        }
    }

    static int? WordToDigit(string word)
    {
        switch (word)
        {
            case "zero": return 0;
            case "one": return 1;
            case "two": return 2;
            case "three": return 3;
            case "four": return 4;
            case "five": return 5;
            case "six": return 6;
            case "seven": return 7;
            case "eight": return 8;
            case "nine": return 9;
            default: return null;
        }
    }
}
*/