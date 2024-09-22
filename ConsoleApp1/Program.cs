using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        string input;

        Console.WriteLine("Enter numbers (press Enter to stop):");

        while (true)
        {
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Largest number: {max}");
            Console.WriteLine($"Smallest number: {min}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    
    }
}
