using System;
using System.ComponentModel;

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

        public void DeleteElement()
        {

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

        public int CountThatFollow(Predicate<T> conditionFunc)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (conditionFunc(array[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public bool IfAtLeastOneFollows(Predicate<T> conditionFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (conditionFunc(array[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IfAllFollow(Predicate<T> conditionFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!conditionFunc(array[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public T FirstThatFollows(Predicate<T> conditionFunc)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (conditionFunc(array[i]))
                    {
                        return array[i];
                    }
                }
                return array[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DoToEveryElement(Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }

        public T[] AllThatFollow(Predicate<T> conditionFunc)
        {
            T[] allThatFollow = new T[CountThatFollow(conditionFunc)];
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!conditionFunc(array[i]))
                {
                    allThatFollow[n] = array[i];
                    n++;
                }
            }
            return allThatFollow;
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
                    n++;
                }
            }
            return elementsOfType;
        }

        public void Reverse(T[] array)
        {
            T el;
            for (int i = 0; i < array.Length-1-i; i++)
            {
                el = array[i];
                array[i] = array[array.Length-1-i];
                array[array.Length-1-i] = el;
            }
        }

        public void MinValue()
        {
            
        }

        public void MaxValue()
        {

        }
    }
}
