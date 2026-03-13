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
        if (Random.Shared.Next(2) == 0)
        {
            return 0;
        }
        else
        {
            return Mida -1;
        }
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

        for (int i = 0; i < 6; i++) // El sexe de les tortugues ha de ser aleatori?
        {
            Sex sexe;
            if (Random.Shared.Next(2) == 0)
            {
                sexe = Sex.Mascle;
            }
            else
            {
                sexe = Sex.Femella;
            }
            habitants.Add(new Tortuga(PosX(), PosY(), sexe, DirAleatoria()));
        }

        for (int i = 0; i < 15; i++)
        {
            habitants.Add(new Pop(PosLateral(), PosLateral(), DirAleatoria()));
        }
    }

    public void passarRondes()
    {
        for (int ronda = 0; ronda <= 100; ronda++)
        {
            // 15 tristes lineas per afegir un guió en funció del nombre de xifres del número de ronda.
            if (ronda < 10){
                Console.WriteLine($"||  Ronda número {ronda}  ||");
                Console.WriteLine($"----------------------");
            }
            else if (ronda >= 10 && ronda < 100)
            {
                Console.WriteLine($"||  Ronda número {ronda}  ||");
                Console.WriteLine($"-----------------------");
            }
            else
            {
                Console.WriteLine($"||  Ronda número {ronda}  ||");
                Console.WriteLine($"------------------------");
            }
            
            mostrarResultats();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            executarRonda();
        }
    }

    public void executarRonda()
    {
        
        foreach(var animal in habitants)
        {
            animal.Moure();
        }
        foreach(var tauro in habitants.OfType<Tauro>())
        {
            tauro.PassarRonda();
        }
        var grups = habitants
        .GroupBy(a => (a.X, a.Y))
        .Where(g => g.Count() > 1);

        foreach(var grup in grups)
        {
            
        }
        habitants.RemoveAll(a => (a is PeixNormal p && p.Estat == EstatPeix.Mort) || (a is Tauro tau && tau.Estat == EstatPeix.Mort) || (a is Tortuga tor && tor.Estat == EstatPeix.Mort) || (a is Pop pop && pop.Estat == EstatPeix.Mort));
    }

    public void mostrarResultats()
    {
        Console.WriteLine($"Actualitzant el sistema...");
        Console.WriteLine($"...");
        Thread.Sleep(1500);
        Console.WriteLine();

        Console.WriteLine($"S'han pogut recuperar les dades amb èxit a les {DateTime.Now:HH:mm:ss}");
        Console.WriteLine($"-------------------------------------------------------");
        Console.WriteLine($"Peixos normals: {habitants.OfType<PeixNormal>().Count()}");
        Console.WriteLine($"Taurons: {habitants.OfType<Tauro>().Count()}");
        Console.WriteLine($"Pops: {habitants.OfType<Pop>().Count()}");
        Console.WriteLine($"Tortugues: {habitants.OfType<Tortuga>().Count()}");
    }

    public void mostrarResultatsFinals()
    {
        Console.WriteLine($"Obtenint resultats finals...");
        Console.WriteLine();
        Thread.Sleep(300);
        Console.WriteLine($"Error #49304: Accés Denegat. Els resultats estàn cifrats.");
        

        int x = random.Next(10);
        for(int i = 0; i < x; i++)
        {
            
        }

        Console.WriteLine($"Peixos normals: {habitants.OfType<PeixNormal>().Count()}");
        Console.WriteLine($"Taurons: {habitants.OfType<Tauro>().Count()}");
        Console.WriteLine($"Pops: {habitants.OfType<Pop>().Count()}");
        Console.WriteLine($"Tortugues: {habitants.OfType<Tortuga>().Count()}");
    }
}