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
}