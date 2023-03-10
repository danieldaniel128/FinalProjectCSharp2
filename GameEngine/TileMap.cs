using System.Collections;
using System.Drawing;

namespace FinalProjectCSharp2;

public class TileMap : Singelton<TileMap>, IEnumerable<Tile>
{


    private Tile[,] grid;
    public Tile[,] Grid { get => grid; private set => grid = value; }
    public int Width { get; private set; }
    public int Height { get; private set; }

    public IEnumerator<Tile> GetEnumerator()
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
                Grid[x, y] = new Tile(x, y, ConsoleColor.White);
            }
        }
    }



    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    

}

/// <summary>
/// An iterator that goes through the grid
/// </summary>

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

    public void Reset() { }

}