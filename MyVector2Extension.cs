using FinalProjectCSharp2;
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
            Console.WriteLine("Current position: " + current);
            Console.WriteLine("Distance: " + distance);

            if (current.X < target.X) current = new MyVector2(Math.Min(current.X + speed, target.X), current.Y);
            else current = new MyVector2(Math.Max(current.X - speed, target.X), current.Y);

            if (current.Y < target.Y) current = new MyVector2(current.X, Math.Min(current.Y + speed, target.Y));
            else current = new MyVector2(current.X, Math.Max(current.X - speed, target.Y));

            Thread.Sleep(16); // PlaceHolder For Now
        }
        return current;
    }

    public static MyVector2 Lerp(this MyVector2 current, MyVector2 target, float percentage)
    {

        return new MyVector2(current.X + (target.X - current.X) * percentage,
            current.Y + (target.Y - current.Y) * percentage);

    }


}