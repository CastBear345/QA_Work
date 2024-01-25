using System;
using System.Text;
using QA_Work.MathBI;

namespace QA_Work.Menu;

public class Calculator
{
    public static void Start()
    {
        char choice;
        do
        {
            Console.Clear();
            UserInterface.PerformCalculatorOperations();

            Console.Write("Желаете выполнить еще одно вычисление? (д/н): ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (choice == 'д' || choice == 'Д' || choice == 'y' || choice == 'Y');
    }

    public static void PerformOperation(IBigInteger operand1, IBigInteger operand2, Action<IBigInteger, IBigInteger> operation)
    {
        operation.Invoke(operand1, operand2);
    }
}