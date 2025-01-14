using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Ask the user for numbers until they enter 0
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        // Core Requirements
        // 1. Compute the sum of the numbers
        int sum = numbers.Sum();

        // 2. Compute the average of the numbers
        double average = numbers.Average();

        // 3. Find the largest number in the list
        int max = numbers.Max();

        // Display results for core requirements
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge
        // 1. Find the smallest positive number (closest to zero)
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();

        // 2. Sort the numbers and display the sorted list
        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}