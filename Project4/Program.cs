using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray<int> arr1 = new OneDimensionalArray<int>();
            arr1.AddElement(4096);
            arr1.AddElement(1024);
            arr1.AddElement(256);
            arr1.AddElement(64);
            arr1.AddElement(16);
            arr1.AddElement(4);
            arr1.AddElement(1);
            OneDimensionalArray<bool> arr2 = new OneDimensionalArray<bool>(4);
            arr2.AddElement(false);
            arr2.AddElement(true);
            arr2.AddElement(false);
            arr2.AddElement(true);
            arr2.AddElement(false);
            arr2.AddElement(true);
            arr1.Print();
            arr2.Print();

            Predicate<int> condition = (int x) =>
            {
                if (x > 1000)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(arr1.CountThatFollow(condition));
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
