using System;

namespace Project4
{
    public class StringProvider : ValueProvider<string>
    {
        string letters = "abcdefghijklmnopqrstuvwxyzQWERTYUIOPASDFGHJKLZXCVBNM,.;:-=+";

        public override string Generate()
        {
            char[] chars = new char[4];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = letters[random.Next(0, letters.Length)];
            }
            return new string(chars);
        }

        public override string ConvertFromString(string input)
        {
            return input;
        }
    }
}