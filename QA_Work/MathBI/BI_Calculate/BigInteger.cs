using System;
using System.Text;
using QA_Work.QA_Work.Menu;
using QA_Work.QA_Work.Menu.MenuLogic;

namespace QA_Work.BI_Calculate;

public class BigInteger
{
    private static List<int>? operand1;
    private static List<int>? operand2;
    private static List<int> result;

    // Конструктор класса
    public BigInteger(string operand1, string operand2)
    {
        // Попытка парсинга строк в списки чисел
        TryParse(operand1, out BigInteger.operand1);
        TryParse(operand2, out BigInteger.operand2);

        // Проверка на корректность парсинга
        if (BigInteger.operand1 == null || BigInteger.operand2 == null)
        {
            Console.WriteLine("Неверные операнды. Программа завершена.");
            return;
        }

        // Выравнивание операндов до одинаковой длины
        int maxLength = Math.Max(BigInteger.operand1.Count, BigInteger.operand2.Count);
        PadOperands(BigInteger.operand1, maxLength);
        PadOperands(BigInteger.operand2, maxLength);

        // Выполнение операций и вывод результатов
        ShowMenu.ShowThirdActions();
    }

    // Метод для попытки парсинга строки в список чисел
    internal static bool TryParse(string value, out List<int>? arr)
    {
        try
        {
            arr = value.Select(c => int.Parse(c.ToString())).ToList();
            return true;
        }
        catch
        {
            arr = null;
            return false;
        }
    }

    // Метод для выравнивания операндов до указанной длины
    internal void PadOperands(List<int> operand, int targetLength)
    {
        while (operand.Count < targetLength)
        {
            operand.Insert(0, 0);
        }
    }

    // Методы для выполнения операций и вывода результатов
    public static void PerformAdd()
    {
        PrintResult("Сумма", BI_Add.Add(operand1, operand2));
    }
    public static void PerformSubstract()
    {
        PrintResult("Разность", BI_Substract.Subtract(operand1, operand2));
    }
    public static void PerformMultiply()
    {
        PrintResult("Произведение", BI_Multiply.Multiply(operand1, operand2));
    }
    public static void PerformDivide()
    {
        PrintResult("Деление", BI_Divide.Divide(operand1, operand2));
    }

    // Метод для вывода результата операции
    public static void PrintResult(string operation, List<int> result)
    {
        Console.WriteLine($"{operation} Результат: " + string.Join("", result));
        Console.Clear();
        Console.ReadLine();
        Calculator.Start();
    }
}
