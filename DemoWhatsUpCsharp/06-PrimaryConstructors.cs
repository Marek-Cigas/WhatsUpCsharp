namespace DemoWhatsUpCsharp;

// Basic primary constructor with simple parameter
// This class is called Person12 to distinguish it from Person in RequiredMembers demo
// This one uses the features of C#12
public class Person12(string name, int age)
{
    // Public property automatically created from constructor parameter
    public string Name { get; } = name;
    
    // Public property with additional logic
    public int Age { get; } = age > 0 ? age : throw new ArgumentException("Age must be positive");
    
    // Method using constructor parameters
    public void Introduce() 
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}

// Primary constructor with parameter validation
public class Employee(string name, decimal salary)
{
    // Validate salary in constructor body
    public decimal Salary { get; } = salary > 0 
        ? salary 
        : throw new ArgumentException("Salary must be positive");
    
    public string Name { get; } = name;
}

// Primary constructor with inheritance
public class Student(string name, string major) : Person12(name, 20)
{
    public string Major { get; } = major;
    
    public void StudyInfo() 
    {
        Console.WriteLine($"{Name} is studying {Major}");
    }
}

// Primary constructor with complex initialization
public class ComplexPerson(string firstName, string lastName)
{
    // Computed property from constructor parameters
    public string FullName { get; } = $"{firstName} {lastName}";
    
    // Using constructor parameters in complex initialization
    private readonly string _sortableName = $"{lastName}, {firstName}";
    
    public void DisplaySortableName() 
    {
        Console.WriteLine($"Sortable Name: {_sortableName}");
    }
}

class PrimaryConstructorsDemo
{
    public static void Demonstrate()
    {
        // Demonstrating primary constructor usage
        var person = new Person12("Alice", 30);
        person.Introduce();

        var employee = new Employee("Bob", 50000m);
        Console.WriteLine($"{employee.Name} earns {employee.Salary}");

        var student = new Student("Charlie", "Computer Science");
        student.Introduce();
        student.StudyInfo();

        var complexPerson = new ComplexPerson("John", "Doe");
        complexPerson.DisplaySortableName();
    }
}