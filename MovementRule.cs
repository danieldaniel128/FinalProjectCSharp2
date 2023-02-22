using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public class MovementRule : Singelton<MovementRule>, IMovementRule
{

    IRenderingMediator rendering = new RenderingManager();
    public List<MyVector2> CalculateRoute(TileObject gameObject, MyVector2 StartPos, MyVector2 EndPos, List<Tile> blockingTiles)
    {
        List<MyVector2> movements = new List<MyVector2>();
        for (int x = 0; x < TileMap.Instance.Width; x++)
            for (int y = 0; y < TileMap.Instance.Height; y++)
            {
                if (StartPos.X == EndPos.X )//COLUMN PATHS
                    if (( x==StartPos.X && StartPos.Y <= y && y <= EndPos.Y) && CanMoveTo(gameObject, new MyVector2(x, y)))
                    movements.Add(new MyVector2(x, y));
                if (StartPos.Y == EndPos.Y)//ROWS PATH
                    if ( (StartPos.X<= x && x <= EndPos.X && StartPos.Y <= y && y <= EndPos.Y) && CanMoveTo(gameObject, new MyVector2(x, y)))
                     movements.Add(new MyVector2(x, y));
                if (MathF.Abs(EndPos.Y - StartPos.Y) == MathF.Abs(EndPos.X - StartPos.X))//ALACHSON PATH
                    if ( (MathF.Abs(y - StartPos.Y) == MathF.Abs(x - StartPos.X)) && CanMoveTo(gameObject, new MyVector2(x, y)))
                        movements.Add(new MyVector2(x,y));
            }
        foreach (MyVector2 movement in movements)//color path
            rendering.ColorTile(TileMap.Instance.Grid[movement.X, movement.Y], ConsoleColor.Blue);
        return movements;
    }

    public bool CanMoveTo(TileObject gameObject,MyVector2 MoveToPos)//down up downleft downright left right
    {
       if(!(MoveToPos.X < TileMap.Instance.Grid.GetLength(1)&& MoveToPos.X >-1 && MoveToPos.Y < TileMap.Instance.Grid.GetLength(0) && MoveToPos.Y > -1))
        return false;
        if (TileMap.Instance.Grid[MoveToPos.X, MoveToPos.Y].gameObject?.Actor == gameObject.Actor)
            return false;
        return true;
    }

    public List<MyVector2> PositionsToMoveObject(GameObject tileObject) 
    {
        if (tileObject == null)
            return null;
        return tileObject.MovementLogic();
    }

    public bool MoveDown(TileObject tileObject)
    {
        if(tileObject == null || !CanMoveTo(tileObject,MyVector2.Down))
            return false;
        tileObject.Step(MyVector2.Down);
        return true;
    }

    public bool MoveUp(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject,MyVector2.Up))
            return false;
        tileObject.Step(MyVector2.Up);
        return true;
    }

    public bool MoveDownLeft(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject,MyVector2.Down+MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Down + MyVector2.Left);
        return true;
    }

    public bool MoveDownRight(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject,MyVector2.Down + MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Down + MyVector2.Right);
        return true;
    }

    public bool MoveLeft(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject,MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Left);
        return true;
    }

    public bool MoveRight(TileObject tileObject)
    {
        if (tileObject==null || !CanMoveTo(tileObject,MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Right);
        return true;
    }


    public bool MoveUpLeft(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject,MyVector2.Up + MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Up + MyVector2.Left);
        return true;
    }

    public bool MoveUpRight(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject,MyVector2.Up + MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Up + MyVector2.Right);
        return true;
    }


}


