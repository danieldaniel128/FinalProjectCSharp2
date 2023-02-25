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

    /// <summary>
    /// Returns a vector of 1
    /// </summary>
    public readonly MyVector2 Normalized => new MyVector2(_x / (int)this.Magnitude, _y / (int)this.Magnitude); // returns a Normalized Vector2 (which is vector with values between -1 and 1)
    /// <summary>
    /// Takes the object one step down
    /// </summary>
    public static MyVector2 Down = new MyVector2(0, -1);
    /// <summary>
    /// Takes the object one step up
    /// </summary>
    public static MyVector2 Up = new MyVector2(0, 1);
    /// <summary>
    /// Takes the object one step right
    /// </summary>
    public static MyVector2 Right = new MyVector2(1, 0);
    /// <summary>
    /// Takes the object one step left
    /// </summary>
    public static MyVector2 Left = new MyVector2(-1, 0);
    /// <summary>
    /// return a (1,1) vector
    /// </summary>
    public static MyVector2 One = new MyVector2(1, 1);
    /// <summary>
    /// return a (0,0) vector
    /// </summary>
    public static MyVector2 Zero = new MyVector2(0, 0);

    /// <summary>
    /// This Struct Let's you writing Positions into gameObjects
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
      
    public MyVector2(int x, int y)
    {
        this._x = x;
        this._y = y;
    }

    // Operators

    /// <summary>
    /// Adds Two Vectors
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static MyVector2 operator +(MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x + pos2._x, pos1._y + pos2._y);
    }

    /// <summary>
    /// Subtructs Two Vectors
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static MyVector2 operator -(MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x - pos2._x, pos1._y - pos2._y);
    }

    /// <summary>
    /// Divides Two Vectors
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static MyVector2 operator / (MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x / pos2._x, pos1._y / pos2._y);
    }

    /// <summary>
    /// Compares Two Vectors
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Checks if one vector is bigger than the other
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static bool operator > (MyVector2 pos1, MyVector2 pos2)
    {
        return (pos1.X > pos2.X && pos1.Y > pos2.Y) || (pos1.X > pos2.X || pos1.Y > pos2.Y);
    }

    /// <summary>
    /// Checks if one vector is smaller than the other
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static bool operator < (MyVector2 pos1, MyVector2 pos2)
    {
  
        return (pos1.X < pos2.X && pos1.Y < pos2.Y) || (pos1.X < pos2.X || pos1.Y < pos2.Y);
    }

    /// <summary>
    /// Checks if one vector is smaller or equals to another
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static bool operator <=(MyVector2 pos1, MyVector2 pos2)
    {
        return (pos1.X <= pos2.X && pos1.Y <= pos2.Y);

    }

    /// <summary>
    /// Checks if one vector is bigger or equals to another
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static bool operator >=(MyVector2 pos1, MyVector2 pos2)
    {
        return (pos1.X >= pos2.X && pos1.Y >= pos2.Y);

    }

    /// <summary>
    /// Returns a vector direction of size 1
    /// </summary>
    /// <returns></returns>

    public MyVector2 Normalize() => new MyVector2(_x / (int)this.Magnitude, _y / (int)this.Magnitude);

    /// <summary>
    /// Checks if two vectors are not equals
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Multiplies two vectors
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static MyVector2 operator * (MyVector2 pos1, MyVector2 pos2)
    {
        return new MyVector2(pos1._x * pos2._x, pos1._y * pos2._y);
    }

    /// <summary>
    /// Multiplies a vector with a integer number
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="multiplier"></param>
    /// <returns></returns>

    public static MyVector2 operator *(MyVector2 pos1, int multiplier)
    {
        return new MyVector2(pos1._x * multiplier, pos1._y * multiplier);
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
    /// <summary>
    /// returns the Distance between 2 Vectors
    /// </summary>
    /// <param name="firstVector"></param>
    /// <param name="secondVector"></param>
    /// <returns></returns>

    public static float Distance(this MyVector2 firstVector, MyVector2 secondVector)
    {
        float distanceX = firstVector.X - secondVector.X;
        float distanceY = firstVector.Y - secondVector.Y;
        return MathF.Sqrt(distanceX * distanceX + distanceY * distanceY);
    }

    /// <summary>
    /// use to make a vector move to other vector in a certain speed
    /// </summary>
    /// <param name="current"></param>
    /// <param name="target"></param>
    /// <param name="speed"></param>
    /// <returns></returns>
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


}