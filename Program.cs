namespace Lesson_1_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 3) Реализовать простой калькулятор
            // + - / *
            //Введите первое число: A \n
            //Введите знак: *
            //Введите второе число: B
            //Результат: A* B

            double number1 = InputNumber("Введите первое число: ");
            string sign = InputSignOfOperation("Введите знак операции: + или - или * или /");
            double number2 = InputNumber("Введите второе число: ");

            switch (sign)
            {
                case "+":
                    {
                        Addition(number1, number2);
                        break;
                    }
                case "-":
                    {
                        Subtraction(number1, number2);
                        break;
                    }
                case "*":
                    {
                        Multiplication(number1, number2);
                        break;
                    }
                case "/":
                    {
                        Division(number1, number2);
                        break;
                    }
            }



            ///<summary>
            ///Ввод числа
            ///</summary>
            double InputNumber(string message = "Введите число: ")
            {
                Console.WriteLine(message);
                bool isNumbercorrect = double.TryParse(Console.ReadLine(), out double number);

                if (!isNumbercorrect || number < 1)
                {
                    return InputNumber("Вы ввели недопустимое значение, попробуйте ещё раз");
                }
                else
                {
                    return number;
                }
            }

            ///<summary>
            ///Ввод знака операции
            ///</summary>
            string InputSignOfOperation(string message = "Введите знак операции: + или - или * или /")
            {
                Console.WriteLine(message);
                string sign = Console.ReadLine();

                if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
                {
                    return sign;
                }
                else
                {
                    return InputSignOfOperation("Вы ввели неверный символ, попробуйте ещё раз (+ или - или * или /): ");
                }

            }

            ///<summary>
            ///Сумма чисел
            /// </summary>
            void Addition(double number1, double number2)
            {
                Console.WriteLine($"Сумма чисел {number1} + {number2} = {number1 + number2}");
            }

            ///<summary>
            ///Разность чисел
            /// </summary>
            void Subtraction(double number1, double number2)
            {
                Console.WriteLine($"Разность чисел {number1} - {number2} = {number1 - number2}");
            }

            ///<summary>
            ///Умножение чисел
            /// </summary>
            void Multiplication(double number1, double number2)
            {
                Console.WriteLine($"Произведение чисел {number1} * {number2} = {number1 * number2}");
            }

            ///<summary>
            ///Деление чисел
            /// </summary>
            void Division(double number1, double number2)
            {
                Console.WriteLine($"Частное от деления числа {number1} на число {number2} = {number1 / number2}");
            }
        }
    }
}
