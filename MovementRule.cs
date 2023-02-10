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

    public bool CanMoveTo(MyVector2 MoveToPos)
    {
        throw new NotImplementedException();
    }

    public bool MoveDown(TileObject tileObject)
    {
        MyVector2 toPos= tileObject.transform.Position;
        //UpgradedTileMap.Instance.Grid[toPos.X, toPos.Y].;
        return true;
    }

    public bool MoveDown()
    {
        throw new NotImplementedException();
    }

    public bool MoveDownLeft()
    {
        throw new NotImplementedException();
    }

    public bool MoveDownRight()
    {
        throw new NotImplementedException();
    }

    public bool MoveLeft()
    {
        throw new NotImplementedException();
    }

    public bool MoveRight()
    {
        throw new NotImplementedException();
    }

    public bool MoveUp()
    {
        throw new NotImplementedException();
    }

    public bool MoveUpLeft()
    {
        throw new NotImplementedException();
    }

    public bool MoveUpRight()
    {
        throw new NotImplementedException();
    }
}


