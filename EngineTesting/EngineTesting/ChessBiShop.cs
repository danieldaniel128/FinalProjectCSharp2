using FinalProjectCSharp2;

namespace EngineTesting
{
    public class ChessBiShop : GameObject
    {
        public ChessBiShop(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {

        }

        public override List<MyVector2> MovementLogic()
        {
            Tile[,] Grid = TileMap.Instance.Grid;
            List<MyVector2> QueenMovements = new List<MyVector2>();
            QueenMovements = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + (MyVector2.Up +  MyVector2.Right) * (TileMap.Instance.Width+ TileMap.Instance.Height), null); ;
            return QueenMovements;
        }
    }


}
