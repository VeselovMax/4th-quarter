using System;

namespace Project4
{
    public sealed class OneDimensionalArray<T> : BaseArray<T>
        where T : IComparable<T>
    {        
        private T[] array;

        public int size;

        private const int defaultCapacity = 7;

        public OneDimensionalArray() {
            array = new T[defaultCapacity];
            size = 0;
        }

        public OneDimensionalArray(int n) {
            array = new T[n];
            size = 0;
        }

        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        public void AddElement(T newEl)
        {
            if (size >= array.Length)
            {
                //T[] newArray = new T[_capacity];
                //Array.CopyTo(newArray, 0, _array, _size);
                //_array = newArray;
                Array.Resize(ref array, array.Length*2+1);
            }
            array[size] = newEl;
            size++;
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
            for (int i = 0; i < array.Length; i++)
            {
                if (conditionFunc(array[i]))
                {
                    return array[i];
                }
            }
            return array[0];
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
                if (conditionFunc(array[i]))
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

        public T MinValue()
        {
            T min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (min.CompareTo(array[i]) > 0)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public T MaxValue()
        {
            T max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (max.CompareTo(array[i]) < 0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public void BubbleSort() {
            T el;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j + 1 < array.Length - i; j++) {
                    if (array[j + 1].CompareTo(array[j]) < 0)
                    {
                        el = array[j];
                        array[j] = array[j+1];
                        array[j+1] = el;
                    }
                }
            }
        }
    }
}