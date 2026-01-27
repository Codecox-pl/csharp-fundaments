partial class Program
{

    static void Homework11()
    {
        // Alumno al1 = new Alumno();
        // al1.AgregarNota(15);
        // al1.AgregarNota(25);
        // al1.AgregarNota(10);

        Alumno al2 = new Alumno();
        al2.AgregarNota(15);
        al2.AgregarNota(25);
        al2.AgregarNota(10);

        var prom = al2.CacularPromedio();
        WriteLine(prom);
        var status = al2.ObtenerEstatus();
        WriteLine(status);
    }
}

class Alumno
{
    public string? Nombre { get; set; }

    public List<double> Notas { get; set; }

    public Alumno()
    {
        Notas = new List<double>();
    }
    public void AgregarNota(double nota)
    {
        if (nota >= 0 && nota <= 20)
        {
            Notas.Add(nota);
            WriteLine($"Se agrego la nota {nota} a la lista");
        }
        else
        {
            WriteLine("La nota ingresada no es valida");
        }
    }

    public double CacularPromedio()
    {

        double sum = 0;
        double prom = 0;
        int cont = 0;

        foreach (var nota in Notas)
        {
            sum += nota;
            cont += 1;
        }

        prom = sum / cont;

        return prom;
    }

    public string ObtenerEstatus()
    {
        double result = CacularPromedio();

        if (result >= 11)
        {
            return "Aprobado";
        }
        else
        {
            return "Desaprobado";
        }
    }
}