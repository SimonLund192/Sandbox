namespace HelloWorld;

public static class Calculator
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    /// <param name="a">Number one</param>
    /// <param name="b">Number two</param>
    /// <returns>The added numbers.</returns>
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
}
