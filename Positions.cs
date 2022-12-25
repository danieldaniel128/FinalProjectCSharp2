

readonly struct Positions : IPositioning
{

    public readonly float _x;
    public readonly float _y;

     float IPositioning.X { readonly get => _x; set => throw new NotImplementedException(); }
    float IPositioning.Y { readonly get => _y; set => throw new NotImplementedException(); }

    /// <summary>
    /// A tool to position the player
    /// </summary>

    public Positions(float x, float y)
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

