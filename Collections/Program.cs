// Collections / Sammlungen
#region Arrays
using System.Runtime.Serialization.Formatters;

int[] ints = new int[10];
int[] ints2 = { 1, 2, 3 };

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = i;
}

Console.WriteLine(string.Join(',', ints));



ints[1] = 952;

Console.WriteLine(string.Join(",", ints));
/*
 * ints = new int[20];
 * ints[0] = 10;
 * Console.WriteLine(string.Join(',', ints));
*/
var newInts = ints.Append(20);
Console.WriteLine("ints: " + string.Join(',', ints));
Console.WriteLine("newInts: " + string.Join(',', newInts));
#endregion

#region Lists
// Listen / Lists
// List<string> names = new List<string>();
List<string> names = new();

names.Add("Tobias Wehrle");
names.Add("Fatih Oezhan");
names.Add("Mustafa Kendo");
names.Add("Alexander Mulholland");
names.Add("Alexander Lorengel");
names.Add("Isabell Oehme");

Console.WriteLine(string.Join(", ", names));

names.Remove("Tobias Wehrle");
names.Remove(names[1]);

Console.WriteLine(string.Join(", ", names));

if(names.Contains("Fatih Oezhan"))
{
    Console.WriteLine("Fatih ist in der Liste");
}

names.Sort();

Console.WriteLine(string.Join(", ", names));

List<int> intList = new() { 20, 40, 10, 3, 6, 42, 100, 13 };
intList.Sort();
Console.WriteLine(string.Join(", ", intList));

foreach(var name in names)
{
    Console.WriteLine(name);
}
for (int i = 0; i < intList.Count; i++)
{
    Console.WriteLine(intList[i]);
}

intList.Any
#endregion