using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.MathBI.BI_Calculate;

internal class BI_Add
{
    internal static List<int> Add(List<int>? operand1, List<int>? operand2)
    {
        if (operand1 == null || operand2 == null)
            throw new ArgumentException("Invalid operands for addition.");

        List<int> result = new List<int>();
        int carry = 0;

        for (int i = operand1.Count - 1; i >= 0; i--)
        {
            int miniSum = operand1[i] + operand2[i] + carry;
            carry = miniSum / 10;
            result.Insert(0, miniSum % 10);
        }

        while (carry > 0)
        {
            result.Insert(0, carry % 10);
            carry /= 10;
        }

        return result;
    }
}
