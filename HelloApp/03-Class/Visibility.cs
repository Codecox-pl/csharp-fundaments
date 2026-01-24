partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new Jedi();
        jedi.PowerLevel = 4000;
        jedi.LightsaberColor = "blue";

        jedi.UseForce();

        jedi.RevealSecret();

        Sith sith = new Sith();
        sith.PowerLevel = 3000;
        sith.LightsaberColor = "pink";

        sith.UseForce();
    }
}

interface IForceUser
{
    int PowerLevel { get; set; }
    string LightsaberColor { get; set; }

    void UseForce();
}

class Jedi : IForceUser
{
    public string PublicField = "Soy un Jedi y mi poder es conocido";
    private string PrivateField = "Pensamientos privados";
    protected string ProtectedField = "lado oscuro no debe conocer mis secretos";

    public int PowerLevel { get; set; }
    public string? LightsaberColor { get; set; }

    public void UseForce()
    {
        WriteLine($"Soy un jedi con un sable de luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
    }

    public void RevealSecret()
    {
        WriteLine(PrivateField);
        WriteLine(ProtectedField);
    }
    private void Meditate()
    {
        WriteLine("Estoy en profunda meditacion con la fuerza");
    }

    protected void Train()
    {
        WriteLine($"Estoy entrenando para convertirme en el mejor Jedi");
    }
}

class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        WriteLine($"Soy un sith con un sable de luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
    }
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}