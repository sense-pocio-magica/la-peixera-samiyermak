namespace Tasca;
public class PeixNormal : PeixBase
{
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;
    public PeixNormal(int x, int y, Sex sexe, DireccioPeix direccio) : base (x, y, sexe, direccio){}

    public override void Interactuar(Animal animal)
    {
        if (animal is PeixNormal peix)
        {
            if (peix.Sexe == Sexe)
            Estat = EstatPeix.Mort;
            Console.WriteLine($"Ha mort un peix.");
        }
        else if (animal is Tauro)
        {
            Estat = EstatPeix.Mort;
            Console.WriteLine($"Ha mort un peix.");
        }
    }
}
