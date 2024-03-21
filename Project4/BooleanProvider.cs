using System;

namespace Project4
{
    public class BooleanProvider : ValueProvider<bool>
    {
        public override bool Generate() {
            if (random.Next(0, 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool ConvertFromString(string input)
        {
            return bool.Parse(input);
        }
    }
}