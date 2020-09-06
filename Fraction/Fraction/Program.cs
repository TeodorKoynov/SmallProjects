using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = Fraction.Parse("1050 / 1205");
            Console.WriteLine(fraction1.TextRepresentation + " " + fraction1.Value);
            Console.WriteLine(fraction1.MyToString());
            fraction1.Reduce();
            Console.WriteLine(fraction1.MyToString());
        }
    }
}
