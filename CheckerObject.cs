using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class CheckerObject : GameObject
{
    public CheckerObject(int actor,char objectChar, ConsoleColor color = ConsoleColor.White) : base(actor,objectChar, color)
    {

    }

    public override List<Component> Components { get; protected set; }

    public override object Clone()
    {
        var tileObject = (CheckerObject)MemberwiseClone();
        tileObject.transform = new Transform(tileObject);
        return tileObject;
    }

    public override List<MyVector2> MovementLogic()
    {
        List<MyVector2> Positons;
        //Quween Test
        if (Actor%2==0)
            Positons= MovementRule.Instance.CalculateRoute(this,transform.Position, transform.Position + MyVector2.Up * (TileMap.Instance.Height - transform.Position.Y),null);


        return Positons;
    }
}
