using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TileMapTesting
    {
        public void TileMapTest(TileMap tileMap)
        {

            if(tileMap.tiles.GetLength(0)>=10 && tileMap.tiles.GetLength(1)>=10)
                tileMap.tiles[7, 6].tileContainer = "[k]";

            for (int x = 0; x<tileMap.tiles.GetLength(0); x++)
            {
                for (int y = 0; y<tileMap.tiles.GetLength(1); y++)
                {
                    Console.Write(tileMap.tiles[x, y].tileContainer);
                }
                Console.WriteLine();
            }
        }
    }

