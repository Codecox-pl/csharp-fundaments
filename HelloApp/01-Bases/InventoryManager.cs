using System;

partial class Program
{
    static void InventoryManager()
    {

        bool bandera = true;

        while (bandera)
        {

            Console.WriteLine("\n Menu ");
            System.Console.WriteLine("1.- Comprar producto");
            System.Console.WriteLine("2.- Salir");
            Console.WriteLine("Ingrese la opcion: ");
            int? op = int.Parse(Console.ReadLine()!);

            switch (op)
            {
                case 1:

                    string[] products = ["Monitor", "Mouse", "Teclado", "Audifono"];
                    double[] prices = [375.4, 189.5, 149.0, 530.6];
                    int[] stock = [10, 8, 24, 2];
                    Console.WriteLine("Inventario de productos");
                    Console.WriteLine("------------------------");

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}");
                    }
                    Console.WriteLine("\nIngrese el producto que desea comprar: ");
                    string? searchedProduct = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad que desea comprar: ");
                    int? quantity = int.Parse(Console.ReadLine()!);

                    for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                        {
                            if (quantity <= stock[i])
                            {
                                double? total = quantity * prices[i];

                                Console.WriteLine($"Compra exitosa. Total a pagar: {total:C}");
                                Console.WriteLine($"Stock restante para el producto {products[i]} es {stock[i] - quantity}");
                            }
                            else
                            {
                                Console.WriteLine("No hay suficiente stock");
                            }
                        }
                    }
                    break;
                case 2:
                    System.Console.WriteLine("Gracias por su visita");
                    bandera = false;
                    break;
            }








        }

    }
}