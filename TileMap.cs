using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FinalProjectCSharp2;


public class TileMap
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public Tile[,] Tiles { get; set; }
    private char _tileObjectChar;

    /// <summary>
    ///  Building a TileMap: enter Width,Height 
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public TileMap(int width, int height)
    {
        Width = width;
        Height = height;
        Tiles = new Tile[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Tiles[x, y] = new Tile(x, y,'#',ConsoleColor.White);
            }
        }
    }

    /// <summary>
    /// Building a TileMap: enter Width, Height, TileObjectChar. (TileObjectChar is the Char that will be the default Tile))
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="tileObjectChar"></param>
    public TileMap(int width, int height, char tileObjectChar)
    {
        _tileObjectChar = tileObjectChar;
        Width = width;
        Height = height;
        Tiles = new Tile[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Tiles[x, y] = new Tile(x, y, tileObjectChar,ConsoleColor.White);
            }
        }
    }
    

    /// <summary>
    /// A method that Draws the Grid from the constructors parameters
    /// </summary>

    public void DrawGrid()
    {
        for (int x = 0; x < Tiles.GetLength(0); x++)
        {
            for (int y = 0; y < Tiles.GetLength(1); y++)
            {
                Console.Write(Tiles[x, y].TileContainer);
            }
            Console.WriteLine();
        }
    }

    public void ChangeGridRow( int row, int columns, char rowsTileObjectChar)
    {
        //rowsTileObjectChar = 'g';

        for (int x = 0; x < Tiles.GetLength(0); x++)
        {
            for (int y = 0; y < Tiles.GetLength(1); y++)
            {

                if (x == row)
                {
                    Tiles[x, y] = new Tile(x, y, rowsTileObjectChar,ConsoleColor.Red);
                    Console.Write(Tiles[x, y].TileContainer);
                }
                else
                {
                    Console.Write(Tiles[x, y].TileContainer);
                }

            }
            Console.WriteLine();
        }
    }



}

