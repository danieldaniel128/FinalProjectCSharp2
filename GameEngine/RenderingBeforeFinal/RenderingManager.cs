using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp2
{
    public class RenderingManager : IRenderingMediator
    {

        public event Action OnPrint;

        public void DrawGrid()
        {
            Console.Clear();
            for (int y = 0; y < TileMap.Instance.Grid.GetLength(1); y++)
            {
                for (int x = 0; x < TileMap.Instance.Grid.GetLength(0); x++)
                {
                    Console.ForegroundColor = TileMap.Instance.Grid[x, y].TileColor;
                    Console.Write(TileMap.Instance.Grid[x, y].TileContainer);
                }
                Console.WriteLine();
            }
            PrintToUser();
        }

        public void AddToPrint(string message) 
        {
            OnPrint += () => Console.WriteLine(message);
        }

        public void PrintToUser()
        {
            OnPrint?.Invoke();
        }
        public void ClearPrint()
        {
            OnPrint=null;
        }



        /// <summary>
        /// converting Grid into a Chess Board
        /// </summary>
        /// <param name="newChar"></param>
        /// <param name="color"></param>
        /// <param name="moduluRow"></param>
        /// <param name="moduluColumn"></param>
        public void ChangeGridToChessGrid(ConsoleColor color = ConsoleColor.Red, int moduluRow = 2, int moduluColumn = 2)
    {
        for (int x = 0; x < TileMap.Instance.Grid.GetLength(0); x++)
        {
            for (int y = 0; y < TileMap.Instance.Grid.GetLength(1); y++)
            {
                if ((y % moduluRow == 0 && x % moduluRow == 0) || (y % moduluColumn == 1 && x % moduluColumn == 1))
                    ColorTile(TileMap.Instance.Grid[x, y], color);
                else
                    ColorTile(TileMap.Instance.Grid[x, y], ConsoleColor.White);

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
            for (int x = 0; x < TileMap.Instance.Grid.GetLength(0); x++)
            {
                for (int y = 0; y < TileMap.Instance.Grid.GetLength(1); y++)
                {
                    if (x == row)
                    {
                        if (y % 2 == 0)
                            TileMap.Instance.Grid[x, y] = new Tile(x, y, newChar, color);
                    }
                }
            }
        }
        public void PlaceGameObjectOnGrid( GameObject gameObject, int moduluRow = 2, int moduluColumn = 2)
     {
         for (int x = 0; x < TileMap.Instance.Grid.GetLength(0); x++)
         {
             for (int y = 0; y < TileMap.Instance.Grid.GetLength(1); y++)
             {
                 if (y % moduluRow == 0 && x % moduluRow == 0)
                        TileMap.Instance.Grid[x, y].gameObject = gameObject;
                 if (y % moduluColumn == 1 && x % moduluColumn == 1)
                        TileMap.Instance.Grid[x, y].gameObject = gameObject;
             }
         }
     }

       public void PlaceGameObjectOnGrid(GameObject gameObject, TileObject tileObject, MyVector2 position)
      {
            TileMap.Instance.Grid[(int)position.X, (int)position.Y].gameObject = tileObject;
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


          for (int x = 0; x < TileMap.Instance.Grid.GetLength(0); x++)
          {
              for (int y = 0; y < TileMap.Instance.Grid.GetLength(1); y++)
              {
                    if (new MyVector2(x, y) >= startPosition && new MyVector2(x, y) <= endPosition)
                    {
                    TileObject cloneGameObjet = (TileObject)tileObject.Clone();
                    TileMap.Instance.Grid[x, y].gameObject = cloneGameObjet;
                    cloneGameObjet.transform.Position = new MyVector2(x, y);
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
        for (int x = 0; x < TileMap.Instance.Grid.GetLength(0); x++)
        {
            for (int y = 0; y < TileMap.Instance.Grid.GetLength(1); y++)
            {
                if (x == row)
                {
                    if (y % 2 == 1)
                            TileMap.Instance.Grid[x, y] = new Tile(x, y, newChar, color);
                }
            }
        }
    }

        public void ColorTile(Tile tile,ConsoleColor tileColor) 
        {
            tile.TileColor = tileColor;
        }


    }


}
