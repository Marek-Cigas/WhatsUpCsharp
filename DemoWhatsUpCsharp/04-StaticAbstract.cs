namespace DemoWhatsUpCsharp;

// Define a generic interface that allows arithmetic operations
public interface IArithmetic<TSelf> 
    where TSelf : IArithmetic<TSelf>
{
    // Static abstract method for addition
    static abstract TSelf operator +(TSelf left, TSelf right);
    
    // Static abstract method for subtraction
    static abstract TSelf operator -(TSelf left, TSelf right);
    
    // Static abstract property for the zero value
    static abstract TSelf Zero { get; }
    
    // Static abstract method to create from an integer
    static abstract TSelf FromInt(int value);
}

// Implementation for a custom numeric type
public struct CustomNumber : IArithmetic<CustomNumber>
{
    public int Value { get; }

    public CustomNumber(int value)
    {
        Value = value;
    }

    // Implement the static abstract operators
    public static CustomNumber operator +(CustomNumber left, CustomNumber right)
        => new CustomNumber(left.Value + right.Value);

    public static CustomNumber operator -(CustomNumber left, CustomNumber right)
        => new CustomNumber(left.Value - right.Value);

    // Implement the Zero property
    public static CustomNumber Zero => new CustomNumber(0);

    // Implement method to create from an integer
    public static CustomNumber FromInt(int value) 
        => new CustomNumber(value);

    // Override ToString for better visibility
    public override string ToString() => Value.ToString();
}

// Generic calculator that works with any type implementing IArithmetic
public class GenericCalculator<T> where T : IArithmetic<T>
{
    // Method that can perform operations on any type implementing IArithmetic
    public T Add(T a, T b)
    {
        return a + b;
    }

    public T Subtract(T a, T b)
    {
        return a - b;
    }

    // Method that creates a sequence starting from zero
    public T CreateSequence(int count)
    {
        T current = T.Zero;
        for (int i = 1; i < count; i++)
        {
            current += T.FromInt(i);
        }
        return current;
    }
}

// Demonstration class
public class StaticAbstractDemo
{
    public static void Demonstrate()
    {
        // Create a calculator for CustomNumber
        var calculator = new GenericCalculator<CustomNumber>();

        // Perform operations
        var a = CustomNumber.FromInt(5);
        var b = CustomNumber.FromInt(3);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"a + b = {calculator.Add(a, b)}");
        Console.WriteLine($"a - b = {calculator.Subtract(a, b)}");

        // Create a sequence
        var sequence = calculator.CreateSequence(5);
        Console.WriteLine($"Sequence result: {sequence}");
    }
}