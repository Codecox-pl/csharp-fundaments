using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        DateTime birthDay = DateTime.Parse("2 Abril 2025");

        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebracion de mi cumpleaños sera {birthDay}");
        WriteLine($"Formato largo {birthDay:D}");
    }
}