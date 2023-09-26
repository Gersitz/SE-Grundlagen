namespace GrundlagenOOP;
public class Cat
{
  public string Name;
  public int Age;
  public string Color;

 

  // Konstruktor -> Erstellt eine neue Instanz der Klasse Cat
  // -> Nicht für static-classes / statische Klassen
  public Cat(string name, int age, string color)
  {
    this.Name = name;
    this.Age = age;
    this.Color = color;
  }
  public void Miau()
  {
    Console.WriteLine("Miau!");
  }
  public static void Schnurren()
  {
    Console.WriteLine("purrrrrrr...");
  }
  public override string ToString()
  {
    // $"Test{x}" -> String-Interpolation
    return $"Name: {this.Name}\nAge: {this.Age}\nColor: {this.Color}";
  }
}