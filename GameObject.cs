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
        { 
            movements.Add(MyVector2.Right);
            EngineManager.Instance.renderingManager.ColorTile(TileMap.Instance.Grid[transform.Position.X+ MyVector2.Right.X, transform.Position.Y+ MyVector2.Right.Y], ConsoleColor.Blue);
        } 
        
        if (MovementRule.Instance.CanMoveTo(MyVector2.Up)) 
        { 
            movements.Add(MyVector2.Up);
            EngineManager.Instance.renderingManager.ColorTile(TileMap.Instance.Grid[transform.Position.X + MyVector2.Up.X, transform.Position.Y + MyVector2.Up.Y], ConsoleColor.Blue);
        }
        if (MovementRule.Instance.CanMoveTo(MyVector2.Down))
        {
            movements.Add(MyVector2.Down);
            EngineManager.Instance.renderingManager.ColorTile(TileMap.Instance.Grid[transform.Position.X + MyVector2.Down.X, transform.Position.Y + MyVector2.Down.Y], ConsoleColor.Blue);
        }
        if (MovementRule.Instance.CanMoveTo(MyVector2.Left))
        {
            movements.Add(MyVector2.Left);
            EngineManager.Instance.renderingManager.ColorTile(TileMap.Instance.Grid[transform.Position.X + MyVector2.Left.X, transform.Position.Y + MyVector2.Left.Y], ConsoleColor.Blue);
        }
        return movements;

    }

}