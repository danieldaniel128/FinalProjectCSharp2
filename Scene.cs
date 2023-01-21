using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Scene
{
    List<GameObject> _gameObjects = new List<GameObject>();

    public void Play()
    {
        var deltatime = 0.016f;
        while (true)
        {
            foreach (var go in _gameObjects)
            {
                go.Update(deltatime);
                Physics.Instance.Update(deltatime);
            }

            Thread.Sleep((int)(deltatime * 1000));
        }
    }
}
