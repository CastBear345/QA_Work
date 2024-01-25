using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QA_Work.BI;

public class ArithmeticWrapper
{
    public BigInteger AddBigIntegers(BigInteger firstValue, BigInteger secondValue)
    {
        return BigInteger2.AddBigIntegers(firstValue, secondValue);
    }

    public BigInteger SubtractBigIntegers(BigInteger firstValue, BigInteger secondValue)
    {
        return BigInteger2.SubstractBigIntegers(firstValue, secondValue);
    }

    public BigInteger MultiplyBigIntegers(BigInteger firstValue, BigInteger secondValue)
    {
        return BigInteger2.MultiplyBigIntegers(firstValue, secondValue);
    }

    public BigInteger DivideBigIntegers(ref BigInteger firstValue, ref BigInteger secondValue)
    {
        return BigInteger2.DivideBigIntegers(ref firstValue, ref secondValue);
    }
}

// Статический класс для выполнения арифметических операций с BigInteger
public static class BigInteger2
{
    public static BigInteger AddBigIntegers(BigInteger firstValue, BigInteger secondValue)
    {
        return firstValue + secondValue;
    }

    public static BigInteger SubstractBigIntegers(BigInteger firstValue, BigInteger secondValue)
    {
        return firstValue - secondValue;
    }

    public static BigInteger MultiplyBigIntegers(BigInteger firstValue, BigInteger secondValue)
    {
        return firstValue * secondValue;
    }

    public static BigInteger DivideBigIntegers(ref BigInteger firstValue, ref BigInteger secondValue)
    {
        // Пример ввода значений с консоли для деления
        Console.Clear();
        Console.WriteLine("Введите первое число:");
        Console.WriteLine(firstValue);
        Console.WriteLine("Введите второе число:");
        Console.WriteLine(secondValue);

        return firstValue / secondValue;
    }
}
