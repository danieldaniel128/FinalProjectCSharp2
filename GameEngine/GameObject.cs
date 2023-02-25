using System.Collections;

namespace FinalProjectCSharp2;

public class GameObject : TileObject
{
    

    /// <summary>
    /// This Class let's you create playable object to place on the grid
    /// </summary>
    /// <param name="actor"></param>
    /// <param name="objectChar"></param>
    /// <param name="color"></param>
    public GameObject(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
    {
        Actor =actor;
    }

    public override List<Component> Components { get; protected set; }

    /// <summary>
    /// Use this method to apply movment logic to your gameObject using the movementRule class
    /// </summary>
    /// <returns></returns>
    public virtual List<MyVector2> MovementLogic() 
    {
        List<MyVector2> movements = new List<MyVector2>();
        if (MovementRule.Instance.CanMoveTo(this,transform.Position+MyVector2.Right))
            movements.Add(transform.Position + MyVector2.Right);
        if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up)) 
            movements.Add(transform.Position + MyVector2.Up);
        if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down))
            movements.Add(transform.Position + MyVector2.Down);
        if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Left))
            movements.Add(transform.Position + MyVector2.Left);
     
        foreach (MyVector2 movement in movements)
            EngineManager.Instance.Rendering.ColorTile(TileMap.Instance.Grid[movement.X, movement.Y], ConsoleColor.Blue);
        return movements;

    }

}