// 🏆 Ejercicio:
// Crear un programa que calcule el salario mensual de un trabajador
// - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
// - Calcular el sueldo y mostrarlo en pantalla

partial class Program
{
    static void SalaryCalculator()
    {

        Console.WriteLine("Calculadora de Salario");

        Console.WriteLine("Ingrese su nombre: ");
        string name = Console.ReadLine()!;

        Console.WriteLine("Ingrese sus horas trabajadas: ");
        int hours = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese su tarifa por hora");
        double salaryXhour = double.Parse(Console.ReadLine()!);


        var salary = hours * salaryXhour;

        Console.WriteLine($"El salario para {name} es de {salary:C}");

    }
}