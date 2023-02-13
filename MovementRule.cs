using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


class MovementRule : IMovementRule
{
    public List<MyVector2> CalculateRoute(MyVector2 StartPos, MyVector2 EndPos, Tile[,] map, List<Tile> blockingTiles)
    {
        throw new NotImplementedException();
    }

    public bool CanMoveTo(MyVector2 MoveToPos)//down up downleft downright left right
    {
        //if (UpgradedTileMap.Instance.Grid[MoveToPos.X, MoveToPos.Y] is not ) //checks if hole or not
        return true;
    }

    public bool MoveDown(TileObject tileObject)
    {
        if(!CanMoveTo(MyVector2.Down))
            return false;
        tileObject.Step(MyVector2.Down);
        return true;
    }

    public bool MoveUp(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Up))
            return false;
        tileObject.Step(MyVector2.Up);
        return true;
    }

    public bool MoveDownLeft(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Down+MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Down + MyVector2.Left);
        return true;
    }

    public bool MoveDownRight(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Down + MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Down + MyVector2.Right);
        return true;
    }

    public bool MoveLeft(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Left);
        return true;
    }

    public bool MoveRight(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Right);
        return true;
    }


    public bool MoveUpLeft(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Up + MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Up + MyVector2.Left);
        return true;
    }

    public bool MoveUpRight(TileObject tileObject)
    {
        if (!CanMoveTo(MyVector2.Up + MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Up + MyVector2.Right);
        return true;
    }


}


