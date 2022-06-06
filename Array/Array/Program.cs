// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] names = { "Samuel", "Abigail", "John", "Miracle", "Shedrack", "Esther" };
names[0] = "Patrick";
names[2] = "Isaac";
Array.Sort(names);

foreach(string a in names)
{
    Console.WriteLine(a);
}

int[] age = { 15, 36, 78, 88 };