using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.MathBI.BI_Calculate;

internal class BI_Substract
{
    internal static List<int> Subtract(List<int>? operand1, List<int>? operand2)
    {
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for subtraction.");

        List<int> result = new List<int>();
        int borrow = 0;

        // Ensure operand1 is greater than or equal to operand2
        if (Compare(operand1, operand2) < 0)
        {
            // Swap operand1 and operand2 if operand1 is smaller
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

        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }

        return result;
    }

    internal static int Compare(List<int> operand1, List<int> operand2)
    {
        if (operand1.Count != operand2.Count)
        {
            return operand1.Count.CompareTo(operand2.Count);
        }

        for (int i = 0; i < operand1.Count; i++)
        {
            if (operand1[i] != operand2[i])
            {
                return operand1[i].CompareTo(operand2[i]);
            }
        }

        return 0;
    }
}
