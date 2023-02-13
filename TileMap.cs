using System.Collections;
using System.Drawing;

namespace FinalProjectCSharp2;

public class TileMap : Singelton<TileMap>, IEnumerable<Tile>
{


    public Tile[,] Grid;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public IEnumerator<Tile> GetEnumerator()//new IntegerEnumerator(_list.ToArray());
    {
        return new TileEnumerator(Grid);
    }

    /// <summary>
    ///  Building a TileMap: enter Width,Height 
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>

    public void Inititialize(int width, int height)
    {
        Width = width;
        Height = height;
        Grid = new Tile[Width, Height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Grid[x, y] = new Tile(x, y, '#', ConsoleColor.White);
            }
        }
    }



    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void FillSpiralMatrix()
    {
        int maxSteps = 1;
        int stepsTaken = 0;
        int direction = 2; // 0 = right, 1 = down, 2 = left, 3 = up


        int maxSizeRow = Grid.GetLength(0);
        int maxSizeCol = Grid.GetLength(1);
        int num = 1;
        int row = maxSizeRow / 2;
        int col = maxSizeCol / 2;

        Grid[row, col].TileContainer = "[0" + num + "]";


        while (num < maxSizeRow * maxSizeCol)
        {

            stepsTaken++;
            switch (direction)
            {
                case 0: // move right
                    col++;
                    break;
                case 1: // move down
                    row++;
                    break;
                case 2: // move left
                    col--;
                    break;
                case 3: // move up
                    row--;
                    break;
            }
            if (row < 0 || row >= maxSizeRow || col < 0 || col >= maxSizeCol)
            {
                break;
            }
            if (stepsTaken == maxSteps)
            {
                stepsTaken = 0;
                direction = (direction + 1) % 4;
                if (direction % 2 == 0)
                {
                    maxSteps++;
                }
            }
            ++num;
            if (num < 10)
                Grid[row, col].TileContainer = "[0" + num + "]";
            else
                Grid[row, col].TileContainer = "[" + num + "]";
        }
    }

}



struct TileEnumerator : IEnumerator<Tile>
{
    Tile[,] _enumerable;  //first rows, second column
    public int _currentRowIndex,_currentCulomnIndex;

    int maxColumnIndex, maxRowIndex;

    int _direction=0, _maxSteps=1, _stepsTaken=0;

    public TileEnumerator(Tile[,] enumerable)
    {
        _enumerable = enumerable;
        _currentRowIndex = _enumerable.GetLength(0) / 2;
        _currentCulomnIndex = (_enumerable.GetLength(1) / 2);
        maxColumnIndex = _enumerable.GetLength(0);
        maxRowIndex = _enumerable.GetLength(1);
    }
    public Tile Current => _currentRowIndex < maxRowIndex && _currentRowIndex >= 0 && _currentCulomnIndex < maxColumnIndex && _currentCulomnIndex >= 0 ? _enumerable[_currentRowIndex,_currentCulomnIndex] : default;
    object IEnumerator.Current => Current;

    public void Dispose() {}


    public bool MoveNext()
    {
        _stepsTaken++;
        switch (_direction)
        {
            case 0: // move left
                _currentCulomnIndex--;
                break;
            case 1: // move up
                _currentRowIndex--;
                break;
            case 2: // move right
                _currentCulomnIndex++;
                break;
            case 3: // move down
                _currentRowIndex++;
                break;
        }

        if (_stepsTaken == _maxSteps)
        {
            _stepsTaken = 0;
            _direction = (_direction + 1) % 4;
            if (_direction % 2 == 0)
            {
                _maxSteps++;
            }
        }
        return _currentRowIndex > 0 || _currentRowIndex < maxRowIndex || _currentCulomnIndex > 0 || _currentCulomnIndex < maxColumnIndex;
    }

    public void Reset() 
    {
        
    }

}