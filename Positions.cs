using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

readonly struct Positions : IPositioning
{
    readonly int _x;
    readonly int _y;

    int IPositioning.X { readonly get => _x; set => throw new NotImplementedException(); }
    int IPositioning.Y { readonly get => _x; set => throw new NotImplementedException(); }

    public Positions(int x, int y)
    {
       this._x = x;
       this._y = y;
    }


    public static Positions operator+(Positions pos1, Positions pos2)
    {
       return new Positions(pos1._x + pos2._x, pos1._y + pos2._y);
    }
    
  

    public static Positions operator -(Positions pos1, Positions pos2)
    {
        return new Positions(pos1._x - pos2._x, pos1._y - pos2._y);
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

