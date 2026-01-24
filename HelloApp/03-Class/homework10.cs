partial class Program
{

    static void Homework10()
    {
        List<Employee> empleados = new List<Employee>();

        TeamLeader per1 = new TeamLeader("Carlos", 5000, "team leader");
        Developer per2 = new Developer("Ana", 4000, "Developer");
        TeamLeader per3 = new TeamLeader("Laura", 6000, "team leader");
        Developer per4 = new Developer("Luis", 3500, "Developer");

        empleados.Add(per1);
        empleados.Add(per2);
        empleados.Add(per3);
        empleados.Add(per4);

        WriteLine("Detalle de Empleados:");

        foreach (Employee empleado in empleados)
        {
            empleado.ShowInfo();
        }
    }
}

class Employee
{
    protected string? Name { get; set; }

    protected double Salary { get; set; }

    protected string? Position { get; set; }

    public Employee() { }
    public Employee(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }


    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }

    public void ShowInfo()
    {
        WriteLine($"Empleado: {Name}, Cargo: {Position}, Salario: ${Salary:C}, Bono: ${CalculateBonus()}");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }
    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }
}

class Developer : Employee
{
    public Developer(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }
    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}