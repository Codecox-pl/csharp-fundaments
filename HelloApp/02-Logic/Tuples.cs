partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (100, "Hi");

        WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}");

        (int Number, string Text) myOtherTuple = (110, "Hiiii");

        WriteLine($"Numero: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");


        var operations = Operations(40, 20);
        WriteLine($"Suma: {operations.Sum}, Resta: {operations.Subtraction}");
    }

    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}