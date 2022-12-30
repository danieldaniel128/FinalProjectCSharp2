using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
    public abstract class Component : IUpdate
{
    public TileObject tileObject;
    public Component(TileObject to)
    {
        tileObject = to;
    }


    public virtual void Update()
    {
        throw new NotImplementedException();
    }
}
