partial class Program
{

    static void Homework12()
    {
        CajaRegistradora cj1 = new CajaRegistradora();

        cj1.EscanearProducto(100);
        cj1.EscanearProducto(50);
        cj1.EscanearProducto(-20);

        //var res = cj1.CalcularTotalFinal("Estudiante");
        var res = cj1.CalcularTotalFinal("Regular");
        WriteLine(res);
    }
}

class CajaRegistradora
{

    private double TotalAcomulado { get; set; }

    public CajaRegistradora()
    {
        TotalAcomulado = 0;
    }
    public void EscanearProducto(double precio)
    {
        if (precio > 0)
        {
            TotalAcomulado += precio;
            WriteLine($"El proudcto con precio {precio:C} fue agregado ");
        }
        else
        {
            WriteLine($"El proudcto tiene un precio invalido");
        }
    }

    public double CalcularTotalFinal(string tipoCliente)
    {

        double montoFinal = 0;
        double dsc = 0;

        if (tipoCliente == "Estudiante")
        {
            dsc = TotalAcomulado * 0.10;
            montoFinal = TotalAcomulado - dsc;
        }
        else if (tipoCliente == "Jubilado")
        {
            dsc = TotalAcomulado * 0.15;
            montoFinal = TotalAcomulado - dsc;

        }
        else
        {
            montoFinal = TotalAcomulado - dsc;
        }
        TotalAcomulado = 0;
        return montoFinal;
    }
}