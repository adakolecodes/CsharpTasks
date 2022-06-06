// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> names = new List<string>();

names.Add("Samuel");
names.Add("Patrick");
names.Add("Abigail");
names.Add("Isaac");
names.Add("Esther");
names.Add("Shedrack");
names.Add("Miracle");
names.Add("John");
names.Add("Daniel");


names.Insert(5, "obed");

Console.WriteLine(names.Count);
Console.WriteLine(names.Contains("victor"));
names.Sort();

foreach (string a in names)
{
    Console.WriteLine(a);
}