namespace GrundlagenOOP;
public class Dog
{
    private int _id;
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
    public string name;
    private string color;
    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            if (value == "black" || value == "white")
            {
                color = value;
            }
        }
    }

    public int Age { get; init; }

    //private int _a;
    //public int A { get; set; }
    public Dog(int id, string name, string color, int age)
    {
        this.Id = id;
        this.name = name;
        this.color = color;
        this.Age = age;
    }

    public void Bark()
    {
        Console.WriteLine("Woof");
    }
}