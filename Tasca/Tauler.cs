namespace Tasca; 
public class Tauler
{
    public const int Mida = 20;
    private List<Animal> habitants = new List<Animal>();
    private Random random = new Random();

    private int PosX() => Random.Shared.Next(Mida);
    private int PosY() => Random.Shared.Next(Mida);

    private int PosLateral() // Metòde exclusiu per el Pop
    {
        
    }
    private DireccioPeix DirAleatoria() => DireccioPeixExt.Randomitzar();
    public void Inicialitzar()
    {
        for (int i = 0; i < 50; i++)
        {
            habitants.Add(new PeixNormal(PosX(), PosY(), Sex.Mascle, DirAleatoria()));
            habitants.Add(new PeixNormal(PosX(), PosY(), Sex.Femella, DirAleatoria()));
        }

        for (int i = 0; i < 10; i++)
        {
            habitants.Add(new Tauro(PosX(), PosY(), Sex.Mascle, DirAleatoria()));
            habitants.Add(new Tauro(PosX(), PosY(), Sex.Femella, DirAleatoria()));
        }

        for (int i = 0; i < 6; i++)
        {
            habitants.Add(new Tortuga(PosX(), PosY(), , DirAleatoria()));
        }

        for (int i = 0; i < 15; i++)
        {
            habitants.Add(new Pop(PosLateral(), PosLateral(), DirAleatoria()));
        }
    }

    public void passarRondes()
    {
        int ronda = 1; 
        while (ronda <= 100)
        {
            Console.WriteLine($"||Ronda número {ronda}||");
            Console.WriteLine($"------------------------");
            ronda++; 
        }
    }

    public void elsMortsNoParlan(PeixNormal peix, Tortuga tortuga, Pop pop, Tauro tauro)
    {
        if (peix.Estat == EstatPeix.Mort)
        {
            Console.WriteLine($"Ha mort un peix.");

        }
        else if (tortuga.Estat == EstatPeix.Mort)
        {
            Console.WriteLine($"Ha mort una tortuga.");
            
        }
        else if (pop.Estat == EstatPeix.Mort)
        {
            Console.WriteLine($"Ha mort un pop.");
            
        }
        else if (tauro.Estat == EstatPeix.Mort)
        {
            Console.WriteLine($"Ha mort un tauró.");
            
        }
    }

}