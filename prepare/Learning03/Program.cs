using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction empty = new Fraction();
        Fraction part = new Fraction(6);
        Fraction full = new Fraction(6,7);

        Console.WriteLine($"empty: {empty.GetTop()}, part: {part.GetBottom()}, full: {full.GetTop()}");

        empty.SetTop(9);
        part.SetBottom(8);

        Console.WriteLine($"empty: {empty.GetTop()}, part: {part.GetBottom()}, full: {full.GetTop()}");

        Console.WriteLine($"empty: {empty.GetFractionString()}, part: {part.GetFractionString()}, full: {full.GetFractionString()}");

        Console.WriteLine($"empty: {empty.GetDecimalValue()}, part: {part.GetDecimalValue()}, full: {full.GetDecimalValue()}");
    }
}