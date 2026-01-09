partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;

        System.Console.WriteLine($"{x} , {y}");
        Person p = new Person{Name =  "Patrick"};
        Person p2 = p;
        p2.Name = "Luis";
        System.Console.WriteLine($"{p}, {p2}");
    }
}


class Person
{
    public string? Name {get; set;}
}