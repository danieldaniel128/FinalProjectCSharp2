using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class TileObject : IUpdate, IComparer<TileObject>
{
    public event Action OnTouch; 

    public abstract List<Component> Components { get; protected set; }
    public virtual Transform transform => Components[0] as Transform;


    public TileObject()
    {
        Components = new List<Component>();
        Components.Add(new Transform(this));
    }
    public void Something()
    {
       OnTouch.Invoke();
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


    public int Compare(TileObject? a, TileObject? b)
    {
       // should compare positions
       if (a.transform.Position == b.transform.Position)
       {
           OnTouch.Invoke();
           return 0;
       }
       if (a.transform.Position < b.transform.Position)
       {
           return -1;
       }
       if (a.transform.Position > b.transform.Position)
       {
           return 1;
       }
       else
       {
           return -4; // a placeHolder
       }
    }
    


}
