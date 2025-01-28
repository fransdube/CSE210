using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions using all three constructors
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(5); // 5/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4
        Fraction fraction4 = new Fraction(1, 3); // 1/3

        // Display fraction strings and decimal values
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Test setters and getters
        fraction1.SetTop(2);
        fraction1.SetBottom(3);
        Console.WriteLine(fraction1.GetFractionString()); // Should print 2/3
        Console.WriteLine(fraction1.GetDecimalValue()); // Should print 0.6666666666666666
    }
}