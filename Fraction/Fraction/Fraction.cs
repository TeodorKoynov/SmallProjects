using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    class Fraction
    {
        // Fields
        private decimal baseNum = 0;
        private decimal divider = 0;

        // Properties
        public string TextRepresentation
        {
            get
            {
                string value = $"{baseNum}/{divider}";
                return value;
            }
        }

        public decimal Value
        {
            get
            {
                return (baseNum / divider);
            }
        }

        // Constructors
        public Fraction(int baseNum, int divider)
        {
            this.baseNum = baseNum;
            this.divider = divider;
        }
        public Fraction(string text)
        {
            string[] numbers = new string[2];
            numbers = text.Split("/", StringSplitOptions.RemoveEmptyEntries);
            new Fraction(int.Parse(numbers[0]), int.Parse(numbers[1]));
        }


        // Methods

        // Parses text To Fraction
        public static Fraction Parse(string text)
        {
            string[] numbers = new string[2];
            numbers = text.Split("/", StringSplitOptions.RemoveEmptyEntries);
            return new Fraction(int.Parse(numbers[0]), int.Parse(numbers[1]));
        }

        public static Fraction Parse(int baseNum, int divider)
        {
            return new Fraction(baseNum, divider);
        }

        public string MyToString()
        {
            return $"{this.baseNum}/{this.divider}";
        }


        // Reduces the number
        public void Reduce()
        {
            for (int i = 2; i < 10; i++)
            {
                while (baseNum % i == 0 && divider % i == 0)
                {
                        baseNum /= i;
                        divider /= i;
                }
            }
        }
    }
}
