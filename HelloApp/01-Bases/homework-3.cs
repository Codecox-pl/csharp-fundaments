partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1995, 4, 8);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"La cantidad de dias vividos es {difference.Days}");
    }
}