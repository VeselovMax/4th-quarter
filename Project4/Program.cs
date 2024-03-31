using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray<int> arr1 = new OneDimensionalArray<int>();
            arr1.Add(4096);
            arr1.Add(1024);
            arr1.Add(256);
            arr1.Add(64);
            arr1.Add(16);
            arr1.Add(4);
            arr1.Add(1);
            arr1.Delete(6);
            arr1.Add(-1);
            OneDimensionalArray<bool> arr2 = new OneDimensionalArray<bool>(4);
            arr2.Add(false);
            arr2.Add(true);
            arr2.Add(false);
            arr2.Add(true);
            arr2.Add(false);
            arr2.Add(true);

            /*
            arr1.Print();
            arr1.BubbleSort();
            arr1.Print();
            Console.WriteLine(arr1.MaxValue());
            Console.WriteLine(arr1.MinValue());
            arr2.Print();
            arr2.BubbleSort();
            arr2.Print();
            Console.WriteLine(arr2.MaxValue());
            Console.WriteLine(arr2.MinValue());

            
            Predicate<int> condition = (int x) =>
            {
                if (x > 1000)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(arr1.CountThatFollow(condition));

            int[] arr3 = arr1.AllThatFollow(condition);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            arr2.Reverse();
            arr2.Print();
            */
        }
        
        static bool CheckFromUser()
        {
            bool answer = false;
            bool incorrectAnswer = true;
            string input;
            while (incorrectAnswer)
            {
                input = Console.ReadLine();
                if (input == "yes")
                {
                    answer = true;
                    incorrectAnswer = false;
                }
                else if (input == "no")
                {
                    answer = false;
                    incorrectAnswer = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный ответ! Попробуйте снова.");
                }
            }
            return answer;
        }
    }
}
