using System.Text.Json;

namespace FinalProjectCSharp2
{
    public interface IRenderingMediator
    {
        public void ChangeGridToChessGrid(ConsoleColor color = ConsoleColor.Red, int moduluRow = 2, int moduluColumn = 2);

        public void PlaceGameObjectOnGrid(GameObject gameObject, int moduluRow = 2, int moduluColumn = 2);

        public void PlaceGameObjectOnGrid(GameObject gameObject, TileObject tileObject, MyVector2 position);

        public void PlaceGameObjectOnGrid(TileObject tileObject, MyVector2 startPosition, MyVector2 endPosition);

        public void ChangeGridRowOdd(int row, char newChar, ConsoleColor color);

        public void DrawGrid();

        public void ColorTile(Tile Tile, ConsoleColor TileColor);
   
    }
}
