namespace Tasca; 
public class Tauro : PeixBase
{
    private const int vidaUtil = 75;
    private int rondesViu = 0;
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;

    public Tauro(int x, int y, Sex sexe, DireccioPeix direccio) : base(x, y, sexe, direccio){}

    public void PassarRonda()
    {
        rondesViu++;
        if (rondesViu >= vidaUtil){
            Estat = EstatPeix.Mort;
        }
    }

    public override void Interactuar(Animal animal)
    {
        if (animal is Tortuga)
        {
            Direccio = DireccioPeixExt.Random(Direccio); // Haig d'afegir a DireccioPeix un mètode per Random()
        }
        else if (animal is Tauro tauro1)
        {
            if ( tauro1.Sexe == Sexe)
            {
                Estat = EstatPeix.Mort;
            }
            else
            {
                
            }
        }
    }
}
