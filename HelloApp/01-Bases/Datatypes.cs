using System.Reflection.Metadata;

partial class Program
{
    static void Datatypes()
    {
        int integer = 42;
        double decimalNumber = 3.1416;
        bool isTrue = true;
        char character = 'C';
        string text = "Hola C#";

        Console.WriteLine($"Entero: {integer}, Decimal: {decimalNumber}, Booleano: {isTrue}, Caracter: {character}, Texto: {text}");
    }
}