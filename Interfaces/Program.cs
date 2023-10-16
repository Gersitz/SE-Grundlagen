var objectList = new List<IFlyable>();

objectList.Add(new Bird());
objectList.Add(new Bird());
objectList.Add(new Airplane());

var driveables = new List<IDriveable>();
driveables.Add(new Car());
driveables.Add(new Car());
driveables.Add(new Airplane());
driveables.Add(new Hovercraft());

var swimmables = new List<ISwimmable>();
swimmables.Add(new Hovercraft());
swimmables.Add(new Hovercraft());
swimmables.Add(new Boot());

foreach (var item in objectList)
{
    item.Fly();
}

foreach (var item in driveables)
{
    item.Drive();
}

foreach (var item in swimmables)
{
    item.Swim();
}

public class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Der Vogel fliegt...");
    }
}

public class Airplane : IFlyable, IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Das Flugzeug fährt...");
    }
    public void Fly()
    {
        Console.WriteLine("Das Flugzeug fliegt...");
    }
}

public class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Das Auto fährt...");
    }
}

public class Hovercraft : ISwimmable, IDriveable
{
    public void Swim()
    {
        Console.WriteLine("Hovercraft schwimmt!");
    }
    public void Drive()
    {
        Console.WriteLine("Hovercraft fährt!");
    }
}

public class Boot : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Das Boot schwimmt!");
    }
}