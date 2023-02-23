using FinalProjectCSharp2;

namespace EngineTesting
{
    class ChessKing : GameObject
    {
        public ChessKing(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {

        }

        public override List<MyVector2> MovementLogic()
        {
            IRenderingMediator rendering = new RenderingManager();
            List<MyVector2> kingMovements = base.MovementLogic();
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up  + MyVector2.Right))
                kingMovements.Add(transform.Position + MyVector2.Up + MyVector2.Right);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up + MyVector2.Left))
                kingMovements.Add(transform.Position + MyVector2.Up + MyVector2.Left);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down + MyVector2.Right))
                kingMovements.Add(transform.Position + MyVector2.Down + MyVector2.Right);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down + MyVector2.Left))
                kingMovements.Add(transform.Position + MyVector2.Up + MyVector2.Left);
            foreach (MyVector2 movement in kingMovements)
                rendering.ColorTile(TileMap.Instance.Grid[movement.X, movement.Y], ConsoleColor.Blue);
            return kingMovements;
        }
    }
}
