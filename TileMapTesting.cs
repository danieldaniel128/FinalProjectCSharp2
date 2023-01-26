using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TileMapTesting
    {
        public void TileMapTest(TileMap tileMap)
        {
            if(tileMap.Tiles.GetLength(0)>=10 && tileMap.Tiles.GetLength(1)>=10)
                tileMap.Tiles[7, 6].TileContainer = "[!]";

            List<int> rowsList = new List<int>();

           // rowsList[0] = 1; rowsList[1] = 2;
        tileMap.DrawGrid(1, 0, '%');


    }
}

