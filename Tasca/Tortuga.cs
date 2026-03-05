namespace Tasca; 
public class Tortuga : PeixBase
{
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;
    public Tortuga(int x, int y, Sex sexe, DireccioPeix direccio) : base(x, y, sexe, direccio){}


}