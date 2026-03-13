namespace Tasca;

internal class Program
{
    static void Main(string[] args)
    {
        Tauler tauler = new Tauler();

        tauler.Inicialitzar();
        tauler.passarRondes();
        tauler.mostrarResultatsFinals();

        Console.WriteLine("Fi de la simulació. Prem una tecla per sortir de la Matrix.");
        Console.ReadKey();
    }
}