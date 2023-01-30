namespace FinalProjectCSharp2;

public class GameObject : TileObject
{
    public GameObject(char objectChar, ConsoleColor color=ConsoleColor.White) : base(objectChar, color)
    {
    }

    public override List<Component> Components { get; protected set; }
}