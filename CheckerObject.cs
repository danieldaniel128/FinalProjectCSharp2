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
        List<MyVector2> Positons1;
        List<MyVector2> Positons2;
        List<MyVector2> Positons3;
        List<MyVector2> Positons4;
        //Quween Test
        //if (Actor % 2 == 0)
        Positons1 = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + (MyVector2.Up + MyVector2.Right)* 4, null);
        //Positons2 = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + (MyVector2.Down + MyVector2.Right) * 4, null);
        //Positons3 = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + (MyVector2.Up + MyVector2.Left) * 4, null);
        //Positons4 = MovementRule.Instance.CalculateRoute(this, transform.Position, transform.Position + (MyVector2.Down + MyVector2.Left) * 4, null);
        //Positons3 = new List<MyVector2>(Positons3.Concat(Positons4));
        //Positons2= new List<MyVector2>(Positons2.Concat(Positons3));
        //Positons1.Concat(Positons2);

        return Positons1;
    }
}
