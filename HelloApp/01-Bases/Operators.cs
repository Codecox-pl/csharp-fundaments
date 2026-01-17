partial class Program
{
    static void Operators()
    {
        int number = 15;

        bool isEven = number % 2 == 0;
        bool isGreaterThan = number > 10;

        if(isEven && isGreaterThan)
        {
            System.Console.WriteLine($"El numero {number} es mayor e par que 10");
        }
        else if(!isEven && isGreaterThan)
        {
            System.Console.WriteLine($"El numero {number} es impar y mayor que 10");
        }
        else
        {
            System.Console.WriteLine($"El numero {number} no cumple con ninguna condicion");
        }

        //operador ternario
        int age = 18;
        string category = age >= 18 ? "Mayor de edad" : "Menor de edad";
        System.Console.WriteLine(category);
    }
}