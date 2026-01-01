partial class Program
{
    static void ShowStringTypes()
    {
        string name = "Juan";
        string message = "Hola " + name;
        string interpolationMessage = $"Hola {name}";

        Console.WriteLine(message);
        Console.WriteLine(interpolationMessage);

        Console.WriteLine($"Tu nombre tiene {name.Length} caracteres");

        Console.WriteLine($"Tu nombre en mayusculas es {name.ToUpper()}");


    }
}