using System;
using System.Numerics;
using System.Text;
using QA_Work.BI;
using QA_Work.QA_Work.Menu;

namespace QA_Work.BI;

internal class Substract
{
    // Метод для операции вычитания
    internal static void ShowExtractResults()
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

        // Выполнение операции вычитания с использованием статического метода
        BigInteger result = BigInteger2.SubstractBigIntegers(value1, value2);

        Console.WriteLine($"Ответ: {result}");
        Console.ReadLine();
        Calculator.Start();
    }
}
