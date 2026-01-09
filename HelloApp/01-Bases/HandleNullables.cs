partial class Program
{
    static void HandleNullable()
    {
        //No nulificable
        string firstName = "Patrick";
        
        //Nulificable
        string? lastName = null;

        if (lastName != null)
        {
            System.Console.WriteLine($"Apellido: {lastName}");
        }
        else
        {
            System.Console.WriteLine("Apellido no identificado");
        }

        //Operador de coalesencia nula ??
        System.Console.WriteLine($"Apellido: {lastName ?? "Apellido no especificado!"}");
    }
}