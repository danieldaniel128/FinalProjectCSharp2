using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTesting
{
    public class ChessKnight : GameObject
    {
        public ChessKnight(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color) { }

        public override List<MyVector2> MovementLogic()
        {
            IRendering rendering = new RenderingManager();
            List<MyVector2> knightMovements = new List<MyVector2>(); 
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up*2 + MyVector2.Right))
                knightMovements.Add(transform.Position + MyVector2.Up * 2 + MyVector2.Right);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down * 2 + MyVector2.Right))
                knightMovements.Add(transform.Position + MyVector2.Down * 2 + MyVector2.Right);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up * 2 + MyVector2.Left))
                knightMovements.Add(transform.Position + MyVector2.Up * 2 + MyVector2.Left);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down * 2 + MyVector2.Left))
                knightMovements.Add(transform.Position + MyVector2.Down * 2 + MyVector2.Left);

            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up  + MyVector2.Right * 2))
                knightMovements.Add(transform.Position + MyVector2.Up + MyVector2.Right * 2);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down + MyVector2.Right * 2))
                knightMovements.Add(transform.Position + MyVector2.Down + MyVector2.Right * 2);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Up * 2 + MyVector2.Left * 2))
                knightMovements.Add(transform.Position + MyVector2.Up + MyVector2.Left * 2);
            if (MovementRule.Instance.CanMoveTo(this, transform.Position + MyVector2.Down * 2 + MyVector2.Left * 2))
                knightMovements.Add(transform.Position + MyVector2.Down + MyVector2.Left * 2);

            foreach (MyVector2 movement in knightMovements)
                rendering.ColorTile(TileMap.Instance.Grid[movement.X, movement.Y], ConsoleColor.Blue);

            return knightMovements;
        }

    }
}
