using System;
using System.Text;
using QA_Work.MathBI.BI_Calculate;

namespace QA_Work.MathBI;

public class BigInteger : IBigInteger
{
    private List<int> result = new List<int>();
    private List<int>? operand1 = new List<int>();
    private List<int>? operand2 = new List<int>();

    // Конструктор класса
    public BigInteger(string operand1, string operand2)
    {
        // Попытка парсинга строк в списки чисел
        TryParse(operand1, out this.operand1);
        TryParse(operand2, out this.operand2);

        // Проверка на корректность парсинга
        if (this.operand1 == null || this.operand2 == null)
        {
            Console.WriteLine("Неверные операнды. Программа завершена.");
            return;
        }

        // Выравнивание операндов до одинаковой длины
        int maxLength = Math.Max(this.operand1.Count, this.operand2.Count);
        PadOperands(this.operand1, maxLength);
        PadOperands(this.operand2, maxLength);

        // Выполнение операций и вывод результатов
        PerformOperations();
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

    // Метод для выполнения операций и вывода результатов
    private void PerformOperations()
    {
        PrintResult("Сумма", BI_Add.Add(operand1, operand2));
        PrintResult("Разность", BI_Substract.Subtract(operand1, operand2));
        PrintResult("Произведение", BI_Multiply.Multiply(operand1, operand2, 2));
        PrintResult("Деление", BI_Divide.Divide(operand1, operand2, 2));
    }

    public void Add(IBigInteger operand)
    {
        if (operand is BigInteger bigIntegerOperand)
        {
            result = BI_Add.Add(operand1, operand2);
        }
        else
        {
            throw new ArgumentException("Invalid operand type for addition.");
        }
    }

    public void Subtract(IBigInteger operand)
    {
        if (operand is BigInteger bigIntegerOperand)
        {
            result = BI_Substract.Subtract(operand1, operand2);
        }
        else
        {
            throw new ArgumentException("Invalid operand type for subtraction.");
        }
    }

    public void Multiply(IBigInteger operand)
    {
        if (operand is BigInteger bigIntegerOperand)
        {
            result = BI_Multiply.Multiply(operand1, operand2, 2);
        }
        else
        {
            throw new ArgumentException("Invalid operand type for multiplication.");
        }
    }

    public void Divide(IBigInteger operand)
    {
        if (operand is BigInteger bigIntegerOperand)
        {
            result = BI_Divide.Divide(operand1, operand2, 2);
        }
        else
        {
            throw new ArgumentException("Invalid operand type for division.");
        }
    }

    // Метод для вывода результата операции
    public void PrintResult(string operation, List<int> result)
    {
        Console.WriteLine($"{operation} Результат: " + string.Join("", result));
        Console.WriteLine();
    }
}
