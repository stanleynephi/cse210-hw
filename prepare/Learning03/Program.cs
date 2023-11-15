using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.Write(fraction.GetFractionDouble());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.Write(fraction1.GetFractionDouble());

        Fraction fraction2 = new Fraction(3,4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.Write(fraction2.GetFractionDouble());

        Fraction fraction3 = new Fraction(1,3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.Write(fraction3.GetFractionDouble());

    }
}