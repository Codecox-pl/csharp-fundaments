partial class Program
{
    static void Inheritance()
    {
        HowgartsStrudent student = new HowgartsStrudent() { Name = "Harry Potter", House = "Gryffindor" };
        HowgartsProfessor professor = new HowgartsProfessor() { Name = "Severus Snape", Subject = "Potions" };

        student.Greet();
    }
}


class Character
{
    public string? Name { get; set; }

    public void Greet()
    {
        WriteLine($"Hola, soy { Name} y estudiante");
    }
}

class HowgartsStrudent : Character
{
    public string? House { get; set; }

    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en Howgarts");
    }

    // public override void Greet()
    // {
    //     WriteLine($"Hola, soy { Name} y profesor");
    // }

    public virtual void Greet()
    {
        WriteLine($"Hola, soy { Name}");
    }



}

class HowgartsProfessor : Character
{
    public string? Subject { get; set; }

    public void MySubject()
    {
        WriteLine($"Enseño en {Subject} en Howgarts");
    }
}