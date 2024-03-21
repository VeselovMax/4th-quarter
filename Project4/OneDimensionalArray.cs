using System;
using System.Security.Principal;


namespace Project4
{
    public sealed class OneDimensionalArray<T> : BaseArray<T>
    {
        private T[] array;


        public OneDimensionalArray() {
            array = new T[7];
        }


        public OneDimensionalArray(int n) {
            array = new T[n];
        }


        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        public bool CheckForEmptySlots(ref int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        public void AddElement(T newEl)
        {
            int index = 0;
            if (CheckForEmptySlots(ref index))
            {
                array[index] = newEl;
            }
            else
            {
                int oldLength = array.Length;
                Array.Resize(ref array, array.Length * 2 + 1);
                array[oldLength] = newEl;
            }
        }

        public int NumberOfElements<C>()
        {
            int n = 0;
            foreach (T el in array)
            {
                if (el is C)
                {
                    n++;
                }
            }
            return n;
        }


        public void Reverse<T>(T[] array)
        {
            T el;
            for (int i = 0; i < array.Length; i++)
            {
                el = array[i];
                array[i] = array[array.Length-1-i];
                array[array.Length-1-i] = el;
            }
        }
        public void DeleteElement()
        {

        }

        public T[] ElementsOfType<C>()
        {
            T[] elementsOfType = new T[NumberOfElements<C>()];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is C)
                {
                    elementsOfType[n] = array[i];
                }
            }
            return elementsOfType;
        }
    }
}
