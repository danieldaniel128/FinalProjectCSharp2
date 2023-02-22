using FinalProjectCSharp2;

namespace EngineTesting
{
    public class ChessPawn : GameObject
    {
        public ChessPawn(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {

        }

        public override List<MyVector2> MovementLogic()
        {
            Tile[,] Grid = TileMap.Instance.Grid;
            List<MyVector2> PawnMovments = new List<MyVector2>();
            PawnMovments = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Down, null); ;
            return PawnMovments;
        }
    }


}
