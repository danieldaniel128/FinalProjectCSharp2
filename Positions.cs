using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

struct Positions : IPositioning
{
    private int _x;
    private int _y;
    int IPositioning.X { get => _x; set => _x = value; }
    int IPositioning.Y { get => _y; set => _y = value; }

    public Positions(int x, int y)
    {
       this._x = x;
       this._y = y;
    }


    public static Positions operator+(Positions pos1, Positions pos2)
    {
        Positions pos3;

        pos3._x = pos1._x + pos2._x;
        pos3._y = pos1._y + pos2._y;

        return pos3;
    }

    public static Positions operator -(Positions pos1, Positions pos2)
    {
        Positions pos3;

        pos3._x = pos1._x - pos2._x;
        pos3._y = pos1._y - pos2._y;

        return pos3;
    }



    public override string ToString() => String.Format("The Position is" + " X :" + _x + " Y: " + _y);
    

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
        return _x * _y * 3 + _y;
    }
}

