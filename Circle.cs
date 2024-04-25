namespace LittlePrince.Kichikshaxzoda;

public struct Circle
{
    public Coordinate Center { get; set; }
    public int Radius { get; set; }

    public Circle() : this(new Coordinate(), 0) { }

    public Circle(Coordinate center, int radius) 
        => (Center, Radius) = (center, radius);
    
    public readonly bool IsIn(Coordinate coordinate) 
        => Center.DistanceTo(coordinate) < Radius;
}