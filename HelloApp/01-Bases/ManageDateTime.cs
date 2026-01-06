partial class Program

{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;

        DateTime nowWeekAgo = now.AddDays(-7);

        DateTime customDate = new DateTime(2025, 4, 8);
        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine($" Fecha y hora actual {now}");
        Console.WriteLine($" Fecha actual {today}");
        Console.WriteLine($" Hace una semana {nowWeekAgo}");
        Console.WriteLine($" Fecha personalizada {customDate}");
        Console.WriteLine($"Dia de la semana {weekDay}");
    }
}