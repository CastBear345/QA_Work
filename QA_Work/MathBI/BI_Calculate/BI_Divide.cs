using System;
using System.Text;

namespace QA_Work.BI_Calculate;
internal class BI_Divide
{
    // Максимальная длина результата деления
    private const int MaxResultLength = 100;

    // Метод для выполнения деления для списков цифр
    internal static List<int> Divide(List<int>? operand1, List<int>? operand2)
    {
        // Проверка наличия входных операндов
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for division.");

        // Проверка деления на ноль
        if (operand2.All(digit => digit == 0))
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }
        else if (operand1[0] == 0 || operand1.Count < operand2.Count)
        {
            // Если делимое равно 0 или делимое меньше делителя, результат = 0
            return new List<int> { 0 };
        }

        List<int> result = new List<int>();

        int divisor = operand2[0];
        int index = 0;
        int partialDividend = 0;

        while (index < operand1.Count && result.Count <= MaxResultLength)
        {
            if (operand1[index] == 0 && result.Count == 0)
            {
                // Пропустить деление, если первая цифра делимого равна 0
                index++;
                continue;
            }

            partialDividend = partialDividend * 10 + operand1[index];

            if (partialDividend < divisor && result.Count > 0)
            {
                result.Add(0);
            }
            else
            {
                result.Add(partialDividend / divisor);
                partialDividend %= divisor;
                index++;
            }
        }

        return result;
    }

    // Метод для округления результата деления
    internal static void RoundResult(List<int> result)
    {
        int roundingPosition = result.Count - 1 - 3;

        // Проверка, что позиция округления находится в пределах длины результата
        if (roundingPosition >= 0 && roundingPosition < result.Count)
        {
            int roundingDigit = result[roundingPosition];

            // Определение направления округления
            if (roundingDigit >= 5)
            {
                // Округление вверх
                int carry = 1;
                for (int i = roundingPosition; i >= 0 && carry > 0; i--)
                {
                    result[i] += carry;
                    carry = result[i] / 10;
                    result[i] %= 10;
                }
            }

            // Удаление цифр за пределами позиции округления
            if (roundingPosition + 1 < result.Count)
            {
                result.RemoveRange(roundingPosition + 1, result.Count - roundingPosition - 1);
            }
        }
    }
}
