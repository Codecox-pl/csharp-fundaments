partial class Program
{
   static double CalculateArea(double width,double height)
    {
        return width * height;
    }
   static void Functions()
    {
        var area = CalculateArea(7.5,2.6);
        WriteLine($"El area es: {area}");
    }
}