using System;

namespace Project4
{
    public sealed class OneDimensionalArray<T> : BaseArray<T>
    {
        private T[] array;

        public OneDimensionalArray(bool getFromUser, ValueProvider<T> input_provider) : base(getFromUser, input_provider) {}

        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        protected override void GetFromUser()
        {
            Console.WriteLine("Получение одномерного массива с клавиатуры, введите длину");
            int length = int.Parse(Console.ReadLine());
            array = new T[length];
            Console.WriteLine("Вводите значения");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = provider.ConvertFromString(Console.ReadLine());
            }
        }

        protected override void GetRandom()
        {
            Random random = new Random();
            int length = random.Next(2, 6);
            array = new T[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = provider.Generate();
            }
        }
    }
}
