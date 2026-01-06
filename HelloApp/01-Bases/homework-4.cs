partial class Program
{
    static void DaysUntilNextBirthday()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento (dd/mm/yyyy): ");
        DateTime nac = DateTime.Parse(Console.ReadLine());

        Console.WriteLine(nac);
    }
}