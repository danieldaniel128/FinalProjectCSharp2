using FinalProjectCSharp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public interface IMovementRule
{
    List<MyVector2> CalculateRoute(MyVector2 StartPos, MyVector2 EndPos, Tile[,] map, List<Tile> blockingTiles);

    bool CanMoveTo(MyVector2 MoveToPos);
    bool MoveUp();
    bool MoveDown();
    bool MoveLeft();
    bool MoveRight();
    bool MoveUpRight();
    bool MoveDownRight();
    bool MoveUpLeft();
    bool MoveDownLeft();

}

