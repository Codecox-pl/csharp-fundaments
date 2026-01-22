partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();
        Product laptop = new Product("Laptop", 1345.90, 5);
        Product mouse = new Product("Mouse", 100, 12);

        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        inventory.ShowInventory();
        laptop.Sell(1);
        inventory.ShowInventory();

    }


    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void ShowInfo()
        {
            WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
        }

        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {

                Stock -= quantity;
                WriteLine($"Venta realizada: {quantity} unidades de {Name}");
                return true;
            }

            WriteLine($"Stock insuficiente para {Name}");
            return false;
        }

    }

    class Inventory
    {

        private List<Product> produtcs = new List<Product>();

        public void AddProduct(Product product)
        {
            produtcs.Add(product);
        }

        public void ShowInventory()
        {
            WriteLine("Inventario de productos");
            foreach (var product in produtcs)
            {
                WriteLine($"Nombre: {product}");
            }
        }
    }
}