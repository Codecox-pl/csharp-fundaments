partial class Program
{
    static string? amount;
    static void HandleException()
    {


        try
        {
            // int number = 10;
            // int result = number / 0;
            WriteLine("Ingrese un monto: ");
            amount = ReadLine();
            if (string.IsNullOrEmpty(amount)) return;

            double amountValue = double.Parse(amount);
            WriteLine($"El monto introducido es: {amountValue:C}");

        }
        catch (DivideByZeroException)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Division por cero");
        }
        catch (FormatException) when (amount.Contains("S/") == true)
        {
            WriteLine("No es necesario usar 'S/'");
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }

    }
}