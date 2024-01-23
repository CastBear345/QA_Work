using PracticalWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator<T>
{
    public static T PerformOperation(INumeric<T> calculator1, INumeric<T> calculator2, char operationSymbol)
    {
        switch (operationSymbol)
        {
            case '+':
                return calculator1.Add(calculator2.Value);
            case '-':
                return calculator1.Subtract(calculator2.Value);
            case '*':
                return calculator1.Multiply(calculator2.Value);
            case '/':
                return calculator1.Divide(calculator2.Value);
            default:
                throw new ArgumentException("Invalid operation choice.");
        }
    }
}