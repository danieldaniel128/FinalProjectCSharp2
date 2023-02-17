namespace FinalProjectCSharp2
{
    public static class GameObjectCreator<T> where T: GameObject
    {
        public static List<T> gameObjects = new List<T>();

        /// <summary>
        /// This Factory Method Allows you to place Gameobjects on the Grid
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="objectChar"></param>
        /// <param name="startPos"></param>
        /// <param name="EndPos"></param>
        /// <param name="color"></param>
        public static void AddToGrid(int actor, char objectChar, MyVector2 startPos, MyVector2 EndPos, ConsoleColor color = ConsoleColor.White)
        {
            T gameObject = (T)Activator.CreateInstance(typeof(T), actor, objectChar, color);
            gameObjects.Add(gameObject);
            PlaceGameObjectOnGrid(startPos,EndPos);
        }

        public static void PlaceGameObjectOnGrid(MyVector2 startPos, MyVector2 EndPos)
        {
            foreach (T gameObject in gameObjects)
            {
               EngineManager.Instance.renderingManager.PlaceGameObjectOnGrid(gameObject, startPos, EndPos);
            }
        }

    }
}
