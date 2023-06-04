namespace Lesson_1_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1) Вычислить n-ое треугольного число(сумма чисел от 1 до n), n!(произведение чисел от 1 до n)

            int number = Input();

            Summa(number);
            Factorial(number);


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

            ///<summary>
            ///Расчет суммы чисел от 1 до заданного по формуле Гауса
            /// </summary>
            void Summa(int number)
            {
                Console.WriteLine($"Сумма чисел от 1 до {number} равна: {(number * (number + 1)/2)}");
            }

            ///<summary>
            ///Расчет факториала числа
            /// </summary>
            void Factorial(int number)
            {
                int fact = 1;
                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"Факториал числа равен: {fact}");
            }
        }
    }
}
