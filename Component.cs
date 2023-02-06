namespace FinalProjectCSharp2;

public abstract class Component : IUpdate
{
    public TileObject gameobject;
    public Component(TileObject gameObject)
    {
        gameobject = gameObject;
        EngineManager.Instance.AddUpdateable(this);
        gameobject.Components.Add(this);
    }

    public virtual void Update()
    {

    }
}