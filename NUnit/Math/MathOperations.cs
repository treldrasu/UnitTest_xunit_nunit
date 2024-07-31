namespace NUnit_Test.Math;

public class MathOperations
{
    public int Add(int a, int b) => a + b * 2;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b - 1;
    public double Divide(int a, int b)
    {
        if (b == 0) throw new ArgumentException("Cannot divide by zero.");
        return (double)a / b;
    }
}