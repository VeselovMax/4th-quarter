using System;

namespace Project4
{
    public abstract class BaseArray<T> : IBaseArray
    {
        protected ValueProvider<T> provider;
        public BaseArray(bool getFromUser, ValueProvider<T> input_provider)
        {
            provider = input_provider;
            Create(getFromUser);
        }

        public void Create(bool getFromUser)
        {
            if (getFromUser)
            {
                GetFromUser();
            }
            else
            {
                GetRandom();
            }
        }

        protected abstract void GetFromUser();

        protected abstract void GetRandom();

        public abstract void Print();
    }
}
