// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<string> planetList = new List<string>() { "Mercury", "Mars" };
planetList.Add("Jupiter");
planetList.Add("Saturn");

List<string> endPlanets = new List<string>() { "Neptune", "Uranus" };

planetList.AddRange(endPlanets);

planetList.Insert(2, "Earth");
planetList.Insert(3, "Venus");


string Planets = planetList.ToString();

foreach (string planet in planetList)
{

    Console.WriteLine($"{planet}");
}

planetList.Add("Pluto");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("New Planet List");
Console.WriteLine();
foreach (string planet in planetList)
{

    Console.WriteLine($"{planet}");
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Rocky Planets");

Console.WriteLine();
Console.WriteLine();

// all planets in planetList List

List<string> rockyPlanets = new List<string>();

rockyPlanets = planetList.GetRange(0, 4).ToList();

foreach (string rockyPlanet in rockyPlanets)
{
    Console.WriteLine($"{rockyPlanet}");


}

planetList.Remove("Pluto");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("No Pluto");

foreach (string planet in planetList)
{
    Console.WriteLine(planet);
}



Dictionary<string, string> orbitList = new Dictionary<string,string> 
{
    {"Mercury", Mercury },
    {"Venus", Venus },
    {"Earth", Earth },
    {"Mars", Mars },
    {"Jupiter", Jupiter },
    {"Saturn", Saturn },
    {"Uranus", Uranus },
    {"Neptune", Neptune };
};



Console.ReadLine();