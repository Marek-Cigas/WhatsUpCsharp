namespace DemoWhatsUpCsharp;

public class EnhancedPerson : Person
{
    public static string Describe(object obj) => obj switch
    {
        Person { Age: >= 18 } p => $"{p.Name} is an adult",
        Person { Age: < 18 } p => $"{p.Name} is a minor",
        _ => "Unknown object"
    };

    public static void PatternDemo()
    {
        var person1 = new Person{ Name = "John", Age = 30 };
        var person2 = new Person{ Name = "Mary", Age = 4 };
        
        Console.WriteLine(Describe(person1));
        Console.WriteLine(Describe(person2));
    }
}
