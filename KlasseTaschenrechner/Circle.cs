namespace KlasseTaschenrechner;
public class Circle
{
    public int Radius;
    public Circle(int radius)
    {
        this.Radius = radius;
        // Radius = radius; -> Funktioniert, wenn es keine Verwechslungsgefahr bei den Variablennamen gibt
    }
    // D = R * 2
    public decimal Diameter()
    {
        return Radius * 2;
    }
    // 2 * PI * R
    public decimal Circumference()
    {
        return Convert.ToDecimal(Math.PI) * 2 * Radius;
    }
    // PI * R^2
    public decimal Area()
    {
        return Convert.ToDecimal(Math.PI * Math.Pow(Radius, 2));
    }
}

