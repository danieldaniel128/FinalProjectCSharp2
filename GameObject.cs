using System.Collections;

namespace FinalProjectCSharp2;

public class GameObject : TileObject
{


    public GameObject(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
    {
        Actor =actor;
    }


  

    public override List<Component> Components { get; protected set; }


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
      //  if (MovementRule.Instance.CanMoveTo(transform.Position + MyVector2.Up + MyVector2.Right))
      //      movements.Add(transform.Position + MyVector2.Up + MyVector2.Right);
      //  if (MovementRule.Instance.CanMoveTo(transform.Position + MyVector2.Down + MyVector2.Right))
      //      movements.Add(transform.Position + MyVector2.Down + MyVector2.Right);
      //  if (MovementRule.Instance.CanMoveTo(transform.Position + MyVector2.Up + MyVector2.Left))
      //      movements.Add(transform.Position + MyVector2.Up + MyVector2.Left);
      //  if (MovementRule.Instance.CanMoveTo(transform.Position + MyVector2.Down + MyVector2.Left))
      //      movements.Add(transform.Position + MyVector2.Down + MyVector2.Left);
        foreach (MyVector2 movement in movements)
            EngineManager.Instance.renderingManager.ColorTile(TileMap.Instance.Grid[movement.X, movement.Y], ConsoleColor.Blue);
        return movements;

    }

}