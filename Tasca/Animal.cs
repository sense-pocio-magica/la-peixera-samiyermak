namespace Tasca;
public abstract class Animal
{
    public int X { get; protected set; }
    public int Y { get; protected set; }

    protected Animal(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public abstract void Moure();
    public abstract void Interactuar(Animal altre);
}