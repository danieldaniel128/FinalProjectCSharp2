using FinalProjectCSharp2;

namespace EngineTesting
{
    public class ChessQueen : GameObject
    {
        public ChessQueen(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {

        }

        public override List<MyVector2> MovementLogic()
        {
            Tile[,] Grid = TileMap.Instance.Grid;
            List<MyVector2> QueenMovements = new List<MyVector2>();
            QueenMovements = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + (MyVector2.Up +  MyVector2.Right) * (TileMap.Instance.Width + TileMap.Instance.Height), null);
            QueenMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Up * TileMap.Instance.Height, null));
            QueenMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Down * TileMap.Instance.Height, null));
            QueenMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Left * TileMap.Instance.Width, null));
            QueenMovements.AddRange(MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Right * TileMap.Instance.Width, null));
            return QueenMovements;
        }
    }


}
