using System;
using System.Text;

namespace QA_Work.BI_Calculate;

internal class BI_Add
{
    // Метод для сложения двух больших целых чисел, представленных в виде списков
    internal static List<int> Add(List<int>? operand1, List<int>? operand2)
    {
        // Проверка наличия операндов
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for addition.");

        // Проверка и коррекция длины операндов
        AdjustOperandsLength(ref operand1, ref operand2);

        // Проверка на пустые списки
        if (operand1.Count == 0)
            return new List<int>(operand2);
        if (operand2.Count == 0)
            return new List<int>(operand1);

        // Результат сложения
        List<int> result = new List<int>();
        // Переменная для переноса
        int carry = 0;

        // Цикл по разрядам чисел справа налево
        for (int i = operand1.Count - 1; i >= 0; i--)
        {
            // Сумма текущих разрядов и значения переноса
            int digitSum = operand1[i] + operand2[i] + carry;
            // Вычисление нового значения переноса
            carry = digitSum / 10;
            // Добавление остатка от деления к результату
            result.Insert(0, digitSum % 10);
        }

        // Добавление оставшегося переноса, если есть
        while (carry > 0)
        {
            result.Insert(0, carry % 10);
            carry /= 10;
        }

        // Удаление ведущих нулей
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }

        // Возвращение результата
        return result;
    }

    // Метод для коррекции длины операндов
    private static void AdjustOperandsLength(ref List<int> operand1, ref List<int> operand2)
    {
        // Получаем текущие длины операндов
        int length1 = operand1.Count;
        int length2 = operand2.Count;

        // Если длины различаются, добавляем нули к короткому операнду
        if (length1 < length2)
        {
            operand1.InsertRange(0, new int[length2 - length1]);
        }
        else if (length1 > length2)
        {
            operand2.InsertRange(0, new int[length1 - length2]);
        }
    }
}