using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.MathBI.BI_Calculate;
internal class BI_Divide
{
    internal static List<int> Divide(List<int>? operand1, List<int>? operand2, int decimalPlaces)
    {
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for division.");

        if (operand2.Count == 1 && operand2[0] == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }
        else if (operand1[0] == 0)
        {
            return new List<int> { 0 }; // Результат равен 0, если числитель равен 0
        }

        List<int> result = new List<int>();
        int totalDecimalPlaces = decimalPlaces * 2; // Удвоенное количество десятичных разрядов для деления

        int divisor = operand2[0];
        int index = 0;
        int partialDividend = 0;

        while (index < operand1.Count && result.Count <= totalDecimalPlaces)
        {
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

        // Если необходимо, округлим результат до указанного количества десятичных знаков
        RoundResult(result, decimalPlaces);

        return result;
    }

    internal static void RoundResult(List<int> result, int decimalPlaces)
    {
        int roundingPosition = result.Count - 1 - decimalPlaces;

        if (roundingPosition >= 0 && roundingPosition < result.Count)
        {
            int roundingDigit = result[roundingPosition];

            // Определение направления округления (round half to even)
            if (roundingDigit >= 5)
            {
                // Округляем вверх
                int carry = 1;
                for (int i = roundingPosition; i >= 0 && carry > 0; i--)
                {
                    result[i] += carry;
                    carry = result[i] / 10;
                    result[i] %= 10;
                }
            }

            // Удаляем цифры за позицией округления
            result.RemoveRange(roundingPosition + 1, result.Count - roundingPosition - 1);
        }
    }
}
