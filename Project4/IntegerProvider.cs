using System;

namespace Project4
{
    public class IntegerProvider : ValueProvider<int>
    {
        public override int Generate()
        {
            return random.Next(0, 101);
        }

        public override int ConvertFromString(string input)
        {
            return int.Parse(input);
        }
    }
}