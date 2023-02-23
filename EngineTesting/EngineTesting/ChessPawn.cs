using FinalProjectCSharp2;

namespace EngineTesting
{
    public class ChessPawn : GameObject
    {
        bool firstMove { get; set; }
        public ChessPawn(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {

        }

        public override List<MyVector2> MovementLogic()
        {
            List<MyVector2> PawnMovments = new List<MyVector2>();
            if(firstMove==false)
                if(Actor==1)
                    PawnMovments = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Down * 2, null);
                else
                    PawnMovments = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Up * 2, null);
            else
                if(Actor == 1)
                    PawnMovments = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Down, null);
                else
                PawnMovments = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + MyVector2.Up, null);
            return PawnMovments;
        }
    }


}
