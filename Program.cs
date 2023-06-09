using System.Timers;

namespace Lesson_1_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 4) (дополнительное задание) Задано уравнение вида q + w = e, q, w, e >= 0.
            // Некоторые цифры могут быть заменены знаком вопроса, например, 2? + ?5 = 69.
            // Требуется восстановить выражение до верного равенства.
            // Знаки вопроса -одинаковые цифры.
            // Предложить хотя бы одно решение или сообщить, что его нет.

            Console.WriteLine("Введите уравнение вида q + w = e;\nq, w, e >=0\n");

            string theEquation = Console.ReadLine();

            string[] numbers = theEquation.Split(' ', '+', '=');

            string firstTerm = numbers[0];
            string secondTerm = numbers[1];
            string sum = numbers[2];

            var firstTermQuestion = LookingForQuestion(firstTerm);
            var secondTermQuestion = LookingForQuestion(secondTerm);          


            ///<summary>
            ///Кортеж. Проверяет, есть ли в слагаемом вопрос и, если есть, запоминает его индекс
            ///</summary>
            (bool question, int position) LookingForQuestion(string number)
            {
                bool question = false;
                int position = 0;

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i].ToString() == "?")
                    {
                        question = true;
                        position = i + 1;
                    }
                }
                return (question, position);
            }

            if (firstTermQuestion.question == true && secondTermQuestion.question == true)
            {
                int result1 = 0, result2 = 0;

                if (firstTermQuestion.position == 1 && secondTermQuestion.position == 2)
                {
                    result1 = Convert.ToInt32(sum[0]) - Convert.ToInt32(secondTerm[0]);
                    Console.WriteLine(result1);
                    result2 = Convert.ToInt32(sum[1]) - Convert.ToInt32(secondTerm[1]);
                    Console.WriteLine(result2);
                }
                if (firstTermQuestion.position == 2 && secondTermQuestion.position == 1)
                {
                    result1 = Convert.ToInt32(sum[1]) - Convert.ToInt32(secondTerm[1]);
                    result2 = Convert.ToInt32(sum[0]) - Convert.ToInt32(secondTerm[0]);
                }
                if (result1 == result2)
                {
                    Console.WriteLine($"Скрытое значение: {result1}");
                }
                else
                {
                    Console.WriteLine("Решений может быть несколько или ни одного");
                }
            }


        }
    }
}
