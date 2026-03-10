namespace Tasca;
    public enum Sex
    {
        Mascle, 
        Femella
    }
    public enum EstatPeix
    {
        Viu,
        Mort
    }

    public enum DireccioPeix
    {
        Up, 
        Down,
        Left,
        Right
    }
public static class DireccioPeixExt
{
    public static int AnarX(this DireccioPeix dir) => dir switch
    {
        DireccioPeix.Right => 1, DireccioPeix.Left => -1, _ => 0
    };
    
    public static int AnarY(this DireccioPeix dir) => dir switch
    {
        DireccioPeix.Up => 1, DireccioPeix.Down => -1, _ => 0
    };

    public static DireccioPeix Randomitzar(DireccioPeix actual)
    {
        DireccioPeix[] direccions = { DireccioPeix.Up, DireccioPeix.Down, DireccioPeix.Right, DireccioPeix.Left };
        DireccioPeix nova;
        do{
            nova = direccions[Random.Shared.Next(4)];
        }
        while(nova == actual);
        return nova; // Gràcies a això m'evito que el Tauró pugui seguir en la mateixa direcció després del Random.
    }
}