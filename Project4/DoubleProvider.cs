using System;

namespace Project4
{
    class DoubleProvider : ValueProvider<double>
    {
        public override double Generate()
        {
            return random.NextDouble();
        }

        public override double ConvertFromString(string input)
        {
            return double.Parse(input);
        }
    }
}