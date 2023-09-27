namespace KlasseTaschenrechner;
public class Rectangle
{
    public int Length;
    public int Width;
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public decimal Area()
    {
        return Width * Length;
    }
    public decimal Circumference()
    {
        return 2 * (Length + Width);
    }
}