using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class RenderingManager
    {
        public UpgradedTileMap TileMap { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
 

        public RenderingManager(UpgradedTileMap tileMap)
        {
            TileMap = tileMap;
        }

        public void DrawGrid()
        {
            for (int y = 0; y < TileMap.Grid.GetLength(1); y++)
            {
                for (int x = 0; x < TileMap.Grid.GetLength(0); x++)
                {
                    Console.ForegroundColor = TileMap.Grid[x, y].TileColor;
                    Console.Write(TileMap.Grid[x, y].TileContainer);
                }
                Console.WriteLine();
            }
        }
    }
}
