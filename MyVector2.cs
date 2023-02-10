namespace FinalProjectCSharp2;

public readonly struct MyVector2 : IPositioning
{
    /// <summary>
    /// Direction (Up,Down,Right,Left) will be used as a shortcut for traversing a vector in 2D space
    /// </summary>

    // fields
    private readonly int _x;
    private readonly int _y;
    public int X { readonly get => _x; set => throw new NotImplementedException(); }
   
    public int Y { readonly get => _y; set => throw new NotImplementedException(); }
    
    // Vector2 Properties
    public readonly float Magnitude => MathF.Sqrt(_x * _x + _y * _y); // return a Vector2's Magnitude aka the Length of the Vector2
    public readonly MyVector2 Normalized => new MyVector2(_x / (int)this.Magnitude, _y / (int)this.Magnitude); // returns a Normalized Vector2 (which is vector with values between -1 and 1)
    public static MyVector2 Down = new MyVector2(0, -1);
    public static MyVector2 Up = new MyVector2(0, 1);
    public static MyVector2 Right = new MyVector2(1, 0);
    public static MyVector2 Left = new MyVector2(-1, 0);
    public static MyVector2 One = new MyVector2(1, 1);
    public static MyVector2 Zero = new MyVector2(0, 0);


      
    public MyVector2(int x, int y)
    {
        this._x = x;
        this._y = y;
    }

    // Operators
    public static MyVector2 operator +(MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x + pos2._x, pos1._y + pos2._y);
    }
    public static MyVector2 operator -(MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x - pos2._x, pos1._y - pos2._y);
    }
    public static MyVector2 operator / (MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x / pos2._x, pos1._y / pos2._y);
    }
    public static bool operator == (MyVector2 pos1, MyVector2 pos2)
    {
        if (pos1._x == pos2._x && pos1._y == pos2._y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator > (MyVector2 pos1, MyVector2 pos2)
    {
        return (pos1.X > pos2.X && pos1.Y > pos2.Y) || (pos1.X > pos2.X || pos1.Y > pos2.Y);
    }
    public static bool operator < (MyVector2 pos1, MyVector2 pos2)
    {
  
        return (pos1.X < pos2.X && pos1.Y < pos2.Y) || (pos1.X < pos2.X || pos1.Y < pos2.Y);
    }
    public static bool operator <=(MyVector2 pos1, MyVector2 pos2)
    {
        return (pos1.X <= pos2.X && pos1.Y <= pos2.Y);

    }
    public static bool operator >=(MyVector2 pos1, MyVector2 pos2)
    {
        return (pos1.X >= pos2.X && pos1.Y >= pos2.Y);

    }

    public MyVector2 Normalize() => new MyVector2(_x / (int)this.Magnitude, _y / (int)this.Magnitude);
    public static bool operator !=(MyVector2 pos1, MyVector2 pos2)
    {
        if (pos1._x != pos2._x && pos1._y != pos2._y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static MyVector2 operator * (MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x * pos2._x, pos1._y * pos2._y);
    }




    // Vector2 Methods

    /// <summary>
    /// returns Dot product of 2 vectors
    /// </summary>
    /// <param name="vec1"></param>
    /// <param name="vec2"></param>
    /// <returns></returns>
    public static float Dot(MyVector2 vec1, MyVector2 vec2) 
    {
        return vec1._x * vec2._x + vec1._y * vec2._y; 
    }
    /// <summary>
    /// returns the Distance between 2 Vectors
    /// </summary>
    /// <param name="firstVector"></param>
    /// <param name="secondVector"></param>
    /// <returns></returns>
    public float Distance(MyVector2 firstVector, MyVector2 secondVector)
    {
        float distanceX = firstVector._x - secondVector._x;
        float distanceY = firstVector._y - secondVector._y;      
        return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY); 
    }

    /// <summary>
    /// use to make a vector move to other vector in a certain speed
    /// </summary>
    /// <param name="current"></param>
    /// <param name="target"></param>
    /// <param name="speed"></param>
    /// <returns></returns>
    public static MyVector2 MoveTowards(MyVector2 current, MyVector2 target, float speed)
    {
        while (!current.Equals(target))
        { 
            

            if (current._x < target._x) current = new MyVector2((int)Math.Min(current._x + speed, target._x), current._y);
            else current = new MyVector2((int)Math.Max(current._x - speed, target._x), current._y);
         
            if (current._y < target._y) current = new MyVector2(current._x, (int)Math.Min(current._y + speed, target._y));
            else current = new MyVector2(current._x, (int)Math.Max(current._y - speed, target._y));

        }
        return current;
    }

   

    public override string ToString() => $"({_x},{_y})";
    public override bool Equals(object obj)
    {
        if (!(obj is MyVector2))
        {
            return false;
        }
        else
        {
            MyVector2 vector = (MyVector2)obj;

            if (vector.GetHashCode() == GetHashCode())
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

static class MyVector2ExtesnionClass
{
    public static float Dot(this MyVector2 vec1, MyVector2 vec2) // returns Dot product of 2 vectors
    {
        return vec1.X * vec2.X + vec1.Y * vec2.Y;
    }
    public static float Distance(this MyVector2 firstVector, MyVector2 secondVector)
    {
        float distanceX = firstVector.X - secondVector.X;
        float distanceY = firstVector.Y - secondVector.Y;
        return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY);
    }
    public static MyVector2 MoveTowards(this MyVector2 current, MyVector2 target, float speed)
    {
        while (!current.Equals(target))
        {

            float distance = current.Distance(current, target);

            if (current.X < target.X) current = new MyVector2((int)Math.Min(current.X + speed, target.X), current.Y);
            else current = new MyVector2((int)Math.Max(current.X - speed, target.X), current.Y);

            if (current.Y < target.Y) current = new MyVector2(current.X, (int)Math.Min(current.Y + speed, target.Y));
            else current = new MyVector2(current.X, (int)Math.Max(current.X - speed, target.Y));

        }
        return current;
    }

    //public static MyVector2 Lerp(this MyVector2 current, MyVector2 target, float percentage)
    //{

    //    return new MyVector2(current.X + (target.X - current.X) * percentage,
    //        current.Y + (target.Y - current.Y) * percentage);

    //}


}