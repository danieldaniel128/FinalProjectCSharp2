﻿using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


class MovementRule : Singelton<MovementRule>, IMovementRule
{
    public List<MyVector2> CalculateRoute(MyVector2 StartPos, MyVector2 EndPos, Tile[,] map, List<Tile> blockingTiles)
    {
        throw new NotImplementedException();
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


