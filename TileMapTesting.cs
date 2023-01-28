namespace FinalProjectCSharp2;

public class TileMapTesting
{
    public void TileMapTest(TileMap tileMap)
    {
        if(tileMap.Tiles.GetLength(0)>=10 && tileMap.Tiles.GetLength(1)>=10)
            tileMap.Tiles[7, 6].TileContainer = "[!]";

        List<int> rowsList = new List<int>();
    }
    public void TestMoveIndex(UpgradedTileMap tiles) 
    {
        TileEnumerator map = new TileEnumerator(tiles.Grid);

        while (map.MoveNext()) //testing to check if spiral index works
        {
            
            if (map._currentRowIndex == 4 || map._currentCulomnIndex == 5)
                break;
            Console.Write(tiles.Grid[map._currentRowIndex, map._currentCulomnIndex].TileContainer);
            Console.WriteLine($"({map._currentRowIndex} , {map._currentCulomnIndex})");
        }
    }

}