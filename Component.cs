namespace FinalProjectCSharp2;

public abstract class Component : IUpdate
{
    public TileObject gameobject;
    public Component(TileObject gameObject)
    {
        gameobject = gameObject;
    }

    public virtual void Update(float deltaTime)
    {

    }
}