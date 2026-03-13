namespace Tasca;
public abstract class PeixBase : Animal
{
    public Sex Sexe { get; }
    public DireccioPeix Direccio { get; set; }
    
    protected PeixBase(int x, int y, Sex sexe, DireccioPeix direccio) : base(x, y)
    {
        Sexe = sexe; 
        Direccio = direccio;
    }

    public override void Moure()
    {
        X += Direccio.AnarX();
        Y += Direccio.AnarY();

        X = (X + Direccio.AnarX() + Tauler.Mida) % Tauler.Mida;
        Y = (Y + Direccio.AnarY() + Tauler.Mida) % Tauler.Mida;
    }
}