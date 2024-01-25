using System;
namespace QA_Work.MathBI;

public interface IBigInteger
{
    void Add(IBigInteger operand);
    void Subtract(IBigInteger operand);
    void Multiply(IBigInteger operand);
    void Divide(IBigInteger operand);
    void PrintResult(string operation, List<int> result);
}