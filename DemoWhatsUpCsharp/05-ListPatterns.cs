namespace DemoWhatsUpCsharp;

public class ListPatternsDemo
{
    public static void Demonstrate()
    {
        // 1. Basic List Pattern Matching
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        int[] numbers2 = { 1, 2, 3 };
        int[] emptyArray = { };

        // Exact match
        Console.WriteLine("Exact Match Examples:");
        Console.WriteLine(IsFirstThree(numbers1));     // False
        Console.WriteLine(IsFirstThree(numbers2));     // True

        // 2. Discard and Slice Patterns
        Console.WriteLine("\nDiscard and Slice Pattern Examples:");
        PrintListInfo(numbers1);  // Matches patterns with discards
        PrintListInfo(emptyArray);

        // 3. Complex Pattern Matching
        Console.WriteLine("\nComplex Pattern Matching:");
        AnalyzeSequence(new[] { 1, 2, 3, 4, 5 });
        AnalyzeSequence(new[] { 1, 2, 3 });
        AnalyzeSequence(new[] { 1 });

        // 4. Recursive Pattern Matching
        Console.WriteLine("\nRecursive Pattern Matching:");
        var nestedArrays = new[] { 
            new[] { 1, 2 }, 
            new[] { 3, 4 }, 
            new[] { 5, 6 } 
        };
        MatchNestedArrays(nestedArrays);

        // 5. Pattern Matching with Different Types
        object[] mixedArray = { 1, "hello", 3.14, true };
        MatchMixedArray(mixedArray);
    }

    // Matches if the first three elements are 1, 2, 3
    private static bool IsFirstThree(int[] arr)
    {
        return arr is [1, 2, 3, ..];
    }

    // Demonstrates discard and slice patterns
    private static void PrintListInfo(int[] arr)
    {
        switch (arr)
        {
            case []:
                Console.WriteLine("Empty array");
                break;
            case [var first, ..var rest]:
                Console.WriteLine($"Array starts with {first}. Remaining length: {rest.Length}");
                break;
        }
    }

    // Complex sequence analysis
    private static void AnalyzeSequence(int[] seq)
    {
        switch (seq)
        {
            case [1, 2, 3, ..]:
                Console.WriteLine("Starts with 1, 2, 3");
                break;
            case [var first, var second, ..var rest] when first < second:
                Console.WriteLine($"Ascending start: {first}, {second}. Remaining: {rest.Length}");
                break;
            case [.., var secondToLast, var last] when secondToLast < last:
                Console.WriteLine($"Ends with ascending pair: {secondToLast}, {last}");
                break;
            case [1]:
                Console.WriteLine("Single element array with value 1");
                break;
            default:
                Console.WriteLine("No specific pattern matched");
                break;
        }
    }

    // Nested array pattern matching
    private static void MatchNestedArrays(int[][] arrays)
    {
        switch (arrays)
        {
            case [[1, 2], [3, 4], ..]:
                Console.WriteLine("Starts with [1,2], [3,4]");
                break;
            case [var first, ..var rest] when first[0] == 1:
                Console.WriteLine($"First sub-array starts with 1. Rest length: {rest.Length}");
                break;
        }
    }

    // Mixed type array pattern matching
    private static void MatchMixedArray(object[] arr)
    {
        switch (arr)
        {
            case [int first, string, double, bool]:
                Console.WriteLine("Mixed type array with specific pattern");
                break;
            case [int, string, ..]:
                Console.WriteLine("Starts with int and string");
                break;
            case [.. object[] subArr] when subArr.Length > 3:
                Console.WriteLine($"Array with more than 3 elements: {subArr.Length}");
                break;
        }
    }
}

// Additional practical example: Processing game scores
public class GameScoreProcessor
{
    public static string ProcessScores(int[] scores)
    {
        return scores switch
        {
            // Perfect game in bowling
            [10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10] => "Perfect Bowling Game",
            
            // Hat-trick in sports
            [_, _, _, var third, ..] when third >= 3 => "Hat-trick Achieved",
            
            // Top 3 scores
            [var first, var second, var third, ..] when 
                first >= second && second >= third => "Consistent Top Performers",
            
            // Dramatic improvement
            [var first, var second, ..] when second > first * 1.5 => "Significant Improvement",
            
            // Default case
            _ => "No special pattern"
        };
    }
}