using System;

namespace PracticalWork;

public interface INumeric<T>
{
    T Value { get; set; }
    T Add(T num);
    T Subtract(T num);
    T Multiply(T num);
    T Divide(T num);
}