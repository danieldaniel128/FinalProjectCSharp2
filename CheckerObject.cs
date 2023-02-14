using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CheckerObject : GameObject
{
    public CheckerObject(char objectChar, ConsoleColor color = ConsoleColor.White) : base(objectChar, color)
    {

    }

    public override List<Component> Components { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

    public override List<MyVector2> MovementLogic()
    {
        return base.MovementLogic();
    }
}
