using QA_Work.MathBI;
using System;
using System.Text;

namespace QA_Work.Menu;

public class UserInterface
{
    public static void PerformCalculatorOperations()
    {
        try
        {
            string operand1 = GetOperand("Введите первое число: ");
            string operand2 = GetOperand("Введите второе число: ");

            IBigInteger bigInteger = new BigInteger(operand1, operand2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            Console.WriteLine();
        }
    }

    public static string GetOperand(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
        {
            throw new ArgumentException("Некорректный ввод. Программа завершена.");
        }

        Console.WriteLine();
        return input;
    }
}