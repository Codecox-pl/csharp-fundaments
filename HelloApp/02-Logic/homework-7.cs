partial class Program
{
    static void FactorialNumber(int number)
    {

        for (int i = 1; i<= number; i++)
        {
           if(i == 1)
        {
            WriteLine($"{1}! = 1");
        }
        else
        {
            WriteLine($"{i}! = {i * (i - 1) }") ;
        } 
        }
        

    }


}