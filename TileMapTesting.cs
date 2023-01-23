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

            tileMap.DrawGrid(tileMap.Width, tileMap.Height);
        }
    }

