//This demo uses file scoped namespaces (reduces indentation)
namespace DemoWhatsUpCsharp;

class Program
{
    static void Main(string[] args)
    {
        var json = """
                   {
                       "name": "John Doe",
                       "age": 30,
                       "city": "New York"
                   }
                   """;
              
        //Console.WriteLine(json);
        
        //EnhancedPerson.PatternDemo();
        
        //StaticAbstractDemo.Demonstrate();
        
        ListPatternsDemo.Demonstrate();
        
        /*
         Primary Constructors for Classes
         Collection Expressions
            Ref Fields
Alias Any Type
Lambda Improvements
         */
    }
}