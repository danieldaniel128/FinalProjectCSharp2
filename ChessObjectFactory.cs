namespace FinalProjectCSharp2
{
    public static class ChessObjectFactory
    {
        public static List<ChessObject> gameObjects = new List<ChessObject>();
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
            gameObjects.Add(new ChessObject(actor, objectChar, color));
            PlaceGameObjectOnGrid(startPos, EndPos);
        }

        public static void PlaceGameObjectOnGrid(MyVector2 startPos, MyVector2 EndPos)
        {
            foreach (ChessObject gameObject in gameObjects)
            {
                EngineManager.Instance.renderingManager.PlaceGameObjectOnGrid(gameObject, startPos, EndPos);

            }
        }



    }
}
