partial class Program
{
    static void Conditional()
    {
        int age = 19;

        if (age >= 18)
        {
            WriteLine("Eres mayor de edad");
        }
        else
        {
            WriteLine("Eres menor de edad");
        }

        //if ternario
        string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
        WriteLine(message);

        //Multiples condiciones
        int temperature = 30;
        if(temperature > 35)
        {
            WriteLine("Hace mucho Calor");
        }else if (temperature >= 25)
        {
            WriteLine("Es agradable");
        }
        else
        {
            WriteLine("Hace frio");
        }

        //Switch
        int day = 3;
        switch(day)
        {
            case 1:
               WriteLine("Lunes");
               break;
            case 2:
               WriteLine("Lunes");
               break;
            case 3:
               WriteLine("Lunes");
               break;
            case 4:
               WriteLine("Lunes");
               break;
            default:
               WriteLine("Dia no valido");
               break;
        }

        //Switch con expresiones
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miercoles",
            _ => "Dia no valido"
        };
        WriteLine(dayMessage);
    }
}