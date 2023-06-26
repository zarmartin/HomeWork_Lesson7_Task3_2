using System.Collections.Generic;

List<string> name = new List<string>() { "Marta", "Bob", "James", "Adam", "Sam", "Paul"};

foreach (string nameItem in name)
{
    Console.WriteLine(nameItem);
}

name.AddRange(new[] { "Artem", "Sony" });

Console.WriteLine(Environment.NewLine);

foreach (string nameItem in name)
{
    Console.WriteLine($"{nameItem}");
}

name.RemoveAt(2);

Console.WriteLine(Environment.NewLine);

foreach(string nameItem in name)
{
    Console.WriteLine(nameItem);
}

name.Remove("Sony");

Console.WriteLine(Environment.NewLine);

foreach(string nameItem in name)
{
    Console.WriteLine(nameItem);
}

name.Sort();

Console.WriteLine(Environment.NewLine);

foreach (string nameItem in name)
{
    Console.WriteLine(nameItem);
}