namespace FinalProjectCSharp2;

public class GameObject : TileObject
{
    public GameObject(char objectChar, ConsoleColor color=ConsoleColor.White) : base(objectChar, color)
    {

    }

    public override List<Component> Components { get; protected set; }


    public virtual List<MyVector2> MovementLogic() 
    {
        List<MyVector2> movements = new List<MyVector2>();
        if (MovementRule.Instance.CanMoveTo(MyVector2.Right))
            movements.Add(MyVector2.Right);
        if (MovementRule.Instance.CanMoveTo(MyVector2.Up)) 
            movements.Add(MyVector2.Up);
        if (MovementRule.Instance.CanMoveTo(MyVector2.Down))
            movements.Add(MyVector2.Down);
        if (MovementRule.Instance.CanMoveTo(MyVector2.Left))
            movements.Add(MyVector2.Left);
        foreach(MyVector2 movement in movements)
            EngineManager.Instance.renderingManager.ColorTile(TileMap.Instance.Grid[transform.Position.X + movement.X, transform.Position.Y + movement.Y], ConsoleColor.Blue);
        return movements;

    }

}