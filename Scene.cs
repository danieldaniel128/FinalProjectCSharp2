namespace FinalProjectCSharp2;

public class Scene // we make a list of tilemaps that will add and remove as we like and we cane change tilemaps as we go to scene and mor. to be continued.
{
    List<TileObject> _gameObjects = new List<TileObject>();
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