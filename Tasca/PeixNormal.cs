using System.Security.Cryptography.X509Certificates;

namespace Tasca;
public class PeixNormal : PeixBase
{
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;
    public PeixNormal(int x, int y, Sex sexe, DireccioPeix direccio) : base (x, y, sexe, direccio){}

    public override void Interactuar(Animal altre)
    {
        if (altre is PeixNormal peix && peix.Sexe != Sexe);
        else
        {
            Estat = EstatPeix.Mort;
        }
    }
}
