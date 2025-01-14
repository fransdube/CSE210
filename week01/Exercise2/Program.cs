using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements
        // 1. Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // 2. Determine the letter grade
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 3. Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You'll do better next time.");
        }

        // 4. Print the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Stretch Challenge
        // Determine the sign (+ or -)
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (letter != "F") // No signs for F grades
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle exceptional cases
        if (letter == "A" && sign == "+") // No A+ grade
        {
            sign = "";
        }
        if (letter == "F") // No F+ or F- grades
        {
            sign = "";
        }

        // Print the final grade with sign
        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}