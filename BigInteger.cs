using PracticalWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class BigInteger : INumeric<BigInteger>
{
    private long _value;

    public BigInteger(long initialValue)
    {
        _value = initialValue;
    }

    public BigInteger Value
    {
        get { return new BigInteger(_value); }
        set { _value = value._value; }
    }

    public BigInteger Add(BigInteger num) => new BigInteger(_value + num._value);

    public BigInteger Subtract(BigInteger num) => new BigInteger(_value - num._value);

    public BigInteger Multiply(BigInteger num) => new BigInteger(_value * num._value);

    public BigInteger Divide(BigInteger num)
    {
        if (_value == 0 || num._value == 0) throw new ArgumentException("Division by zero is not allowed.");
        return new BigInteger(_value / num._value);
    }
}