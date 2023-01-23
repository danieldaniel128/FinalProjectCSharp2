using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TileMap
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public Tile[,] tiles { get; set; }

    public TileMap(int width, int height)
    {
        Width = width;
        Height = height;
        tiles = new Tile[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                tiles[x, y] = new Tile(x, y,'i');
            }
        }
    }

}