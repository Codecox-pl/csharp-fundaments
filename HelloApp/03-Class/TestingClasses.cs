partial class Program
{
    static void TestingClass()
    {

        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "TodoTerrenox1";
        toyota.Year = 2021;
        toyota.isAvaible = true;
        toyota.ManufacturingDate = DateTime.Now;
        toyota.ShowInfo();


        Vehicle susuki = new Vehicle { Brand = "Susuki", Model = "Prix201", Year = 2000, isAvaible = true, ManufacturingDate = DateTime.Today };
        susuki.ShowInfo();

        Vehicle lambogirni = new Vehicle("Lamborgini", "Platano", 2026, true, DateTime.Now);
        lambogirni.ShowInfo();
    }
}


class Vehicle
{
    //Propiedades

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool isAvaible { get; set; }

    public DateTime ManufacturingDate { get; set; }

    //Constructor
    public Vehicle(string brand, string model, int year, bool isAvaible, DateTime manufacturinDate)
    {
        Brand = brand;
        Model = model;
        Year = year;
        isAvaible = isAvaible;
        ManufacturingDate = manufacturinDate;
    }

    public Vehicle()
    {

    }

    //Metodos

    public void ShowInfo()
    {
        WriteLine($"Este Vehiculo es un {Brand} {Model} del año {Year} y fue fabricado {ManufacturingDate}");
    }

}