partial class Program
{
    static void FactorialNumber(int number)
    {
        int res = 1;

        WriteLine($"Factorial del numero {number} desde el 1 hasta el {number}");

        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {res *= i}");
        }

    }


}