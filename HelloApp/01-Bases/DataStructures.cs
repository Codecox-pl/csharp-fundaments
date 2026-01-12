partial class Program
{
    static void DataStructures()
    {
        User name1 = new User{ Name = "Patrick", Age= 29};
        name1.Greet();

        Point punto = new Point{x = 30, y= 10};
        System.Console.WriteLine($"Punto x: {punto.x} y Punto Y: {punto.y}");
    }
}

class User
{
    public string? Name {get; set;}
    public int Age {get; set;}

    public void Greet()
    {
        System.Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age} años");
    }
}

struct Point
{
    public int x {get; set;}
    public int y {get; set;}
}

record CellPhone(string Model, int Year);