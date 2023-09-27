namespace GrundlagenOOP;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); // Statische-Klasse
        Random rng = new Random(); // Instanziierbare-Klasse
        // Cat myCat = new Cat();
        int x;
        Cat y; // Cat ist unser eigens erstellter Datentyp
        // myCat.Meow();
        // myCat.Name = "Minka";
        // myCat.Age = 10;
        // myCat.Color = "Silver-Tabby";
        // Cat myCoolCat = new Cat();
        // myCoolCat.Color = "Brown";
        // myCoolCat.Age = 12;
        // myCoolCat.Name = "Tom";
        // Console.ReadLine();
        // Console.WriteLine(myCat);
        // Console.WriteLine(myCoolCat);
        // myCoolCat.Name = "Stefan";
        // Console.WriteLine(myCoolCat);

        Cat jerry = new Cat("jerry", 8, "black");
        Console.WriteLine(jerry);

        jerry.Age += 1;

        jerry = new Cat("minka", 12, "silver");
        Console.WriteLine(jerry);

        jerry.Miau();
        Cat.Schnurren();

        Console.WriteLine(jerry);
        Console.ReadLine();

        // fields vs properties
        Dog myDog = new Dog(0, "fifi", "white",3 );
        var myDog2 = new Dog(1, "susi", "black",5 );
        Dog myDog3 = new(2, "maria", "golden", 10);
        myDog.Bark();

        myDog.name = "fritz";
        myDog.Id = 1;
        Console.WriteLine(myDog);

        Console.WriteLine("**********");
        Console.WriteLine(myDog.Color);
        myDog.Color = "yellow";
        Console.WriteLine(myDog.Color);
    }
}
