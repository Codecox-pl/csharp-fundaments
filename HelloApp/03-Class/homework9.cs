partial class Program
{
    static void BusFleet()
    {
        Fleet objFleet = new();

        Bus objBus1 = new Bus("Toyota","Corolla",2019,29484,10000);
        Bus objBus2 = new Bus("Honda","Civic",2018,29484,8000);
        Bus objBus3 = new Bus("Ford","Fiesta",2017,29484,7000);

        objFleet.AddBus(objBus1);
        objFleet.AddBus(objBus2);
        objFleet.AddBus(objBus3);
        
        objFleet.listBuses();
        WriteLine("Despues de manejar 5000 km"); 
        objBus1.Drive(5000);  
        objBus2.Drive(5000); 
        objBus3.Drive(5000);   
        objFleet.listBuses(); 
 
        
    }

    class Bus
    {
      public string? Brand {get;set;}

      public string? Model {get;set;}

      public int? Year {get;set;}

      public double? Price {get;set;}

      public double? TotalKilometers {get;set;}

      public Bus(string brand, string model, int year, double price, double totalKilometers)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            TotalKilometers = totalKilometers;
        }

        public bool Drive(int kilometers)
        {
            if( kilometers <= TotalKilometers)
            {
                TotalKilometers += kilometers;
                return true;
            }

            WriteLine($"El kilometraje ingresado {kilometers} es menos al que tiene actualmente");
            return false;
        }

        public void ShowPrice()
        {
            WriteLine($"El precio de la Marca: {Brand} - Modelo: {Model}, es: {Price:C}");
        }

    }

    class Fleet
    {

        List<Bus> buses = new List<Bus>();
        public void AddBus (Bus objbus)
        {
            buses.Add(objbus);
        }

        public void listBuses()
        {
            foreach (var bus in buses)
            {
                WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Año: {bus.Year}, Kilometraje: {bus.TotalKilometers}");
            }
        }
    }
}