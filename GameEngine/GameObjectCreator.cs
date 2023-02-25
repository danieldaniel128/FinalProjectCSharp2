namespace FinalProjectCSharp2
{
    /// <summary>
    /// Inside the type here, place the gameObject you want to place on the grid
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class GameObjectCreator<T> where T : GameObject
    {
        /// <summary>
        /// This List returns a list of generic gameObjects to place on the grid
        /// </summary>
        private static List<T> gameObjects = new List<T>();
        public static List<T> GameObjects { get => gameObjects; set => gameObjects = value; }


        /// <summary>
        /// This Factory Method Allows you to place your chosen Gameobject type on the Grid
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="objectChar"></param>
        /// <param name="startPos"></param>
        /// <param name="EndPos"></param>
        /// <param name="color"></param>
        public static void AddToGrid(int actor, char objectChar, MyVector2 startPos, MyVector2 EndPos, ConsoleColor color = ConsoleColor.White)
        {
            T gameObject = (T)Activator.CreateInstance(typeof(T), actor, objectChar, color);
            GameObjects.Add(gameObject);
            PlaceGameObject(startPos, EndPos);

        }

        /// <summary>
        /// This method uses the PlaceGameObjectOnGrid of the renderer to place the generic Gameobject on the grid
        /// </summary>
        /// <param name="startPos"></param>
        /// <param name="EndPos"></param>

        private static void PlaceGameObject(MyVector2 startPos, MyVector2 EndPos)
        {
            foreach (T gameObject in GameObjects)
            {
                EngineManager.Instance.Rendering.PlaceGameObjectOnGrid(gameObject, startPos, EndPos);
            }
        }


    }
}
