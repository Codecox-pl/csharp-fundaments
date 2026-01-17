partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string>{"Patrick","Luis","Claudia"};
        names.Add("Madeleyne");

        System.Console.WriteLine($"Total de nombres: {names.Count}");


        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }

        names.Remove("Madeleyne");

        bool isPresent = names.Contains("Madeleyne");
        System.Console.WriteLine($"¿Ana esta en la lista? {isPresent}");


        //Dictionary
        Dictionary<int,string> students = new Dictionary<int, string>
        {
            {1,"Patrick"},
            {2, "Claudia"},
            {3, "Walter"}
        };

        foreach (var student in students)
        {
            System.Console.WriteLine($"Id: {student.Key}, Nombre: {student.Value}");
        }
    }
}