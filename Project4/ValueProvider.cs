using System;

namespace Project4
{
    public abstract class ValueProvider<T>
    {
        protected Random random = new Random();
        
        public abstract T Generate();

        public abstract T ConvertFromString(string input);
    }
}