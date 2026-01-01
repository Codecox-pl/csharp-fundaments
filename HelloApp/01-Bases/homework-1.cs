partial class Program
{
    static void ShowHomework1()
    {
        string product = "Computadora";
        int quantitySold = 3;
        double unitPrice = 2555.40;
        double totalAmount = quantitySold * unitPrice;

        System.Console.WriteLine($"Producto: {product}");
        System.Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        System.Console.WriteLine($"Precio Unitario: {unitPrice}");
        System.Console.WriteLine($"Total: {totalAmount:C}");
    }
}