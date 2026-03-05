namespace Tasca; 
public class Tauro : PeixBase
{
    public int vidaUtil { get; private set; } = 75;
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;

    public Tauro(int x, int y, Sex sexe, DireccioPeix direccio, int vida) : base(x, y, sexe, direccio)
    {
        vidaUtil = vida; 
    }

    virtual void Menjar()
    {
        
    }
}
