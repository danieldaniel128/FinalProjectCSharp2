using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
     class RenderingManager
    {
        public UpgradedTileMap TileMap { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???


        public RenderingManager(UpgradedTileMap tileMap)
        {
            TileMap = tileMap;

        }
    }
}
