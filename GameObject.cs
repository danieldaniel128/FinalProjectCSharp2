using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

public class GameObject : IUpdate
{
    List<Component> _components;
    public Transform transform => _components[0] as Transform;

    public Scene Affiliation;

    public GameObject()
    {
        _components = new List<Component>();
        _components.Add(new Transform(this));
    }

    public void Update(float deltaTime)
    {
        foreach (var comp in _components)
        {
            comp.Update(deltaTime);
        }
    }

    public void AddComponent(Component c)
    {
        _components.Add(c);
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
