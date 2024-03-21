using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
