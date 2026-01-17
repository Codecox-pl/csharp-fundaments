partial class Program
{
    static void Loops()
    {
        //While
        int counter = 1;
        while(counter <= 5)
        {
            WriteLine($"Iteracion {counter}");
            counter++;
        }

        //Do while
        int num = 0;
        do
        {
            WriteLine($"Iteracion {num}");
            num++;
        } while (num <= 4);

        Dictionary<int,string> students = new Dictionary<int, string>
        {
            {1,"Patrick"},
            {2, "Claudia"},
            {3, "Walter"}
        };

        foreach (var student in students)
        {
            WriteLine($"Item {student.Value}");
        }
    }
}