namespace GrundlagenOOP;
internal class Person
{
    private string firstname;
    public string Firstname
    {
        get => firstname;
        set => firstname = value;
    }
    private string lastname;
    public string Lastname { get => lastname; set => lastname = value; }
    public Person(string firstname, string lastname)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
    }

    // public string FullName()
    // {
    //     return Firstname + " " + Lastname;
    // }
    public string FullName() => Firstname + " " + Lastname;

    public void Platzhalter()
    {
        var CallName = (string name) => Console.WriteLine($"Hello {name}");
        CallName("tobi");
        if (firstname == "tobi") Console.WriteLine(firstname);
        else Console.WriteLine("Error");
    }
}
