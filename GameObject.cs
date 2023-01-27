using System;
using FinalProjectCSharp2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameObject : TileObject
{
    public override List<Component> Components { get; protected set; }
}
