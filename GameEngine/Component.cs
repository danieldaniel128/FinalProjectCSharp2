namespace FinalProjectCSharp2;

/// <summary>
/// This class allows to create beahvioral rules for gameObjects
/// </summary>
public abstract class Component
{
    protected TileObject gameobject { get; set; }
    protected Component(TileObject gameObject)
    {
        gameobject = gameObject;
        gameobject.Components.Add(this);
    }

}