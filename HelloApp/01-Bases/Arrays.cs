partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;

        //Directa

        int[] numsArray = [5,10,14,19,4,20];
        //indices
        System.Console.WriteLine($"Primer Elemento {numsArray[0]}");

        // Desde el final del arreglo
        System.Console.WriteLine($"El ultimo elemento {numsArray[^1]}");

        //Rangos para obtener subarreglos
        int[] firstThree = numsArray[..3];
        int[] fromIndexTwo = numsArray[2..];
        System.Console.WriteLine($"Los primeros tres: {firstThree}");
    }
}