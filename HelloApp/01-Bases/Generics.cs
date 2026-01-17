partial class Program
{
    static void Generics()
    {
        string[] name = {"Patrick","Claudia","Juan"};
        int[] numbers = {1,2,3};
        
        WriteLine($"Tamaño del arreglo numerico{GetGenArrayLength(name)}");

        WriteLine($"Tamaño del arreglo texto{GetGenArrayLength(numbers)}");

        Box<int> numberBox = new Box<int> {Content = 100};
        Box<string> stringBox = new Box<string> {Content = "Hola"};
        numberBox.Show();
        stringBox.Show();

    }

    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }
    //Modo Generico
    static int GetGenArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T? Content {get; set;}

    public void Show()
    {
        WriteLine($"Contenido: {Content}");
    }
}