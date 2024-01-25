using System.Numerics;
using QA_Work.BI;
using QA_Work.QA_Work.Menu;

namespace QA_Work.BI;

internal class Divide
{
    // Метод для операции деления
    internal static void ShowDivisionResults()
    {
        Console.Clear();
        BigInteger value1;

        // Цикл для ввода первого числа, продолжается, пока не введено корректное значение
        do
        {
            Console.Clear();
            Console.WriteLine("Введите первое число:");
            string userInput = Console.ReadLine();

            // Проверка на корректность ввода, если ввод пустой или не является числом
            if (string.IsNullOrWhiteSpace(userInput) || !BigInteger.TryParse(userInput, out value1))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите правильное значение: ");
                continue;
            }

            break;
        } while (true);

        BigInteger value2;

        // Цикл для ввода второго числа, продолжается, пока не введено корректное значение
        do
        {
            Console.WriteLine("Введите второе число:");
            string userInput = Console.ReadLine();
            var isEmpty = string.IsNullOrWhiteSpace(userInput);
            var parseResult = BigInteger.TryParse(userInput, out value2);
            var isZero = value2 == 0;

            // Проверка на корректность второго числа
            var isNotValid = isEmpty || !parseResult || isZero;

            if (isNotValid)
            {
                Console.Clear();
                Console.WriteLine("Введите первое число:");
                Console.WriteLine(value1);
                continue;
            }

            break;
        } while (true);

        // Выполнение операции деления с использованием статического метода
        BigInteger result = BigInteger2.DivideBigIntegers(ref value1, ref value2);

        Console.WriteLine($"Ответ: {result}");
        Console.ReadLine();
        Calculator.Start();
    }
}
