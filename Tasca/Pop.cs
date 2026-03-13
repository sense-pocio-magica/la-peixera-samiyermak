namespace Tasca;
public class Pop : Animal
{
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;
    public DireccioPeix Direccio { get; private set; }

    public Pop(int x, int y, DireccioPeix direccio) : base(x, y)
    {
        Direccio = direccio;
    }
    public override void Moure()
    {
        X += Direccio.AnarX();
        Y += Direccio.AnarY();

        if (X < 0)
        {
            X = 0; 
            Direccio = DireccioPeix.Up;
        }
        else if (Y < 0)
        {
            Y = 0;
            Direccio = DireccioPeix.Right;
        }
        else if (X >= Tauler.Mida)
        {
            X = Tauler.Mida - 1;
            Direccio = DireccioPeix.Down; 
        }
        else if (Y >= Tauler.Mida)
        {
            Y = Tauler.Mida - 1;
            Direccio = DireccioPeix.Left;
        }
    }

    public override void Interactuar(Animal animal)
    {
        if(animal is Tauro)
        {
            Estat = EstatPeix.Mort;
            Console.WriteLine($"Ha mort un pop.");
        }
        else if(animal is Pop)
        {
            Direccio = DireccioPeixExt.Randomitzar(Direccio);
        }
    }
}