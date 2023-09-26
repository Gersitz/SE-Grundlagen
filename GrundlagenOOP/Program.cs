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
    }
}
