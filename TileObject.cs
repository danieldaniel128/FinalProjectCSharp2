using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class TileObject : IUpdate, IComparer<TileObject>
{
    public abstract List<Component> Components { get; protected set; }
    public virtual Transform transform => Components[0] as Transform;


    public TileObject()
    {
        Components = new List<Component>();
        Components.Add(new Transform(this));
    }

    public void Update(float deltaTime)
    {
        foreach (var comp in Components)
        {
            comp.Update(deltaTime);
        }
    }

    public void AddComponent(Component component)
    {
        Components.Add(component);
    }


    public int Compare(TileObject? x, TileObject? y)
    {
       // should compare postisions
        throw new NotImplementedException();
    }
}
