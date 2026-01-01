
partial class Program
{
    static void ShowNumericTypes()
    {
       int integerNumber = 42; 
       double doubleNumber = 3.14d;
       float floatNumber = 2.71828f;
       long longNumber = 1234567890123456789L;
       decimal decimalNumber = 1.618033988749895m;

       Console.WriteLine($"Entero: {integerNumber}");
       Console.WriteLine($"Double: {doubleNumber}");
       Console.WriteLine($"Float: {floatNumber}");
       Console.WriteLine($"Long: {longNumber}");
       Console.WriteLine($"Decimal: {decimalNumber}");
    }
}