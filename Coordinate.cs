namespace LittlePrince.Kichikshaxzoda;

public struct Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate() : this(0, 0) { }

    public Coordinate(int x, int y) => (X, Y) = (x, y);

    public readonly double DistanceTo(Coordinate other)
    {
        var a = X - other.X;
        var b = Y - other.Y;

        var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        return c;
    }

}