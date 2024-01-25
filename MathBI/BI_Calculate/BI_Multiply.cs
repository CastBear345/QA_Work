using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.MathBI.BI_Calculate;
internal class BI_Multiply
{
    internal static List<int> Multiply(List<int>? operand1, List<int>? operand2, int decimalPlaces)
    {
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for multiplication.");

        List<int> result = new List<int>(new int[operand1.Count + operand2.Count - 1]);

        if (operand1[0] == 0 || operand2[0] == 0)
        {
            return new List<int> { 0 };
        }

        for (int i = 0; i < operand1.Count; i++)
        {
            for (int j = 0; j < operand2.Count; j++)
            {
                int product = operand1[i] * operand2[j];
                AddProductToResult(result, product, i + j);
            }
        }

        NormalizeResult(result);

        // Adjust for decimal places
        while (result.Count <= decimalPlaces)
        {
            result.Insert(0, 0);
        }

        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }

        //RoundResult(result, decimalPlaces);

        return result;
    }

    internal static void AddProductToResult(List<int> result, int product, int position)
    {
        int carry = 0;

        while (result.Count <= position)
        {
            result.Insert(0, 0);
        }

        result[position] += product;

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

    internal static void NormalizeResult(List<int> result)
    {
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }
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
