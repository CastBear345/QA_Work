using QA_Work.BI_Calculate;
using System;
using System.Text;

namespace QA_Work.QA_Work.Menu;

public class UserInterface
{
    // Метод для выполнения операций с калькулятором, используя BigInteger
    public static void PerformCalculatorOperations()
    {
        try
        {
            Console.Clear();
            string operand1 = GetOperand("Введите первое число: ");
            string operand2 = GetOperand("Введите второе число: ");

            // Создание объекта BigInteger на основе введенных операндов
            var bigInteger = new BigInteger(operand1, operand2);

            // Здесь можно выполнять дополнительные операции с объектом bigInteger
            // Например, вывод результатов или выполнение математических операций

            Console.WriteLine("Операции с BigInteger выполнены успешно.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            Console.WriteLine();
        }
    }

    // Метод для получения корректного числового ввода от пользователя
    public static string GetOperand(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        // Проверка на пустой ввод или ввод, содержащий нечисловые символы
        if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
        {
            throw new ArgumentException("Некорректный ввод. Программа завершена.");
        }

        Console.WriteLine();
        return input;
    }
}