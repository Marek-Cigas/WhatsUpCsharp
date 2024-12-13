namespace DemoWhatsUpCsharp;

public class Person
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

public class MembersDemo
{
    public void SetUpPerson()
    {
        var person1 = new Person { Name = "John", Age = 30 };
        var person2 = new Person { Name = "John", Age = 30 }; //try to delete Name or Age
    }
}
