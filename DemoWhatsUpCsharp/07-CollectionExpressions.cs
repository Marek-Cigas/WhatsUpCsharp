namespace DemoWhatsUpCsharp;

public class CollectionExpressionDemo
{
    // Simple array creation
    public int[] SimpleArray = [1, 2, 3, 4, 5];
    
    // List creation
    public List<string> SimpleList = ["apple", "banana", "cherry"];
    
    // Spread operator with arrays
    public void DemonstrateSpreadOperator()
    {
        int[] initial = [1, 2, 3];
        int[] extended = [..initial, 4, 5, 6];  // Spreads initial array
        
        Console.WriteLine("Extended Array: " + string.Join(", ", extended));
    }
    
    // Collection creation with mixed types
    public object[] MixedTypeCollection = [1, "two", 3.0, true];
    
    // Nested collection expressions
    public int[][] NestedArrays = 
    [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ];
    
    // LINQ and collection expressions
    public void LinqWithCollectionExpressions()
    {
        // Create collection directly in LINQ
        var squares = Enumerable.Range(1, 5)
            .Select(x => x * x)
            .ToArray();  // [1, 4, 9, 16, 25]
        
        Console.WriteLine("Squares: " + string.Join(", ", squares));
    }
    
    // Method returning a collection
    public string[] GetFruits() => ["apple", "banana", "orange"];
    
    // Collection with collection initializer
    public HashSet<int> NumberSet = [1, 2, 3, 4, 5];
    
    // Combining spread operators
    public void CombineCollections()
    {
        int[] numbers1 = [1, 2, 3];
        int[] numbers2 = [4, 5, 6];
        
        // Combine multiple collections
        int[] combinedNumbers = [..numbers1, ..numbers2, 7, 8, 9];
        
        Console.WriteLine("Combined Numbers: " + string.Join(", ", combinedNumbers));
    }
    
    // Demonstration method
    public void Demonstrate()
    {
        Console.WriteLine("Simple Array: " + string.Join(", ", SimpleArray));
        Console.WriteLine("Simple List: " + string.Join(", ", SimpleList));
        
        DemonstrateSpreadOperator();
        LinqWithCollectionExpressions();
        CombineCollections();
        
        Console.WriteLine("Nested Arrays:");
        foreach (var array in NestedArrays)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}