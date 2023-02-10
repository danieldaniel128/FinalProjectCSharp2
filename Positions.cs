

namespace FinalProjectCSharp2;

readonly struct Positions : IPositioning
{

    public readonly int _x;
    public readonly int _y;

    int IPositioning.X { readonly get => _x; set => throw new NotImplementedException(); }
    int IPositioning.Y { readonly get => _y; set => throw new NotImplementedException(); }

    /// <summary>
    /// A tool to position the player
    /// </summary>

    public Positions(int x, int y)
    {
        this._x = x;
        this._y = y;
    }

    public static Positions operator +(Positions pos1, Positions pos2)
    {
        return new Positions(pos1._x + pos2._x, pos1._y + pos2._y);
    }


    public static Positions operator -(Positions pos1, Positions pos2)
    {
        return new Positions(pos1._x - pos2._x, pos1._y - pos2._y);
    }



    public override string ToString() => "The Position is" + " X :" + _x + " Y: " + _y;

    public override bool Equals(object obj)
    {
        if (!(obj is Positions))
        {
            return false;
        }
        else
        {
            Positions positions = (Positions)obj;

            if (positions.GetHashCode() == GetHashCode())
            {
                return true;
            }

        }

        return false;
    }

    public override int GetHashCode()
    {
        return ((int)_x * 100) + ((int)_y * 50);
    }
}