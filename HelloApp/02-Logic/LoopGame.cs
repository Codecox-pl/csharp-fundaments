partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine("🚩Pulse cualquier tecla para aumentar el contador");
        WriteLine("🔴 Pulsa ESC para salir.\n");

        while(true)
        {
            var key = ReadKey(true).Key;

            if(key == ConsoleKey.Escape)
            {
                WriteLine("Has pulsado la tecla escape");
                WriteLine($"Haz pulsado {counter} la teclas antes de salir");
                WriteLine("Programa terminado");
                break;
            }

            counter++;
        }
    }
}