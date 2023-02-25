using System.Text.Json;

namespace FinalProjectCSharp2
{
    public interface IRendering
    {
        public void ChangeGridToChessGrid(ConsoleColor color = ConsoleColor.Red, int moduluRow = 2, int moduluColumn = 2);

        public void PlaceGameObjectOnGrid(GameObject gameObject, int moduluRow = 2, int moduluColumn = 2);

        public void PlaceGameObjectOnGrid(GameObject gameObject, TileObject tileObject, MyVector2 position);

        public void PlaceGameObjectOnGrid(TileObject tileObject, MyVector2 startPosition, MyVector2 endPosition);

        public void ChangeGridRowOdd(int row, ConsoleColor color);

        public void DrawGrid();

        public void AddToPrint(string message);

        public void PrintToUser();

        public void ClearPrint();

        public void ColorTile(Tile Tile, ConsoleColor TileColor);
   
    }
}
