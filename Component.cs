using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Component : IUpdate
{
    public GameObject gameobject;
    public Component(GameObject go)
    {
        gameobject = go;
    }

    public virtual void Update(float deltaTime)
    {

    }
}
