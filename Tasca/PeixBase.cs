namespace Tasca;
public abstract class PeixBase : Animal
{
    public Sex Sexe { get; }
    public DireccioPeix Direccio { get; set; }
    private const int Mida = 20;
    
    protected PeixBase(int x, int y, Sex sexe, DireccioPeix direccio) : base(x, y)
    {
        Sexe = sexe; 
        Direccio = direccio;
    }

    public override void Moure()
    {
        X = (X + Direccio.AnarX() + Mida) % Mida;
        Y = (Y + Direccio.AnarY() + Mida) % Mida;
    }
}