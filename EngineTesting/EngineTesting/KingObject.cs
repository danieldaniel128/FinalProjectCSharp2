using FinalProjectCSharp2;

namespace EngineTesting
{
    class KingObject : GameObject
    {
        public KingObject(int actor, char objectChar, ConsoleColor color) : base(actor, objectChar, color)
        {

        }

        public override List<MyVector2> MovementLogic()
        {
            return base.MovementLogic();
        }
    }
}
