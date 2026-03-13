using System.Xml.XPath;

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
                mostrarResultats();
            }
            else if (ronda >= 10 && ronda < 100)
            {
                Console.WriteLine($"||  Ronda número {ronda}  ||");
                Console.WriteLine($"-----------------------");
                mostrarResultats();
            }
            else
            {
                Console.WriteLine($"||  Ronda número {ronda}  ||");
                Console.WriteLine($"------------------------");
                
                Console.WriteLine($"Actualitzant el sistema...");
                Console.WriteLine($"...");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.WriteLine($"Fatal Error. Message: Hem intervingut amb la simulació deguda a la exposició de dades sensibles dels animals.");
                Console.WriteLine($"Si us plau, se us prega no tractar d'intervenir amb el món animal, gràcies.");
                Console.WriteLine();
            }

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

    public void countPeixos()
    {
        int xpe = habitants.OfType<PeixNormal>().Count(); 
        int xta = habitants.OfType<PeixNormal>().Count();
        int xpo = habitants.OfType<PeixNormal>().Count();
        int xto = habitants.OfType<PeixNormal>().Count();
        
        Console.WriteLine($"Peixos: {xpe}. S'han perdut a {100 - xpe} peixos...");
        Console.WriteLine($"Taurons: {xta}. S'han perdut a {20 - xta} taurons!!");
        Console.WriteLine($"Pops: {xpo}. S'han perdut a {15 - xpo} pops...");
        Console.WriteLine($"Tortugues: {xto}. S'han perdut a {6 - xto} tortugues...");
    }
    public void mostrarResultats()
    {
        Console.WriteLine($"Actualitzant el sistema...");
        Thread.Sleep(1500);
        Console.WriteLine();

        Console.WriteLine($"S'han pogut recuperar les dades amb èxit a les {DateTime.Now:HH:mm:ss}");
        Console.WriteLine($"-------------------------------------------------------");
        countPeixos();
        Console.WriteLine();
    }

    public void mostrarResultatsFinals()
    {
        Console.WriteLine($"Obtenint resultats finals...");
        Console.WriteLine();
        Thread.Sleep(300);
        Console.WriteLine($"Error #49304: Accés Denegat. Els resultats estàn cifrats.");
        Console.WriteLine($"Error #49304: Accés Denegat. Els resultats estàn cifrats.");
        Console.WriteLine($"Error #49304: Accés Denegat. Els resultats estàn cifrats.");
        Console.WriteLine($"Error #49304: Accés Denegat. Els resultats estàn cifrats.");
        Console.WriteLine($"Error #49304: Accés Denegat. Els resultats estàn cifrats.");
        
        Console.WriteLine();
        Thread.Sleep(500);
        Console.WriteLine($"Your 512MB of RAM DDR2 says: Tranquila nena, I can handle this. Treballant per descifrar el document.");
        Console.WriteLine();

        int x = random.Next(1, 11);
        for(int i = 0; i < x; i++)
        {
            string hackTool(int i) => i switch // Honestament, el 44% dels conceptes que hi ha a continuació ni em sonen, però tinguent en compte que vas cursar una enginyeria probablement et despertaren bons records <3.
            {
                1 => "1 + 1 = 1                                                      | Fatal error, Math Incoherency",
                2 => "ρ(∂v/∂t + v·∇v) = -∇p + μ∇²v + f                               | Operació exitosa: S'ha calculat el moviment del fluid.",
                3 => "iℏ ∂Ψ(r,t)/∂t = Ĥ Ψ(r,t)                                       | Operació exitosa: S'ha obtingut l'estat quàntic de la partícula.",
                4 => "∂(ρu_i)/∂t + ∂(ρu_i u_j)/∂x_j = -∂p/∂x_i + ∂τ_ij/∂x_j + ρf_i   | Operació exitosa: S'han calculat les forces del fluid viscós.",
                5 => "∂ρ/∂t + ∇·(ρu) = 0                                             | Operació exitosa: S'ha verificat la conservació de massa.",
                6 => "-ℏ²/2m · ∇²ψ + Vψ = Eψ                                         | Operació exitosa: S'ha resolt l'energia de la partícula.",
                7 => "F_αβ;γ + F_βγ;α + F_γα;β = 0                                   | Operació exitosa: S'ha propagat el camp electromagnètic.",
                8 => "ΔG = ΔH - TΔS                                                  | Operació exitosa: S'ha obtingut amb èxit l'Energia Total de Gibbs",
                9 => "∮ B·dA = 0  |  ∮ E·dl = -dΦ_B/dt                               | Operació exitosa: S'ha confirmat la inducció electromagnètica.",
                10 => "E = mc²  →  E² = (pc)² + (m₀c²)²                              | Operació exitosa: S'ha calculat l'energia relativista total.",
                _ => "Unrecognized Error"
            };
            int y = random.Next(300,1600);
            Thread.Sleep(y);
            Console.WriteLine($"{hackTool(i)}");
            Console.WriteLine();
        }

        Console.WriteLine($"S'han aconseguit recuperar amb èxit els resultats finals.");
        Console.WriteLine("-------------------------------------------------------");
        countPeixos();
        Console.WriteLine();
    }
}