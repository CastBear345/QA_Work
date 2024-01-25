using System;
using System.Text;

namespace QA_Work.BI_Calculate;
internal class BI_Multiply
{
    // Метод умножения для списков цифр
    internal static List<int> Multiply(List<int>? operand1, List<int>? operand2)
    {
        // Проверка наличия входных операндов
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for multiplication.");

        // Создание списка для хранения результата умножения
        List<int> result = new List<int>(new int[operand1.Count + operand2.Count - 1]);

        // Если один из множителей равен 0, результат также равен 0
        if (operand1[0] == 0 || operand2[0] == 0)
        {
            return new List<int> { 0 };
        }

        // Вычисление произведения для каждой пары цифр
        for (int i = 0; i < operand1.Count; i++)
        {
            for (int j = 0; j < operand2.Count; j++)
            {
                int product = operand1[i] * operand2[j];
                AddProductToResult(result, product, i + j);
            }
        }

        // Нормализация результата (удаление нулей)
        NormalizeResult(result);

        return result;
    }

    // Метод для добавления произведения в определенную позицию результата
    internal static void AddProductToResult(List<int> result, int product, int position)
    {
        int carry = 0;

        while (result.Count <= position)
        {
            result.Insert(0, 0);
        }

        result[position] += product;

        // Обработка переноса разряда
        while (result[position] > 9)
        {
            carry = result[position] / 10;
            result[position] %= 10;

            position++;

            if (result.Count <= position)
            {
                result.Insert(0, 0);
            }

            result[position] += carry;
        }
    }

    // Метод для нормализации результата (удаление нулей)
    internal static void NormalizeResult(List<int> result)
    {
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }
    }
}
