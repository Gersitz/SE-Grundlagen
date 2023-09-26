using System.Reflection.Metadata.Ecma335;

namespace KlasseTaschenrechner;
public class Triangle
{
    public int Length;
    public int Heigth;
    public Triangle(int length, int heigth)
    {
        Length = length;
        Heigth = heigth;
    }
    public decimal Area()
    {
        return Length * Heigth / 2;
    } 
}