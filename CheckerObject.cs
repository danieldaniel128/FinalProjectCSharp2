using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CheckerObject : GameObject
{
    public CheckerObject(int actor,char objectChar, ConsoleColor color = ConsoleColor.White) : base(actor,objectChar, color)
    {

    }

    public override List<Component> Components { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

    public override object Clone()
    {
        var tileObject = (CheckerObject)MemberwiseClone();
        tileObject.transform = new Transform(tileObject);
        return tileObject;
    }

    public override List<MyVector2> MovementLogic()
    {
            List<MyVector2> Positons= base.MovementLogic();
        

        return Positons;
    }
}
