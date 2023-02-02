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
 

        public RenderingManager()
        {
           

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
        /// <summary>
        /// converting Grid into a Chess Board
        /// </summary>
        /// <param name="newChar"></param>
        /// <param name="color"></param>
        /// <param name="moduluRow"></param>
        /// <param name="moduluColumn"></param>
     public void ChangeGridToChessGrid(  char newChar, ConsoleColor color = ConsoleColor.Red, int moduluRow = 2, int moduluColumn = 2)
    {
        for (int x = 0; x < TileMap.Grid.GetLength(0); x++)
        {
            for (int y = 0; y < TileMap.Grid.GetLength(1); y++)
            {
                if (y % moduluRow == 0 && x % moduluRow == 0)
                    TileMap.Grid[x, y] = new Tile(x, y, newChar, color);
                if (y % moduluColumn == 1 && x % moduluColumn == 1)
                        TileMap.Grid[x, y] = new Tile(x, y, newChar, color);
            }
        }
    }

        /// <summary>
        /// to transform all Tiles in a specific <paramref name="row"/> to different char aka <paramref name="newChar"/> and <paramref name="color"/>
        /// </summary>
        /// <param name="row"></param>
        /// <param name="newChar"></param>
        /// <param name="color"></param>
        public void ChangeGridRowEven( int row, char newChar, ConsoleColor color)
        {
            for (int x = 0; x < TileMap.Grid.GetLength(0); x++)
            {
                for (int y = 0; y < TileMap.Grid.GetLength(1); y++)
                {
                    if (x == row)
                    {
                        if (y % 2 == 0)
                            TileMap.Grid[x, y] = new Tile(x, y, newChar, color);
                    }
                }
            }
        }
        public void PlaceGameObjectOnGrid( GameObject gameObject, int moduluRow = 2, int moduluColumn = 2)
     {
         for (int x = 0; x < TileMap.Grid.GetLength(0); x++)
         {
             for (int y = 0; y < TileMap.Grid.GetLength(1); y++)
             {
                 if (y % moduluRow == 0 && x % moduluRow == 0)
                     TileMap.Grid[x, y].gameObject = gameObject;
                 if (y % moduluColumn == 1 && x % moduluColumn == 1)
                     TileMap.Grid[x, y].gameObject = gameObject;
             }
         }
     }

       public void PlaceGameObjectOnGrid( TileObject tileObject, MyVector2 position)
      {
          TileMap.Grid[(int)position.X, (int)position.Y].gameObject = tileObject;
      }
      /// <summary>
      /// Add GameObjects from StartPosition to EndPosition On The Grid
      /// </summary>
      /// <param name="tileMap"></param>
      /// <param name="tileObject"></param>
      /// <param name="startPosition"></param>
      /// <param name="endPosition"></param>
       public void PlaceGameObjectOnGrid( TileObject tileObject, MyVector2 startPosition, MyVector2 endPosition)
      {


          for (int x = 0; x < TileMap.Grid.GetLength(0); x++)
          {
              for (int y = 0; y < TileMap.Grid.GetLength(1); y++)
              {
                  if (new MyVector2(x, y) >= startPosition && new MyVector2(x, y) <= endPosition)
                  {
                      TileMap.Grid[x, y].gameObject = tileObject;
                  }

              }
          }


      }
    /// <summary>
    /// to transform all odd tiles in a specific <paramref name="row"/> to different char aka <paramref name="newChar"/> and <paramref name="color"/>
    /// </summary>
    /// <param name="tileMap"></param>
    /// <param name="row"></param>
    /// <param name="newChar"></param>
    /// <param name="color"></param>
     public void ChangeGridRowOdd( int row, char newChar, ConsoleColor color)
    {
        for (int x = 0; x < TileMap.Grid.GetLength(0); x++)
        {
            for (int y = 0; y < TileMap.Grid.GetLength(1); y++)
            {
                if (x == row)
                {
                    if (y % 2 == 1)
                        TileMap.Grid[x, y] = new Tile(x, y, newChar, color);
                }
            }
        }
    }
    }


}
