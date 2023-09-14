void printHello()
{
    Console.WriteLine("Hello");
}

string getHello()
{
    return "Hello";
}

void printGreeting(string name, int itercount = 1)
{
    int i = 0;
    while (i < itercount)
    {
        Console.WriteLine($"Hello {name}");
        i++;
    }
}

printHello();

var hello = getHello();

hello = hello + " World!";

Console.WriteLine(hello);

Console.WriteLine("Nenne mir deinen Namen");
var inputName = Console.ReadLine();

printGreeting(inputName);
printGreeting(inputName, 10);