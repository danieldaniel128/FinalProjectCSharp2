using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTesting
{
    public class ChessRook : GameObject
    {
        public ChessRook(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {
        }

        public override List<MyVector2> MovementLogic()
        {
            TileMap map = TileMap.Instance;
            List<MyVector2> RookMovements = new List<MyVector2>();
            RookMovements = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Right* map.Width, null);
            RookMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Left * map.Width, null));
            RookMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Up * map.Height, null));
            RookMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Down * map.Height, null));
            return RookMovements;
        }


    }
}
