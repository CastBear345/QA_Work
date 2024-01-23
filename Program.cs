using PracticalWork;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            long operand1 = GetOperand("Enter the first number: ");
            long operand2 = GetOperand("Enter the second number: ");

            var calculator1 = new BigInteger(operand1);
            var calculator2 = new BigInteger(operand2);

            char operationSymbol = GetOperationSymbol();

            var result = Calculator<BigInteger>.PerformOperation(calculator1, calculator2, operationSymbol);
            Console.WriteLine("Result: " + result.Value);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Arithmetic overflow occurred.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unhandled error: " + ex.Message);
        }
    }

    static long GetOperand(string prompt)
    {
        Console.Write(prompt);
        if (!long.TryParse(Console.ReadLine(), out long operand))
        {
            throw new ArgumentException("Invalid input. Program terminated.");
        }
        Console.WriteLine();
        return operand;
    }

    static char GetOperationSymbol()
    {
        Console.Write("Choose operation (+, -, *, /): ");
        char operationSymbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        return operationSymbol;
    }
}
