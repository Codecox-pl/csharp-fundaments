using System.Globalization;
partial class Program
{
    static void DaysUntilNextBirthday()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento (dd/mm/yyyy): ");
        string inpt = Console.ReadLine()!;
        DateTime nac = DateTime.ParseExact(inpt,"dd/MM/yyyy",CultureInfo.InvariantCulture);

        
        int day = nac.Day;
        int month = nac.Month;
        int year = DateTime.Now.Year;
        DateTime proxBirthay = new DateTime(year,month,day);

        

        if (month > DateTime.Now.Month)
        {
            proxBirthay.AddYears(1);
        }

        TimeSpan difference = proxBirthay - DateTime.Now ;

       System.Console.WriteLine(difference.ToString(@"dd\ d"));
        

    }
}

