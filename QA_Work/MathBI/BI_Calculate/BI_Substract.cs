using System;
using System.Text;

namespace QA_Work.BI_Calculate;

internal class BI_Substract
{
    // Метод вычитания для списка цифр
    internal static List<int> Subtract(List<int>? operand1, List<int>? operand2)
    {
        // Проверка наличия входных операндов
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for subtraction.");

        // Создание списка для хранения результата вычитания
        List<int> result = new List<int>();
        int borrow = 0;

        // Убедимся, что operand1 больше или равен operand2
        if (Compare(operand1, operand2) < 0)
        {
            // Обмен operand1 и operand2, если operand1 меньше
            List<int>? temp = operand1;
            operand1 = operand2;
            operand2 = temp;
        }

        for (int i = operand1.Count - 1; i >= 0; i--)
        {
            int digitDiff = operand1[i] - borrow;

            if (i < operand2.Count)
            {
                digitDiff -= operand2[i];
            }

            if (digitDiff < 0)
            {
                digitDiff += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }

            result.Insert(0, digitDiff);
        }

        // Удаление ведущих нулей
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }

        return result;
    }

    // Метод для сравнения двух списков цифр
    internal static int Compare(List<int> operand1, List<int> operand2)
    {
        // Сравнение по длине
        if (operand1.Count != operand2.Count)
        {
            return operand1.Count.CompareTo(operand2.Count);
        }

        // Сравнение по каждой цифре
        for (int i = 0; i < operand1.Count; i++)
        {
            if (operand1[i] != operand2[i])
            {
                return operand1[i].CompareTo(operand2[i]);
            }
        }

        return 0; // Числа равны
    }
}
