using FinalProjectCSharp2;


public class MovementRule : Singelton<MovementRule>, IMovementRule
{


    /// <summary>
    /// This methods allows to to easily detrminte directions of your gameObject
    /// </summary>
    /// <param name="gameObject"></param>
    /// <param name="StartPos"></param>
    /// <param name="EndPos"></param>
    /// <param name="blockingTiles"></param>
    /// <returns></returns>
    public List<MyVector2> CalculateRoute(TileObject gameObject, MyVector2 StartPos, MyVector2 EndPos, List<Tile> blockingTiles)
    {
        List<MyVector2> movements = new List<MyVector2>();
        for (int x = 0; x < TileMap.Instance.Width; x++)
            for (int y = 0; y < TileMap.Instance.Height; y++)
            {
                if (StartPos.X == EndPos.X)//COLUMN PATHS
                    if (StartPos.Y > EndPos.Y)
                    {
                        int tmpY = TileMap.Instance.Width - 1 - y;
                        if ((x == StartPos.X && (StartPos.Y >= tmpY && tmpY >= EndPos.Y)) && CanMoveTo(gameObject, new MyVector2(x, tmpY)))
                            if (TileMap.Instance.Grid[x, tmpY].gameObject != null)
                            {
                                movements.Add(new MyVector2(x, tmpY));
                                goto End;
                            }
                            else
                                movements.Add(new MyVector2(x, tmpY));

                    }
                    else
                    {
                        if ((x == StartPos.X && (StartPos.Y <= y && y <= EndPos.Y)) && CanMoveTo(gameObject, new MyVector2(x, y)))
                            if (TileMap.Instance.Grid[x, y].gameObject != null)
                            {
                                movements.Add(new MyVector2(x, y));
                                goto End;
                            }
                            else
                                movements.Add(new MyVector2(x, y));
                    }
                if (StartPos.Y == EndPos.Y)//ROWS PATH
                {
                    int tmpX = TileMap.Instance.Width-1 - x;
                    if (StartPos.X > EndPos.X)//jump to left side
                    {
                        if ((StartPos.X >= tmpX && tmpX >= EndPos.X) && StartPos.Y == y && CanMoveTo(gameObject, new MyVector2(tmpX, y)))
                            if (TileMap.Instance.Grid[tmpX, y].gameObject != null)
                            {
                                movements.Add(new MyVector2(tmpX, y));
                                goto End;
                            }
                            else
                                movements.Add(new MyVector2(tmpX, y));
                    }
                    else//jump to right side
                    {
                        tmpX = TileMap.Instance.Width - x;
                        if ((StartPos.X <= tmpX && tmpX <= EndPos.X) && StartPos.Y == y && CanMoveTo(gameObject, new MyVector2(tmpX, y)))
                            if (TileMap.Instance.Grid[tmpX, y].gameObject != null)
                            {
                                movements.Add(new MyVector2(tmpX, y));
                                goto End;
                            }
                            else
                                movements.Add(new MyVector2(tmpX, y));
                    }
                }
                if (MathF.Abs(EndPos.Y - StartPos.Y) == MathF.Abs(EndPos.X - StartPos.X))//ALACHSON PATH
                    if ((MathF.Abs(y - StartPos.Y) == MathF.Abs(x - StartPos.X)) && CanMoveTo(gameObject, new MyVector2(x, y)))
                        movements.Add(new MyVector2(x, y));
            }
        End:
        foreach (MyVector2 movement in movements)//color path
            EngineManager.Instance.Rendering.ColorTile(TileMap.Instance.Grid[movement.X, movement.Y], ConsoleColor.Blue);
        return movements;
    }

    /// <summary>
    /// This Method Detrmines whether the gameObject can move to the select position
    /// </summary>
    /// <param name="gameObject"></param>
    /// <param name="MoveToPos"></param>
    /// <returns></returns>

    public bool CanMoveTo(TileObject gameObject, MyVector2 MoveToPos)//down up downleft downright left right
    {
        if (!(MoveToPos.X < TileMap.Instance.Grid.GetLength(1) && MoveToPos.X > -1 && MoveToPos.Y < TileMap.Instance.Grid.GetLength(0) && MoveToPos.Y > -1))
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
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Down))
            return false;
        tileObject.Step(MyVector2.Down);
        return true;
    }

    public bool MoveUp(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Up))
            return false;
        tileObject.Step(MyVector2.Up);
        return true;
    }

    public bool MoveDownLeft(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Down + MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Down + MyVector2.Left);
        return true;
    }

    public bool MoveDownRight(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Down + MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Down + MyVector2.Right);
        return true;
    }

    public bool MoveLeft(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Left);
        return true;
    }

    public bool MoveRight(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Right);
        return true;
    }


    public bool MoveUpLeft(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Up + MyVector2.Left))
            return false;
        tileObject.Step(MyVector2.Up + MyVector2.Left);
        return true;
    }

    public bool MoveUpRight(TileObject tileObject)
    {
        if (tileObject == null || !CanMoveTo(tileObject, MyVector2.Up + MyVector2.Right))
            return false;
        tileObject.Step(MyVector2.Up + MyVector2.Right);
        return true;
    }


}


