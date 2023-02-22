using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public interface IMovementRule
{
    List<MyVector2> CalculateRoute(TileObject tileObject, MyVector2 StartPos, MyVector2 EndPos, List<Tile> blockingTiles);

    bool CanMoveTo(TileObject tileObject, MyVector2 MoveToPos);
    bool MoveUp(TileObject tileObject);
    bool MoveDown(TileObject tileObject);
    bool MoveLeft(TileObject tileObject);
    bool MoveRight(TileObject tileObject);
    bool MoveUpRight(TileObject tileObject);
    bool MoveDownRight(TileObject tileObject);
    bool MoveUpLeft(TileObject tileObject);
    bool MoveDownLeft(TileObject tileObject);

}

