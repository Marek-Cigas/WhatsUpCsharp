namespace DemoWhatsUpCsharp;

public class LambdaImprovementsDemo
{
    // Lambda expression with natural type inference
    public void TypeInferenceDemo()
    {
        // Implicit typing for lambda parameters
        var add = (int x, int y) => x + y;
        Console.WriteLine($"Addition Result: {add(5, 3)}");

        // Explicit return type
        Func<int, int, int> multiply = (int x, int y) => x * y;
        Console.WriteLine($"Multiplication Result: {multiply(4, 6)}");
    }

    // Lambda with multiple statements
    public void MultiStatementLambda()
    {
        Func<string, string, string> complexOperation = (firstName, lastName) =>
        {
            var trimmedFirst = firstName.Trim();
            var trimmedLast = lastName.Trim();
            return $"{trimmedFirst} {trimmedLast}".ToUpper();
        };

        Console.WriteLine($"Formatted Name: {complexOperation("  John  ", "  Doe  ")}");
    }

    // Lambda with pattern matching
    public void PatternMatchingLambda()
    {
        // Advanced pattern matching in lambda
        Func<object, string> typeDescriber = obj => obj switch
        {
            int x => $"Integer: {x}",
            string s => $"String: {s}",
            List<int> list => $"Integer List with {list.Count} elements",
            _ => "Unknown type"
        };

        Console.WriteLine(typeDescriber(42));
        Console.WriteLine(typeDescriber("Hello"));
        Console.WriteLine(typeDescriber(new List<int> { 1, 2, 3 }));
    }

    // LINQ with improved lambda expressions
    public void LinqLambdaImprovements()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // More readable LINQ with lambdas
        var evenSquares = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * x)
            .ToArray();

        Console.WriteLine("Even Squares: " + string.Join(", ", evenSquares));
    }

    // Lambda with async support
    public async Task AsyncLambdaDemo()
    {
        // Async lambda
        Func<int, Task<int>> asyncSquare = async (int x) =>
        {
            await Task.Delay(100);  // Simulating async work
            return x * x;
        };

        int result = await asyncSquare(7);
        Console.WriteLine($"Async Square Result: {result}");
    }

    public void Demonstrate()
    {
        TypeInferenceDemo();
        MultiStatementLambda();
        PatternMatchingLambda();
        LinqLambdaImprovements();
        AsyncLambdaDemo().Wait();
    }
}