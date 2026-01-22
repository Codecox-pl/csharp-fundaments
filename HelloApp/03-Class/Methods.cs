partial class Program
{
    static void Methods()
    {

        // Car nc = new Car();
        // nc.Model = "Xtris";
        // nc.Year = 2014;
        //WriteLine(nc.ShowInfo());


        //Constructor
        Car sportCar = new Car("Lambo", 2019);
        WriteLine(sportCar.ShowInfo());

        //Sintaxis simplificada
        Car collectionCar = new Car { Model = "Susuki", Year = 2024 };
        WriteLine(collectionCar.ShowInfo());

        // Lista de objetos
        List<Car> cars = new List<Car>()
        {
           new Car(){Model = "Toyota", Year=2010},
           new Car(){Model = "Marbo", Year=2014},
           new Car(){Model = "Bruns", Year=2011}
        };

        foreach (var car in cars)
        {
            WriteLine($"{car.ShowInfo()}");
        }
    }
}

class Car
{
    public string? Model { get; set; }

    public int? Year { get; set; }

    //constructor por defecto
    public Car() { }

    // constructor por parametros
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    //Destructor (~)
    ~Car()
    {
        WriteLine("Destructor llamado. Recurso liberado");
    }

    public void ChangedModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Automovil: {Model}, Año: {Year}";
    }

    public void ShowMessage() => WriteLine("Este es un automovil");

    public void ShowMessage(string message) => WriteLine(message);
}