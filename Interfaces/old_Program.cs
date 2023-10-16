namespace old_Project;

//var flyingThing = new FlyableObject();
//flyingThing.Fly();
//var myBird = new Bird();
//myBird.Fly();

//var myCar = new Car();
//myCar.Drive();

public class FlyableObject
{
    public void Fly()
    {
        Console.WriteLine("Der Vogel fliegt...");
    }
}

public class DriveableObject
{
    public void Drive()
    {
        Console.WriteLine("Das Auto fährt...");
    }
}

public class Bird : FlyableObject
{
    //public void Fly()
    //{
    //    Console.WriteLine("Der Vogel fliegt...");
    //}
}

public class Airplane : FlyableObject
{
    //public void Fly()
    //{
    //    Console.WriteLine("Das Flugzeug fliegt...");
    //}
}

public class Car : DriveableObject
{

}