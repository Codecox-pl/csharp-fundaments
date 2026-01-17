partial class Program
{
   static void PrintMultiplicationTable(int number,int tableLimit)
    {
        WriteLine($"Tabla de multiplicar del numero {number} desde el 1 hasta el {tableLimit}");
        WriteLine();
        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }
        WriteLine();
    } 
}