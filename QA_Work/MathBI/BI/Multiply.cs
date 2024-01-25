using System.Numerics;
using QA_Work.BI;
using QA_Work.QA_Work.Menu;
namespace QA_Work.BI;

internal class Multiply
{
    // Метод для операции умножения
    internal static void ShowMultiplyResults()
    {
        Console.Clear();
        BigInteger value1;

        // Цикл для ввода первого числа, продолжается, пока не введено корректное значение
        do
        {
            Console.Clear();
            Console.WriteLine("Введите первое число:");
        } while (!BigInteger.TryParse(Console.ReadLine(), out value1));

        BigInteger value2;

        // Цикл для ввода второго числа, продолжается, пока не введено корректное значение
        do
        {
            Console.Clear();
            Console.WriteLine("Введите первое число:");
            Console.WriteLine(value1);
            Console.WriteLine("Введите второе число:");
        } while (!BigInteger.TryParse(Console.ReadLine(), out value2));

        // Выполнение операции умножения с использованием статического метода
        BigInteger result = BigInteger2.MultiplyBigIntegers(value1, value2);

        Console.WriteLine($"Ответ: {result}");
        Console.ReadLine();
        Calculator.Start();
    }
}
