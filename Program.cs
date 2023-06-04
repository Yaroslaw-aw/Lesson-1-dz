namespace Lesson_1_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 2) Вывести все простые числа от 1 до 1000

            int number = Input();
            simpleNumbers(number);


            ///<summary>
            ///Ищет и выводит на консоль все простые числа от 2 до заданного
            /// </summary>
            void simpleNumbers(int number)
            {
                List<int> simpleNumbers = new List<int>();
                simpleNumbers.Add(2);

                int actualRange = (int)Math.Sqrt(number) + 2; // актуальный диапазон чисел, который имеет смысл проверять

                // собираем простые числа в список
                for (int i = 3; i <= number; i += 2)
                {
                    bool isSimpleNumber = true;

                    foreach (int simple in simpleNumbers)
                    {
                        if (simple > actualRange)
                        {
                            break;
                        }
                        if (i % simple == 0)
                        {
                            isSimpleNumber = false;
                            break;
                        }
                    }
                    if (isSimpleNumber == true)
                    {
                        simpleNumbers.Add(i);
                    }
                }
                // вывод списка простых чисел на экран
                Console.Write($"Все простые числа от 2 до {number}:\n[{String.Join(", ", simpleNumbers)}]\n");
            }



            ///<summary>
            ///Ввод числа
            ///</summary>
            int Input(string message = "Введите число: ")
            {
                Console.WriteLine(message);
                bool isNumbercorrect = int.TryParse(Console.ReadLine(), out int number);

                if (!isNumbercorrect || number < 1)
                {
                    return Input("Вы ввели недопустимое значение, попробуйте ещё раз");
                }
                else
                {
                    return number;
                }
            }

            
        }
    }
}
