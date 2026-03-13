using System.Net.Mail;

namespace Tasca; 
public class Tortuga : PeixBase
{
    public EstatPeix Estat { get; private set; } = EstatPeix.Viu;
    public Tortuga(int x, int y, Sex sexe, DireccioPeix direccio) : base(x, y, sexe, direccio){}

    public override void Interactuar(Animal animal)
    {
        if (animal is Tortuga tortuga)
        {
            if (tortuga.Sexe == Sexe)
            {
                Estat = EstatPeix.Mort;
                Console.WriteLine($"Ha mort una tortuga.");
            }
        }
    }
}